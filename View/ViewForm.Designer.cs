using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectDemo
{
    partial class ViewForm
    {

        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score_num = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Fullbar = new System.Windows.Forms.PictureBox();
            this.Hpbar = new System.Windows.Forms.PictureBox();
            this.Back_Hpbar = new System.Windows.Forms.PictureBox();
            this.jokboCheck1 = new System.Windows.Forms.PictureBox();
            this.jokboCheck2 = new System.Windows.Forms.PictureBox();
            this.jokboCheck3 = new System.Windows.Forms.PictureBox();
            this.jokboCheck4 = new System.Windows.Forms.PictureBox();
            this.jokboCheck5 = new System.Windows.Forms.PictureBox();
            this.Hp_num = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heart_hpbar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LifeCheck5 = new System.Windows.Forms.PictureBox();
            this.LifeCheck4 = new System.Windows.Forms.PictureBox();
            this.LifeCheck3 = new System.Windows.Forms.PictureBox();
            this.LifeCheck2 = new System.Windows.Forms.PictureBox();
            this.LifeCheck1 = new System.Windows.Forms.PictureBox();
            this.speed_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fullbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hpbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Hpbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokboCheck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokboCheck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokboCheck3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokboCheck4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokboCheck5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_hpbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCheck5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCheck4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCheck3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCheck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCheck1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score_num
            // 
            this.score_num.AutoSize = true;
            this.score_num.BackColor = System.Drawing.Color.Transparent;
            this.score_num.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score_num.Location = new System.Drawing.Point(736, 13);
            this.score_num.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.score_num.Name = "score_num";
            this.score_num.Size = new System.Drawing.Size(84, 16);
            this.score_num.TabIndex = 1;
            this.score_num.Text = "Score: 0";
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("screen.BackgroundImage")));
            this.screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1713, 420);
            this.screen.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10;
            // 
            // Fullbar
            // 
            this.Fullbar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Fullbar.Location = new System.Drawing.Point(54, 53);
            this.Fullbar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Fullbar.Name = "Fullbar";
            this.Fullbar.Size = new System.Drawing.Size(190, 25);
            this.Fullbar.TabIndex = 2;
            this.Fullbar.TabStop = false;
            // 
            // Hpbar
            // 
            this.Hpbar.BackColor = System.Drawing.Color.Crimson;
            this.Hpbar.Location = new System.Drawing.Point(54, 53);
            this.Hpbar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Hpbar.Name = "Hpbar";
            this.Hpbar.Size = new System.Drawing.Size(190, 25);
            this.Hpbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Hpbar.TabIndex = 3;
            this.Hpbar.TabStop = false;
            // 
            // Back_Hpbar
            // 
            this.Back_Hpbar.BackColor = System.Drawing.Color.Gold;
            this.Back_Hpbar.Location = new System.Drawing.Point(3, 47);
            this.Back_Hpbar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Back_Hpbar.Name = "Back_Hpbar";
            this.Back_Hpbar.Size = new System.Drawing.Size(251, 37);
            this.Back_Hpbar.TabIndex = 4;
            this.Back_Hpbar.TabStop = false;
            // 
            // jokboCheck1
            // 
            this.jokboCheck1.BackColor = System.Drawing.Color.Transparent;
            this.jokboCheck1.Image = global::TeamProjectDemo.Properties.Resources.notebook__2_;
            this.jokboCheck1.Location = new System.Drawing.Point(678, 53);
            this.jokboCheck1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.jokboCheck1.Name = "jokboCheck1";
            this.jokboCheck1.Size = new System.Drawing.Size(28, 29);
            this.jokboCheck1.TabIndex = 5;
            this.jokboCheck1.TabStop = false;
            // 
            // jokboCheck2
            // 
            this.jokboCheck2.BackColor = System.Drawing.Color.Transparent;
            this.jokboCheck2.Image = global::TeamProjectDemo.Properties.Resources.notebook__2_;
            this.jokboCheck2.Location = new System.Drawing.Point(717, 53);
            this.jokboCheck2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.jokboCheck2.Name = "jokboCheck2";
            this.jokboCheck2.Size = new System.Drawing.Size(29, 29);
            this.jokboCheck2.TabIndex = 6;
            this.jokboCheck2.TabStop = false;
            // 
            // jokboCheck3
            // 
            this.jokboCheck3.BackColor = System.Drawing.Color.Transparent;
            this.jokboCheck3.Image = global::TeamProjectDemo.Properties.Resources.notebook__2_;
            this.jokboCheck3.Location = new System.Drawing.Point(759, 53);
            this.jokboCheck3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.jokboCheck3.Name = "jokboCheck3";
            this.jokboCheck3.Size = new System.Drawing.Size(29, 29);
            this.jokboCheck3.TabIndex = 7;
            this.jokboCheck3.TabStop = false;
            // 
            // jokboCheck4
            // 
            this.jokboCheck4.BackColor = System.Drawing.Color.Transparent;
            this.jokboCheck4.Image = global::TeamProjectDemo.Properties.Resources.notebook__2_;
            this.jokboCheck4.Location = new System.Drawing.Point(799, 53);
            this.jokboCheck4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.jokboCheck4.Name = "jokboCheck4";
            this.jokboCheck4.Size = new System.Drawing.Size(29, 29);
            this.jokboCheck4.TabIndex = 8;
            this.jokboCheck4.TabStop = false;
            // 
            // jokboCheck5
            // 
            this.jokboCheck5.BackColor = System.Drawing.Color.Transparent;
            this.jokboCheck5.Image = global::TeamProjectDemo.Properties.Resources.notebook__2_;
            this.jokboCheck5.Location = new System.Drawing.Point(840, 53);
            this.jokboCheck5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.jokboCheck5.Name = "jokboCheck5";
            this.jokboCheck5.Size = new System.Drawing.Size(27, 29);
            this.jokboCheck5.TabIndex = 9;
            this.jokboCheck5.TabStop = false;
            // 
            // Hp_num
            // 
            this.Hp_num.AutoSize = true;
            this.Hp_num.BackColor = System.Drawing.Color.Transparent;
            this.Hp_num.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Hp_num.Location = new System.Drawing.Point(1, 33);
            this.Hp_num.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Hp_num.Name = "Hp_num";
            this.Hp_num.Size = new System.Drawing.Size(26, 12);
            this.Hp_num.TabIndex = 10;
            this.Hp_num.Text = "HP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(624, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "SuperMode";
            // 
            // heart_hpbar
            // 
            this.heart_hpbar.BackColor = System.Drawing.Color.Gold;
            this.heart_hpbar.Image = global::TeamProjectDemo.Properties.Resources.Basic_Dashboard_UI_heart_love_like_512;
            this.heart_hpbar.Location = new System.Drawing.Point(10, 47);
            this.heart_hpbar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.heart_hpbar.Name = "heart_hpbar";
            this.heart_hpbar.Size = new System.Drawing.Size(38, 37);
            this.heart_hpbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart_hpbar.TabIndex = 12;
            this.heart_hpbar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(47, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "LIFE";
            // 
            // LifeCheck5
            // 
            this.LifeCheck5.BackColor = System.Drawing.Color.Transparent;
            this.LifeCheck5.Image = global::TeamProjectDemo.Properties.Resources.check_skull;
            this.LifeCheck5.Location = new System.Drawing.Point(216, 13);
            this.LifeCheck5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LifeCheck5.Name = "LifeCheck5";
            this.LifeCheck5.Size = new System.Drawing.Size(29, 29);
            this.LifeCheck5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LifeCheck5.TabIndex = 18;
            this.LifeCheck5.TabStop = false;
            // 
            // LifeCheck4
            // 
            this.LifeCheck4.BackColor = System.Drawing.Color.Transparent;
            this.LifeCheck4.Image = global::TeamProjectDemo.Properties.Resources.check_skull;
            this.LifeCheck4.Location = new System.Drawing.Point(176, 13);
            this.LifeCheck4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LifeCheck4.Name = "LifeCheck4";
            this.LifeCheck4.Size = new System.Drawing.Size(29, 29);
            this.LifeCheck4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LifeCheck4.TabIndex = 17;
            this.LifeCheck4.TabStop = false;
            // 
            // LifeCheck3
            // 
            this.LifeCheck3.BackColor = System.Drawing.Color.Transparent;
            this.LifeCheck3.Image = global::TeamProjectDemo.Properties.Resources.check_skull;
            this.LifeCheck3.Location = new System.Drawing.Point(136, 13);
            this.LifeCheck3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LifeCheck3.Name = "LifeCheck3";
            this.LifeCheck3.Size = new System.Drawing.Size(29, 29);
            this.LifeCheck3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LifeCheck3.TabIndex = 16;
            this.LifeCheck3.TabStop = false;
            // 
            // LifeCheck2
            // 
            this.LifeCheck2.BackColor = System.Drawing.Color.Transparent;
            this.LifeCheck2.Image = global::TeamProjectDemo.Properties.Resources.check_skull;
            this.LifeCheck2.Location = new System.Drawing.Point(94, 13);
            this.LifeCheck2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LifeCheck2.Name = "LifeCheck2";
            this.LifeCheck2.Size = new System.Drawing.Size(29, 29);
            this.LifeCheck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LifeCheck2.TabIndex = 15;
            this.LifeCheck2.TabStop = false;
            // 
            // LifeCheck1
            // 
            this.LifeCheck1.BackColor = System.Drawing.Color.Transparent;
            this.LifeCheck1.Image = global::TeamProjectDemo.Properties.Resources.check_skull;
            this.LifeCheck1.Location = new System.Drawing.Point(54, 13);
            this.LifeCheck1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LifeCheck1.Name = "LifeCheck1";
            this.LifeCheck1.Size = new System.Drawing.Size(28, 29);
            this.LifeCheck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LifeCheck1.TabIndex = 14;
            this.LifeCheck1.TabStop = false;
            // 
            // speed_txt
            // 
            this.speed_txt.AutoSize = true;
            this.speed_txt.BackColor = System.Drawing.Color.Transparent;
            this.speed_txt.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.speed_txt.ForeColor = System.Drawing.Color.OrangeRed;
            this.speed_txt.Location = new System.Drawing.Point(417, 26);
            this.speed_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_txt.Name = "speed_txt";
            this.speed_txt.Size = new System.Drawing.Size(118, 19);
            this.speed_txt.TabIndex = 19;
            this.speed_txt.Text = "LEVEL 1!!";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TeamProjectDemo.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 436);
            this.ControlBox = false;
            this.Controls.Add(this.speed_txt);
            this.Controls.Add(this.LifeCheck5);
            this.Controls.Add(this.LifeCheck4);
            this.Controls.Add(this.LifeCheck3);
            this.Controls.Add(this.LifeCheck2);
            this.Controls.Add(this.LifeCheck1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heart_hpbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hp_num);
            this.Controls.Add(this.jokboCheck5);
            this.Controls.Add(this.jokboCheck4);
            this.Controls.Add(this.jokboCheck3);
            this.Controls.Add(this.jokboCheck2);
            this.Controls.Add(this.jokboCheck1);
            this.Controls.Add(this.Hpbar);
            this.Controls.Add(this.Fullbar);
            this.Controls.Add(this.score_num);
            this.Controls.Add(this.Back_Hpbar);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ViewForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ViewForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Fullbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hpbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Hpbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokboCheck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokboCheck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokboCheck3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokboCheck4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokboCheck5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_hpbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCheck5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCheck4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCheck3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCheck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCheck1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score_num;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox Fullbar;
        private System.Windows.Forms.PictureBox Hpbar;
        private System.Windows.Forms.PictureBox Back_Hpbar;
        private System.Windows.Forms.PictureBox jokboCheck1;
        private System.Windows.Forms.PictureBox jokboCheck2;
        private System.Windows.Forms.PictureBox jokboCheck3;
        private System.Windows.Forms.PictureBox jokboCheck4;
        private System.Windows.Forms.PictureBox jokboCheck5;
        private System.Windows.Forms.Label Hp_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox heart_hpbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox LifeCheck5;
        private System.Windows.Forms.PictureBox LifeCheck4;
        private System.Windows.Forms.PictureBox LifeCheck3;
        private System.Windows.Forms.PictureBox LifeCheck2;
        private System.Windows.Forms.PictureBox LifeCheck1;
        private System.Windows.Forms.Label speed_txt;

        public Color Text_Color
        {
            get { return speed_txt.ForeColor; }
            set { speed_txt.ForeColor = value; }
        }



        public string Speed_txt
        {
            get { return speed_txt.Text; }
            set { speed_txt.Text = value; }
        }
        public int Screen_Height
        {
            get { return screen.Height; }
            set { screen.Height = value; }
        }
        public string Label_Text
        {
            get { return score_num.Text; }
            set { score_num.Text = value; }
        }
        public int Hpbar_Size
        {
            get { return Hpbar.Width; }
            set { Hpbar.Width = value; }
        }
        public Image JokboCheck1_image
        {
            get { return jokboCheck1.Image; }
            set { jokboCheck1.Image = value; }
        }
        public Image JokboCheck2_image
        {
            get { return jokboCheck2.Image; }
            set { jokboCheck2.Image = value; }
        }
        public Image JokboCheck3_image
        {
            get { return jokboCheck3.Image; }
            set { jokboCheck3.Image = value; }
        }
        public Image JokboCheck4_image
        {
            get { return jokboCheck4.Image; }
            set { jokboCheck4.Image = value; }
        }
        public Image JokboCheck5_image
        {
            get { return jokboCheck5.Image; }
            set { jokboCheck5.Image = value; }
        }
        public Image LifeCheck1_image
        {
            get { return LifeCheck1.Image; }
            set { LifeCheck1.Image = value; }
        }
        public Image LifeCheck2_image
        {
            get { return LifeCheck2.Image; }
            set { LifeCheck2.Image = value; }
        }
        public Image LifeCheck3_image
        {
            get { return LifeCheck3.Image; }
            set { LifeCheck3.Image = value; }
        }
        public Image LifeCheck4_image
        {
            get { return LifeCheck4.Image; }
            set { LifeCheck4.Image = value; }
        }
        public Image LifeCheck5_image
        {
            get { return LifeCheck5.Image; }
            set { LifeCheck5.Image = value; }
        }





    }
}