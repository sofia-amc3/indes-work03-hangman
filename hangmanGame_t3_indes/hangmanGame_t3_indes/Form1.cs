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
        string userName;
        int score;
        List<Player> playerList;
        List<Item> itemsList;
        string playerListPath;
        string wordListPath;
        int currentPlayer;
        int currentLevel = 1;
        int totalLevels;

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
                  itemsList = JsonConvert.DeserializeObject<List<Item>>(json);
                  Debug.WriteLine(itemsList.Count);
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
                playerList = JsonConvert.DeserializeObject<List<Player>>(json);
            }
            else {

                Debug.WriteLine("Players.json doesn't exist");
            }

            currentPlayer = playerList.Count;
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
            // Verifies if the name inside of the input is valid 
            if(enterName_input.Text.Length >= 3 && enterName_input.Text.Length <= 3)
            {
                // Adds it to the json database
            } else
            {
                MessageBox.Show("Please enter a player name between 3 and 20 characters.", "Invalid Player Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Checks which number of levels was selected
            if (enterName_radioBtn1.Checked) totalLevels = 5;
            else if (enterName_radioBtn2.Checked) totalLevels = 10;
            else if (enterName_radioBtn3.Checked) totalLevels = 15;
            else MessageBox.Show("No number of levels was selected. Please select your total number of levels.", "No Levels Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Goes to Play Area
            displayGame();
            menu.SelectedIndex = 4;
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
        private void letterQBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterWBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterEBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterRBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterTBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterYBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterUBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterIBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterOBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterPBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterABtn_Click(object sender, EventArgs e)
        {

        }

        private void letterSBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterDBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterFBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterGBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterHBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterJBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterKBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterLBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterZBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterXBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterCBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterVBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterBBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterNBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterMBtn_Click(object sender, EventArgs e)
        {

        }

        // Play Screen ------------------------------------------------------------------------------------------------------------------------------------
        private void play_quitBtn_Click(object sender, EventArgs e)
        {
            // after popup
            menu.SelectedIndex = 0;
        }

        //Save player data 
        private void SaveUserData(string playerName, int playerScore) 
        {
            string json = JsonConvert.SerializeObject(playerList);
            File.WriteAllText(playerListPath, json);
        }

        private void displayGame()
        {
            play_currentLevel.Text = "Level " + currentLevel + "/" + totalLevels;
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
