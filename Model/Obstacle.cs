using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TeamProjectDemo
{
    public class Obstacle : Sprite
    {
        protected int hpControl;
        //constructor
        public Obstacle(System.Windows.Forms.PictureBox picture, Image image, String name, Point location, Size size) : base(picture)
        {
            this.Sprite_Image = image;
            this.Sprite_Name = name;
            this.Sprite_Location = location;
            this.Sprite_Size = size;
            this.hpControl = -10;
        }

        //get,set
        public int Hpcontrol
        {
            get { return this.hpControl; }
            set { this.hpControl = value; }
        }
 
        
    }
}