using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// JSON Dependencies
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
// Speech Dependencies
using System.Speech.Recognition;

namespace trabalho03_indes_v2
{
    public partial class hangman : Form
    {
        // Global Variables
        int score;
        List<Player> playerList;
        List<Item> wordList;
        string playerListPath;
        string wordListPath;
        int currentPlayer;
        int currentLevel = 1;
        int totalLevels;
        Item chosenWord;
        List<string> devidedWord;
        List<Item> alreadyUsedWords = new List<Item>();
        List<Button> clickedButtons = new List<Button>();
        List<string> revealedLetters = new List<string>();
        List<Label> labelsToRemove = new List<Label>();
        int numLettersDiscovered = 0;
        int hangmanStage = 0;
        int roundScore = 0;
        bool speechActivated = false;
        SpeechRecognitionEngine speechRecognizer;
        TextBox showSaidWords;
        Label levelResult;

        // Colors for buttons
        Color originalBgColor = Color.FromArgb(255, 17, 36, 68);
        Color usedColor = Color.Black; // Color.FromArgb(255, 57, 95, 141);

        public hangman()
        {
            // Initialize list
            playerList = new List<Player>();

            InitializeComponent();

            // Load Speech Recognition
            speechRecognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-001"));
            speechRecognizer.SetInputToDefaultAudioDevice();
            speechRecognizer.LoadGrammar(new DictationGrammar());

            // Create text box to show what is being said by the user
            showSaidWords = new TextBox();
            showSaidWords.Location = new Point(16, 655);
            showSaidWords.Name = "speechRecognizerTextBox";
            showSaidWords.ForeColor = Color.FromArgb(255, 146, 168, 192);
            showSaidWords.BackColor = Color.FromArgb(255, 17, 36, 68);
            showSaidWords.BorderStyle = BorderStyle.None;
            showSaidWords.TextAlign = HorizontalAlignment.Center;
            showSaidWords.Font = new Font("Montserrat", 9);
            showSaidWords.MinimumSize = new Size(0, 25);
            showSaidWords.Size = new Size(1280, 25);
            showSaidWords.Text = "Speech Recognizer: ";
            showSaidWords.Visible = false;

            wordListPath = Path.Combine(Environment.CurrentDirectory, @"jsonFiles\HangManWords.json");
            Debug.WriteLine(wordListPath);

            // Check if file exists
            if (File.Exists(wordListPath))
            {
                string json = File.ReadAllText(wordListPath);
                wordList = JsonConvert.DeserializeObject<List<Item>>(json);
            }
            else Debug.WriteLine("HangManWords.json doesn't exist");

            // Player list url
            playerListPath = Path.Combine(Environment.CurrentDirectory, @"jsonFiles\Players.json");

            // Check if player file exists
            if (File.Exists(playerListPath))
            {
                // Get top five players' data
                string json = File.ReadAllText(playerListPath);
                playerList = JsonConvert.DeserializeObject<List<Player>>(json);
            }
            else Debug.WriteLine("Players.json doesn't exist");
        }

        //Sort by score
        static int SortByScore(Player p1, Player p2)
        {
            return p1.score.CompareTo(p2.score);
        }

        // Welcome Screen --------------------------------------------------------------------------------------------------------------------------------------
        private void welcome_creditsBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 1;
        }

