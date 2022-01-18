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

        // Welcome Screen -------------------------------------------------------------------------------------------------------------------------------------
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

        // Rules Screen ---------------------------------------------------------------------------------------------------------------------------------------
        private void rules_backBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 0;
        }

        // Credits Screen ---------------------------------------------------------------------------------------------------------------------------------------
        private void credits_backBtn_Click(object sender, EventArgs e)
        {
            menu.SelectedIndex = 0;
        }
    }
}
