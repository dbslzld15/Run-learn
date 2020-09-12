using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TeamProjectDemo
{

    public partial class ViewForm : Form
    {
        protected SpriteController _controller;
        protected User user;
        protected List<Item> itemList;
        protected List<Obstacle> obstacleList;
        public Thread moveThdUp;
        

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED 
                return cp;
            }
        }
    
        public ViewForm()
        {
            InitializeComponent();
            Init();
            
        }

        public void Init()
        {
 
        }

        //View에서의 Event처리 Function
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            _controller.jump_count--;
            if (_controller.jump_count > 0)
            {
                //JUMP 메서드 
                if (e.KeyCode == Keys.Up)
                {

                    moveThdUp = new Thread(() =>
                    {
                        _controller.KeyUpFunc();
                        this.Invoke(new MethodInvoker(this.Refresh));

                    });
                    moveThdUp.Start();

                }
            }

            //Sliding 메서드
            if (e.KeyCode == Keys.Down )
            {
                if (_controller.jump_count >= 1)
                    _controller.KeyDownFunc();
            }

            if (e.KeyCode == Keys.Escape)
            {
                _controller.KeyEscapeFunc();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _controller.timerTickFunc();
            _controller.ItemTickFunc();
        }
        
        public void SetController(SpriteController controller)
        {
            this._controller = controller;
        }
        
        private void ViewForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                _controller.KeyDownUpFunc();
            }
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}