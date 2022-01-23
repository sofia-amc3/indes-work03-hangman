
namespace trabalho03_indes_v2
{
    partial class hangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hangman));
            this.menu = new System.Windows.Forms.TabControl();
            this.welcome = new System.Windows.Forms.TabPage();
            this.welcome_creditsBtn = new System.Windows.Forms.Button();
            this.welcome_rulesBtn = new System.Windows.Forms.Button();
            this.welcome_playBtn = new System.Windows.Forms.Button();
            this.welcome_question = new System.Windows.Forms.Label();
            this.welcome_gameSubtitle = new System.Windows.Forms.Label();
            this.welcome_gameTitle = new System.Windows.Forms.Label();
            this.welcome_gameLogo = new System.Windows.Forms.PictureBox();
            this.credits = new System.Windows.Forms.TabPage();
            this.credits_title = new System.Windows.Forms.Label();
            this.credits_gameLogo = new System.Windows.Forms.PictureBox();
            this.credits_backBtn = new System.Windows.Forms.Button();
            this.credits_img = new System.Windows.Forms.PictureBox();
            this.rules = new System.Windows.Forms.TabPage();
            this.rules_title = new System.Windows.Forms.Label();
            this.rules_gameLogo = new System.Windows.Forms.PictureBox();
            this.rules_backBtn = new System.Windows.Forms.Button();
            this.rules_img = new System.Windows.Forms.PictureBox();
            this.enterName = new System.Windows.Forms.TabPage();
            this.play = new System.Windows.Forms.TabPage();
            this.highScores = new System.Windows.Forms.TabPage();
            this.highScore_player5 = new System.Windows.Forms.Label();
            this.highScore_player4 = new System.Windows.Forms.Label();
            this.highScore_player3 = new System.Windows.Forms.Label();
            this.highScore_player2 = new System.Windows.Forms.Label();
            this.highScore_player1 = new System.Windows.Forms.Label();
            this.highScores_score5 = new System.Windows.Forms.Label();
            this.highScores_score4 = new System.Windows.Forms.Label();
            this.highScores_score3 = new System.Windows.Forms.Label();
            this.highScores_score2 = new System.Windows.Forms.Label();
            this.highScores_score1 = new System.Windows.Forms.Label();
            this.highScores_title = new System.Windows.Forms.Label();
            this.highScores_gameLogo = new System.Windows.Forms.PictureBox();
            this.highScores_backBtn = new System.Windows.Forms.Button();
            this.highScore_player1Score = new System.Windows.Forms.Label();
            this.highScores_player2Score = new System.Windows.Forms.Label();
            this.highScores_player3Score = new System.Windows.Forms.Label();
            this.highScores_player4Score = new System.Windows.Forms.Label();
            this.highScores_player5Score = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_gameLogo)).BeginInit();
            this.credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credits_gameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_img)).BeginInit();
            this.rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rules_gameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rules_img)).BeginInit();
            this.highScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highScores_gameLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.welcome);
            this.menu.Controls.Add(this.credits);
            this.menu.Controls.Add(this.rules);
            this.menu.Controls.Add(this.enterName);
            this.menu.Controls.Add(this.play);
            this.menu.Controls.Add(this.highScores);
            this.menu.Location = new System.Drawing.Point(-8, -29);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(1489, 821);
            this.menu.TabIndex = 0;
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.welcome.Controls.Add(this.welcome_creditsBtn);
            this.welcome.Controls.Add(this.welcome_rulesBtn);
            this.welcome.Controls.Add(this.welcome_playBtn);
            this.welcome.Controls.Add(this.welcome_question);
            this.welcome.Controls.Add(this.welcome_gameSubtitle);
            this.welcome.Controls.Add(this.welcome_gameTitle);
            this.welcome.Controls.Add(this.welcome_gameLogo);
            this.welcome.Location = new System.Drawing.Point(4, 24);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(1481, 793);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "welcome";
            // 
            // welcome_creditsBtn
            // 
            this.welcome_creditsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome_creditsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.welcome_creditsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_creditsBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_creditsBtn.ForeColor = System.Drawing.Color.White;
            this.welcome_creditsBtn.Location = new System.Drawing.Point(344, 439);
            this.welcome_creditsBtn.Name = "welcome_creditsBtn";
            this.welcome_creditsBtn.Size = new System.Drawing.Size(156, 56);
            this.welcome_creditsBtn.TabIndex = 6;
            this.welcome_creditsBtn.Text = "CREDITS";
            this.welcome_creditsBtn.UseVisualStyleBackColor = true;
            this.welcome_creditsBtn.Click += new System.EventHandler(this.welcome_creditsBtn_Click);
            // 
            // welcome_rulesBtn
            // 
            this.welcome_rulesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome_rulesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.welcome_rulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_rulesBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_rulesBtn.ForeColor = System.Drawing.Color.White;
            this.welcome_rulesBtn.Location = new System.Drawing.Point(521, 439);
            this.welcome_rulesBtn.Name = "welcome_rulesBtn";
            this.welcome_rulesBtn.Size = new System.Drawing.Size(156, 56);
            this.welcome_rulesBtn.TabIndex = 5;
            this.welcome_rulesBtn.Text = "RULES";
            this.welcome_rulesBtn.UseVisualStyleBackColor = true;
            this.welcome_rulesBtn.Click += new System.EventHandler(this.welcome_rulesBtn_Click);
            // 
            // welcome_playBtn
            // 
            this.welcome_playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome_playBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.welcome_playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_playBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_playBtn.ForeColor = System.Drawing.Color.White;
            this.welcome_playBtn.Location = new System.Drawing.Point(698, 439);
            this.welcome_playBtn.Name = "welcome_playBtn";
            this.welcome_playBtn.Size = new System.Drawing.Size(156, 56);
            this.welcome_playBtn.TabIndex = 4;
            this.welcome_playBtn.Text = "PLAY";
            this.welcome_playBtn.UseVisualStyleBackColor = true;
            this.welcome_playBtn.Click += new System.EventHandler(this.welcome_playBtn_Click);
            // 
            // welcome_question
            // 
            this.welcome_question.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.welcome_question.Location = new System.Drawing.Point(510, 320);
            this.welcome_question.Name = "welcome_question";
            this.welcome_question.Size = new System.Drawing.Size(279, 61);
            this.welcome_question.TabIndex = 3;
            this.welcome_question.Text = "Can you guess the word before you get hung?";
            // 
            // welcome_gameSubtitle
            // 
            this.welcome_gameSubtitle.AutoSize = true;
            this.welcome_gameSubtitle.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_gameSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.welcome_gameSubtitle.Location = new System.Drawing.Point(510, 270);
            this.welcome_gameSubtitle.Name = "welcome_gameSubtitle";
            this.welcome_gameSubtitle.Size = new System.Drawing.Size(182, 26);
            this.welcome_gameSubtitle.TabIndex = 2;
            this.welcome_gameSubtitle.Text = "DEMO VERSION";
            // 
            // welcome_gameTitle
            // 
            this.welcome_gameTitle.AutoSize = true;
            this.welcome_gameTitle.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_gameTitle.ForeColor = System.Drawing.Color.White;
            this.welcome_gameTitle.Location = new System.Drawing.Point(502, 185);
            this.welcome_gameTitle.Name = "welcome_gameTitle";
            this.welcome_gameTitle.Size = new System.Drawing.Size(302, 66);
            this.welcome_gameTitle.TabIndex = 1;
            this.welcome_gameTitle.Text = "HANGMAN";
            // 
            // welcome_gameLogo
            // 
            this.welcome_gameLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcome_gameLogo.BackgroundImage")));
            this.welcome_gameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.welcome_gameLogo.Location = new System.Drawing.Point(402, 203);
            this.welcome_gameLogo.Name = "welcome_gameLogo";
            this.welcome_gameLogo.Size = new System.Drawing.Size(79, 168);
            this.welcome_gameLogo.TabIndex = 0;
            this.welcome_gameLogo.TabStop = false;
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.credits.Controls.Add(this.credits_title);
            this.credits.Controls.Add(this.credits_gameLogo);
            this.credits.Controls.Add(this.credits_backBtn);
            this.credits.Controls.Add(this.credits_img);
            this.credits.Location = new System.Drawing.Point(4, 24);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(1481, 793);
            this.credits.TabIndex = 1;
            this.credits.Text = "credits";
            // 
            // credits_title
            // 
            this.credits_title.Font = new System.Drawing.Font("Montserrat", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits_title.ForeColor = System.Drawing.Color.White;
            this.credits_title.Location = new System.Drawing.Point(128, 43);
            this.credits_title.Name = "credits_title";
            this.credits_title.Size = new System.Drawing.Size(190, 50);
            this.credits_title.TabIndex = 13;
            this.credits_title.Text = "CREDITS";
            // 
            // credits_gameLogo
            // 
            this.credits_gameLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credits_gameLogo.BackgroundImage")));
            this.credits_gameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.credits_gameLogo.Location = new System.Drawing.Point(58, 3);
            this.credits_gameLogo.Name = "credits_gameLogo";
            this.credits_gameLogo.Size = new System.Drawing.Size(64, 106);
            this.credits_gameLogo.TabIndex = 12;
            this.credits_gameLogo.TabStop = false;
            // 
            // credits_backBtn
            // 
            this.credits_backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credits_backBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.credits_backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credits_backBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits_backBtn.ForeColor = System.Drawing.Color.White;
            this.credits_backBtn.Location = new System.Drawing.Point(568, 589);
            this.credits_backBtn.Name = "credits_backBtn";
            this.credits_backBtn.Size = new System.Drawing.Size(156, 56);
            this.credits_backBtn.TabIndex = 11;
            this.credits_backBtn.Text = "BACK";
            this.credits_backBtn.UseVisualStyleBackColor = true;
            this.credits_backBtn.Click += new System.EventHandler(this.credits_backBtn_Click);
            // 
            // credits_img
            // 
            this.credits_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credits_img.BackgroundImage")));
            this.credits_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.credits_img.Location = new System.Drawing.Point(3, 36);
            this.credits_img.Name = "credits_img";
            this.credits_img.Size = new System.Drawing.Size(1265, 646);
            this.credits_img.TabIndex = 10;
            this.credits_img.TabStop = false;
            // 
            // rules
            // 
            this.rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.rules.Controls.Add(this.rules_title);
            this.rules.Controls.Add(this.rules_gameLogo);
            this.rules.Controls.Add(this.rules_backBtn);
            this.rules.Controls.Add(this.rules_img);
            this.rules.Location = new System.Drawing.Point(4, 24);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(1481, 793);
            this.rules.TabIndex = 2;
            this.rules.Text = "rules";
            // 
            // rules_title
            // 
            this.rules_title.Font = new System.Drawing.Font("Montserrat", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rules_title.ForeColor = System.Drawing.Color.White;
            this.rules_title.Location = new System.Drawing.Point(128, 43);
            this.rules_title.Name = "rules_title";
            this.rules_title.Size = new System.Drawing.Size(145, 50);
            this.rules_title.TabIndex = 9;
            this.rules_title.Text = "RULES";
            // 
            // rules_gameLogo
            // 
            this.rules_gameLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rules_gameLogo.BackgroundImage")));
            this.rules_gameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rules_gameLogo.Location = new System.Drawing.Point(58, 3);
            this.rules_gameLogo.Name = "rules_gameLogo";
            this.rules_gameLogo.Size = new System.Drawing.Size(64, 106);
            this.rules_gameLogo.TabIndex = 8;
            this.rules_gameLogo.TabStop = false;
            // 
            // rules_backBtn
            // 
            this.rules_backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rules_backBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rules_backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rules_backBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rules_backBtn.ForeColor = System.Drawing.Color.White;
            this.rules_backBtn.Location = new System.Drawing.Point(568, 589);
            this.rules_backBtn.Name = "rules_backBtn";
            this.rules_backBtn.Size = new System.Drawing.Size(156, 56);
            this.rules_backBtn.TabIndex = 7;
            this.rules_backBtn.Text = "BACK";
            this.rules_backBtn.UseVisualStyleBackColor = true;
            this.rules_backBtn.Click += new System.EventHandler(this.rules_backBtn_Click);
            // 
            // rules_img
            // 
            this.rules_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rules_img.BackgroundImage")));
            this.rules_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rules_img.Location = new System.Drawing.Point(3, 3);
            this.rules_img.Name = "rules_img";
            this.rules_img.Size = new System.Drawing.Size(1265, 642);
            this.rules_img.TabIndex = 0;
            this.rules_img.TabStop = false;
            // 
            // enterName
            // 
            this.enterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.enterName.Location = new System.Drawing.Point(4, 24);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(1481, 793);
            this.enterName.TabIndex = 3;
            this.enterName.Text = "enterName";
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.play.Location = new System.Drawing.Point(4, 24);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(1481, 793);
            this.play.TabIndex = 4;
            this.play.Text = "play";
            // 
            // highScores
            // 
            this.highScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.highScores.Controls.Add(this.highScores_player5Score);
            this.highScores.Controls.Add(this.highScores_player4Score);
            this.highScores.Controls.Add(this.highScores_player3Score);
            this.highScores.Controls.Add(this.highScores_player2Score);
            this.highScores.Controls.Add(this.highScore_player1Score);
            this.highScores.Controls.Add(this.highScore_player5);
            this.highScores.Controls.Add(this.highScore_player4);
            this.highScores.Controls.Add(this.highScore_player3);
            this.highScores.Controls.Add(this.highScore_player2);
            this.highScores.Controls.Add(this.highScore_player1);
            this.highScores.Controls.Add(this.highScores_score5);
            this.highScores.Controls.Add(this.highScores_score4);
            this.highScores.Controls.Add(this.highScores_score3);
            this.highScores.Controls.Add(this.highScores_score2);
            this.highScores.Controls.Add(this.highScores_score1);
            this.highScores.Controls.Add(this.highScores_title);
            this.highScores.Controls.Add(this.highScores_gameLogo);
            this.highScores.Controls.Add(this.highScores_backBtn);
            this.highScores.Location = new System.Drawing.Point(4, 24);
            this.highScores.Name = "highScores";
            this.highScores.Size = new System.Drawing.Size(1481, 793);
            this.highScores.TabIndex = 5;
            this.highScores.Text = "highScores";
            // 
            // highScore_player5
            // 
            this.highScore_player5.BackColor = System.Drawing.Color.White;
            this.highScore_player5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore_player5.ForeColor = System.Drawing.Color.Black;
            this.highScore_player5.Location = new System.Drawing.Point(471, 427);
            this.highScore_player5.Name = "highScore_player5";
            this.highScore_player5.Size = new System.Drawing.Size(303, 46);
            this.highScore_player5.TabIndex = 26;
            this.highScore_player5.Text = "playerName05";
            this.highScore_player5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScore_player4
            // 
            this.highScore_player4.BackColor = System.Drawing.Color.White;
            this.highScore_player4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore_player4.ForeColor = System.Drawing.Color.Black;
            this.highScore_player4.Location = new System.Drawing.Point(471, 369);
            this.highScore_player4.Name = "highScore_player4";
            this.highScore_player4.Size = new System.Drawing.Size(303, 46);
            this.highScore_player4.TabIndex = 25;
            this.highScore_player4.Text = "playerName04";
            this.highScore_player4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScore_player3
            // 
            this.highScore_player3.BackColor = System.Drawing.Color.White;
            this.highScore_player3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore_player3.ForeColor = System.Drawing.Color.Black;
            this.highScore_player3.Location = new System.Drawing.Point(471, 310);
            this.highScore_player3.Name = "highScore_player3";
            this.highScore_player3.Size = new System.Drawing.Size(303, 46);
            this.highScore_player3.TabIndex = 24;
            this.highScore_player3.Text = "playerName03";
            this.highScore_player3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScore_player2
            // 
            this.highScore_player2.BackColor = System.Drawing.Color.White;
            this.highScore_player2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore_player2.ForeColor = System.Drawing.Color.Black;
            this.highScore_player2.Location = new System.Drawing.Point(471, 251);
            this.highScore_player2.Name = "highScore_player2";
            this.highScore_player2.Size = new System.Drawing.Size(303, 46);
            this.highScore_player2.TabIndex = 23;
            this.highScore_player2.Text = "playerName02";
            this.highScore_player2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScore_player1
            // 
            this.highScore_player1.BackColor = System.Drawing.Color.White;
            this.highScore_player1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore_player1.ForeColor = System.Drawing.Color.Black;
            this.highScore_player1.Location = new System.Drawing.Point(471, 192);
            this.highScore_player1.Name = "highScore_player1";
            this.highScore_player1.Size = new System.Drawing.Size(303, 46);
            this.highScore_player1.TabIndex = 22;
            this.highScore_player1.Text = "playerName01";
            this.highScore_player1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores_score5
            // 
            this.highScores_score5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.highScores_score5.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_score5.ForeColor = System.Drawing.Color.White;
            this.highScores_score5.Location = new System.Drawing.Point(349, 427);
            this.highScores_score5.Name = "highScores_score5";
            this.highScores_score5.Size = new System.Drawing.Size(116, 46);
            this.highScores_score5.TabIndex = 21;
            this.highScores_score5.Text = "5";
            this.highScores_score5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores_score4
            // 
            this.highScores_score4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.highScores_score4.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_score4.ForeColor = System.Drawing.Color.White;
            this.highScores_score4.Location = new System.Drawing.Point(349, 369);
            this.highScores_score4.Name = "highScores_score4";
            this.highScores_score4.Size = new System.Drawing.Size(116, 46);
            this.highScores_score4.TabIndex = 20;
            this.highScores_score4.Text = "4";
            this.highScores_score4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores_score3
            // 
            this.highScores_score3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.highScores_score3.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_score3.ForeColor = System.Drawing.Color.White;
            this.highScores_score3.Location = new System.Drawing.Point(349, 310);
            this.highScores_score3.Name = "highScores_score3";
            this.highScores_score3.Size = new System.Drawing.Size(116, 46);
            this.highScores_score3.TabIndex = 19;
            this.highScores_score3.Text = "3";
            this.highScores_score3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores_score2
            // 
            this.highScores_score2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.highScores_score2.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_score2.ForeColor = System.Drawing.Color.White;
            this.highScores_score2.Location = new System.Drawing.Point(349, 251);
            this.highScores_score2.Name = "highScores_score2";
            this.highScores_score2.Size = new System.Drawing.Size(116, 46);
            this.highScores_score2.TabIndex = 18;
            this.highScores_score2.Text = "2";
            this.highScores_score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores_score1
            // 
            this.highScores_score1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.highScores_score1.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_score1.ForeColor = System.Drawing.Color.White;
            this.highScores_score1.Location = new System.Drawing.Point(349, 192);
            this.highScores_score1.Name = "highScores_score1";
            this.highScores_score1.Size = new System.Drawing.Size(116, 46);
            this.highScores_score1.TabIndex = 17;
            this.highScores_score1.Text = "1";
            this.highScores_score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores_title
            // 
            this.highScores_title.Font = new System.Drawing.Font("Montserrat", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_title.ForeColor = System.Drawing.Color.White;
            this.highScores_title.Location = new System.Drawing.Point(126, 36);
            this.highScores_title.Name = "highScores_title";
            this.highScores_title.Size = new System.Drawing.Size(302, 50);
            this.highScores_title.TabIndex = 16;
            this.highScores_title.Text = "HIGH SCORES";
            // 
            // highScores_gameLogo
            // 
            this.highScores_gameLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("highScores_gameLogo.BackgroundImage")));
            this.highScores_gameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.highScores_gameLogo.Location = new System.Drawing.Point(56, -4);
            this.highScores_gameLogo.Name = "highScores_gameLogo";
            this.highScores_gameLogo.Size = new System.Drawing.Size(64, 106);
            this.highScores_gameLogo.TabIndex = 15;
            this.highScores_gameLogo.TabStop = false;
            // 
            // highScores_backBtn
            // 
            this.highScores_backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highScores_backBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.highScores_backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highScores_backBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_backBtn.ForeColor = System.Drawing.Color.White;
            this.highScores_backBtn.Location = new System.Drawing.Point(566, 582);
            this.highScores_backBtn.Name = "highScores_backBtn";
            this.highScores_backBtn.Size = new System.Drawing.Size(156, 56);
            this.highScores_backBtn.TabIndex = 14;
            this.highScores_backBtn.Text = "BACK";
            this.highScores_backBtn.UseVisualStyleBackColor = true;
            this.highScores_backBtn.Click += new System.EventHandler(this.highScores_backBtn_Click);
            // 
            // highScore_player1Score
            // 
            this.highScore_player1Score.BackColor = System.Drawing.Color.White;
            this.highScore_player1Score.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore_player1Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.highScore_player1Score.Location = new System.Drawing.Point(780, 192);
            this.highScore_player1Score.Name = "highScore_player1Score";
            this.highScore_player1Score.Size = new System.Drawing.Size(164, 46);
            this.highScore_player1Score.TabIndex = 27;
            this.highScore_player1Score.Text = "500 points";
            this.highScore_player1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores_player2Score
            // 
            this.highScores_player2Score.BackColor = System.Drawing.Color.White;
            this.highScores_player2Score.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_player2Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.highScores_player2Score.Location = new System.Drawing.Point(780, 251);
            this.highScores_player2Score.Name = "highScores_player2Score";
            this.highScores_player2Score.Size = new System.Drawing.Size(164, 46);
            this.highScores_player2Score.TabIndex = 28;
            this.highScores_player2Score.Text = "250 points";
            this.highScores_player2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores_player3Score
            // 
            this.highScores_player3Score.BackColor = System.Drawing.Color.White;
            this.highScores_player3Score.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_player3Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.highScores_player3Score.Location = new System.Drawing.Point(780, 310);
            this.highScores_player3Score.Name = "highScores_player3Score";
            this.highScores_player3Score.Size = new System.Drawing.Size(164, 46);
            this.highScores_player3Score.TabIndex = 29;
            this.highScores_player3Score.Text = "100 points";
            this.highScores_player3Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores_player4Score
            // 
            this.highScores_player4Score.BackColor = System.Drawing.Color.White;
            this.highScores_player4Score.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_player4Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.highScores_player4Score.Location = new System.Drawing.Point(780, 369);
            this.highScores_player4Score.Name = "highScores_player4Score";
            this.highScores_player4Score.Size = new System.Drawing.Size(164, 46);
            this.highScores_player4Score.TabIndex = 30;
            this.highScores_player4Score.Text = "0 points";
            this.highScores_player4Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScores_player5Score
            // 
            this.highScores_player5Score.BackColor = System.Drawing.Color.White;
            this.highScores_player5Score.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_player5Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.highScores_player5Score.Location = new System.Drawing.Point(780, 427);
            this.highScores_player5Score.Name = "highScores_player5Score";
            this.highScores_player5Score.Size = new System.Drawing.Size(164, 46);
            this.highScores_player5Score.TabIndex = 31;
            this.highScores_player5Score.Text = "-30 points";
            this.highScores_player5Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "hangman";
            this.Text = "Hangman";
            this.menu.ResumeLayout(false);
            this.welcome.ResumeLayout(false);
            this.welcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_gameLogo)).EndInit();
            this.credits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.credits_gameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_img)).EndInit();
            this.rules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rules_gameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rules_img)).EndInit();
            this.highScores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.highScores_gameLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage welcome;
        private System.Windows.Forms.Button welcome_creditsBtn;
        private System.Windows.Forms.Button welcome_rulesBtn;
        private System.Windows.Forms.Button welcome_playBtn;
        private System.Windows.Forms.Label welcome_question;
        private System.Windows.Forms.Label welcome_gameSubtitle;
        private System.Windows.Forms.Label welcome_gameTitle;
        private System.Windows.Forms.PictureBox welcome_gameLogo;
        private System.Windows.Forms.TabPage credits;
        private System.Windows.Forms.TabPage rules;
        private System.Windows.Forms.TabPage enterName;
        private System.Windows.Forms.TabPage play;
        private System.Windows.Forms.TabPage highScores;
        private System.Windows.Forms.Label credits_title;
        private System.Windows.Forms.PictureBox credits_gameLogo;
        private System.Windows.Forms.Button credits_backBtn;
        private System.Windows.Forms.PictureBox credits_img;
        private System.Windows.Forms.Label rules_title;
        private System.Windows.Forms.PictureBox rules_gameLogo;
        private System.Windows.Forms.Button rules_backBtn;
        private System.Windows.Forms.PictureBox rules_img;
        private System.Windows.Forms.Label highScore_player5;
        private System.Windows.Forms.Label highScore_player4;
        private System.Windows.Forms.Label highScore_player3;
        private System.Windows.Forms.Label highScore_player2;
        private System.Windows.Forms.Label highScore_player1;
        private System.Windows.Forms.Label highScores_score5;
        private System.Windows.Forms.Label highScores_score4;
        private System.Windows.Forms.Label highScores_score3;
        private System.Windows.Forms.Label highScores_score2;
        private System.Windows.Forms.Label highScores_score1;
        private System.Windows.Forms.Label highScores_title;
        private System.Windows.Forms.PictureBox highScores_gameLogo;
        private System.Windows.Forms.Button highScores_backBtn;
        private System.Windows.Forms.Label highScores_player5Score;
        private System.Windows.Forms.Label highScores_player4Score;
        private System.Windows.Forms.Label highScores_player3Score;
        private System.Windows.Forms.Label highScores_player2Score;
        private System.Windows.Forms.Label highScore_player1Score;
    }
}

