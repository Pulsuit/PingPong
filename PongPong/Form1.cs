using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongPong
{
    public partial class Form1 : Form
    {
        private int  speed_vertical = 4;
        private int  speed_hor = 4;
        private int  score = 0;
        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;

            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            this.Bounds = Screen.PrimaryScreen.Bounds;

            gamePanel.Top = backGround.Bottom - (backGround.Bottom / 10);

            loseLabel.Visible = false;
            loseLabel.Left = (backGround.Width / 2) - (loseLabel.Width / 2);
            loseLabel.Top = (backGround.Height / 2) - (loseLabel.Height / 2);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                this.Close();
            if(e.KeyCode == Keys.R)
            {
                gameBall.Top = 50;
                gameBall.Left = 70;
                speed_hor = 2;
                speed_vertical = 2;
                score = 0;
                loseLabel.Visible = false;
                timer.Enabled = true;
                result.Text = "Result: 0";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);

            gameBall.Left += speed_hor;
            gameBall.Top += speed_vertical;

            if (gameBall.Left <= backGround.Left)
                speed_hor *= -1;

            if (gameBall.Right >= backGround.Right)
                speed_hor *= -1;

            if (gameBall.Top <= backGround.Top)
                speed_vertical *= -1;

            if (gameBall.Bottom >= backGround.Bottom)
            {
                loseLabel.Visible = true;
                timer.Enabled = false;
            }
                

            if (gameBall.Bottom >= gamePanel.Top && gameBall.Bottom <= gamePanel.Bottom && gameBall.Left >= gamePanel.Left && gameBall.Right <= gamePanel.Right)
            {
                speed_hor += 3;
                speed_vertical += 3;
                speed_vertical *= -1;
                score += 1;
                result.Text = "Result: " + score.ToString();


                Random randColor = new Random();
                backGround.BackColor = Color.FromArgb(randColor.Next(150, 255), randColor.Next(150, 255), randColor.Next(150, 255));
            }

        }
    }
}
