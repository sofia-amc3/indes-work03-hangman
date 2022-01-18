
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
            this.enterName = new System.Windows.Forms.TabPage();
            this.rules = new System.Windows.Forms.TabPage();
            this.credits = new System.Windows.Forms.TabPage();
            this.playArea = new System.Windows.Forms.TabPage();
            this.highScores = new System.Windows.Forms.TabPage();
            this.welcome_gameLogo = new System.Windows.Forms.PictureBox();
            this.welcome_gameTitle = new System.Windows.Forms.Label();
            this.welcome_gameSubtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome_playBtn = new System.Windows.Forms.Button();
            this.welcome_rulesBtn = new System.Windows.Forms.Button();
            this.welcome_creditsBtn = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_gameLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.welcome);
            this.menu.Controls.Add(this.rules);
            this.menu.Controls.Add(this.credits);
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
            this.welcome.Controls.Add(this.label1);
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
            // enterName
            // 
            this.enterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.enterName.ForeColor = System.Drawing.Color.White;
            this.enterName.Location = new System.Drawing.Point(4, 25);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(1280, 701);
            this.enterName.TabIndex = 1;
            this.enterName.Text = "enterName";
            // 
            // rules
            // 
            this.rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.rules.ForeColor = System.Drawing.Color.White;
            this.rules.Location = new System.Drawing.Point(4, 25);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(1280, 701);
            this.rules.TabIndex = 2;
            this.rules.Text = "rules";
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.credits.ForeColor = System.Drawing.Color.White;
            this.credits.Location = new System.Drawing.Point(4, 25);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(1280, 701);
            this.credits.TabIndex = 3;
            this.credits.Text = "credits";
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
            // welcome_gameTitle
            // 
            this.welcome_gameTitle.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome_gameTitle.Location = new System.Drawing.Point(540, 184);
            this.welcome_gameTitle.Name = "welcome_gameTitle";
            this.welcome_gameTitle.Size = new System.Drawing.Size(310, 58);
            this.welcome_gameTitle.TabIndex = 2;
            this.welcome_gameTitle.Text = "HANGMAN";
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(549, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Can you guess the word before you get hung?";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcome_gameSubtitle;
    }
}

