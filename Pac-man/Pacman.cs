using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_man
{
    internal class Pacman
    {
        PictureBox pictureBox1 = new PictureBox();
        //public PictureBox pictureBox5;
        //private const string V = "left.gif";
        public int x;
        public int y;
        public int w;
        public int h;
        public int speed;
        //public bool flag;
        public bool goup;
        public bool godown;
        public bool goleft;
        public bool goright;
        public Image image;


        public Pacman(int x, int y, Image image)
        {
            this.speed = 5;
            this.x = x;
            this.y = y;
            this.w = 25;
            this.h = 28;
            //this.flag = true;
            this.goup = false;
            this.godown = false;
            this.goleft = false;
            this.goright = false;
            this.image = image;


        }
        public Pacman()
        {

        }

        public void MoveLeft()
        {
            this.x -= speed;
            pictureBox1.Location = new Point( x, y);
            pictureBox1.Image = Properties.Resources.left;
            //MessageBox.Show(Convert.ToString(this.x) + " " + Convert.ToString(this.y));


        }

        public void MoveRight()
        {
            this.x += speed;
            pictureBox1.Location = new Point( x, y);
            pictureBox1.Image = Properties.Resources.right;


        }

        public void MoveDown()
        {
            this.y += speed;
            pictureBox1.Location = new Point( x, y );
            pictureBox1.Image = Properties.Resources.down;


        }
        public void MoveUp()
        {
            this.y -= speed;
            pictureBox1.Location = new Point( x, y );
            pictureBox1.Image = Properties.Resources.Up;


        }

        public void Draw(Graphics g)
        {
            g.Clear(Color.Silver);
            g.DrawImage(image, x, y, w, h);
            //pacman.Draw(e.Graphics);
            //Bitmap mypacman = new Bitmap(this.image);
            //Bitmap mypacman_2 = new Bitmap(mypacman, new Size(25, 28));
            //g.DrawImage(mypacman_2, x, y);
            //g.DrawIcon(pictureBox5, this.x, this.y);
            //g.DrawImage(V, x, y);
        }
    }
}
