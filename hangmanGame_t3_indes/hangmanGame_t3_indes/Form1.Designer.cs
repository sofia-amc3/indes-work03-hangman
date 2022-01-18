
namespace hangmanGame_t3_indes
{
    partial class hangman
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            this.playArea = new System.Windows.Forms.TabPage();
            this.highScores = new System.Windows.Forms.TabPage();
            this.enterName_title = new System.Windows.Forms.Label();
            this.enterName_gameLogo = new System.Windows.Forms.PictureBox();
            this.enterName_backBtn = new System.Windows.Forms.Button();
            this.enterName_playBtn = new System.Windows.Forms.Button();
            this.enterName_nameLabel = new System.Windows.Forms.Label();
            this.enterName_input = new System.Windows.Forms.TextBox();
            this.enterName_levelsLabel = new System.Windows.Forms.Label();
            this.enterName_radioBtn1 = new System.Windows.Forms.RadioButton();
            this.enterName_radioBtn2 = new System.Windows.Forms.RadioButton();
            this.enterName_radioBtn3 = new System.Windows.Forms.RadioButton();
            this.menu.SuspendLayout();
            this.welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_gameLogo)).BeginInit();
            this.credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credits_gameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_img)).BeginInit();
            this.rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rules_gameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rules_img)).BeginInit();
            this.enterName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterName_gameLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.welcome);
            this.menu.Controls.Add(this.credits);
            this.menu.Controls.Add(this.rules);
            this.menu.Controls.Add(this.enterName);
            this.menu.Controls.Add(this.playArea);
            this.menu.Controls.Add(this.highScores);
            this.menu.Location = new System.Drawing.Point(-11, -35);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(1288, 730);
            this.menu.TabIndex = 1;
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
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(4, 25);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(1280, 701);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "welcome";
            // 
            // welcome_creditsBtn
            // 
            this.welcome_creditsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome_creditsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.welcome_creditsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_creditsBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome_creditsBtn.Location = new System.Drawing.Point(372, 441);
            this.welcome_creditsBtn.Name = "welcome_creditsBtn";
            this.welcome_creditsBtn.Size = new System.Drawing.Size(156, 56);
            this.welcome_creditsBtn.TabIndex = 7;
            this.welcome_creditsBtn.Text = "CREDITS";
            this.welcome_creditsBtn.UseVisualStyleBackColor = true;
            this.welcome_creditsBtn.Click += new System.EventHandler(this.welcome_creditsBtn_Click);
            // 
            // welcome_rulesBtn
            // 
            this.welcome_rulesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome_rulesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.welcome_rulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_rulesBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome_rulesBtn.Location = new System.Drawing.Point(549, 441);
            this.welcome_rulesBtn.Name = "welcome_rulesBtn";
            this.welcome_rulesBtn.Size = new System.Drawing.Size(156, 56);
            this.welcome_rulesBtn.TabIndex = 6;
            this.welcome_rulesBtn.Text = "RULES";
            this.welcome_rulesBtn.UseVisualStyleBackColor = true;
            this.welcome_rulesBtn.Click += new System.EventHandler(this.welcome_rulesBtn_Click);
            // 
            // welcome_playBtn
            // 
            this.welcome_playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome_playBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.welcome_playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_playBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome_playBtn.Location = new System.Drawing.Point(725, 441);
            this.welcome_playBtn.Name = "welcome_playBtn";
            this.welcome_playBtn.Size = new System.Drawing.Size(156, 56);
            this.welcome_playBtn.TabIndex = 5;
            this.welcome_playBtn.Text = "PLAY";
            this.welcome_playBtn.UseVisualStyleBackColor = true;
            this.welcome_playBtn.Click += new System.EventHandler(this.welcome_playBtn_Click);
            // 
            // welcome_question
            // 
            this.welcome_question.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome_question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.welcome_question.Location = new System.Drawing.Point(549, 313);
            this.welcome_question.Name = "welcome_question";
            this.welcome_question.Size = new System.Drawing.Size(283, 55);
            this.welcome_question.TabIndex = 4;
            this.welcome_question.Text = "Can you guess the word before you get hung?";
            // 
            // welcome_gameSubtitle
            // 
            this.welcome_gameSubtitle.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome_gameSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.welcome_gameSubtitle.Location = new System.Drawing.Point(549, 265);
            this.welcome_gameSubtitle.Name = "welcome_gameSubtitle";
            this.welcome_gameSubtitle.Size = new System.Drawing.Size(283, 28);
            this.welcome_gameSubtitle.TabIndex = 3;
            this.welcome_gameSubtitle.Text = "DEMO VERSION";
            // 
            // welcome_gameTitle
            // 
            this.welcome_gameTitle.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome_gameTitle.Location = new System.Drawing.Point(540, 184);
            this.welcome_gameTitle.Name = "welcome_gameTitle";
            this.welcome_gameTitle.Size = new System.Drawing.Size(310, 58);
            this.welcome_gameTitle.TabIndex = 2;
            this.welcome_gameTitle.Text = "HANGMAN";
            // 
            // welcome_gameLogo
            // 
            this.welcome_gameLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcome_gameLogo.BackgroundImage")));
            this.welcome_gameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.welcome_gameLogo.Location = new System.Drawing.Point(440, 200);
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
            this.credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credits.ForeColor = System.Drawing.Color.White;
            this.credits.Location = new System.Drawing.Point(4, 25);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(1280, 701);
            this.credits.TabIndex = 3;
            this.credits.Text = "credits";
            // 
            // credits_title
            // 
            this.credits_title.AutoSize = true;
            this.credits_title.Font = new System.Drawing.Font("Montserrat", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.credits_title.Location = new System.Drawing.Point(134, 37);
            this.credits_title.Name = "credits_title";
            this.credits_title.Size = new System.Drawing.Size(185, 50);
            this.credits_title.TabIndex = 7;
            this.credits_title.Text = "CREDITS";
            // 
            // credits_gameLogo
            // 
            this.credits_gameLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credits_gameLogo.BackgroundImage")));
            this.credits_gameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.credits_gameLogo.Location = new System.Drawing.Point(55, 1);
            this.credits_gameLogo.Name = "credits_gameLogo";
            this.credits_gameLogo.Size = new System.Drawing.Size(64, 106);
            this.credits_gameLogo.TabIndex = 6;
            this.credits_gameLogo.TabStop = false;
            // 
            // credits_backBtn
            // 
            this.credits_backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credits_backBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.credits_backBtn.Location = new System.Drawing.Point(565, 602);
            this.credits_backBtn.Name = "credits_backBtn";
            this.credits_backBtn.Size = new System.Drawing.Size(156, 56);
            this.credits_backBtn.TabIndex = 5;
            this.credits_backBtn.Text = "BACK";
            this.credits_backBtn.UseVisualStyleBackColor = true;
            // 
            // credits_img
            // 
            this.credits_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credits_img.BackgroundImage")));
            this.credits_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.credits_img.Location = new System.Drawing.Point(3, 7);
            this.credits_img.Name = "credits_img";
            this.credits_img.Size = new System.Drawing.Size(1273, 627);
            this.credits_img.TabIndex = 4;
            this.credits_img.TabStop = false;
            // 
            // rules
            // 
            this.rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.rules.Controls.Add(this.rules_title);
            this.rules.Controls.Add(this.rules_gameLogo);
            this.rules.Controls.Add(this.rules_backBtn);
            this.rules.Controls.Add(this.rules_img);
            this.rules.ForeColor = System.Drawing.Color.White;
            this.rules.Location = new System.Drawing.Point(4, 25);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(1280, 701);
            this.rules.TabIndex = 2;
            this.rules.Text = "rules";
            // 
            // rules_title
            // 
            this.rules_title.AutoSize = true;
            this.rules_title.Font = new System.Drawing.Font("Montserrat", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rules_title.Location = new System.Drawing.Point(137, 39);
            this.rules_title.Name = "rules_title";
            this.rules_title.Size = new System.Drawing.Size(145, 50);
            this.rules_title.TabIndex = 3;
            this.rules_title.Text = "RULES";
            // 
            // rules_gameLogo
            // 
            this.rules_gameLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rules_gameLogo.BackgroundImage")));
            this.rules_gameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rules_gameLogo.Location = new System.Drawing.Point(58, 3);
            this.rules_gameLogo.Name = "rules_gameLogo";
            this.rules_gameLogo.Size = new System.Drawing.Size(64, 106);
            this.rules_gameLogo.TabIndex = 2;
            this.rules_gameLogo.TabStop = false;
            // 
            // rules_backBtn
            // 
            this.rules_backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rules_backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rules_backBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rules_backBtn.Location = new System.Drawing.Point(568, 604);
            this.rules_backBtn.Name = "rules_backBtn";
            this.rules_backBtn.Size = new System.Drawing.Size(156, 56);
            this.rules_backBtn.TabIndex = 1;
            this.rules_backBtn.Text = "BACK";
            this.rules_backBtn.UseVisualStyleBackColor = true;
            this.rules_backBtn.Click += new System.EventHandler(this.rules_backBtn_Click);
            // 
            // rules_img
            // 
            this.rules_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rules_img.BackgroundImage")));
            this.rules_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rules_img.Location = new System.Drawing.Point(6, 9);
            this.rules_img.Name = "rules_img";
            this.rules_img.Size = new System.Drawing.Size(1273, 627);
            this.rules_img.TabIndex = 0;
            this.rules_img.TabStop = false;
            // 
            // enterName
            // 
            this.enterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.enterName.Controls.Add(this.enterName_radioBtn3);
            this.enterName.Controls.Add(this.enterName_radioBtn2);
            this.enterName.Controls.Add(this.enterName_radioBtn1);
            this.enterName.Controls.Add(this.enterName_levelsLabel);
            this.enterName.Controls.Add(this.enterName_input);
            this.enterName.Controls.Add(this.enterName_nameLabel);
            this.enterName.Controls.Add(this.enterName_playBtn);
            this.enterName.Controls.Add(this.enterName_title);
            this.enterName.Controls.Add(this.enterName_gameLogo);
            this.enterName.Controls.Add(this.enterName_backBtn);
            this.enterName.ForeColor = System.Drawing.Color.White;
            this.enterName.Location = new System.Drawing.Point(4, 25);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(1280, 701);
            this.enterName.TabIndex = 1;
            this.enterName.Text = "enterName";
            // 
            // playArea
            // 
            this.playArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.playArea.ForeColor = System.Drawing.Color.White;
            this.playArea.Location = new System.Drawing.Point(4, 25);
            this.playArea.Name = "playArea";
            this.playArea.Size = new System.Drawing.Size(1280, 701);
            this.playArea.TabIndex = 4;
            this.playArea.Text = "playArea";
            // 
            // highScores
            // 
            this.highScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.highScores.ForeColor = System.Drawing.Color.White;
            this.highScores.Location = new System.Drawing.Point(4, 25);
            this.highScores.Name = "highScores";
            this.highScores.Size = new System.Drawing.Size(1280, 701);
            this.highScores.TabIndex = 5;
            this.highScores.Text = "highScores";
            // 
            // enterName_title
            // 
            this.enterName_title.AutoSize = true;
            this.enterName_title.Font = new System.Drawing.Font("Montserrat", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterName_title.Location = new System.Drawing.Point(135, 37);
            this.enterName_title.Name = "enterName_title";
            this.enterName_title.Size = new System.Drawing.Size(120, 50);
            this.enterName_title.TabIndex = 10;
            this.enterName_title.Text = "PLAY";
            // 
            // enterName_gameLogo
            // 
            this.enterName_gameLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enterName_gameLogo.BackgroundImage")));
            this.enterName_gameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enterName_gameLogo.Location = new System.Drawing.Point(56, 1);
            this.enterName_gameLogo.Name = "enterName_gameLogo";
            this.enterName_gameLogo.Size = new System.Drawing.Size(64, 106);
            this.enterName_gameLogo.TabIndex = 9;
            this.enterName_gameLogo.TabStop = false;
            // 
            // enterName_backBtn
            // 
            this.enterName_backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterName_backBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterName_backBtn.Location = new System.Drawing.Point(469, 603);
            this.enterName_backBtn.Name = "enterName_backBtn";
            this.enterName_backBtn.Size = new System.Drawing.Size(156, 56);
            this.enterName_backBtn.TabIndex = 8;
            this.enterName_backBtn.Text = "BACK";
            this.enterName_backBtn.UseVisualStyleBackColor = true;
            this.enterName_backBtn.Click += new System.EventHandler(this.enterName_backBtn_Click);
            // 
            // enterName_playBtn
            // 
            this.enterName_playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterName_playBtn.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterName_playBtn.Location = new System.Drawing.Point(643, 603);
            this.enterName_playBtn.Name = "enterName_playBtn";
            this.enterName_playBtn.Size = new System.Drawing.Size(156, 56);
            this.enterName_playBtn.TabIndex = 11;
            this.enterName_playBtn.Text = "PLAY";
            this.enterName_playBtn.UseVisualStyleBackColor = true;
            this.enterName_playBtn.Click += new System.EventHandler(this.enterName_playBtn_Click);
            // 
            // enterName_nameLabel
            // 
            this.enterName_nameLabel.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterName_nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.enterName_nameLabel.Location = new System.Drawing.Point(469, 222);
            this.enterName_nameLabel.Name = "enterName_nameLabel";
            this.enterName_nameLabel.Size = new System.Drawing.Size(330, 33);
            this.enterName_nameLabel.TabIndex = 12;
            this.enterName_nameLabel.Text = "Please enter your player name:";
            this.enterName_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterName_input
            // 
            this.enterName_input.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterName_input.Location = new System.Drawing.Point(469, 278);
            this.enterName_input.MinimumSize = new System.Drawing.Size(0, 40);
            this.enterName_input.Name = "enterName_input";
            this.enterName_input.Size = new System.Drawing.Size(330, 40);
            this.enterName_input.TabIndex = 13;
            this.enterName_input.TextChanged += new System.EventHandler(this.enterName_input_TextChanged);
            // 
            // enterName_levelsLabel
            // 
            this.enterName_levelsLabel.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterName_levelsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.enterName_levelsLabel.Location = new System.Drawing.Point(469, 372);
            this.enterName_levelsLabel.Name = "enterName_levelsLabel";
            this.enterName_levelsLabel.Size = new System.Drawing.Size(336, 33);
            this.enterName_levelsLabel.TabIndex = 14;
            this.enterName_levelsLabel.Text = "Number of Levels:";
            this.enterName_levelsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterName_radioBtn1
            // 
            this.enterName_radioBtn1.AutoSize = true;
            this.enterName_radioBtn1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterName_radioBtn1.Location = new System.Drawing.Point(545, 431);
            this.enterName_radioBtn1.Name = "enterName_radioBtn1";
            this.enterName_radioBtn1.Size = new System.Drawing.Size(41, 31);
            this.enterName_radioBtn1.TabIndex = 15;
            this.enterName_radioBtn1.TabStop = true;
            this.enterName_radioBtn1.Text = "5";
            this.enterName_radioBtn1.UseVisualStyleBackColor = true;
            this.enterName_radioBtn1.CheckedChanged += new System.EventHandler(this.enterName_radioBtn1_CheckedChanged);
            // 
            // enterName_radioBtn2
            // 
            this.enterName_radioBtn2.AutoSize = true;
            this.enterName_radioBtn2.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterName_radioBtn2.Location = new System.Drawing.Point(616, 431);
            this.enterName_radioBtn2.Name = "enterName_radioBtn2";
            this.enterName_radioBtn2.Size = new System.Drawing.Size(50, 31);
            this.enterName_radioBtn2.TabIndex = 16;
            this.enterName_radioBtn2.TabStop = true;
            this.enterName_radioBtn2.Text = "10";
            this.enterName_radioBtn2.UseVisualStyleBackColor = true;
            this.enterName_radioBtn2.CheckedChanged += new System.EventHandler(this.enterName_radioBtn2_CheckedChanged);
            // 
            // enterName_radioBtn3
            // 
            this.enterName_radioBtn3.AutoSize = true;
            this.enterName_radioBtn3.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterName_radioBtn3.Location = new System.Drawing.Point(690, 431);
            this.enterName_radioBtn3.Name = "enterName_radioBtn3";
            this.enterName_radioBtn3.Size = new System.Drawing.Size(48, 31);
            this.enterName_radioBtn3.TabIndex = 17;
            this.enterName_radioBtn3.TabStop = true;
            this.enterName_radioBtn3.Text = "15";
            this.enterName_radioBtn3.UseVisualStyleBackColor = true;
            this.enterName_radioBtn3.CheckedChanged += new System.EventHandler(this.enterName_radioBtn3_CheckedChanged);
            // 
            // hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "hangman";
            this.Text = "Hangman";
            this.menu.ResumeLayout(false);
            this.welcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.welcome_gameLogo)).EndInit();
            this.credits.ResumeLayout(false);
            this.credits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credits_gameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_img)).EndInit();
            this.rules.ResumeLayout(false);
            this.rules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rules_gameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rules_img)).EndInit();
            this.enterName.ResumeLayout(false);
            this.enterName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterName_gameLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage welcome;
        private System.Windows.Forms.Label welcome_gameTitle;
        private System.Windows.Forms.PictureBox welcome_gameLogo;
        private System.Windows.Forms.TabPage rules;
        private System.Windows.Forms.TabPage credits;
        private System.Windows.Forms.TabPage enterName;
        private System.Windows.Forms.TabPage playArea;
        private System.Windows.Forms.TabPage highScores;
        private System.Windows.Forms.Button welcome_creditsBtn;
        private System.Windows.Forms.Button welcome_rulesBtn;
        private System.Windows.Forms.Button welcome_playBtn;
        private System.Windows.Forms.Label welcome_question;
        private System.Windows.Forms.Label welcome_gameSubtitle;
        private System.Windows.Forms.Label rules_title;
        private System.Windows.Forms.PictureBox rules_gameLogo;
        private System.Windows.Forms.Button rules_backBtn;
        private System.Windows.Forms.PictureBox rules_img;
        private System.Windows.Forms.Label credits_title;
        private System.Windows.Forms.PictureBox credits_gameLogo;
        private System.Windows.Forms.Button credits_backBtn;
        private System.Windows.Forms.PictureBox credits_img;
        private System.Windows.Forms.Button enterName_playBtn;
        private System.Windows.Forms.Label enterName_title;
        private System.Windows.Forms.PictureBox enterName_gameLogo;
        private System.Windows.Forms.Button enterName_backBtn;
        private System.Windows.Forms.TextBox enterName_input;
        private System.Windows.Forms.Label enterName_nameLabel;
        private System.Windows.Forms.RadioButton enterName_radioBtn3;
        private System.Windows.Forms.RadioButton enterName_radioBtn2;
        private System.Windows.Forms.RadioButton enterName_radioBtn1;
        private System.Windows.Forms.Label enterName_levelsLabel;
    }
}

