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
    public partial class HelpMenu : Form
    {
        protected MenuController _controller;

        public void SetController(MenuController controller)
        {
            this._controller = controller;
        }

        public HelpMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _controller.HelpMenuMove();
        }
    }
}
