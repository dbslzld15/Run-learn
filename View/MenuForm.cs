using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TeamProjectDemo
{
    public partial class MenuForm : Form
    {
      

        protected MenuController _controller;

       
        public MenuForm()
        {
            InitializeComponent();
            
            label1.BackColor = Color.Transparent;
            label1.Parent = this;

        }

        public void SetController(MenuController controller)
        {
            this._controller = controller;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.RankFunc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _controller.ExitFunc();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            _controller.Label1_MouseHover();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            _controller.Label1_MouseLeave();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            _controller.Label2_MouseHover();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            _controller.Label2_MouseLeave();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            _controller.Label3_MouseHover();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            _controller.Label3_MouseLeave();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            _controller.Label4_MouseHover();
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            _controller.Label4_MouseLeave();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            _controller.GameStartFunc();
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            _controller.RankFunc();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            _controller.ExitFunc();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            _controller.HelpFunc();
        }
    }
    
}
