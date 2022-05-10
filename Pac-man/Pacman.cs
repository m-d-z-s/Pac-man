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
        //public PictureBox pictureBox5;
        //private const string V = "left.gif";
        public int x;
        public int y;
        public int speed;
        public bool goup;
        public bool godown;
        public bool goleft;
        public bool goright;
        public Image image;


        public Pacman(bool goup, bool godown,bool goleft, bool goright, Image image)
        {
            this.speed = 5;
            this.x = 0;
            this.y = 0;
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
            
        }

        public void MoveRight()
        {
            this.x += speed;

        }

        public void MoveDown()
        {
            this.y += speed;

        }
        public void MoveUp()
        {
            this.y -= speed;

        }

        public void Draw(Graphics g)
        {
            Bitmap mypacman = new Bitmap(this.image);
            Bitmap mypacman_2 = new Bitmap(mypacman, new Size(25, 28));
            g.DrawImage(mypacman_2, x, y);
            //g.DrawIcon(pictureBox5, this.x, this.y);
            //g.DrawImage(V, x, y);
        }
    }
}
