namespace FlappyBirdGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.WMPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.gameScore = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.FreeHitUpgradePic = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.endGameGameOver = new System.Windows.Forms.Label();
            this.endGameScore = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSubmitScore = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLeaderBoard = new System.Windows.Forms.Label();
            this.btnGoToMenu = new System.Windows.Forms.Button();
            this.btnMenuPlay = new System.Windows.Forms.Button();
            this.btnMenuSettings = new System.Windows.Forms.Button();
            this.btnMenuExit = new System.Windows.Forms.Button();
            this.trackBarIncreaseInitialSpeed = new System.Windows.Forms.TrackBar();
            this.labelIncreaseInitialSpeed = new System.Windows.Forms.Label();
            this.checkBoxDisableUpgrades = new System.Windows.Forms.CheckBox();
            this.comboBoxChosenSkin = new System.Windows.Forms.ComboBox();
            this.lblChooseSkin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeHitUpgradePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIncreaseInitialSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // WMPlayer1
            // 
            this.WMPlayer1.Enabled = true;
            this.WMPlayer1.Location = new System.Drawing.Point(745, 529);
            this.WMPlayer1.Name = "WMPlayer1";
            this.WMPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer1.OcxState")));
            this.WMPlayer1.Size = new System.Drawing.Size(34, 33);
            this.WMPlayer1.TabIndex = 4;
            this.WMPlayer1.Visible = false;
            // 
            // gameScore
            // 
            this.gameScore.AutoSize = true;
            this.gameScore.Location = new System.Drawing.Point(616, 19);
            this.gameScore.Name = "gameScore";
            this.gameScore.Size = new System.Drawing.Size(13, 13);
            this.gameScore.TabIndex = 6;
            this.gameScore.Text = "0";
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Location = new System.Drawing.Point(616, 106);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(45, 13);
            this.lblControls.TabIndex = 7;
            this.lblControls.Text = "Controls";
            // 
            // FreeHitUpgradePic
            // 
            this.FreeHitUpgradePic.Image = global::FlappyBirdGame.Properties.Resources.freeHitUpgrade;
            this.FreeHitUpgradePic.Location = new System.Drawing.Point(989, 523);
            this.FreeHitUpgradePic.Name = "FreeHitUpgradePic";
            this.FreeHitUpgradePic.Size = new System.Drawing.Size(79, 61);
            this.FreeHitUpgradePic.TabIndex = 5;
            this.FreeHitUpgradePic.TabStop = false;
            this.FreeHitUpgradePic.Visible = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirdGame.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(596, 480);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(685, 82);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(1136, 320);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(125, 168);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(943, 9);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(125, 168);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::FlappyBirdGame.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(607, 209);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(75, 58);
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // endGameGameOver
            // 
            this.endGameGameOver.AutoSize = true;
            this.endGameGameOver.Location = new System.Drawing.Point(871, 233);
            this.endGameGameOver.Name = "endGameGameOver";
            this.endGameGameOver.Size = new System.Drawing.Size(64, 13);
            this.endGameGameOver.TabIndex = 8;
            this.endGameGameOver.Text = "Game Over!";
            this.endGameGameOver.Visible = false;
            // 
            // endGameScore
            // 
            this.endGameScore.AutoSize = true;
            this.endGameScore.Location = new System.Drawing.Point(871, 253);
            this.endGameScore.Name = "endGameScore";
            this.endGameScore.Size = new System.Drawing.Size(38, 13);
            this.endGameScore.TabIndex = 9;
            this.endGameScore.Text = "Score:";
            this.endGameScore.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Image = global::FlappyBirdGame.Properties.Resources.nigal;
            this.btnRestart.Location = new System.Drawing.Point(874, 353);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(143, 59);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSubmitScore
            // 
            this.btnSubmitScore.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnSubmitScore.Enabled = false;
            this.btnSubmitScore.Location = new System.Drawing.Point(874, 292);
            this.btnSubmitScore.Name = "btnSubmitScore";
            this.btnSubmitScore.Size = new System.Drawing.Size(143, 55);
            this.btnSubmitScore.TabIndex = 11;
            this.btnSubmitScore.Text = "Submit Score";
            this.btnSubmitScore.UseVisualStyleBackColor = false;
            this.btnSubmitScore.Visible = false;
            this.btnSubmitScore.Click += new System.EventHandler(this.btnSubmitScore_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Enabled = false;
            this.txtBoxName.Location = new System.Drawing.Point(907, 270);
            this.txtBoxName.MaxLength = 10;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(107, 20);
            this.txtBoxName.TabIndex = 12;
            this.txtBoxName.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(871, 272);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name:";
            this.lblName.Visible = false;
            // 
            // lblLeaderBoard
            // 
            this.lblLeaderBoard.AutoSize = true;
            this.lblLeaderBoard.Location = new System.Drawing.Point(874, 42);
            this.lblLeaderBoard.Name = "lblLeaderBoard";
            this.lblLeaderBoard.Size = new System.Drawing.Size(118, 13);
            this.lblLeaderBoard.TabIndex = 14;
            this.lblLeaderBoard.Text = "High Scores: Loading...";
            this.lblLeaderBoard.Visible = false;
            // 
            // btnGoToMenu
            // 
            this.btnGoToMenu.BackColor = System.Drawing.Color.Red;
            this.btnGoToMenu.Enabled = false;
            this.btnGoToMenu.Location = new System.Drawing.Point(874, 419);
            this.btnGoToMenu.Name = "btnGoToMenu";
            this.btnGoToMenu.Size = new System.Drawing.Size(143, 55);
            this.btnGoToMenu.TabIndex = 15;
            this.btnGoToMenu.Text = "Main Menu";
            this.btnGoToMenu.UseVisualStyleBackColor = false;
            this.btnGoToMenu.Visible = false;
            this.btnGoToMenu.Click += new System.EventHandler(this.btnGoToMenu_Click);
            // 
            // btnMenuPlay
            // 
            this.btnMenuPlay.BackColor = System.Drawing.Color.DimGray;
            this.btnMenuPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPlay.Location = new System.Drawing.Point(584, 161);
            this.btnMenuPlay.Name = "btnMenuPlay";
            this.btnMenuPlay.Size = new System.Drawing.Size(107, 42);
            this.btnMenuPlay.TabIndex = 16;
            this.btnMenuPlay.Text = "Play";
            this.btnMenuPlay.UseVisualStyleBackColor = false;
            this.btnMenuPlay.Click += new System.EventHandler(this.btnMenuPlay_Click);
            // 
            // btnMenuSettings
            // 
            this.btnMenuSettings.BackColor = System.Drawing.Color.DimGray;
            this.btnMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSettings.Location = new System.Drawing.Point(584, 253);
            this.btnMenuSettings.Name = "btnMenuSettings";
            this.btnMenuSettings.Size = new System.Drawing.Size(107, 42);
            this.btnMenuSettings.TabIndex = 17;
            this.btnMenuSettings.Text = "Settings";
            this.btnMenuSettings.UseVisualStyleBackColor = false;
            this.btnMenuSettings.Click += new System.EventHandler(this.btnMenuSettings_Click);
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.BackColor = System.Drawing.Color.DimGray;
            this.btnMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuExit.Location = new System.Drawing.Point(584, 349);
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(107, 42);
            this.btnMenuExit.TabIndex = 18;
            this.btnMenuExit.Text = "Exit";
            this.btnMenuExit.UseVisualStyleBackColor = false;
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // trackBarIncreaseInitialSpeed
            // 
            this.trackBarIncreaseInitialSpeed.BackColor = System.Drawing.Color.Black;
            this.trackBarIncreaseInitialSpeed.LargeChange = 1;
            this.trackBarIncreaseInitialSpeed.Location = new System.Drawing.Point(261, 74);
            this.trackBarIncreaseInitialSpeed.Name = "trackBarIncreaseInitialSpeed";
            this.trackBarIncreaseInitialSpeed.Size = new System.Drawing.Size(104, 45);
            this.trackBarIncreaseInitialSpeed.TabIndex = 19;
            this.trackBarIncreaseInitialSpeed.TickFrequency = 2;
            this.trackBarIncreaseInitialSpeed.Visible = false;
            // 
            // labelIncreaseInitialSpeed
            // 
            this.labelIncreaseInitialSpeed.AutoSize = true;
            this.labelIncreaseInitialSpeed.BackColor = System.Drawing.Color.Black;
            this.labelIncreaseInitialSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIncreaseInitialSpeed.Location = new System.Drawing.Point(261, 55);
            this.labelIncreaseInitialSpeed.Name = "labelIncreaseInitialSpeed";
            this.labelIncreaseInitialSpeed.Size = new System.Drawing.Size(306, 13);
            this.labelIncreaseInitialSpeed.TabIndex = 20;
            this.labelIncreaseInitialSpeed.Text = "Increase Initial Speed (Many Bugs 50% chance to freeze game)";
            this.labelIncreaseInitialSpeed.Visible = false;
            // 
            // checkBoxDisableUpgrades
            // 
            this.checkBoxDisableUpgrades.AutoSize = true;
            this.checkBoxDisableUpgrades.BackColor = System.Drawing.Color.Black;
            this.checkBoxDisableUpgrades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxDisableUpgrades.Location = new System.Drawing.Point(264, 125);
            this.checkBoxDisableUpgrades.Name = "checkBoxDisableUpgrades";
            this.checkBoxDisableUpgrades.Size = new System.Drawing.Size(108, 17);
            this.checkBoxDisableUpgrades.TabIndex = 21;
            this.checkBoxDisableUpgrades.Text = "Disable upgrades";
            this.checkBoxDisableUpgrades.UseVisualStyleBackColor = false;
            this.checkBoxDisableUpgrades.Visible = false;
            // 
            // comboBoxChosenSkin
            // 
            this.comboBoxChosenSkin.FormattingEnabled = true;
            this.comboBoxChosenSkin.Items.AddRange(new object[] {
            "Original",
            "Hentai"});
            this.comboBoxChosenSkin.Location = new System.Drawing.Point(264, 209);
            this.comboBoxChosenSkin.Name = "comboBoxChosenSkin";
            this.comboBoxChosenSkin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChosenSkin.TabIndex = 23;
            this.comboBoxChosenSkin.Text = "Original";
            this.comboBoxChosenSkin.Visible = false;
            // 
            // lblChooseSkin
            // 
            this.lblChooseSkin.AutoSize = true;
            this.lblChooseSkin.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseSkin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChooseSkin.Location = new System.Drawing.Point(264, 170);
            this.lblChooseSkin.Name = "lblChooseSkin";
            this.lblChooseSkin.Size = new System.Drawing.Size(36, 13);
            this.lblChooseSkin.TabIndex = 24;
            this.lblChooseSkin.Text = "Skins:";
            this.lblChooseSkin.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::FlappyBirdGame.Properties.Resources.catBackgroundPic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 551);
            this.Controls.Add(this.lblChooseSkin);
            this.Controls.Add(this.comboBoxChosenSkin);
            this.Controls.Add(this.checkBoxDisableUpgrades);
            this.Controls.Add(this.labelIncreaseInitialSpeed);
            this.Controls.Add(this.trackBarIncreaseInitialSpeed);
            this.Controls.Add(this.btnMenuExit);
            this.Controls.Add(this.btnMenuSettings);
            this.Controls.Add(this.btnMenuPlay);
            this.Controls.Add(this.btnGoToMenu);
            this.Controls.Add(this.lblLeaderBoard);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnSubmitScore);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.endGameScore);
            this.Controls.Add(this.endGameGameOver);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.gameScore);
            this.Controls.Add(this.FreeHitUpgradePic);
            this.Controls.Add(this.WMPlayer1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappyBird);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "WE DID THE JEWS A FAVOUR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeHitUpgradePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIncreaseInitialSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private AxWMPLib.AxWindowsMediaPlayer WMPlayer1;
        private System.Windows.Forms.PictureBox FreeHitUpgradePic;
        private System.Windows.Forms.Label gameScore;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Label endGameGameOver;
        private System.Windows.Forms.Label endGameScore;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSubmitScore;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLeaderBoard;
        private System.Windows.Forms.Button btnGoToMenu;
        private System.Windows.Forms.Button btnMenuPlay;
        private System.Windows.Forms.Button btnMenuSettings;
        private System.Windows.Forms.Button btnMenuExit;
        private System.Windows.Forms.TrackBar trackBarIncreaseInitialSpeed;
        private System.Windows.Forms.Label labelIncreaseInitialSpeed;
        private System.Windows.Forms.CheckBox checkBoxDisableUpgrades;
        private System.Windows.Forms.ComboBox comboBoxChosenSkin;
        private System.Windows.Forms.Label lblChooseSkin;
    }
}

