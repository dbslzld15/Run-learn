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
    public partial class RankMenu : Form
    {
        protected MenuController _controller;

        public void SetController(MenuController controller)
        {
            this._controller = controller;
        }

        public RankMenu()
        {
            InitializeComponent();

            label1.BackColor = Color.Transparent;
            label1.Parent = this;

            label2.BackColor = Color.Transparent;
            label2.Parent = this;

            label3.BackColor = Color.Transparent;
            label3.Parent = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.RankMenuMove();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            _controller.RankMenuMove();
        }
        private void label3_MouseHover(object sender, EventArgs e)
        {
            _controller.Label3_MouseHover();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            _controller.Label3_MouseLeave();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
