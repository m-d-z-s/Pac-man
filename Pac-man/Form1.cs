using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_man
{
    public partial class Form1 : Form
    {
        Graphics g;
        PictureBox[] pb = new PictureBox[25];
        Pacman pacman = new Pacman(Properties.Resources.left);
        Coins coins = new Coins(Properties.Resources.coin);
     

        int score = 0;

        public Form1()
        {
            InitializeComponent();
            //g = this.CreateGraphics();
            g = pictureBox2.CreateGraphics();
            DrawCoins(g);

        }


        private void keyisdown(object sender, KeyEventArgs e)
        {            
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pacman.goleft = true;
                    pacman.image = Properties.Resources.left;
                    pictureBox1.Image = pacman.image;
                    break;
                case Keys.Right:
                    pacman.goright = true;
                    pacman.image = Properties.Resources.right;
                    pictureBox1.Image = pacman.image;
                    break;
                case Keys.Up:
                    pacman.goup = true;
                    pacman.image = Properties.Resources.Up;
                    pictureBox1.Image = pacman.image;
                    break;
                case Keys.Down:
                    pacman.godown = true;
                    pacman.image = Properties.Resources.down;
                    pictureBox1.Image = pacman.image;
                    break;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pacman.goleft = false;
                    break;
                case Keys.Right:
                    pacman.goright = false;
                    break;
                case Keys.Up:
                    pacman.goup = false;
                    break;
                case Keys.Down:
                    pacman.godown = false;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = "Score: " + score; 

            if (pacman.goleft && pictureBox1.Left > 0)
            {
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                pictureBox1.Left -= pacman.speed;
                pacman.MoveLeft();
                pacman.Clear(g);
            }
            if (pacman.goright && pictureBox1.Right < 451)
            {
                pictureBox1.Left += pacman.speed;
                pacman.MoveRight();
                pacman.Clear(g);
            }
            if (pacman.goup && pictureBox1.Top > 0)
            {
                pictureBox1.Top -= pacman.speed;
                pacman.MoveUp();
                pacman.Clear(g);
            }

            if (pacman.godown && pictureBox1.Top < 348)
            {
                pictureBox1.Top += pacman.speed;
                pacman.MoveDown();
                pacman.Clear(g);
            }
            //if (!(Check() is null))
            //{
            //    EatCoin(Check());
            //}
            else
            {
                pacman.Clear(g);
            }


        }

        public PictureBox Check()
        {
            foreach (var item in pb)
            {
                if (pictureBox1.Right == item.Right)
                {
                    return item;
                }
            }
            return null;
        }
        
        public void EatCoin(PictureBox theCoin)
        {
            theCoin.Hide();
            score += 10;
        }

        public void DrawCoins(Graphics g)
        {
            int changeX = 0;
            int changeY = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    pb[i] = new PictureBox();
                    pb[i].Image = pictureBox3.Image;
                    pb[i].Width = pictureBox3.Width + 3;
                    pb[i].Height = pictureBox3.Height +3;
                    pb[i].Location = new Point(coins.x + changeX, coins.y + changeY);
                    Controls.Add(pb[i]);
                    changeX += 60;
                }
                changeX = 0;
                changeY += 60;
            }
        }



    }
}