        private void welcome_rulesBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 2;
        }

        private void welcome_playBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 3;
        }

        private void welcome_speechBtn_Click(object sender, EventArgs e)
        {
            speechActivated = !speechActivated;

            if(speechActivated)
            {
                welcome_speechBtn.ForeColor = Color.FromArgb(17, 36, 68);
                welcome_speechBtn.BackColor = Color.White;
                welcome_speechBtn.Text = "ON";

                speechRecognizer.RecognizeAsync(RecognizeMode.Multiple);
                speechRecognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechRec);
                showSaidWords.Visible = true;
                speechHelper_letter.Visible = true;
                speechHelper_numberOfLevels.Visible = true;
                speechHelper_playerName.Visible = true;
            } else
            {
                welcome_speechBtn.ForeColor = Color.White;
                welcome_speechBtn.BackColor = Color.FromArgb(17, 36, 68);
                welcome_speechBtn.Text = "OFF";

                speechRecognizer.RecognizeAsyncStop();
                showSaidWords.Visible = false;
                speechHelper_letter.Visible = false;
                speechHelper_numberOfLevels.Visible = false;
                speechHelper_playerName.Visible = false;
            }
        }

        // Rules Screen ----------------------------------------------------------------------------------------------------------------------------------------
        private void rules_backBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 0;
        }

        // Credits Screen ---------------------------------------------------------------------------------------------------------------------------------------
        private void credits_backBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 0;
        }

        // Enter Name Screen ------------------------------------------------------------------------------------------------------------------------------------
        private void enterName_playBtn_Click(object sender, EventArgs e)
        {
            int check = 0;

            // Verifies if the name inside of the input is valid 
            if (enterName_input.Text.Length >= 3 && enterName_input.Text.Length <= 20)
            {
                // Create new player
                Player newPlayer = new Player();
                newPlayer.id = playerList.Count;
                newPlayer.name = enterName_input.Text;
                newPlayer.score = score;
                currentPlayer = newPlayer.id;

                // Adds it to the json database
                playerList.Add(newPlayer);
                SaveUserData();
                check++;
            }
            else MessageBox.Show("Please enter a player name between 3 and 20 characters.", "Invalid Player Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Checks which number of levels was selected
            if (enterName_radioBtn1.Checked) { totalLevels = 5; check++; }
            else if (enterName_radioBtn2.Checked) { totalLevels = 10; check++; }
            else if (enterName_radioBtn3.Checked) { totalLevels = 15; check++; }
            else MessageBox.Show("No number of levels was selected. Please select your total number of levels.", "No Levels Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Only goes to the next page if all the verifications are made
            if (check == 2)
            {
                // Reset Power Ups
                Button btn = (Button)this.Controls.Find("play_useBoosterBtn", true).First();
                btn.Enabled = true;
                btn.BackColor = originalBgColor;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.White;

                btn = (Button)this.Controls.Find("play_changeThemeBtn", true).First();
                btn.Enabled = true;
                btn.BackColor = originalBgColor;
                btn.ForeColor = Color.White; 
                btn.FlatAppearance.BorderColor = Color.White;
                
                btn = (Button)this.Controls.Find("play_changeWordBtn", true).First();
                btn.Enabled = true;
                btn.BackColor = originalBgColor;
                btn.FlatAppearance.BorderColor = Color.White;
                btn.ForeColor = Color.White;

                // Reset game score and current level
                score = 0;
                currentLevel = 1;

                // Creates "You Win/You Lose" Label
                levelResult = new Label();
                levelResult.Location = new Point(196, 274);
                levelResult.Name = "play_levelResult";
                levelResult.ForeColor = Color.White;
                levelResult.BackColor = Color.FromArgb(255, 97, 153, 215);
                levelResult.Font = new Font("Montserrat Semibold", 18);
                levelResult.TextAlign = ContentAlignment.MiddleCenter;
                levelResult.Size = new Size(454, 115);
                levelResult.Visible = false;
                play.Controls.Add(levelResult);

                // Goes to Play Area
                displayGame();
                menu.SelectedIndex = 4;
            }
        }

        private void enterName_backBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 0;
        }

        // High Scores Screen -----------------------------------------------------------------------------------------------------------------------------
        private void highScores_backBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 0;
        }

        // Play Screen (Keyboard) -------------------------------------------------------------------------------------------------------------------------
        private void letterBtn_Click(object sender, EventArgs e)
        {
            if (hangmanStage < 6 && numLettersDiscovered != devidedWord.Count)
            {
                Button btn = sender as Button;

                clickedButtons.Add(btn);

                btn.Enabled = false;
                btn.ForeColor = usedColor;
                btn.FlatAppearance.BorderColor = usedColor;

                RegisterLetter(btn.Text.ToLower());
            }
        }

        private void LetterBtnBooster(string buttonLetter)
        {
            Button btn = (Button)this.Controls.Find("letter" + buttonLetter + "Btn", true).First();

            clickedButtons.Add(btn);

            btn.Enabled = false;
            btn.ForeColor = usedColor;
            btn.FlatAppearance.BorderColor = usedColor;

            RegisterLetter(btn.Text.ToLower());
        }

        private void RegisterLetter(string letter)
        {
            if (devidedWord.Contains(letter))
            {
                score = score + 5;
                roundScore = roundScore + 5;
                UpdateScore();
                revealedLetters.Add(letter);
                int counter = 0;
                
                // Guessed a letter - reveal the letters from the word
                foreach (string wordLetter in devidedWord)
                {
                    if (wordLetter == letter)
                    {
                        // Player found a letter!
                        numLettersDiscovered++;

                        // Show letter - Create label at the correct position and fill it with the letter
                        if (devidedWord.Count % 2 == 0)
                        {
                            // First pos = 368 - (((devidedWord.Count - 2) / 2) * 30) (space between letters)
                            int pos = 368 + 7 - (((devidedWord.Count - 2) / 2) * 50);
                            pos = pos + 50 * counter;
                            Label wordSpace = new Label();
                            wordSpace.Text = letter;
                            wordSpace.Name = "";
                            wordSpace.ForeColor = Color.White;
                            wordSpace.Width = 50;
                            wordSpace.Height = 70;
                            wordSpace.TextAlign = ContentAlignment.MiddleCenter;
                            wordSpace.Location = new Point(pos, 160);
                            wordSpace.Font = new Font("Montserrat", 39);
                            play.Controls.Add(wordSpace);
                            wordSpace.BringToFront();

                            labelsToRemove.Add(wordSpace);
                        }
                        else
                        {
                            // First pos = 393 - (((devidedWord.Count - 1) / 2) * 50) (space between letters)
                            int pos = 393 + 7 - ((devidedWord.Count - 1) / 2) * 50;
                            pos = pos + 50 * counter;
                            Label wordSpace = new Label();
                            wordSpace.Text = letter;
                            wordSpace.Name = "";
                            wordSpace.ForeColor = Color.White;
                            wordSpace.Width = 50;
                            wordSpace.Height = 70;
                            wordSpace.TextAlign = ContentAlignment.MiddleCenter;
                            wordSpace.Location = new Point(pos, 160);
                            wordSpace.Font = new Font("Montserrat", 39);
                            play.Controls.Add(wordSpace);
                            wordSpace.BringToFront();

                            labelsToRemove.Add(wordSpace);
                        }
                    }
                    counter++;
                }

                // After putting the letters in place, check if the player has won 
                CheckIfWon();
            }
            else
            {
                // Player did not get a letter right - Punish them!
                score = score - 5;
                roundScore = roundScore - 5;
                UpdateScore();
                AdvanceHangman();
            }
        }

        private void AdvanceHangman()
        {
            hangmanStage++;

            // Change image depending on the stage!
            switch (hangmanStage)
            {
                case 1:
                    play_hangman.BackgroundImage = Image.FromFile(@"..\..\images\hangman-02.png", true);
                    break;

                case 2:
                    play_hangman.BackgroundImage = Image.FromFile(@"..\..\images\hangman-03.png", true);
                    break;

                case 3:
                    play_hangman.BackgroundImage = Image.FromFile(@"..\..\images\hangman-04.png", true);
                    break;

                case 4:
                    play_hangman.BackgroundImage = Image.FromFile(@"..\..\images\hangman-05.png", true);
                    break;

                case 5:
                    play_hangman.BackgroundImage = Image.FromFile(@"..\..\images\hangman-06.png", true);
                    break;

                case 6:
                    play_hangman.BackgroundImage = Image.FromFile(@"..\..\images\hangman-07.png", true);
                    break;
            }

            // After changing the image, check if the player has lost.
            CheckIfLost();
        }

        private async void CheckIfWon()
        {
            // The player WINS when numDiscoveredLetters = devidedWord.Count
            if (numLettersDiscovered == devidedWord.Count)
            {
                score = score + 50;
                UpdateScore();

                await Task.Delay(2000);
                play_hangman.Visible = false;
                levelResult.Text = "You Win!";
                levelResult.Visible = true;

                await Task.Delay(3000);

                currentLevel++;
                displayGame();
                ResetButtons();
            }
        }

        private async void CheckIfLost()
        {
            // The player LOSES when hangmanStage = 6 (full image)
            if (hangmanStage == 6)
            {
                score = score - 50;
                UpdateScore();

                await Task.Delay(1000);
                // Show the full word
                RevealWord();

                await Task.Delay(2000);
                play_hangman.Visible = false;
                levelResult.Text = "You Lose.";
                levelResult.Visible = true;

                await Task.Delay(3000);

                currentLevel++;
                displayGame();
                ResetButtons();
            }
        }

        private void ResetButtons()
        {
            foreach (Button btn in clickedButtons)
            {
                btn.Enabled = true;
                btn.ForeColor = Color.White;
                btn.BackColor = originalBgColor;
                btn.FlatAppearance.BorderColor = Color.White;
            }
        }

        private void UpdateScore()
        {
            play.Text = score.ToString();
        }

        private void RevealWord()
        {
            int counter = 0;
            foreach (string letter in devidedWord)
            {
                if (!revealedLetters.Contains(letter))
                {
                    if (devidedWord.Count % 2 == 0)
                    {
                        // First pos = 368 - (((devidedWord.Count - 2) / 2) * 30) (space between letters)
                        int pos = 368 + 7 - (((devidedWord.Count - 2) / 2) * 50);
                        pos = pos + 50 * counter;
                        Label wordSpace = new Label();
                        wordSpace.Text = letter;
                        wordSpace.Name = "";
                        wordSpace.ForeColor = Color.White;
                        wordSpace.Width = 50;
                        wordSpace.Height = 70;
                        wordSpace.TextAlign = ContentAlignment.MiddleCenter;
                        wordSpace.Location = new Point(pos, 160);
                        wordSpace.Font = new Font("Montserrat", 39);
                        play.Controls.Add(wordSpace);
                        wordSpace.BringToFront();

                        labelsToRemove.Add(wordSpace);
                    }
                    else
                    {
                        // First pos = 393 - (((devidedWord.Count - 1) / 2) * 50) (space between letters)
                        int pos = 393 + 7 - ((devidedWord.Count - 1) / 2) * 50;
                        pos = pos + 50 * counter;
                        Label wordSpace = new Label();
                        wordSpace.Text = letter;
                        wordSpace.Name = "";
                        wordSpace.ForeColor = Color.White;
                        wordSpace.Width = 50;
                        wordSpace.Height = 70;
                        wordSpace.TextAlign = ContentAlignment.MiddleCenter;
                        wordSpace.Location = new Point(pos, 160);
                        wordSpace.Font = new Font("Montserrat", 39);
                        play.Controls.Add(wordSpace);
                        wordSpace.BringToFront();

                        labelsToRemove.Add(wordSpace);
                    }
                }
                counter++;
            }
        }

        // Play Screen ------------------------------------------------------------------------------------------------------------------------------------
        private void play_quitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit? You will lose all your progress.", "Quit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // go back to welcome page
                menu.SelectedIndex = 0;
            }
        }

        //Save player data 
        private void SaveUserData()
        {
            //Convert list to string
            string json = JsonConvert.SerializeObject(playerList);

            //and save it in the json file
            File.WriteAllText(playerListPath, json);
        }

        private void displayGame(string themeFilterInclude = "", string themeFilterExclude = "")
        {
            // Clear previous labels
            foreach (Label label in labelsToRemove)
                play.Controls.Remove(label);

            // Reset number of fails
            hangmanStage = 0;

            // Reset hangman image
            play_hangman.BackgroundImage = Image.FromFile(@"..\..\images\hangman-01.png", true);

            // Reset letters guessed
            revealedLetters.Clear();
            numLettersDiscovered = 0;

            // Reset Buttons
            ResetButtons();
            clickedButtons.Clear();

            // Reset round score
            roundScore = 0;

            // Clear "You Win/You Lose" Label
            levelResult.Visible = false;

            // Image of hangman is visible
            play_hangman.Visible = true;

            play_currentLevel.Text = "Level " + currentLevel + "/" + totalLevels;
            UpdateScore();

            if (currentLevel > totalLevels)
            {
                playerList[playerList.Count - 1].score = score;
                playerList.Sort(SortByScore);
                SaveUserData();
                DisplayHighScores();
                menu.SelectedIndex = 5;
            }
            else
            {
                //Generate word for 5 levels
                if (totalLevels == 5)
                { // if player chose 5 levels 
                    //Check if current level
                    if (currentLevel < 3) // if 2 or less pick from the easy difficulty
                        EasyWordRnd(themeFilterInclude, themeFilterExclude);

                    //Check if current level is 3 or 4
                    if (currentLevel >= 3 && currentLevel < 5)
                        AverageWordRnd(themeFilterInclude, themeFilterExclude);

                    //Check if current level is 5
                    if (currentLevel == 5)
                        DifficultWordRnd(themeFilterInclude, themeFilterExclude);
                }

                //Generate word for 10 levels
                if (totalLevels == 10)
                { // if player chose 10 levels 
                    //Check if current level
                    if (currentLevel < 5) // if 4 or less pick from the easy difficulty
                        EasyWordRnd(themeFilterInclude, themeFilterExclude);

                    //Check if current level is 5 or higher, but less then 9
                    if (currentLevel >= 5 && currentLevel < 9)
                        AverageWordRnd(themeFilterInclude, themeFilterExclude);

                    //Check if current level is 9 or higher
                    if (currentLevel >= 9)
                        DifficultWordRnd(themeFilterInclude, themeFilterExclude);
                }

                //Generate word for 15 levels
                if (totalLevels == 15)
                { // if player chose 15 levels 
                    //Check if current level
                    if (currentLevel < 6) // if 5 or less pick from the easy difficulty
                        EasyWordRnd(themeFilterInclude, themeFilterExclude);

                    //Check if current level is 6 or higher, but less then 11
                    if (currentLevel >= 6 && currentLevel < 11)
                        AverageWordRnd(themeFilterInclude, themeFilterExclude);

                    //Check if current level is 11 or higher
                    if (currentLevel >= 11)
                        DifficultWordRnd(themeFilterInclude, themeFilterExclude);
                }
            }
        }

        #region Randomize Words
        //Randomize easy words
        private void EasyWordRnd(string themeFilterInclude = "", string themeFilterExclude = "")
        {
            List<Item> items = new List<Item>();

            //Search
            for (int i = 0; i < wordList.Count; i++)
            {
                //Add only the easy difficulty words
                if (wordList[i].difficulty == "easy" && !alreadyUsedWords.Contains(wordList[i])) items.Add(wordList[i]);
            }

            if (themeFilterInclude != "") items = items.Where(i => i.theme == themeFilterInclude).ToList();

            if (themeFilterExclude != "") items = items.Where(i => i.theme != themeFilterExclude).ToList();

            Random rnd = new Random();
            chosenWord = items[rnd.Next(0, items.Count)];
            alreadyUsedWords.Add(chosenWord);
            devidedWord = SeparateWord(chosenWord.name);

            string playWord = "";
            string line = "";

            for (int i = 0; i < devidedWord.Count; i++)
            {
                playWord += devidedWord[i];
                line += "_";

                if (i != devidedWord.Count - 1)
                {
                    line += " ";
                    playWord += "  ";
                }

            }

            //Add values to labels
            play_theme.Text = chosenWord.theme.ToUpper();
            GenerateBlankSpaces(chosenWord.name);
            play_letterDashes.Text = "";
        }

        //Randomize average words
        private void AverageWordRnd(string themeFilterInclude = "", string themeFilterExclude = "")
        {
            List<Item> items = new List<Item>();

            //Search
            for (int i = 0; i < wordList.Count; i++)
            {
                //Add only the average difficulty words
                if (wordList[i].difficulty == "average" && !alreadyUsedWords.Contains(wordList[i])) items.Add(wordList[i]);
            }

            if (themeFilterInclude != "") items = items.Where(i => i.theme == themeFilterInclude).ToList();

            if (themeFilterExclude != "") items = items.Where(i => i.theme != themeFilterExclude).ToList();

            //Generate randomize word
            Random rnd = new Random();
            chosenWord = items[rnd.Next(0, items.Count)];

            //Add chosen word to already used words, so tht it's not picked again
            alreadyUsedWords.Add(chosenWord);

            //Splite the word in to list
            devidedWord = SeparateWord(chosenWord.name);
            string playWord = "";
            string line = "";

            for (int i = 0; i < devidedWord.Count; i++)
            {
                playWord += devidedWord[i];

                if (devidedWord[i] != " ") line += "_";
                else line += " ";
            }

            //Add values to labels
            //play_word.Text = playWord;
            play_theme.Text = chosenWord.theme.ToUpper();
            GenerateBlankSpaces(chosenWord.name);
            play_letterDashes.Text = "";
        }

        //Randomize difficult words
        private void DifficultWordRnd(string themeFilterInclude = "", string themeFilterExclude = "")
        {
            List<Item> items = new List<Item>();

            //Search
            for (int i = 0; i < wordList.Count; i++)
            {
                //Add only the difficult words
                if (wordList[i].difficulty == "difficult" && !alreadyUsedWords.Contains(wordList[i])) items.Add(wordList[i]);
            }

            if (themeFilterInclude != "") items = items.Where(i => i.theme == themeFilterInclude).ToList();

            if (themeFilterExclude != "") items = items.Where(i => i.theme != themeFilterExclude).ToList();

            //Generate randomize word
            Random rnd = new Random();
            chosenWord = items[rnd.Next(0, items.Count)];

            //Add chosen word to already used words, so tht it's not picked again
            alreadyUsedWords.Add(chosenWord);

            //Splite the word in to list
            devidedWord = SeparateWord(chosenWord.name);
            string playWord = "";
            string line = "";

            for (int i = 0; i < devidedWord.Count; i++)
            {
                playWord += devidedWord[i];

                if (devidedWord[i] != " ") line += "_";
                else line += " ";
            }

            //Add values to labels
            //play_word.Text = playWord;
            play_theme.Text = chosenWord.theme.ToUpper();
            GenerateBlankSpaces(chosenWord.name);
            play_letterDashes.Text = "";
        }

        //Add the letters to a list
        private List<string> SeparateWord(string x)
        {
            List<string> newWord = new List<string>();

            foreach (char c in x) newWord.Add(c.ToString());

            return newWord;
        }
        #endregion

        private void GenerateBlankSpaces(String word)
        {
            if (word.Length % 2 == 0)
            {
                Label blankSpace = new Label();
                blankSpace.Text = "_";
                blankSpace.Name = "";
                blankSpace.ForeColor = Color.White;
                blankSpace.AutoSize = true;
                blankSpace.TextAlign = ContentAlignment.MiddleCenter;
                blankSpace.Location = new Point(368, 174);
                blankSpace.Font = new Font("Montserrat", 43);
                play.Controls.Add(blankSpace);

                labelsToRemove.Add(blankSpace);

                int pos = 368;

                for (int i = 0; i < (word.Length - 2) / 2; i++)
                {
                    pos = pos - 50;
                    Label blankSpace3 = new Label();
                    blankSpace3.Text = "_";
                    blankSpace3.Name = "";
                    blankSpace3.ForeColor = Color.White;
                    blankSpace3.AutoSize = true;
                    blankSpace3.TextAlign = ContentAlignment.MiddleCenter;
                    blankSpace3.Location = new Point(pos, 174);
                    blankSpace3.Font = new Font("Montserrat", 43);
                    play.Controls.Add(blankSpace3);

                    labelsToRemove.Add(blankSpace3);
                }

                Label blankSpace2 = new Label();
                blankSpace2.Text = "_";
                blankSpace2.Name = "";
                blankSpace2.ForeColor = Color.White;
                blankSpace2.AutoSize = true;
                blankSpace2.TextAlign = ContentAlignment.MiddleCenter;
                blankSpace2.Location = new Point(418, 174);
                blankSpace2.Font = new Font("Montserrat", 43);
                play.Controls.Add(blankSpace2);

                labelsToRemove.Add(blankSpace2);

                int pos2 = 418;

                for (int i = 0; i < (word.Length - 2) / 2; i++)
                {
                    pos2 = pos2 + 50;
                    Label blankSpace3 = new Label();
                    blankSpace3.Text = "_";
                    blankSpace3.Name = "";
                    blankSpace3.ForeColor = Color.White;
                    blankSpace3.AutoSize = true;
                    blankSpace3.TextAlign = ContentAlignment.MiddleCenter;
                    blankSpace3.Location = new Point(pos2, 174);
                    blankSpace3.Font = new Font("Montserrat", 43);
                    play.Controls.Add(blankSpace3);

                    labelsToRemove.Add(blankSpace3);
                }
            }
            else
            {
                Label blankSpace = new Label();
                blankSpace.Text = "_";
                blankSpace.Name = "";
                blankSpace.ForeColor = Color.White;
                blankSpace.AutoSize = true;
                blankSpace.TextAlign = ContentAlignment.MiddleCenter;
                blankSpace.Location = new Point(393, 174);
                blankSpace.Font = new Font("Montserrat", 43);
                play.Controls.Add(blankSpace);

                labelsToRemove.Add(blankSpace);

                int pos = 393;

                for (int i = 0; i < (word.Length - 1) / 2; i++)
                {
                    pos = pos - 50;
                    Label blankSpace2 = new Label();
                    blankSpace2.Text = "_";
                    blankSpace2.Name = "";
                    blankSpace2.ForeColor = Color.White;
                    blankSpace2.AutoSize = true;
                    blankSpace2.TextAlign = ContentAlignment.MiddleCenter;
                    blankSpace2.Location = new Point(pos, 174);
                    blankSpace2.Font = new Font("Montserrat", 43);
                    play.Controls.Add(blankSpace2);

                    labelsToRemove.Add(blankSpace2);
                }

                int pos2 = 393;

                for (int i = 0; i < (word.Length - 1) / 2; i++)
                {
                    pos2 = pos2 + 50;
                    Label blankSpace2 = new Label();
                    blankSpace2.Text = "_";
                    blankSpace2.Name = "";
                    blankSpace2.ForeColor = Color.White;
                    blankSpace2.AutoSize = true;
                    blankSpace2.TextAlign = ContentAlignment.MiddleCenter;
                    blankSpace2.Location = new Point(pos2, 174);
                    blankSpace2.Font = new Font("Montserrat", 43);
                    play.Controls.Add(blankSpace2);

                    labelsToRemove.Add(blankSpace2);
                }
            }
        }

        // When you finish the game
        private void DisplayHighScores()
        {
            //Update
            Label[] topPlayers = new Label[] { highScore_player1, highScore_player2, highScore_player3, highScore_player4, highScore_player5 };
            Label[] topScores = new Label[] { highScore_player1Score, highScore_player2Score, highScore_player3Score, highScore_player4Score, highScore_player5Score };

            //Sort list by player score
            playerList.Sort(SortByScore);

            //Check if list count is not bigger then 5
            if (playerList.Count > 5)
            {
                //if it is, start removing from the bottom up
                for (int i = playerList.Count - 1; i >= 5; i--) playerList.RemoveAt(i);
            }


            // Set labels text
            for (int i = 0; i < playerList.Count; i++)
            {
                topPlayers[i].Text = playerList[(playerList.Count - 1) - i].name;
                topScores[i].Text = playerList[(playerList.Count - 1) - i].score.ToString() + " points";
            }
        }

        private void FetchRandomLetterFromWord()
        {
            List<string> possibleOutcomes = devidedWord.Where(l => !revealedLetters.Contains(l)).ToList();

            Random rnd = new Random();
            string chosenLetter = possibleOutcomes[rnd.Next(0, possibleOutcomes.Count)];

            LetterBtnBooster(chosenLetter);
        }

        private void ResetRoundScore()
        {
            int scoreProfit = roundScore;
            score = score - scoreProfit;
        }

        private void play_changeThemeBtn_Click(object sender, EventArgs e)
        {
            if (hangmanStage < 6 && numLettersDiscovered != devidedWord.Count)
            {
                Button btn = sender as Button;

                btn.Enabled = false;
                btn.ForeColor = usedColor;
                btn.FlatAppearance.BorderColor = usedColor;

                ResetRoundScore();
                displayGame("", chosenWord.theme);
            }
        }

        private void play_changeWordBtn_Click(object sender, EventArgs e)
        {
            if (hangmanStage < 6 && numLettersDiscovered != devidedWord.Count)
            {
                Button btn = sender as Button;

                btn.Enabled = false;
                btn.ForeColor = usedColor;
                btn.FlatAppearance.BorderColor = usedColor;

                ResetRoundScore();
                displayGame(chosenWord.theme);
            }
        }

        private void play_useBoosterBtn_Click(object sender, EventArgs e)
        {
            if (hangmanStage < 6 && numLettersDiscovered != devidedWord.Count)
            {
                Button btn = sender as Button;

                btn.Enabled = false;
                btn.ForeColor = usedColor;
                btn.FlatAppearance.BorderColor = usedColor;

                FetchRandomLetterFromWord();
            }
        }

        // Speech Recognizer Function ---------------------------------------------------------------------------------------------------------------------
        private void speechRec(object sender, SpeechRecognizedEventArgs result)
        {
            String saidWords = result.Result.Text.ToLower();

            showSaidWords.Text = "Speech Recognizer: " + saidWords;
            menu.SelectedTab.Controls.Add(showSaidWords);

            if (menu.SelectedIndex == 0) // Welcome Screen
            {
                if (saidWords == "play") welcome_playBtn_Click(sender, result);
                if (saidWords == "credits") welcome_creditsBtn_Click(sender, result);
                if (saidWords == "rules") welcome_rulesBtn_Click(sender, result);
            }
            if (menu.SelectedIndex == 1) if (saidWords == "back") credits_backBtn_Click(sender, result); // Credits Screen
            if (menu.SelectedIndex == 2) if (saidWords == "back") rules_backBtn_Click(sender, result); // Rules Screen
            if (menu.SelectedIndex == 3) // Enter Name Screen
            {
                if (saidWords.Contains("player name is")) enterName_input.Text = saidWords.Split(' ').LastOrDefault();
                if (saidWords == "number of levels is five" || saidWords == "number of levels is 5") enterName_radioBtn1.Checked = true;
                if (saidWords == "number of levels is ten" || saidWords == "number of levels is 10") enterName_radioBtn2.Checked = true;
                if (saidWords == "number of levels is fifteen" || saidWords == "number of levels is 15") enterName_radioBtn3.Checked = true;
                if (saidWords == "play") enterName_playBtn_Click(sender, result);
                if (saidWords == "back") enterName_backBtn_Click(sender, result);
            }
            if(menu.SelectedIndex == 4) // Play Screen
            {
                String[] alphabet = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                                    "r", "s", "t", "u", "v", "w", "x", "y", "z"};

                for (int i = 0; i < alphabet.Length; i++) 
                {
                    Button btn = (Button) play.Controls.Find("letter" + alphabet[i].ToUpper() + "Btn", true).First();
                    if (saidWords == alphabet[i] || saidWords == "letter " + alphabet[i])
                    {
                        if (btn.Enabled) letterBtn_Click(btn, result);
                    }
                    if (saidWords == "change theme" || saidWords == "change the theme") play_changeThemeBtn_Click(btn, result);
                    if (saidWords == "change word" || saidWords == "change the word") play_changeWordBtn_Click(btn, result);
                    if (saidWords == "use booster" || saidWords == "booster") play_useBoosterBtn_Click(btn, result);
                }
                if (saidWords == "quit game" || saidWords == "quit" || saidWords == "quit the game") play_quitBtn_Click(sender, result);
            }
            if (menu.SelectedIndex == 5) if (saidWords == "back") highScores_backBtn_Click(sender, result); // High Scores Screen
        }
    }
}

[System.Serializable]
public class Item
{
    public int id;
    public string name;
    public string difficulty;
    public string theme;
}

[System.Serializable]
public class Player
{
    public int id;
    public string name;
    public int score;
}
