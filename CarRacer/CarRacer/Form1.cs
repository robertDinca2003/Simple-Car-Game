using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarRacer
{
    public partial class Game : Form
    {
        public Game()
        {

            InitializeComponent();
        }

        int currentScore;

        int bestScore = 0;

        int lifes;

        int speed;

        int gameStarted = 0;

        int timeCounter = 0;

        PictureBox[] enemy = new PictureBox[10];
        PictureBox[] coins = new PictureBox[4];
        PictureBox[] hearts = new PictureBox[3];
        PictureBox[] lines = new PictureBox[5];

        PictureBox player = new PictureBox();

        Random rand = new Random();

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            GameName.Visible = false;
            BestScoreLabel.Visible = false;
            Game.ActiveForm.BackColor = Color.Gray;
            btnStartGame.Enabled = false;
            btnStartGame.Visible = false;
            leftBorder.Visible = true;
            rightBorder.Visible = true;
            label2.Visible = true;
            timerCloack.Enabled = true;

            currentScore = 0;
            lifes = 3;
            speed = 10;
            gameStarted = 1;

            label2.Text = "Current Score: " + currentScore.ToString();
            label2.BackColor = Color.Transparent;

            PictureBox temp1 = new PictureBox();
            panelGame.Controls.Add(temp1);
            temp1.Height = 200;
            temp1.Width = 100;
            temp1.Location = new Point(270, 650);
            temp1.Visible = true;
            string path = Directory.GetCurrentDirectory();
            path = path + "\\Resources\\copycar.png";
            Image playerCar = Image.FromFile(path);
            temp1.Image = playerCar;
            temp1.SizeMode = PictureBoxSizeMode.StretchImage;
            temp1.BackColor = Color.Transparent;
            player = temp1;
            player.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);

            for (int i = 0; i < 5; i++)
            {
                PictureBox temp2 = new PictureBox();
                panelGame.Controls.Add(temp2);
                enemy[i] = temp2;
                enemy[i].Height = 200;
                enemy[i].Width = 100;
                enemy[i].Visible = true;
                enemy[i].Location = new Point(rand.Next(1, 5) * 100, -i * 400);
                string path2 = Directory.GetCurrentDirectory();
                path2 = path2 + "\\Resources\\obstacleCar.png";
                enemy[i].Image = Image.FromFile(path2);
                enemy[i].SizeMode = PictureBoxSizeMode.StretchImage;
                enemy[i].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            for (int i = 0; i < 4; i++)
            {
                PictureBox temp3 = new PictureBox();
                panelGame.Controls.Add(temp3);
                temp3.Height = 75;
                temp3.Width = 75;
                temp3.Visible = true;
                temp3.Location = new Point(rand.Next(1, 10) * 50, -i * 300);
                string path3 = Directory.GetCurrentDirectory();
                path3 = path3 + "\\Resources\\coin.png";
                temp3.Image = Image.FromFile(path3);
                temp3.SizeMode = PictureBoxSizeMode.StretchImage;
                coins[i] = temp3; 
            }

            for (int i = 0; i < 5; i++)
            {
                PictureBox temp = new PictureBox();
                panelGame.Controls.Add(temp);
                temp.Height=100;
                temp.Width=10;
                temp.Location =new Point(300,  i*220);
                temp.BackColor = Color.White;
                temp.Visible = true;
                
                lines[i] = temp;
                
                

            }
            
            


        }

        void moveLines()
        {
            if (gameStarted == 0) return;
            for(int i = 0; i < 5; i++)
            {
                    if (lines[i].Top >= 970) lines[i].Top = -100;
                    else lines[i].Top += speed;
                //if (lines[i].Location.Y >= 900) lines[i].Location = new Point(lines[i].Location.X, -10);
                //else lines[i].Location = new Point(lines[i].Location.X, lines[i].Location.Y + speed);
            }
           

        }

        void updateEnemy()
        {
            
            for(int i = 0; i < 5; i++)
            {
                if (enemy[i].Top <= 1600) enemy[i].Top += speed;
                else { enemy[i].Top = -400; enemy[i].Left = 10 + rand.Next(10, 500); }
            }
        }

        void updateCoins()
        {
           for(int i = 0; i < 4; i++)
            {
                if (coins[i].Top >= 1020) { coins[i].Location = new Point(rand.Next(1, 10) * 50, -200); coins[i].Visible = true; }
                else coins[i].Top += speed;
            }
        }

        private void timerCloack_Tick(object sender, EventArgs e)
        {
            if (gameStarted == 0) return;
            if (timeCounter < 35) timeCounter++;
            if (timeCounter == 35 && speed <=21) { timeCounter = 0; speed++; }
            //MessageBox.Show(timerCloack.Interval.ToString());
            
            moveLines();
            updateEnemy();
            updateCoins();

            for(int i = 0; i < 5; i++)
            {
                if (Math.Abs(enemy[i].Top - player.Top) <= 185 && Math.Abs(enemy[i].Left - player.Left) <= 90) { timerCloack.Enabled = false; gameStarted = 0; endGame(); }
            }

            for(int i = 0; i < 4; i++)
            {
                if ( player.Top - coins[i].Top <= 45 && player.Top - coins[i].Top >= -200 && coins[i].Left - player.Left <= 90 && coins[i].Left - player.Left >= -60  && coins[i].Visible == true)
                {
                    currentScore++;
                    coins[i].Visible = false;
                    label2.Text = "Current Score :" + currentScore.ToString();
                }
            }
            
        }

        void endGame()
        {
            btn_back.Enabled = true;
            btn_back.Visible = true;
            label2.Visible = false;
            label3.Text = "You scored: " + currentScore.ToString();
            label3.Visible = true;

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (gameStarted == 0 || timerCloack.Enabled == false ) return;
            if (e.KeyCode == Keys.Left && player.Left >= 10) player.Left -= speed;

            if (e.KeyCode == Keys.Right && player.Left <= 520) player.Left += speed;
            

        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (gameStarted == 0 || timerCloack.Enabled == false) return;
            if (e.KeyChar == Left && player.Left >= 10) player.Left -= speed;

            if (e.KeyChar == Right && player.Left <= 520) player.Left += speed;
            */
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            GameName.Visible = true;
            if (currentScore > bestScore) bestScore = currentScore;
            BestScoreLabel.Text = "Best Score: " + currentScore.ToString();
            BestScoreLabel.Visible = true;
            
            Game.ActiveForm.BackColor = Color.Teal;
            btnStartGame.Enabled = true;
            btnStartGame.Visible = true;
            leftBorder.Visible = false;
            rightBorder.Visible = false;
            label2.Visible = false;

            panelGame.Controls.Remove(player);
            for (int i = 0; i < 5; i++)
                panelGame.Controls.Remove(lines[i]);
            for (int i = 0; i < 5; i++)
                panelGame.Controls.Remove(enemy[i]);
            for (int i = 0; i < 4; i++)
                panelGame.Controls.Remove(coins[i]);

            label3.Visible = false;
            btn_back.Visible = false;
            btn_back.Enabled = false;
        }
    }
}
