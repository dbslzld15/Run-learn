using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;


namespace TeamProjectDemo
{
    public class Item : Sprite
    {
        protected int hpControl; //아이템이 갖고있는 hp 깎거나 증가시키는 수치
        protected int scoreControl; //아이템이 갖고있는 score 증가 수치 
  
        //constructor
        public Item(System.Windows.Forms.PictureBox picture, Image image, String name, Point location, Size size) : base(picture)
        {
            this.Sprite_Image = image;
            if (name == "jokbo")
            {
                this.Sprite_Name = "jokbo";
            }
            else if (name == "hotsix")
            {
                this.Sprite_Name = "hotsix";
                this.hpControl = 10;
            }
            else if (name == "soju")
            {
                this.Sprite_Name = "soju";
            }
            else if (name == "vitamins")
            {
                this.Sprite_Name = "vitamins";
                this.ScoreControl = 10;
            }
            this.Sprite_Location = location;
            this.Sprite_Size = size;
 
        }

        //get,set
        public int HpControl
        {
            get { return this.hpControl; }
            set { this.hpControl = value; }
        }

        public int ScoreControl
        {
            get { return this.scoreControl; }
            set { this.scoreControl = value; }
        }
    }
}