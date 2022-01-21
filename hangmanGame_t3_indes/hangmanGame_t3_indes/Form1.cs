using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace hangmanGame_t3_indes
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
        List<Item> alreadyUsedLetters = new List<Item>();
        List<Button> clickedButtons = new List<Button>();
        List<String> revealedLetters = new List<String>();
        int numLettersDiscovered = 0;
        int hangmanStage = 0;

        // Color for gray out buttons
        Color backgroundOriginal = Color.FromArgb(255, 17, 36, 68);
        Color backgroundUsed = Color.FromArgb(150, 17, 36, 68);
        Color foregroundUsed = Color.FromArgb(150, 255, 255, 255);

        public hangman()
        {
            // Initialize list
            playerList = new List<Player>();
            
            InitializeComponent();
            wordListPath = Path.Combine(Environment.CurrentDirectory, @"jsonFiles\HangManWords.json");
            Debug.WriteLine(wordListPath);

            // Check if file exists
            if (File.Exists(wordListPath))
            {
                  string json = File.ReadAllText(wordListPath);
                  wordList = JsonConvert.DeserializeObject<List<Item>>(json);
                 
                  Debug.WriteLine("File exists");
            }
            else { Debug.WriteLine("File doesn't exist"); }

            // Player list url
            playerListPath = Path.Combine(Environment.CurrentDirectory, @"jsonFiles\Players.json");

            // Check if player file exists
            if (File.Exists(playerListPath))
            {
                // Get top five players' data
                string json = File.ReadAllText(playerListPath);
                playerList = SortList(JsonConvert.DeserializeObject<List<Player>>(json));

            }
            else {

                Debug.WriteLine("Players.json doesn't exist");
            }

        }

        private List<Player> SortList(List<Player> x)
        {

            List<Player> sortedPlayerList = new List<Player>();

            //Sort the playerList for player with the 
            IEnumerable<Player> query = x.OrderBy(player => player.score);

            //Add to new list
            foreach (Player player in query)
            {

                sortedPlayerList.Add(player);


            }

            if (sortedPlayerList.Count > 5)
            {
                for (int i = sortedPlayerList.Count - 1; i >= 5; i--) { 
                
                    sortedPlayerList.RemoveAt(i);
                
                }
            }

            return sortedPlayerList;
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
            if(enterName_input.Text.Length >= 3 && enterName_input.Text.Length <= 20)
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
            else
            {
                MessageBox.Show("Please enter a player name between 3 and 20 characters.", "Invalid Player Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Checks which number of levels was selected
            if (enterName_radioBtn1.Checked) { totalLevels = 5; check++; }
            else if (enterName_radioBtn2.Checked) { totalLevels = 10; check++; }
            else if (enterName_radioBtn3.Checked) { totalLevels = 15; check++; }
            else MessageBox.Show("No number of levels was selected. Please select your total number of levels.", "No Levels Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Only goe to next page if all the verefications are made
            if (check == 2) {

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
            Button btn = sender as Button;

            clickedButtons.Add(btn);

            btn.Enabled = false;
            btn.BackColor = backgroundUsed;
            btn.ForeColor = foregroundUsed;

            RegisterLetter(btn.Text);
        }

        private void RegisterLetter(string letter)
        {
            if (devidedWord.Contains(letter))
            {
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
                            // First pos = 373 - (((devidedWord.Count - 2) / 2) * 30) (space between letters)
                            int pos = 373 - (((devidedWord.Count - 2) / 2) * 30);
                            pos = pos + 30 * counter;
                            Label blankSpace = new Label();
                            blankSpace.Text = letter;
                            blankSpace.Name = "";
                            blankSpace.ForeColor = Color.White;
                            blankSpace.AutoSize = true;
                            blankSpace.TextAlign = ContentAlignment.MiddleCenter;
                            blankSpace.Location = new Point(pos, 150);
                            blankSpace.Font = new Font("Montserrat", 39);
                            play.Controls.Add(blankSpace);
                        }
                        else
                        {
                            // First pos = 403 - (((devidedWord.Count - 1) / 2) * 30) (space between letters)
                            int pos = 403 - ((devidedWord.Count - 1) / 2) * 30;
                            pos = pos + 30 * counter;
                            Label blankSpace = new Label();
                            blankSpace.Text = letter;
                            blankSpace.Name = "";
                            blankSpace.ForeColor = Color.White;
                            blankSpace.AutoSize = true;
                            blankSpace.TextAlign = ContentAlignment.MiddleCenter;
                            blankSpace.Location = new Point(pos, 150);
                            blankSpace.Font = new Font("Montserrat", 39);
                            play.Controls.Add(blankSpace);
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
                AdvanceHangman();
            }
        }

        private void AdvanceHangman()
        {
            hangmanStage++;

            // Change image depending on the stage!
            switch (hangmanStage) {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;
            }

            // After changing the image, check if the player has lost.

            CheckIfLost();
        }

        private void CheckIfWon()
        {
            // The player WINS when numDiscoveredLetters = devidedWord.Count
            if (numLettersDiscovered == devidedWord.Count)
            {
                // Disable all the buttons!
                // When the player wins, move him to a win screen, and reset the buttons' appearances so they are not greyed out
                ResetButtons();
            }
        }

        private void CheckIfLost()
        {
            // The player LOSES when hangmanStage = 6 (full image)
            if (hangmanStage == 6)
            {
                // Disable all the buttons!
                // Show the full word
                // When the player loses, move him to a lose screen, and reset the buttons' appearances so they are not greyed out
                ResetButtons();
            }
        }

        private void ResetButtons()
        {
            foreach (Button btn in clickedButtons)
            {
                btn.Enabled = true;
                btn.ForeColor = Color.White;
                btn.BackColor = backgroundOriginal;
            }
        }

        // Play Screen ------------------------------------------------------------------------------------------------------------------------------------
        private void play_quitBtn_Click(object sender, EventArgs e)
        {
            // after popup
            menu.SelectedIndex = 5;
            DisplayHighScores();
        }

        //Save player data 
        private void SaveUserData() 
        {
            //Convert list to string
            string json = JsonConvert.SerializeObject(playerList);

            //and save it in the json file
            File.WriteAllText(playerListPath, json);
        }

        private void displayGame()
        {
            play_currentLevel.Text = "Level " + currentLevel + "/" + totalLevels;
            play_score.Text = score.ToString();

            //Generate word for 5 levels
            if (totalLevels == 5) { // if palyer chose 5 levels 
            
                //Check if current level
                if(currentLevel < 3) // if 2 or less pick from the easy difficulty
                {
                    //Look through the easy words
                    EasyWordRnd();
                }

                //Check if current level is 3 or 4
                if (currentLevel >= 3 && currentLevel < 5) { 
                
                    //look through the average words
                    AverageWordRnd();
                
                }

                //Check if current level is 5
                if (currentLevel == 5) { 
                
                    //look throught the difficult words
                    DifficultWordRnd();
                
                }
            
            }

            //Generate word for 10 levels
            if (totalLevels == 10)
            { // if palyer chose 10 levels 

                //Check if current level
                if (currentLevel < 5) // if 4 or less pick from the easy difficulty
                {
                    //Look through the easy words
                    EasyWordRnd();
                }

                //Check if current level is 5 or higher, but less then 9
                if (currentLevel >= 5 && currentLevel < 9)
                {

                    //look through the average words
                    AverageWordRnd();

                }

                //Check if current level is 9 or higher
                if (currentLevel >= 9)
                {

                    //look throught the difficult words
                    DifficultWordRnd();

                }

            }

            //Generate word for 15 levels
            if (totalLevels == 15)
            { // if palyer chose 15 levels 

                //Check if current level
                if (currentLevel < 6) // if 5 or less pick from the easy difficulty
                {
                    //Look through the easy words
                    EasyWordRnd();
                }

                //Check if current level is 6 or higher, but less then 11
                if (currentLevel >= 6 && currentLevel < 11)
                {

                    //look through the average words
                    AverageWordRnd();

                }

                //Check if current level is 11 or higher
                if (currentLevel >= 11)
                {

                    //look throught the difficult words
                    DifficultWordRnd();

                }

            }

        }

        #region Randomize Words
        //Randomize easy words
        private void EasyWordRnd() {

            List<Item> items = new List<Item>();

            //Search
            for (int i = 0; i < wordList.Count; i++)
            {

                //Add only the easy difficulty words
                if (wordList[i].difficulty == "easy" && !alreadyUsedLetters.Contains(wordList[i]))
                {

                    //Add word to new list
                    items.Add(wordList[i]);

                }

            }

            Random rnd = new Random();
            chosenWord = items[rnd.Next(0, items.Count)];
            alreadyUsedLetters.Add(chosenWord);
            devidedWord = SeparateWord(chosenWord.name);
            
            string playWord = "";
            string line = "";

            for (int i = 0; i < devidedWord.Count; i++)
            { 
                playWord += devidedWord[i];
                line += "_";
               
                if (i != devidedWord.Count - 1) {

                    line += " ";
                    playWord += "  ";
                }
            
            }

            //Add values to labels
            //play_word.Text = playWord;
            play_theme.Text = chosenWord.theme.ToUpper();
            GenerateBlankSpaces(chosenWord.name);
            play_letterDashes.Text = "";


        }

        //Randomize average words
        private void AverageWordRnd()
        {

            List<Item> items = new List<Item>();

            //Search
            for (int i = 0; i < wordList.Count; i++)
            {

                //Add only the average difficulty words
                if (wordList[i].difficulty == "average" && !alreadyUsedLetters.Contains(wordList[i]))
                {

                    //Add word to new list
                    items.Add(wordList[i]);

                }

            }

            //Generate randomize word
            Random rnd = new Random();
            chosenWord = items[rnd.Next(0, items.Count)];

            //Add chosen word to already used words, so tht it's not picked again
            alreadyUsedLetters.Add(chosenWord);

            //Splite the word in to list
            devidedWord = SeparateWord(chosenWord.name);
            string playWord = "";
            string line = "";

            for (int i = 0; i < devidedWord.Count; i++)
            {
                playWord += devidedWord[i];

                if (devidedWord[i] != " ")
                {

                    line += "_";

                }
                else
                {

                    line += " ";

                }

            }

            //Add values to labels
            //play_word.Text = playWord;
            play_theme.Text = chosenWord.theme.ToUpper();
            GenerateBlankSpaces(chosenWord.name);
            play_letterDashes.Text = "";


        }

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
                blankSpace.Location = new Point(373, 174);
                blankSpace.Font = new Font("Montserrat", 43);
                play.Controls.Add(blankSpace);

                Label blankSpace2 = new Label();
                blankSpace2.Text = "_";
                blankSpace2.Name = "";
                blankSpace2.ForeColor = Color.White;
                blankSpace2.AutoSize = true;
                blankSpace2.TextAlign = ContentAlignment.MiddleCenter;
                blankSpace2.Location = new Point(433, 174);
                blankSpace2.Font = new Font("Montserrat", 43);
                play.Controls.Add(blankSpace2);
            }
            else
            {
                Label blankSpace = new Label();
                blankSpace.Text = "_";
                blankSpace.Name = "";
                blankSpace.ForeColor = Color.White;
                blankSpace.AutoSize = true;
                blankSpace.TextAlign = ContentAlignment.MiddleCenter;
                blankSpace.Location = new Point(403, 174);
                blankSpace.Font = new Font("Montserrat", 43);
                play.Controls.Add(blankSpace);
            }
        }

        //Randomize difficult words
        private void DifficultWordRnd()
        {

            List<Item> items = new List<Item>();

            //Search
            for (int i = 0; i < wordList.Count; i++)
            {

                //Add only the difficult words
                if (wordList[i].difficulty == "difficult" && !alreadyUsedLetters.Contains(wordList[i]))
                {

                    //Add word to new list
                    items.Add(wordList[i]);

                }

            }

            //Generate randomize word
            Random rnd = new Random();
            chosenWord = items[rnd.Next(0, items.Count)];

            //Add chosen word to already used words, so tht it's not picked again
            alreadyUsedLetters.Add(chosenWord);

            //Splite the word in to list
            devidedWord = SeparateWord(chosenWord.name);
            string playWord = "";
            string line = "";

            for (int i = 0; i < devidedWord.Count; i++)
            {
                playWord += devidedWord[i];

                if (devidedWord[i] != " ")
                line += "_";      
                else
                line += " ";

            }

            //Add values to labels
            //play_word.Text = playWord;
            play_theme.Text = chosenWord.theme.ToUpper();
            GenerateBlankSpaces(chosenWord.name);
            play_letterDashes.Text = "";

        }

        #endregion


        //Add the letters to a list
        private List<string> SeparateWord(string x) {


            List<string> newWord = new List<string>();

            
            foreach (char c in x) {

                newWord.Add(c.ToString());
            }

            return newWord;
        }

        // When you finish the game
        private void DisplayHighScores() {

            //Updaty
            Label[] topPlayers = new Label[] { highScore_player1, highScore_player2, highScore_player3, highScore_player4, highScore_player5 };
            Label[] topScores = new Label[] { highScore_player1Score, highScore_player2Score, highScore_player3Score, highScore_player4Score, highScore_player5Score };

            playerList = SortList(playerList);
            //Add data
            for (int i = 0; i < playerList.Count; i++) {

                topPlayers[i].Text = playerList[i].name;
                topScores[i].Text = playerList[i].score.ToString() + " points";
            
            }


        }

        // Cheack if input is right
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
