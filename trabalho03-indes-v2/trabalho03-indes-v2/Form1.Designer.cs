
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
            this.letterMBtn = new System.Windows.Forms.Button();
            this.letterNBtn = new System.Windows.Forms.Button();
            this.letterBBtn = new System.Windows.Forms.Button();
            this.letterVBtn = new System.Windows.Forms.Button();
            this.letterCBtn = new System.Windows.Forms.Button();
            this.letterXBtn = new System.Windows.Forms.Button();
            this.letterZBtn = new System.Windows.Forms.Button();
            this.letterLBtn = new System.Windows.Forms.Button();
            this.letterKBtn = new System.Windows.Forms.Button();
            this.letterJBtn = new System.Windows.Forms.Button();
            this.letterHBtn = new System.Windows.Forms.Button();
            this.letterGBtn = new System.Windows.Forms.Button();
            this.letterFBtn = new System.Windows.Forms.Button();
            this.letterDBtn = new System.Windows.Forms.Button();
            this.letterSBtn = new System.Windows.Forms.Button();
            this.letterABtn = new System.Windows.Forms.Button();
            this.letterPBtn = new System.Windows.Forms.Button();
            this.letterOBtn = new System.Windows.Forms.Button();
            this.letterIBtn = new System.Windows.Forms.Button();
            this.letterUBtn = new System.Windows.Forms.Button();
            this.letterYBtn = new System.Windows.Forms.Button();
            this.letterTBtn = new System.Windows.Forms.Button();
            this.letterRBtn = new System.Windows.Forms.Button();
            this.letterEBtn = new System.Windows.Forms.Button();
            this.letterWBtn = new System.Windows.Forms.Button();
            this.letterQBtn = new System.Windows.Forms.Button();
            this.play_hangman = new System.Windows.Forms.PictureBox();
            this.play_word = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.play_currentLevel = new System.Windows.Forms.Label();
            this.play_letterDashes = new System.Windows.Forms.Label();
            this.highScores = new System.Windows.Forms.TabPage();
            this.highScores_player5Score = new System.Windows.Forms.Label();
            this.highScores_player4Score = new System.Windows.Forms.Label();
            this.highScores_player3Score = new System.Windows.Forms.Label();
            this.highScores_player2Score = new System.Windows.Forms.Label();
            this.highScore_player1Score = new System.Windows.Forms.Label();
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
            this.play_divider = new System.Windows.Forms.Label();
            this.play_themeLabel = new System.Windows.Forms.Label();
            this.play_theme = new System.Windows.Forms.Label();
            this.play_score = new System.Windows.Forms.Label();
            this.play_scoreLabel = new System.Windows.Forms.Label();
            this.play_quitBtn = new System.Windows.Forms.Button();
            this.play_changeThemeBtn = new System.Windows.Forms.Button();
            this.play_changeWordBtn = new System.Windows.Forms.Button();
            this.play_useBoosterBtn = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_gameLogo)).BeginInit();
            this.credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credits_gameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_img)).BeginInit();
            this.rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rules_gameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rules_img)).BeginInit();
            this.play.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.play_hangman)).BeginInit();
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
            this.play.Controls.Add(this.play_useBoosterBtn);
            this.play.Controls.Add(this.play_changeWordBtn);
            this.play.Controls.Add(this.play_changeThemeBtn);
            this.play.Controls.Add(this.play_quitBtn);
            this.play.Controls.Add(this.play_score);
            this.play.Controls.Add(this.play_scoreLabel);
            this.play.Controls.Add(this.play_theme);
            this.play.Controls.Add(this.play_themeLabel);
            this.play.Controls.Add(this.play_divider);
            this.play.Controls.Add(this.letterMBtn);
            this.play.Controls.Add(this.letterNBtn);
            this.play.Controls.Add(this.letterBBtn);
            this.play.Controls.Add(this.letterVBtn);
            this.play.Controls.Add(this.letterCBtn);
            this.play.Controls.Add(this.letterXBtn);
            this.play.Controls.Add(this.letterZBtn);
            this.play.Controls.Add(this.letterLBtn);
            this.play.Controls.Add(this.letterKBtn);
            this.play.Controls.Add(this.letterJBtn);
            this.play.Controls.Add(this.letterHBtn);
            this.play.Controls.Add(this.letterGBtn);
            this.play.Controls.Add(this.letterFBtn);
            this.play.Controls.Add(this.letterDBtn);
            this.play.Controls.Add(this.letterSBtn);
            this.play.Controls.Add(this.letterABtn);
            this.play.Controls.Add(this.letterPBtn);
            this.play.Controls.Add(this.letterOBtn);
            this.play.Controls.Add(this.letterIBtn);
            this.play.Controls.Add(this.letterUBtn);
            this.play.Controls.Add(this.letterYBtn);
            this.play.Controls.Add(this.letterTBtn);
            this.play.Controls.Add(this.letterRBtn);
            this.play.Controls.Add(this.letterEBtn);
            this.play.Controls.Add(this.letterWBtn);
            this.play.Controls.Add(this.letterQBtn);
            this.play.Controls.Add(this.play_hangman);
            this.play.Controls.Add(this.play_word);
            this.play.Controls.Add(this.label1);
            this.play.Controls.Add(this.play_currentLevel);
            this.play.Controls.Add(this.play_letterDashes);
            this.play.Location = new System.Drawing.Point(4, 24);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(1481, 793);
            this.play.TabIndex = 4;
            this.play.Text = "play";
            // 
            // letterMBtn
            // 
            this.letterMBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterMBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterMBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterMBtn.ForeColor = System.Drawing.Color.White;
            this.letterMBtn.Location = new System.Drawing.Point(543, 561);
            this.letterMBtn.Name = "letterMBtn";
            this.letterMBtn.Size = new System.Drawing.Size(40, 40);
            this.letterMBtn.TabIndex = 30;
            this.letterMBtn.Text = "M";
            this.letterMBtn.UseVisualStyleBackColor = true;
            this.letterMBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterNBtn
            // 
            this.letterNBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterNBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterNBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterNBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterNBtn.ForeColor = System.Drawing.Color.White;
            this.letterNBtn.Location = new System.Drawing.Point(497, 561);
            this.letterNBtn.Name = "letterNBtn";
            this.letterNBtn.Size = new System.Drawing.Size(40, 40);
            this.letterNBtn.TabIndex = 29;
            this.letterNBtn.Text = "N";
            this.letterNBtn.UseVisualStyleBackColor = true;
            this.letterNBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterBBtn
            // 
            this.letterBBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterBBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterBBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterBBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterBBtn.ForeColor = System.Drawing.Color.White;
            this.letterBBtn.Location = new System.Drawing.Point(451, 561);
            this.letterBBtn.Name = "letterBBtn";
            this.letterBBtn.Size = new System.Drawing.Size(40, 40);
            this.letterBBtn.TabIndex = 28;
            this.letterBBtn.Text = "B";
            this.letterBBtn.UseVisualStyleBackColor = true;
            this.letterBBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterVBtn
            // 
            this.letterVBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterVBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterVBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterVBtn.ForeColor = System.Drawing.Color.White;
            this.letterVBtn.Location = new System.Drawing.Point(405, 561);
            this.letterVBtn.Name = "letterVBtn";
            this.letterVBtn.Size = new System.Drawing.Size(40, 40);
            this.letterVBtn.TabIndex = 27;
            this.letterVBtn.Text = "V";
            this.letterVBtn.UseVisualStyleBackColor = true;
            this.letterVBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterCBtn
            // 
            this.letterCBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterCBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterCBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterCBtn.ForeColor = System.Drawing.Color.White;
            this.letterCBtn.Location = new System.Drawing.Point(359, 561);
            this.letterCBtn.Name = "letterCBtn";
            this.letterCBtn.Size = new System.Drawing.Size(40, 40);
            this.letterCBtn.TabIndex = 26;
            this.letterCBtn.Text = "C";
            this.letterCBtn.UseVisualStyleBackColor = true;
            this.letterCBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterXBtn
            // 
            this.letterXBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterXBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterXBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterXBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterXBtn.ForeColor = System.Drawing.Color.White;
            this.letterXBtn.Location = new System.Drawing.Point(313, 561);
            this.letterXBtn.Name = "letterXBtn";
            this.letterXBtn.Size = new System.Drawing.Size(40, 40);
            this.letterXBtn.TabIndex = 25;
            this.letterXBtn.Text = "X";
            this.letterXBtn.UseVisualStyleBackColor = true;
            this.letterXBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterZBtn
            // 
            this.letterZBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterZBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterZBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterZBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterZBtn.ForeColor = System.Drawing.Color.White;
            this.letterZBtn.Location = new System.Drawing.Point(267, 561);
            this.letterZBtn.Name = "letterZBtn";
            this.letterZBtn.Size = new System.Drawing.Size(40, 40);
            this.letterZBtn.TabIndex = 24;
            this.letterZBtn.Text = "Z";
            this.letterZBtn.UseVisualStyleBackColor = true;
            this.letterZBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterLBtn
            // 
            this.letterLBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterLBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterLBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterLBtn.ForeColor = System.Drawing.Color.White;
            this.letterLBtn.Location = new System.Drawing.Point(589, 515);
            this.letterLBtn.Name = "letterLBtn";
            this.letterLBtn.Size = new System.Drawing.Size(40, 40);
            this.letterLBtn.TabIndex = 23;
            this.letterLBtn.Text = "L";
            this.letterLBtn.UseVisualStyleBackColor = true;
            this.letterLBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterKBtn
            // 
            this.letterKBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterKBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterKBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterKBtn.ForeColor = System.Drawing.Color.White;
            this.letterKBtn.Location = new System.Drawing.Point(543, 515);
            this.letterKBtn.Name = "letterKBtn";
            this.letterKBtn.Size = new System.Drawing.Size(40, 40);
            this.letterKBtn.TabIndex = 22;
            this.letterKBtn.Text = "K";
            this.letterKBtn.UseVisualStyleBackColor = true;
            this.letterKBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterJBtn
            // 
            this.letterJBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterJBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterJBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterJBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterJBtn.ForeColor = System.Drawing.Color.White;
            this.letterJBtn.Location = new System.Drawing.Point(497, 515);
            this.letterJBtn.Name = "letterJBtn";
            this.letterJBtn.Size = new System.Drawing.Size(40, 40);
            this.letterJBtn.TabIndex = 21;
            this.letterJBtn.Text = "J";
            this.letterJBtn.UseVisualStyleBackColor = true;
            this.letterJBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterHBtn
            // 
            this.letterHBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterHBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterHBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterHBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterHBtn.ForeColor = System.Drawing.Color.White;
            this.letterHBtn.Location = new System.Drawing.Point(451, 515);
            this.letterHBtn.Name = "letterHBtn";
            this.letterHBtn.Size = new System.Drawing.Size(40, 40);
            this.letterHBtn.TabIndex = 20;
            this.letterHBtn.Text = "H";
            this.letterHBtn.UseVisualStyleBackColor = true;
            this.letterHBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterGBtn
            // 
            this.letterGBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterGBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterGBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterGBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterGBtn.ForeColor = System.Drawing.Color.White;
            this.letterGBtn.Location = new System.Drawing.Point(405, 515);
            this.letterGBtn.Name = "letterGBtn";
            this.letterGBtn.Size = new System.Drawing.Size(40, 40);
            this.letterGBtn.TabIndex = 19;
            this.letterGBtn.Text = "G";
            this.letterGBtn.UseVisualStyleBackColor = true;
            this.letterGBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterFBtn
            // 
            this.letterFBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterFBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterFBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterFBtn.ForeColor = System.Drawing.Color.White;
            this.letterFBtn.Location = new System.Drawing.Point(359, 515);
            this.letterFBtn.Name = "letterFBtn";
            this.letterFBtn.Size = new System.Drawing.Size(40, 40);
            this.letterFBtn.TabIndex = 18;
            this.letterFBtn.Text = "F";
            this.letterFBtn.UseVisualStyleBackColor = true;
            this.letterFBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterDBtn
            // 
            this.letterDBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterDBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterDBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterDBtn.ForeColor = System.Drawing.Color.White;
            this.letterDBtn.Location = new System.Drawing.Point(313, 515);
            this.letterDBtn.Name = "letterDBtn";
            this.letterDBtn.Size = new System.Drawing.Size(40, 40);
            this.letterDBtn.TabIndex = 17;
            this.letterDBtn.Text = "D";
            this.letterDBtn.UseVisualStyleBackColor = true;
            this.letterDBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterSBtn
            // 
            this.letterSBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterSBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterSBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSBtn.ForeColor = System.Drawing.Color.White;
            this.letterSBtn.Location = new System.Drawing.Point(267, 515);
            this.letterSBtn.Name = "letterSBtn";
            this.letterSBtn.Size = new System.Drawing.Size(40, 40);
            this.letterSBtn.TabIndex = 16;
            this.letterSBtn.Text = "S";
            this.letterSBtn.UseVisualStyleBackColor = true;
            this.letterSBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterABtn
            // 
            this.letterABtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterABtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterABtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterABtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterABtn.ForeColor = System.Drawing.Color.White;
            this.letterABtn.Location = new System.Drawing.Point(221, 515);
            this.letterABtn.Name = "letterABtn";
            this.letterABtn.Size = new System.Drawing.Size(40, 40);
            this.letterABtn.TabIndex = 15;
            this.letterABtn.Text = "A";
            this.letterABtn.UseVisualStyleBackColor = true;
            this.letterABtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterPBtn
            // 
            this.letterPBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterPBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterPBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterPBtn.ForeColor = System.Drawing.Color.White;
            this.letterPBtn.Location = new System.Drawing.Point(610, 469);
            this.letterPBtn.Name = "letterPBtn";
            this.letterPBtn.Size = new System.Drawing.Size(40, 40);
            this.letterPBtn.TabIndex = 14;
            this.letterPBtn.Text = "P";
            this.letterPBtn.UseVisualStyleBackColor = true;
            this.letterPBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterOBtn
            // 
            this.letterOBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterOBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterOBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterOBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterOBtn.ForeColor = System.Drawing.Color.White;
            this.letterOBtn.Location = new System.Drawing.Point(564, 469);
            this.letterOBtn.Name = "letterOBtn";
            this.letterOBtn.Size = new System.Drawing.Size(40, 40);
            this.letterOBtn.TabIndex = 13;
            this.letterOBtn.Text = "O";
            this.letterOBtn.UseVisualStyleBackColor = true;
            this.letterOBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterIBtn
            // 
            this.letterIBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterIBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterIBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterIBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterIBtn.ForeColor = System.Drawing.Color.White;
            this.letterIBtn.Location = new System.Drawing.Point(518, 469);
            this.letterIBtn.Name = "letterIBtn";
            this.letterIBtn.Size = new System.Drawing.Size(40, 40);
            this.letterIBtn.TabIndex = 12;
            this.letterIBtn.Text = "I";
            this.letterIBtn.UseVisualStyleBackColor = true;
            this.letterIBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterUBtn
            // 
            this.letterUBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterUBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterUBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterUBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterUBtn.ForeColor = System.Drawing.Color.White;
            this.letterUBtn.Location = new System.Drawing.Point(472, 469);
            this.letterUBtn.Name = "letterUBtn";
            this.letterUBtn.Size = new System.Drawing.Size(40, 40);
            this.letterUBtn.TabIndex = 11;
            this.letterUBtn.Text = "U";
            this.letterUBtn.UseVisualStyleBackColor = true;
            this.letterUBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterYBtn
            // 
            this.letterYBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterYBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterYBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterYBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterYBtn.ForeColor = System.Drawing.Color.White;
            this.letterYBtn.Location = new System.Drawing.Point(426, 469);
            this.letterYBtn.Name = "letterYBtn";
            this.letterYBtn.Size = new System.Drawing.Size(40, 40);
            this.letterYBtn.TabIndex = 10;
            this.letterYBtn.Text = "Y";
            this.letterYBtn.UseVisualStyleBackColor = true;
            this.letterYBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterTBtn
            // 
            this.letterTBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterTBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterTBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterTBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterTBtn.ForeColor = System.Drawing.Color.White;
            this.letterTBtn.Location = new System.Drawing.Point(380, 469);
            this.letterTBtn.Name = "letterTBtn";
            this.letterTBtn.Size = new System.Drawing.Size(40, 40);
            this.letterTBtn.TabIndex = 9;
            this.letterTBtn.Text = "T";
            this.letterTBtn.UseVisualStyleBackColor = true;
            this.letterTBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterRBtn
            // 
            this.letterRBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterRBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterRBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterRBtn.ForeColor = System.Drawing.Color.White;
            this.letterRBtn.Location = new System.Drawing.Point(334, 469);
            this.letterRBtn.Name = "letterRBtn";
            this.letterRBtn.Size = new System.Drawing.Size(40, 40);
            this.letterRBtn.TabIndex = 8;
            this.letterRBtn.Text = "R";
            this.letterRBtn.UseVisualStyleBackColor = true;
            this.letterRBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterEBtn
            // 
            this.letterEBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterEBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterEBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterEBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterEBtn.ForeColor = System.Drawing.Color.White;
            this.letterEBtn.Location = new System.Drawing.Point(288, 469);
            this.letterEBtn.Name = "letterEBtn";
            this.letterEBtn.Size = new System.Drawing.Size(40, 40);
            this.letterEBtn.TabIndex = 7;
            this.letterEBtn.Text = "E";
            this.letterEBtn.UseVisualStyleBackColor = true;
            this.letterEBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterWBtn
            // 
            this.letterWBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterWBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterWBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterWBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterWBtn.ForeColor = System.Drawing.Color.White;
            this.letterWBtn.Location = new System.Drawing.Point(242, 469);
            this.letterWBtn.Name = "letterWBtn";
            this.letterWBtn.Size = new System.Drawing.Size(40, 40);
            this.letterWBtn.TabIndex = 6;
            this.letterWBtn.Text = "W";
            this.letterWBtn.UseVisualStyleBackColor = true;
            this.letterWBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // letterQBtn
            // 
            this.letterQBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterQBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letterQBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterQBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterQBtn.ForeColor = System.Drawing.Color.White;
            this.letterQBtn.Location = new System.Drawing.Point(196, 469);
            this.letterQBtn.Name = "letterQBtn";
            this.letterQBtn.Size = new System.Drawing.Size(40, 40);
            this.letterQBtn.TabIndex = 5;
            this.letterQBtn.Text = "Q";
            this.letterQBtn.UseVisualStyleBackColor = true;
            this.letterQBtn.Click += new System.EventHandler(this.letterBtn_Click);
            // 
            // play_hangman
            // 
            this.play_hangman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play_hangman.BackgroundImage")));
            this.play_hangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play_hangman.Location = new System.Drawing.Point(345, 245);
            this.play_hangman.Name = "play_hangman";
            this.play_hangman.Size = new System.Drawing.Size(151, 180);
            this.play_hangman.TabIndex = 4;
            this.play_hangman.TabStop = false;
            // 
            // play_word
            // 
            this.play_word.BackColor = System.Drawing.Color.Transparent;
            this.play_word.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_word.ForeColor = System.Drawing.Color.White;
            this.play_word.Location = new System.Drawing.Point(119, 122);
            this.play_word.Name = "play_word";
            this.play_word.Size = new System.Drawing.Size(611, 73);
            this.play_word.TabIndex = 2;
            this.play_word.Text = "r h i n o c e r o s";
            this.play_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(180, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "WORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // play_currentLevel
            // 
            this.play_currentLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.play_currentLevel.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_currentLevel.ForeColor = System.Drawing.Color.White;
            this.play_currentLevel.Location = new System.Drawing.Point(3, 51);
            this.play_currentLevel.Name = "play_currentLevel";
            this.play_currentLevel.Size = new System.Drawing.Size(160, 44);
            this.play_currentLevel.TabIndex = 0;
            this.play_currentLevel.Text = "LEVEL 1/10";
            this.play_currentLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // play_letterDashes
            // 
            this.play_letterDashes.BackColor = System.Drawing.Color.Transparent;
            this.play_letterDashes.Font = new System.Drawing.Font("Montserrat", 47.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_letterDashes.ForeColor = System.Drawing.Color.White;
            this.play_letterDashes.Location = new System.Drawing.Point(119, 124);
            this.play_letterDashes.Name = "play_letterDashes";
            this.play_letterDashes.Size = new System.Drawing.Size(611, 89);
            this.play_letterDashes.TabIndex = 3;
            this.play_letterDashes.Text = "_ _ _ _ _ _ _ _";
            this.play_letterDashes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // play_divider
            // 
            this.play_divider.BackColor = System.Drawing.Color.White;
            this.play_divider.ForeColor = System.Drawing.Color.White;
            this.play_divider.Location = new System.Drawing.Point(814, 94);
            this.play_divider.Name = "play_divider";
            this.play_divider.Size = new System.Drawing.Size(1, 507);
            this.play_divider.TabIndex = 31;
            // 
            // play_themeLabel
            // 
            this.play_themeLabel.BackColor = System.Drawing.Color.Transparent;
            this.play_themeLabel.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_themeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.play_themeLabel.Location = new System.Drawing.Point(821, 72);
            this.play_themeLabel.Name = "play_themeLabel";
            this.play_themeLabel.Size = new System.Drawing.Size(447, 56);
            this.play_themeLabel.TabIndex = 32;
            this.play_themeLabel.Text = "THEME";
            this.play_themeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // play_theme
            // 
            this.play_theme.BackColor = System.Drawing.Color.Transparent;
            this.play_theme.Font = new System.Drawing.Font("Montserrat SemiBold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_theme.ForeColor = System.Drawing.Color.White;
            this.play_theme.Location = new System.Drawing.Point(821, 116);
            this.play_theme.Name = "play_theme";
            this.play_theme.Size = new System.Drawing.Size(447, 56);
            this.play_theme.TabIndex = 33;
            this.play_theme.Text = "ANIMALS";
            this.play_theme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // play_score
            // 
            this.play_score.BackColor = System.Drawing.Color.Transparent;
            this.play_score.Font = new System.Drawing.Font("Montserrat SemiBold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_score.ForeColor = System.Drawing.Color.White;
            this.play_score.Location = new System.Drawing.Point(821, 448);
            this.play_score.Name = "play_score";
            this.play_score.Size = new System.Drawing.Size(447, 56);
            this.play_score.TabIndex = 35;
            this.play_score.Text = "1000";
            this.play_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // play_scoreLabel
            // 
            this.play_scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.play_scoreLabel.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.play_scoreLabel.Location = new System.Drawing.Point(821, 404);
            this.play_scoreLabel.Name = "play_scoreLabel";
            this.play_scoreLabel.Size = new System.Drawing.Size(447, 56);
            this.play_scoreLabel.TabIndex = 34;
            this.play_scoreLabel.Text = "SCORE";
            this.play_scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // play_quitBtn
            // 
            this.play_quitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_quitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.play_quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_quitBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_quitBtn.ForeColor = System.Drawing.Color.White;
            this.play_quitBtn.Location = new System.Drawing.Point(933, 545);
            this.play_quitBtn.Name = "play_quitBtn";
            this.play_quitBtn.Size = new System.Drawing.Size(232, 56);
            this.play_quitBtn.TabIndex = 36;
            this.play_quitBtn.Text = "QUIT GAME";
            this.play_quitBtn.UseVisualStyleBackColor = true;
            this.play_quitBtn.Click += new System.EventHandler(this.play_quitBtn_Click);
            // 
            // play_changeThemeBtn
            // 
            this.play_changeThemeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_changeThemeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.play_changeThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_changeThemeBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_changeThemeBtn.ForeColor = System.Drawing.Color.White;
            this.play_changeThemeBtn.Location = new System.Drawing.Point(933, 193);
            this.play_changeThemeBtn.Name = "play_changeThemeBtn";
            this.play_changeThemeBtn.Size = new System.Drawing.Size(232, 56);
            this.play_changeThemeBtn.TabIndex = 37;
            this.play_changeThemeBtn.Text = "CHANGE THEME";
            this.play_changeThemeBtn.UseVisualStyleBackColor = true;
            this.play_changeThemeBtn.Click += new System.EventHandler(this.play_changeThemeBtn_Click);
            // 
            // play_changeWordBtn
            // 
            this.play_changeWordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_changeWordBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.play_changeWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_changeWordBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_changeWordBtn.ForeColor = System.Drawing.Color.White;
            this.play_changeWordBtn.Location = new System.Drawing.Point(933, 255);
            this.play_changeWordBtn.Name = "play_changeWordBtn";
            this.play_changeWordBtn.Size = new System.Drawing.Size(232, 56);
            this.play_changeWordBtn.TabIndex = 38;
            this.play_changeWordBtn.Text = "CHANGE WORD";
            this.play_changeWordBtn.UseVisualStyleBackColor = true;
            this.play_changeWordBtn.Click += new System.EventHandler(this.play_changeWordBtn_Click);
            // 
            // play_useBoosterBtn
            // 
            this.play_useBoosterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_useBoosterBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.play_useBoosterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_useBoosterBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_useBoosterBtn.ForeColor = System.Drawing.Color.White;
            this.play_useBoosterBtn.Location = new System.Drawing.Point(933, 317);
            this.play_useBoosterBtn.Name = "play_useBoosterBtn";
            this.play_useBoosterBtn.Size = new System.Drawing.Size(232, 56);
            this.play_useBoosterBtn.TabIndex = 39;
            this.play_useBoosterBtn.Text = "USE BOOSTER";
            this.play_useBoosterBtn.UseVisualStyleBackColor = true;
            this.play_useBoosterBtn.Click += new System.EventHandler(this.play_useBoosterBtn_Click);
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
            this.play.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.play_hangman)).EndInit();
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
        private System.Windows.Forms.Button letterMBtn;
        private System.Windows.Forms.Button letterNBtn;
        private System.Windows.Forms.Button letterBBtn;
        private System.Windows.Forms.Button letterVBtn;
        private System.Windows.Forms.Button letterCBtn;
        private System.Windows.Forms.Button letterXBtn;
        private System.Windows.Forms.Button letterZBtn;
        private System.Windows.Forms.Button letterLBtn;
        private System.Windows.Forms.Button letterKBtn;
        private System.Windows.Forms.Button letterJBtn;
        private System.Windows.Forms.Button letterHBtn;
        private System.Windows.Forms.Button letterGBtn;
        private System.Windows.Forms.Button letterFBtn;
        private System.Windows.Forms.Button letterDBtn;
        private System.Windows.Forms.Button letterSBtn;
        private System.Windows.Forms.Button letterABtn;
        private System.Windows.Forms.Button letterPBtn;
        private System.Windows.Forms.Button letterOBtn;
        private System.Windows.Forms.Button letterIBtn;
        private System.Windows.Forms.Button letterUBtn;
        private System.Windows.Forms.Button letterYBtn;
        private System.Windows.Forms.Button letterTBtn;
        private System.Windows.Forms.Button letterRBtn;
        private System.Windows.Forms.Button letterEBtn;
        private System.Windows.Forms.Button letterWBtn;
        private System.Windows.Forms.Button letterQBtn;
        private System.Windows.Forms.PictureBox play_hangman;
        private System.Windows.Forms.Label play_word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label play_currentLevel;
        private System.Windows.Forms.Label play_letterDashes;
        private System.Windows.Forms.Label play_score;
        private System.Windows.Forms.Label play_scoreLabel;
        private System.Windows.Forms.Label play_theme;
        private System.Windows.Forms.Label play_themeLabel;
        private System.Windows.Forms.Label play_divider;
        private System.Windows.Forms.Button play_useBoosterBtn;
        private System.Windows.Forms.Button play_changeWordBtn;
        private System.Windows.Forms.Button play_changeThemeBtn;
        private System.Windows.Forms.Button play_quitBtn;
    }
}

