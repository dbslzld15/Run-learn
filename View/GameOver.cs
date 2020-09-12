using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProjectDemo
{
    public partial class GameOver : Form
    {
        protected MenuController _controller;

        public GameOver()
        {
            InitializeComponent();
            label1.ForeColor = Color.Red;

            label1.BackColor = Color.Transparent;
            label1.Parent = this;

            label2.BackColor = Color.Transparent;
            label2.Parent = this;
        }

        public void SetController(MenuController controller)
        {
            this._controller = controller;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            _controller.DataInsert();
            _controller.MenuMove();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _controller.MenuMove();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
