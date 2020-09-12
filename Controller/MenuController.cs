using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace TeamProjectDemo
{
    public class MenuController
    {
        protected MenuForm _menuForm;
        protected ViewForm _gameForm;
        protected GameOver _gameOver;
        protected RankMenu _rankMenu;
        protected HelpMenu _helpMenu;

        protected SpriteController _gameController;

        protected User user;
        protected List<Item> itemList;
        protected List<Obstacle> obstacleList;

        public static String url = "SERVER=127.0.0.1; " +
                                 "USER=root; " +
                                 "DATABASE=rank;" +
                                 "PORT=3306; " +
                                 "PASSWORD=0242; " +
                                 "SSLMODE=NONE";

        protected MySqlConnection mConnection; // DB접속
        protected MySqlCommand mCommand; // 쿼리문
        protected MySqlDataReader mDataReader; // 실행문

        private MySqlDataAdapter mySqlDataAdapter;
        
        public string gradeStr;
        public int score;

        public MenuController(MenuForm _menuForm)
        {
            this._menuForm = _menuForm;
            _menuForm.SetController(this);

            _rankMenu = new RankMenu();
            _rankMenu.SetController(this);

            _helpMenu = new HelpMenu();
            _helpMenu.SetController(this);
        }//생성자

        public void GameStartFunc()
        {
            user = new User(new PictureBox(), Image.FromFile("user.gif"), "user", new Point(380, 260), new Size(50, 60));
            
            _gameForm = new ViewForm();
            _gameForm.Controls.Add(user.Sprite_Picture);

            _gameOver = new GameOver();
            _gameOver.SetController(this);

            itemList = new List<Item>();
            obstacleList = new List<Obstacle>();

            _gameController = new SpriteController(_gameForm, _menuForm, _gameOver, _rankMenu, user, itemList, obstacleList);
            
            _menuForm.Visible = false;
            _gameForm.Show();

        }
        public void RankFunc()
        {
            _menuForm.Visible = false;
            this.DataSearch();
            _rankMenu.Show();
        }

        public void HelpFunc()
        {
            _menuForm.Visible = false;
            _helpMenu.Show();
        }

        public void ExitFunc()
        {
            _menuForm.Close();
            Application.Exit();
        }

        public void MenuMove()
        {
            _gameOver.Visible = false;
            _menuForm.Show();
        }

        public void RankMenuMove()
        {
            _rankMenu.Visible = false;
            _menuForm.Show();
        }

        public void HelpMenuMove()
        {
            _helpMenu.Visible = false;
            _menuForm.Show();
        }

        public void Label1_MouseHover()
        {
            _menuForm.Label1Color = Color.Red;
        }

        public void Label1_MouseLeave()
        {
            _menuForm.Label1Color = Color.Black;
        }

        public void Label2_MouseHover()
        {
            _menuForm.Label2Color = Color.Red;
        }

        public void Label2_MouseLeave()
        {
            _menuForm.Label2Color = Color.Black;
        }

        public void Label3_MouseHover()
        {
            _menuForm.Label3Color = Color.Red;
            _rankMenu.Label3Color = Color.Red;
        }

        public void Label3_MouseLeave()
        {
            _menuForm.Label3Color = Color.Black;
            _rankMenu.Label3Color = Color.Black;
        }

        public void Label4_MouseHover()
        {
            _menuForm.Label4Color = Color.Red;
        }

        public void Label4_MouseLeave()
        {
            _menuForm.Label4Color = Color.Black;
        }

        public void DataInsert()
        {
            try
            {
                score = _gameController.resultScore;
                mConnection = new MySqlConnection(url); // DB접속
                mCommand = new MySqlCommand(); // 쿼리문 생성
                mCommand.Connection = mConnection; // DB에 연결

                if (score < 100)
                {
                    gradeStr = "F";
                }
                else if (score >= 100 && score < 200)
                {
                    gradeStr = "C";
                }
                else if (score >= 200 && score < 300)
                {
                    gradeStr = "C+";
                }
                else if (score >= 300 && score < 400)
                {
                    gradeStr = "B";
                }
                else if (score >= 400 && score < 500)
                {
                    gradeStr = "B+";
                }
                else if (score >= 500 && score < 600)
                {
                    gradeStr = "A";
                }
                else
                {
                    gradeStr = "A+";
                }
                
                mCommand.CommandText = "INSERT INTO ranking (name, score, grade) VALUES ('" + _gameOver.textBox1.Text + "', " + score + ",'" + gradeStr + "')"; // 쿼리문 작성
                
                mConnection.Open(); // DB 오픈
                mDataReader = mCommand.ExecuteReader(); // 쿼리문 실행

                mConnection.Close(); // 사용 후 객체 닫기

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.StackTrace);
            }
        }

        public void DataSearch()
        {
            using (Font fnt = new Font(this._rankMenu.label2.Font.Name, 7)) { this._rankMenu.label2.Font = fnt; }
            
            mConnection = new MySqlConnection(url); // DB접속
            mCommand = new MySqlCommand(); // 쿼리문 생성
            mCommand.Connection = mConnection; // DB에 연결
            mCommand.CommandText = "SELECT * FROM ranking"; // 쿼리문 작성
            mConnection.Open(); // DB 오픈
            mDataReader = mCommand.ExecuteReader(); // 쿼리문 실행

            mySqlDataAdapter = new MySqlDataAdapter("select name AS Name, score as Score, grade as Grade from ranking order by score desc limit 10", mConnection);
            DataSet DS = new DataSet();

            mConnection.Close(); // 사용 후 객체 닫기

            mySqlDataAdapter.Fill(DS);
            _rankMenu.dataGridView1.DataSource = DS.Tables[0];
            _rankMenu.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _rankMenu.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


    }
}