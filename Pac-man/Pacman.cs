using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_man
{
    public class Pacman
    {
        PictureBox pictureBox1 = new PictureBox();
        //int x;
        //int y;
        //int w;
        //int h;
        public int speed;
        public bool goup;
        public bool godown;
        public bool goleft;
        public bool goright;
        public Image image;


        public Pacman(Image image)
        {
            this.speed = 5;
            //this.x = x;
            //this.y = y;
            //this.w = 25;
            //this.h = 28;
            this.goup = false;
            this.godown = false;
            this.goleft = false;
            this.goright = false;
            this.image = image;


        }

        public void MoveLeft()
        {
            //this.x -= speed;
            //pictureBox1.Location = new Point( x, y);
            pictureBox1.Image = Properties.Resources.left;


        }

        public void MoveRight()
        {
            //this.x += speed;
            //pictureBox1.Location = new Point( x, y);
            pictureBox1.Image = Properties.Resources.right;


        }

        public void MoveDown()
        {
            //this.y += speed;
            //pictureBox1.Location = new Point( x, y);
            pictureBox1.Image = Properties.Resources.down;


        }
        public void MoveUp()
        {
            //this.y -= speed;
            //pictureBox1.Location = new Point( x, y);
            pictureBox1.Image = Properties.Resources.Up;


        }

        public void Clear(Graphics g)
        {
            g.Clear(Color.Silver);
            //g.DrawImage(image, x, y, w, h);
        }
    }
}
