using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TeamProjectDemo
{
    public class Sprite
    {
        protected int dx; //단위시간당 x 이동거리
        protected int dy; //단위시간당 y 이동거리


        //constructor
        public Sprite(System.Windows.Forms.PictureBox picture)
        {
            Sprite_Picture = picture;
            this.Sprite_Picture.BackColor = System.Drawing.Color.Transparent;
            this.dx = 0;
            this.dy = 0;

        }

        //get,set
        public int Dx
        {
            get { return dx; }
            set { this.dx = value; }
        }
        public int Dy
        {
            get { return dy; }
            set { this.dy = value; }
        }
        public PictureBox Sprite_Picture { get; set; }
        public Image Sprite_Image
        {
            get { return Sprite_Picture.Image; }
            set { this.Sprite_Picture.Image = value; }
        }
        public Point Sprite_Location
        {
            get { return Sprite_Picture.Location; }
            set { this.Sprite_Picture.Location = value; }
        }
        public Size Sprite_Size
        {
            get { return Sprite_Picture.Size; }
            set { this.Sprite_Picture.Size = value; }
        }
        public int Sprite_Top
        {
            get { return Sprite_Picture.Top; }
            set { Sprite_Picture.Top = value; }
        }
        public int Width
        {
            get { return Sprite_Picture.Width; }
            set { this.Sprite_Picture.Width = value; }
        }
        public int Height
        {
            get { return Sprite_Picture.Height; }
            set { this.Sprite_Picture.Height = value; }
        }
        public string Sprite_Name
        {
            get { return Sprite_Picture.Name; }
            set { this.Sprite_Picture.Name = value; }
        }

        //funcitionality
        public void move(int dx, int dy)
        {
            if (Sprite_Picture.GetType() == typeof(Item))
            {
                Sprite_Picture.Invoke(new Action(delegate ()
                {
                    Sprite_Picture.Location = new Point(Sprite_Picture.Location.X + (dx), Sprite_Picture.Location.Y + dy);
                }));
            }
            else
            {
                Sprite_Picture.Location = new Point(Sprite_Picture.Location.X + (dx), Sprite_Picture.Location.Y + dy);
            }

        }

        public bool checkCollision(Sprite other)
        {
            Rectangle myRect = new Rectangle();
            Rectangle otherRect = new Rectangle();

            myRect.Location = this.Sprite_Location;
            myRect.Size = this.Sprite_Size;

            otherRect.Location = other.Sprite_Location;
            otherRect.Size = other.Sprite_Size;

            return myRect.IntersectsWith(otherRect);
        }
    }
}