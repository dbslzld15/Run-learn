using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TeamProjectDemo
{
    public class User : Sprite
    {
        protected int hp;
        protected int score;
        protected int superTime;
        protected int superCount, force, gravity;
        protected int top;
        protected bool jump;
        protected bool doubleJump;
        protected bool slide;
        protected int intervalSum;
        protected int deathCount;
        protected int jump_count;


        //constructor
        public User(System.Windows.Forms.PictureBox picture, Image image, String name, Point location, Size size) : base(picture)
        {
            this.Sprite_Image = image;
            this.Sprite_Name = name;
            this.Sprite_Location = location;
            this.Sprite_Size = size;

            hp = 190;
            score = 0;
            superTime = 700;
            superCount = 0; //무적모드 카운트
            force = 0;
            gravity = 20; //처음중력
            jump = false;
            doubleJump = false;
            jump_count = 2;
            slide = false;
            intervalSum =0; //Timer함수 호출 횟수 누적 값 (1000ms= 1s)
            deathCount = 0;
          
        }

        //get,set

        public int JumpCount
        {
            get { return jump_count; }
            set { jump_count = value; }
        }
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public int SuperTime
        {
            get { return superTime; }
            set { superTime = value; }
        }
        public int SuperCount
        {
            get { return superCount; }
            set { superCount = value; }
        }
        public int Force
        {
            get { return force; }
            set { force = value; }
        }
        public int Gravitiy
        {
            get { return gravity; }
            set { gravity = value; }
        }
        public bool Jump
        {
            get { return jump; }
            set { jump = value; }
        }
        public bool DoubleJump
        {
            get { return doubleJump; }
            set { doubleJump = value; }
        }

        public bool Slide
        {
            get { return slide; }
            set { slide = value; }
        }

        public int IntervalSum
        {
            get { return intervalSum; }
            set { intervalSum = value; }
        }
        public int DeathCount
        {
            get { return deathCount; }
            set { deathCount = value; }
        }
    }
}