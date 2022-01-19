using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangmanGame_t3_indes
{
    public partial class hangman : Form
    {
        public hangman()
        {
            InitializeComponent();
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
            menu.SelectedIndex = 4;
        }

        private void enterName_backBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 0;
        }

        private void enterName_input_TextChanged(object sender, EventArgs e)
        {
            // Enter Player Name Input
        }

        private void enterName_radioBtn1_CheckedChanged(object sender, EventArgs e)
        {
            // 5 levels
        }

        private void enterName_radioBtn2_CheckedChanged(object sender, EventArgs e)
        {
            // 10 levels
        }

        private void enterName_radioBtn3_CheckedChanged(object sender, EventArgs e)
        {
            // 15 levels
        }

        // High Scores Screen -----------------------------------------------------------------------------------------------------------------------------
        private void highScores_backBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 0;
        }

        // Play Screen ------------------------------------------------------------------------------------------------------------------------------------
        private void play_quitBtn_Click(object sender, EventArgs e)
        {
            // after popup
            menu.SelectedIndex = 0;
        }

    }
}
