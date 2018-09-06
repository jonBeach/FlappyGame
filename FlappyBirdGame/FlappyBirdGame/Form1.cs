using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed = 5;
        int gravity = 5;
        int score = 0;
        bool startGame = false;
        bool playClicked = false;
        int scoreCheckerthing = 10;
        int trackBarIncreaseSpeed;

        bool freeHitUpgrade = false;
        int percentNumber = 10;
        int scoreNeededToCheck = 10;
        bool freeUpgradeSpawned = false;
        bool goingThroughWall = true;
        bool freeUpgradeCanSpawn = true;

        Image flappyBirdImage = Properties.Resources.bird;
        Image BackGroundImage = null;

        string SongUrl = @"HEY.mp3";

        Graphics g;
        Pen selPen = new Pen(Color.Blue);
        Rectangle r1;
        GraphicsPath gp = new GraphicsPath();

        Button saveSettingButton;

        public Form1()
        {
            this.KeyPreview = true;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            lblControls.Text = "Controls:\n" +
                "Hold Space To Go Up.\n" +
                "Don't Hold Space To Go Down\n" +
                "Press Space to Begin!";
            endGameGameOver.Visible = false;
            endGameScore.Visible = false;

            /*GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, flappyBird.Width, flappyBird.Height);
            flappyBird.Region = new Region(path);*/

            gp.AddRectangle(r1);

            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideGame();
            btnMenuPlay.Location = new Point(255, 179);
            btnMenuSettings.Location = new Point(255, 271);
            btnMenuExit.Location = new Point(255, 367);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (startGame == true)
            {
                /*label1.Text = "Bird:"+flappyBird.Bounds.ToString()
                    +"\nPipeB"+pipeBottom.Bounds.ToString()
                    +"\nPipeBTop:"+pipeBottom.Top +" PipeBBottom:"+pipeBottom.Bottom+" PipeBLeft:"+pipeBottom.Left+" PipeBRight:"+pipeBottom.Right
                    +"\nBirdTop:"+flappyBird.Top+" BirdBottom:"+flappyBird.Bottom+" BirdLeft:"+flappyBird.Left+" BirdRight"+flappyBird.Right
                    +"\nRecTop:"+r1.Top + " RecBottom:"+r1.Bottom+" RecLeft"+r1.Left + " RecRight:"+r1.Right;*/
                DoubleBuffered = true;
                btnRestart.Enabled = false;
                pipeBottom.Left -= pipeSpeed;
                pipeTop.Left -= pipeSpeed;
                flappyBird.Top += gravity;
                r1 = new Rectangle(new Point(15, flappyBird.Location.Y), new Size(45, 53));

                if (WMPlayer1.playState != WMPPlayState.wmppsPlaying)
                {
                    WMPlayer1.URL = @"Home.m4a";
                    WMPlayer1.settings.volume = 20;
                    WMPlayer1.Ctlcontrols.play();
                }

                if (score < 200)
                {
                    if (score == scoreCheckerthing)
                    {
                        pipeSpeed++;
                        scoreCheckerthing = scoreCheckerthing * 2;
                    }
                }
                else
                {
                    if (score == scoreCheckerthing)
                    {
                        pipeSpeed++;
                        scoreCheckerthing += 20;
                    }
                }
                if (freeUpgradeCanSpawn == true)
                {
                    if (score == scoreNeededToCheck)
                    {
                        Random rnd = new Random();
                        int chanceNumber = rnd.Next(1, 101);
                        if (chanceNumber >= percentNumber)
                        {
                            int randomYCord = rnd.Next(10, 440);
                            FreeHitUpgradePic.Location = new Point(400, randomYCord);
                            FreeHitUpgradePic.Visible = true;
                            freeUpgradeSpawned = true;
                            DoubleBuffered = true;
                        }
                        else
                        {
                            percentNumber = percentNumber + 5;
                        }
                        scoreNeededToCheck = scoreNeededToCheck + 10;
                    }
                }

                if (freeUpgradeSpawned == true)
                {
                    FreeHitUpgradePic.Left -= pipeSpeed;
                }
                if (FreeHitUpgradePic.Left < -105)
                {
                    FreeHitUpgradePic.Visible = false;
                }
                if (flappyBird.Bounds.IntersectsWith(FreeHitUpgradePic.Bounds))
                {
                    freeHitUpgrade = true;
                    FreeHitUpgradePic.Visible = false;
                    flappyBird.Image = FreeHitUpgradePic.Image;
                }
                if (r1.IntersectsWith(pipeBottom.Bounds) ||
                    r1.IntersectsWith(pipeTop.Bounds))
                {
                    if (freeHitUpgrade == false)
                    {
                        gameTimer.Stop();
                        endGame();
                    }
                    else
                    {
                        goingThroughWall = true;
                    }
                }
                if (pipeTop.Left < 6 && flappyBird.Location.Y <= -1)
                {
                    if (freeHitUpgrade == false)
                    {
                        gameTimer.Stop();
                        endGame();
                    }
                    else
                    {
                        goingThroughWall = true;
                        flappyBird.Image = FreeHitUpgradePic.Image;
                    }
                }
                if (goingThroughWall == true)
                {
                    if (!flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) &&
                            !flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
                    {
                        freeHitUpgrade = false;
                        goingThroughWall = false;
                        percentNumber = 10;
                        flappyBird.Image = flappyBirdImage;
                    }
                }
                if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
                {
                    gameTimer.Stop();
                    endGame();
                }
                if (pipeBottom.Left < -105)
                {
                    pipeBottom.Left = 600;
                    score++;
                    WMPlayer1.settings.volume++;
                    gameScore.Text = score.ToString();
                }
                else if (pipeTop.Left < -105)
                {
                    pipeTop.Left = 1100;
                    score++;
                    WMPlayer1.settings.volume++;
                    gameScore.Text = score.ToString();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (playClicked == true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    startGame = true;
                    lblControls.Visible = false;
                    jumping = true;
                    gravity = -5;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (playClicked == true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jumping = false;
                    gravity = 5;
                }
            }
        }

        private void endGame()
        {
            endGameGameOver.Visible = true;
            endGameScore.Visible = true;
            btnRestart.Visible = true;
            btnRestart.Enabled = true;
            btnSubmitScore.Visible = true;
            btnSubmitScore.Enabled = true;
            btnGoToMenu.Visible = true;
            btnGoToMenu.Enabled = true;
            txtBoxName.Visible = true;
            txtBoxName.Enabled = true;
            lblName.Visible = true;
            lblLeaderBoard.Visible = true;

            txtBoxName.Focus();
            showLeaderBoard();
            startGame = false;
            WMPlayer1.Ctlcontrols.stop();
            goingThroughWall = false;
            flappyBird.Image = flappyBirdImage;
            percentNumber = 10;
            scoreNeededToCheck = 10;
            endGameGameOver.Text = "Game Over!";
            endGameScore.Text = "Score: " + score;
        }

        private void restartGame()
        {
            if (startGame == false)
            {
                endGameGameOver.Visible = false;
                endGameScore.Visible = false;
                lblControls.Visible = true;
                btnRestart.Visible = false;
                btnRestart.Enabled = false;
                btnSubmitScore.Visible = false;
                btnSubmitScore.Enabled = false;
                btnGoToMenu.Visible = false;
                btnGoToMenu.Enabled = false;
                txtBoxName.Visible = false;
                txtBoxName.Enabled = false;
                lblName.Visible = false;
                lblLeaderBoard.Visible = false;

                jumping = false;
                if (trackBarIncreaseSpeed == 0)
                {
                    pipeSpeed = 5;
                }
                else
                {
                    pipeSpeed = 5;
                    pipeSpeed += trackBarIncreaseSpeed;
                }
                gravity = 5;
                score = 0;

                flappyBird.Location = new Point(3, 198);
                pipeTop.Location = new Point(339, -1);
                pipeBottom.Location = new Point(532, 310);

                WMPlayer1.URL = SongUrl;
                WMPlayer1.settings.volume = 0;
                WMPlayer1.Ctlcontrols.play();

                gameTimer.Start();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            startGame = false;
            restartGame();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            //g.DrawRectangle(new Pen(Color.Blue), r1);
            //g.DrawRectangle(selPen, 15, 200, 45, 53);
        }

        private void btnSubmitScore_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text != null && txtBoxName.Text.Trim() != ""
                && txtBoxName.Text.Trim() != " ")
            {
                try
                {
                    const int PORT_NO = 85;
                    const string SERVER_IP = "cuckmedad.ddns.net";//"99.233.243.223";

                    //---data to send to the server---
                    string textToSend = score + " " + txtBoxName.Text;

                    //---create a TCPClient object at the IP and port no.---
                    TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
                    NetworkStream nwStream = client.GetStream();
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

                    //---send the text---
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);

                    client.Close();

                    MessageBox.Show("Score Sent!");

                    btnSubmitScore.Enabled = false;
                    btnSubmitScore.Visible = false;
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Can't connect to server! Retry later!");
                }
                catch (SocketException)
                {
                    MessageBox.Show("Can't connect to server! Retry later!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
        }
        private void showLeaderBoard()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                try
                {
                    const int PORT_NO = 85;
                    const string SERVER_IP = "cuckmedad.ddns.net";//"99.233.243.223";

                    //---data to send to the server---
                    string textToSend = "List";

                    //---create a TCPClient object at the IP and port no.---
                    TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
                    NetworkStream nwStream = client.GetStream();
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

                    //---send the text---
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);

                    //---read back the text---
                    byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                    int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                    string message = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);

                    Invoke(new Action(() => { lblLeaderBoard.Text = "High Scores:\n" + message; }));
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Can't connect to server! Retry later!");
                }
                catch (SocketException)
                {
                    Invoke(new Action(() => { lblLeaderBoard.Text = "Can't connect to server!"; }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }).Start();
        }

        private void btnGoToMenu_Click(object sender, EventArgs e)
        {
            playClicked = false;

            hideGame();

            Form1.ActiveForm.BackgroundImage = Properties.Resources.catBackgroundPic;

            btnMenuPlay.Visible = true;
            btnMenuPlay.Enabled = true;
            btnMenuSettings.Visible = true;
            btnMenuSettings.Enabled = true;
            btnMenuExit.Visible = true;
            btnMenuExit.Enabled = true;
        }

        private void btnMenuPlay_Click(object sender, EventArgs e)
        {
            playClicked = true;

            showGame();

            ActiveForm.BackgroundImage = BackGroundImage;

            restartGame();

            btnMenuPlay.Visible = false;
            btnMenuPlay.Enabled = false;
            btnMenuSettings.Visible = false;
            btnMenuSettings.Enabled = false;
            btnMenuExit.Visible = false;
            btnMenuExit.Enabled = false;

        }

        private void btnMenuSettings_Click(object sender, EventArgs e)
        {
            btnMenuPlay.Visible = false;
            btnMenuPlay.Enabled = false;
            btnMenuSettings.Visible = false;
            btnMenuSettings.Enabled = false;
            btnMenuExit.Visible = false;
            btnMenuExit.Enabled = false;

            labelIncreaseInitialSpeed.Visible = true;
            lblChooseSkin.Visible = true;
            trackBarIncreaseInitialSpeed.Visible = true;
            trackBarIncreaseInitialSpeed.Enabled = true;
            checkBoxDisableUpgrades.Visible = true;
            checkBoxDisableUpgrades.Enabled = true;
            comboBoxChosenSkin.Visible = true;
            comboBoxChosenSkin.Enabled = true;

            comboBoxChosenSkin.DropDownStyle = ComboBoxStyle.DropDownList;

            /*Graphics rectangle = CreateGraphics();
            SolidBrush grayColor = new SolidBrush(Color.Gray);

            rectangle.FillRectangle(grayColor, 160, 5, 300, 540);*/

            // Create a Button object 
            saveSettingButton = new Button();
            saveSettingButton.Enabled = true;

            //button properties
            saveSettingButton.Width = 107;
            saveSettingButton.Height = 42;
            saveSettingButton.Location = new Point(255, 500);
            saveSettingButton.Text = "Save";
            saveSettingButton.BackColor = Color.Red;

            // Add a Button Click Event handler
            saveSettingButton.Click += new EventHandler(saveSettingButton_Click);
            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(saveSettingButton);
        }
        private void saveSettingButton_Click(object sender, EventArgs e)
        {
            trackBarIncreaseSpeed = trackBarIncreaseInitialSpeed.Value;

            if (checkBoxDisableUpgrades.Checked == true)
            {
                freeUpgradeCanSpawn = false;
            }

            labelIncreaseInitialSpeed.Visible = false;
            lblChooseSkin.Visible = false;
            trackBarIncreaseInitialSpeed.Visible = false;
            trackBarIncreaseInitialSpeed.Enabled = false;
            checkBoxDisableUpgrades.Visible = false;
            checkBoxDisableUpgrades.Enabled = false;
            saveSettingButton.Enabled = false;
            comboBoxChosenSkin.Visible = false;
            comboBoxChosenSkin.Enabled = false;

            Controls.Remove(saveSettingButton);

            if (comboBoxChosenSkin.Text == "Original")
            {
                flappyBird.Image = Properties.Resources.bird;
                ground.Image = Properties.Resources.ground;
                pipeBottom.Image = Properties.Resources.pipe;
                pipeTop.Image = Properties.Resources.pipedown;
                pipeBottom.BackColor = Color.PaleTurquoise;
                pipeTop.BackColor = Color.PaleTurquoise;
                ActiveForm.BackgroundImage = null;
                Form1.ActiveForm.BackColor = Color.PaleTurquoise;
                SongUrl = @"HEY.mp3";
            }
            if (comboBoxChosenSkin.Text == "Hentai")
            {
                pipeBottom.Image = Properties.Resources.tentaclePipeBottom;
                pipeTop.Image = Properties.Resources.tentaclePipeTop;
                pipeBottom.BackColor = Color.LightGray;
                pipeTop.BackColor = Color.LightGray;
                flappyBird.Image = Properties.Resources.HentaiBird;
                flappyBirdImage = Properties.Resources.HentaiBird;
                ground.Image = Properties.Resources.HentaiGround;
                BackGroundImage = Properties.Resources.HentaiGameBackground;
                SongUrl = @"pomf.mp3";
            }

            btnGoToMenu_Click(sender, e);
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void hideGame()
        {
            gameScore.Visible = false;
            lblControls.Visible = false;
            flappyBird.Visible = false;
            lblLeaderBoard.Visible = false;
            pipeTop.Visible = false;
            pipeBottom.Visible = false;
            endGameGameOver.Visible = false;
            endGameScore.Visible = false;
            lblName.Visible = false;
            txtBoxName.Visible = false;
            btnSubmitScore.Visible = false;
            btnRestart.Visible = false;
            btnGoToMenu.Visible = false;
            ground.Visible = false;
            WMPlayer1.Visible = false;
            FreeHitUpgradePic.Visible = false;
        }

        public void showGame()
        {
            gameScore.Location = new Point(12, 9);
            lblControls.Location = new Point(12, 96);
            flappyBird.Location = new Point(3, 199);
            lblLeaderBoard.Location = new Point(270, 32);
            pipeTop.Location = new Point(339, -1);
            pipeBottom.Location = new Point(542, 310);
            endGameGameOver.Location = new Point(267, 223);
            endGameScore.Location = new Point(267, 243);
            lblName.Location = new Point(267, 262);
            txtBoxName.Location = new Point(303, 260);
            btnSubmitScore.Location = new Point(270, 282);
            btnRestart.Location = new Point(270, 343);
            btnGoToMenu.Location = new Point(270, 409);
            ground.Location = new Point(-8, 470);
            WMPlayer1.Location = new Point(141, 519);
            FreeHitUpgradePic.Location = new Point(385, 513);

            gameScore.Visible = true;
            lblControls.Visible = true;
            flappyBird.Visible = true;
            pipeTop.Visible = true;
            pipeBottom.Visible = true;
            ground.Visible = true;
        }
    }
}