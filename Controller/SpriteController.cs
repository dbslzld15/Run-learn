using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace TeamProjectDemo
{
    public class SpriteController
    {
        protected ViewForm _gameForm;
        protected MenuForm _menuForm;
        protected GameOver _gameOver;
        protected RankMenu _rankMenu;

        public int resultScore;
        public int item_Speed = -5;
        public int obstacle_Speed = -5;
        public int jump_count = 2;

        protected User user;
        protected List<Item> itemList;
        protected List<Obstacle> obstacleList;

        public int checkThd = 0;

        public Item itemtemp;

        public SpriteController(ViewForm _gameForm, MenuForm _menuForm, GameOver _gameOver, RankMenu _rankMenu, User user, List<Item> itemList, List<Obstacle> obstacleList)
        {
            this._gameForm = _gameForm;
            this._menuForm = _menuForm;
            this._gameOver = _gameOver;
            this._rankMenu = _rankMenu;
            this.user = user;
            this.itemList = itemList;
            this.obstacleList = obstacleList;

            _gameForm.SetController(this);
        }

        public void KeyUpFunc()
        {
            if (jump_count == 2) user.DoubleJump = false;
            if (user.Jump != true)
            {
                user.Jump = true;
                user.Force = user.Gravitiy;
                //superCount Check
                if (user.SuperCount == 5)
                {
                    user.Sprite_Image = Properties.Resources.super;
                }
                else
                {
                    user.Sprite_Image = Properties.Resources.jump;
                }
            }
            else
            {
                user.Force = user.Gravitiy;
                user.DoubleJump = true;

            }
        }//KeyUpFunc()

        public void KeyDownFunc()
        {
            if (user.Slide != true && user.Jump == false && user.DoubleJump == false)
            {
                user.Slide = true;
                if (user.SuperCount != 5)
                {
                    user.Sprite_Image = Properties.Resources.tackle;
                }
                else
                {
                    user.Sprite_Image = Properties.Resources.super;
                }
            }
        }


        public void KeyDownUpFunc()
        {
            if (user.SuperCount != 5)
            {
                user.Sprite_Image = Properties.Resources.user;
            }
            else
            {
                user.Sprite_Image = Properties.Resources.super;
            }
        }



        public void KeyEscapeFunc()
        {
            _gameForm.Close();
            _menuForm.Show();
        }




        public void ItemTickFunc()
        {

            foreach (Item tempItem in itemList)
            {
                _gameForm.Controls.Add(tempItem.Sprite_Picture);
            }
            // 핫식스,obstacle 지속 생성  + 족보 + 소주 intervalSum==1000까지 ( 난이도 1)
            if (user.IntervalSum <= 1000)
            {
                Random rnd = new Random();

                int rndtemp = rnd.Next(-1, 3);

                if (user.IntervalSum % 140 == 0)
                {
                    obstacleList.Add(new Obstacle(new PictureBox(), Properties.Resources.beer, "Beer", new Point(800, 370), new Size(50, 50)));

                    // 족보
                    foreach (Item tempItem in itemList)
                    {
                        _gameForm.Controls.Add(tempItem.Sprite_Picture);
                    }
                    foreach (Obstacle tempObstacle in obstacleList)
                    {
                        _gameForm.Controls.Add(tempObstacle.Sprite_Picture);
                    }
                }
                else if (user.IntervalSum % 30 == 0)
                {
                    itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800, 370), new Size(30, 30)));
                }
                else if (user.IntervalSum % 111 == 0)
                {
                    itemList.Add(new Item(new PictureBox(), Properties.Resources.jokbo, "jokbo", new Point(800, 250), new Size(30, 30)));
                }
                else if (user.IntervalSum % 75 == 0)
                {
                    itemList.Add(new Item(new PictureBox(), Properties.Resources.hotsix, "hotsix", new Point(800, 150 + 20 * rndtemp), new Size(30, 30)));
                }
            }

            //난이도 2
            else if (user.IntervalSum <= 2000)
            {
                if (user.IntervalSum % 140 == 0)
                {
                    Random rnd = new Random();

                    int rndtemp = rnd.Next(1, 3);

                    for (int i = 0; i < 5; i++)
                    {
                        if (i < 2)
                        {
                            itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 240 - 60 * i), new Size(30, 30)));
                        }
                        else if (i == 2)
                        {
                            if (rndtemp == 1)
                            {
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 180 - 30 * i), new Size(30, 30)));
                            }
                            else
                            {
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.soju, "soju", new Point(800 + i * 50, 180 - 30 * i), new Size(30, 45)));
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 240), new Size(30, 45)));
                            }
                            obstacleList.Add(new Obstacle(new PictureBox(), Properties.Resources.beer, "Beer", new Point(800 + 50 * i, 370), new Size(50, 50)));
                        }
                        else
                        {
                            itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 120 + 60 * (i - 2)), new Size(30, 30)));
                        }
                    }
                    // 족보
                    if (user.IntervalSum % 420 == 0)
                    {
                        itemList.Add(new Item(new PictureBox(), Properties.Resources.jokbo, "jokbo", new Point(900, 200), new Size(30, 30)));
                    }
                    foreach (Item tempItem in itemList)
                    {
                        _gameForm.Controls.Add(tempItem.Sprite_Picture);
                    }
                    foreach (Obstacle tempObstacle in obstacleList)
                    {
                        _gameForm.Controls.Add(tempObstacle.Sprite_Picture);
                    }
                }
                else if (user.IntervalSum % 30 == 0)
                {
                    itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800, 370), new Size(30, 30)));
                }
                else if (user.IntervalSum % 113 == 0)
                {
                    itemList.Add(new Item(new PictureBox(), Properties.Resources.hotsix, "hotsix", new Point(800, 150), new Size(30, 30)));
                }
            }
            //난이도 3
            else if (user.IntervalSum <= 3000)
            {
                if (user.IntervalSum % 140 == 0)
                {
                    Random rnd = new Random();

                    int rndtemp = rnd.Next(1, 3);

                    for (int i = 0; i < 5; i++)
                    {
                        if (i < 2)
                        {
                            itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 240 - 60 * i), new Size(30, 30)));
                        }
                        else if (i == 2)
                        {
                            if (rndtemp == 1)
                            {
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 180 - 30 * i), new Size(30, 30)));
                            }
                            else
                            {
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.soju, "soju", new Point(800 + i * 50, 180 - 30 * i), new Size(30, 45)));
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 240), new Size(30, 45)));
                            }
                            obstacleList.Add(new Obstacle(new PictureBox(), Properties.Resources.beer, "Beer", new Point(800 + 50 * i, 370), new Size(50, 50)));
                        }
                        else
                        {
                            itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 120 + 60 * (i - 2)), new Size(30, 30)));
                        }
                    }
                    // 족보
                    if (user.IntervalSum % 420 == 0)
                    {
                        itemList.Add(new Item(new PictureBox(), Properties.Resources.jokbo, "jokbo", new Point(900, 200), new Size(30, 30)));
                    }
                    foreach (Item tempItem in itemList)
                    {
                        _gameForm.Controls.Add(tempItem.Sprite_Picture);
                    }
                    foreach (Obstacle tempObstacle in obstacleList)
                    {
                        _gameForm.Controls.Add(tempObstacle.Sprite_Picture);
                    }
                }
                else if (user.IntervalSum % 30 == 0)
                {
                    itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800, 370), new Size(30, 30)));
                }
                else if (user.IntervalSum % 60 == 0)
                {
                    itemList.Add(new Item(new PictureBox(), Properties.Resources.soju, "soju", new Point(850, 370), new Size(30, 45)));
                }
            }


            else //final 라운드
            {
                if (user.IntervalSum % 140 == 0)
                {
                    Random rnd = new Random();

                    int rndtemp = rnd.Next(1, 3);

                    for (int i = 0; i < 5; i++)
                    {
                        if (i < 2)
                        {
                            if (rndtemp == 1)
                            {
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.soju, "soju", new Point(800 + i * 50, 240 - 60 * i), new Size(30, 45)));
                            }
                            else
                            {
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 240 - 60 * i), new Size(30, 30)));
                            }
                        }
                        else if (i == 2)
                        {
                            if (rndtemp == 1)
                            {
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 180 - 30 * i), new Size(30, 30)));
                            }
                            else
                            {
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.soju, "soju", new Point(800 + i * 50, 180 - 30 * i), new Size(30, 45)));
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 240), new Size(30, 45)));
                            }
                            obstacleList.Add(new Obstacle(new PictureBox(), Properties.Resources.duck, "duck", new Point(800 + 50 * i, 370), new Size(50, 50)));
                        }
                        else
                        {
                            if (rndtemp == 1)
                            {
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800 + i * 50, 120 + 60 * (i - 2)), new Size(30, 30)));
                            }
                            else
                            {
                                itemList.Add(new Item(new PictureBox(), Properties.Resources.soju, "soju", new Point(800 + i * 50, 120 + 60 * (i - 2)), new Size(30, 45)));

                            }
                        }
                    }
                    // 족보
                    if (user.IntervalSum % 420 == 0)
                    {
                        itemList.Add(new Item(new PictureBox(), Properties.Resources.jokbo, "jokbo", new Point(900, 200), new Size(30, 30)));
                    }
                    foreach (Item tempItem in itemList)
                    {
                        _gameForm.Controls.Add(tempItem.Sprite_Picture);
                    }
                    foreach (Obstacle tempObstacle in obstacleList)
                    {
                        _gameForm.Controls.Add(tempObstacle.Sprite_Picture);
                    }
                }
                else if (user.IntervalSum % 30 == 0)
                {
                    itemList.Add(new Item(new PictureBox(), Properties.Resources.vitamins, "vitamins", new Point(800, 370), new Size(30, 30)));
                }
                else if (user.IntervalSum % 60 == 0)
                {
                    itemList.Add(new Item(new PictureBox(), Properties.Resources.soju, "soju", new Point(850, 370), new Size(30, 45)));
                }
            }

            //item 이동 및 user 충돌 처리 부분 
            Item temp;

            for (int i = itemList.Count - 1; i >= 0; i--)
            {
                temp = itemList[i];

                if (user.checkCollision(temp))
                {
                    if (temp.Sprite_Name == "vitamins")
                    {
                        user.Score += temp.ScoreControl;
                    }
                    if (temp.Sprite_Name == "hotsix") //hotsix랑 부딪히면 score , hp 증가
                    {
                        if (user.Hp <= 180) //hp 최대값 설정하기위해
                        {
                            user.Hp += temp.HpControl;
                        }
                        else
                        {
                            user.Hp = 190;
                        }
                        user.Score += temp.ScoreControl;
                    }
                    //soju 랑 부딪히면 deathCount 증가
                    if (temp.Sprite_Name == "soju")
                    {
                        if (user.SuperCount != 5)
                        {
                            if (user.DeathCount == 0)
                            {
                                _gameForm.LifeCheck1_image = Properties.Resources.skull;
                                user.DeathCount++;
                            }
                            else if (user.DeathCount == 1)
                            {
                                _gameForm.LifeCheck2_image = Properties.Resources.skull;
                                user.DeathCount++;
                            }
                            else if (user.DeathCount == 2)
                            {
                                _gameForm.LifeCheck3_image = Properties.Resources.skull;
                                user.DeathCount++;
                            }
                            else if (user.DeathCount == 3)
                            {
                                _gameForm.LifeCheck4_image = Properties.Resources.skull;
                                user.DeathCount++;
                            }
                            else if (user.DeathCount == 4)
                            {
                                _gameForm.LifeCheck5_image = Properties.Resources.skull;
                                user.DeathCount++;
                            }

                        }
                    }
                    //jokbo 랑 부딪히면 supercount 증가
                    if (temp.Sprite_Name == "jokbo")
                    {
                        if (user.SuperCount == 0)
                        {
                            _gameForm.JokboCheck1_image = Properties.Resources.checkbook;
                            user.SuperCount++;
                        }
                        else if (user.SuperCount == 1)
                        {
                            _gameForm.JokboCheck2_image = Properties.Resources.checkbook;
                            user.SuperCount++;
                        }
                        else if (user.SuperCount == 2)
                        {
                            _gameForm.JokboCheck3_image = Properties.Resources.checkbook;
                            user.SuperCount++;
                        }
                        else if (user.SuperCount == 3)
                        {
                            _gameForm.JokboCheck4_image = Properties.Resources.checkbook;
                            user.SuperCount++;
                        }
                        else if (user.SuperCount == 4)
                        {
                            _gameForm.JokboCheck5_image = Properties.Resources.checkbook;
                            user.SuperCount++;

                            //user.Sprite_Image = Properties.Resources.success;
                            user.Sprite_Size = new Size(120, 120);
                            user.Sprite_Image = Properties.Resources.super;
                        }

                    }
                    //부딛힌 item은 안보이는 곳으로 좌표 봐꾸고 itemList에서 삭제  

                    //temp.Sprite_Picture.Location = new Point(1000, 150);
                    itemList.Remove(temp);
                    temp.Sprite_Picture.Dispose();
                }
                //item의 x좌표가 100미만으로 될 경우 없어지게 함.
                if (temp.Sprite_Picture.Location.X < 10)
                {
                    //item은 안보이는 곳으로 좌표 봐꾸고 itemList에서 삭제    
                    //temp.Sprite_Picture.Location = new Point(1000, 150);
                    itemList.Remove(temp);
                    temp.Sprite_Picture.Dispose();
                }
                else
                {
                    //부딪히지 않으면 아이템의 스피드만큼 이동 

                    this.createnewItemMoveThread(temp);
                    // temp.move(item_Speed, 0);
                    if (user.IntervalSum >= 3040)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Green;
                    }
                    else if (user.IntervalSum % 3040 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Green;
                    }
                    else if (user.IntervalSum % 3030 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Transparent;
                    }
                    else if (user.IntervalSum % 3020 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Green;
                    }
                    else if (user.IntervalSum % 3010 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Transparent;
                    }
                    else if (user.IntervalSum % 3000 == 0 && item_Speed >= -7)
                    {
                        item_Speed--;
                        _gameForm.Speed_txt = "FINAL!!";
                        _gameForm.Text_Color = System.Drawing.Color.Green;
                    }
                    else if (user.IntervalSum % 2040 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Red;
                    }
                    else if (user.IntervalSum % 2030 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Transparent;
                    }
                    else if (user.IntervalSum % 2020 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Red;
                    }
                    else if (user.IntervalSum % 2010 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Transparent;
                    }
                    else if (item_Speed == -7)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Red;

                    }
                    else if (user.IntervalSum % 2000 == 0 && item_Speed >= -6)
                    {
                        item_Speed--;
                        _gameForm.Speed_txt = "LEVEL 3!!";
                        _gameForm.Text_Color = System.Drawing.Color.Red;
                    }
                    else if (user.IntervalSum % 1040 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.DarkBlue;
                    }
                    else if (user.IntervalSum % 1030 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Transparent;
                    }
                    else if (user.IntervalSum % 1020 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.DarkBlue;
                    }
                    else if (user.IntervalSum % 1010 == 0)
                    {
                        _gameForm.Text_Color = System.Drawing.Color.Transparent;
                    }
                    else if (user.IntervalSum % 1000 == 0 && item_Speed >= -5)
                    {
                        _gameForm.Speed_txt = "LEVEL 2!!";
                        _gameForm.Text_Color = System.Drawing.Color.DarkBlue;
                    }
                }

            }

            //Obstacle 이동 및 user 충돌 처리 부분 
            Obstacle temp_Obs;

            for (int i = obstacleList.Count - 1; i >= 0; i--)
            {
                temp_Obs = obstacleList[i];

                if (user.checkCollision(temp_Obs))
                {
                    if (user.SuperCount != 5)
                    {

                        user.Hp += temp_Obs.Hpcontrol; //부딪히면 user의 hp의 -5씩 감소   

                    }
                    //부딛힌 Obstacle은 안보이는 곳으로 좌표 봐꾸고 ObstacleList에서 삭제                     
                    temp_Obs.Sprite_Picture.Location = new Point(1000, 150);
                    obstacleList.Remove(temp_Obs);
                }
                //Obstacle의 x좌표가 100미만으로 될 경우 없어지게 함.
                if (temp_Obs.Sprite_Picture.Location.X < 10)
                {
                    //Obstacle은 안보이는 곳으로 좌표 봐꾸고 ObstacleList에서 삭제    
                    temp_Obs.Sprite_Picture.Dispose();
                    obstacleList.Remove(temp_Obs);
                }
                else
                {
                    //부딪히지 않으면 장애물의 속도만큼 이동함
                    temp_Obs.move(obstacle_Speed, 0);

                    if (user.IntervalSum % 4000 == 0 && obstacle_Speed >= -8)
                    {

                    }
                    else if (user.IntervalSum % 3000 == 0 && obstacle_Speed >= -7)
                    {
                        obstacle_Speed--;
                    }
                    else if (user.IntervalSum % 2000 == 0 && obstacle_Speed >= -6)
                    {
                        obstacle_Speed -= 2;
                    }
                    else if (user.IntervalSum % 1000 == 0 && obstacle_Speed >= -5)
                    {
                    }
                }

            }



        }//itemTickFunc

        public void createnewItemMoveThread(Item item)
        {
            Thread my_thread = new Thread(() =>
            {
                item.move(item_Speed, 0);

                //  item.Sprite_Picture.Invoke(new MethodInvoker(item.Sprite_Picture.Refresh));

            }); // worker thread 생성하기. my_thread.Start();

            my_thread.Start();
            // Console.WriteLine("되는건가");
        }



        public void timerTickFunc()
        {

            //user intervalSum 누적 부분
            user.IntervalSum += 1;

            //DeathCount Check 
            if (user.DeathCount == 5)
            {
                _gameForm.Close();
                _gameOver.Show();
            }
            if (user.Hp < 0) //Hp Check
            {
                resultScore = user.Score;
                _gameForm.Close();
                _gameOver.Show();
            }

            //SuperMode 지속 시간 관련 부분
            if (user.SuperCount == 5)
            {
                if (user.SuperTime == 0)
                {
                    user.SuperTime = 700;
                    user.SuperCount = 0;
                    user.Sprite_Image = Properties.Resources.user;
                    user.Sprite_Size = new Size(60, 66);
                    _gameForm.JokboCheck1_image = Properties.Resources.notebook__2_;
                    _gameForm.JokboCheck2_image = Properties.Resources.notebook__2_;
                    _gameForm.JokboCheck3_image = Properties.Resources.notebook__2_;
                    _gameForm.JokboCheck4_image = Properties.Resources.notebook__2_;
                    _gameForm.JokboCheck5_image = Properties.Resources.notebook__2_;
                }
                user.SuperTime--;
            }

            //점수 등록 부분 
            if (user.IntervalSum % 5 == 0) //스코어 올라가는 속도 조절
            {
                user.Score++;
            }
            _gameForm.Label_Text = "Score: " + user.Score.ToString();

            //user 점프 처리 부분 
            if (user.Jump == true)
            {
                user.Sprite_Top -= user.Force; //점프하면서 떨어짐
                user.Force -= 1;
            }
            if (user.DoubleJump == false)
            {
                jump_count = 2;
                //user.Sprite_Top -= user.Force; //점프하면서 떨어짐
                //user.Force -= 1;
            }

            if (user.Sprite_Top + user.Height >= _gameForm.Screen_Height)
            {
                user.Sprite_Top = _gameForm.Screen_Height - user.Height; //stop falling at bottom
                if (user.Jump == true)
                {
                    //user의 supercount 확인
                    if (user.SuperCount == 5)
                    {
                        user.Sprite_Image = Properties.Resources.super;
                    }
                    else
                    {
                        user.Sprite_Image = Properties.Resources.user;
                    }

                }
                user.Jump = false;
                user.DoubleJump = false;    
                user.Slide = false;
            }
            else
            {
                user.Sprite_Top += 5;
            }



            _gameForm.Hpbar_Size = user.Hp; //hpbar의 가로크기는 user의 hp와 똑같음

            if (user.Hp <= 190) //시간이 지남에따라 hp회복을 위해
            {
                if (user.SuperCount != 5) //슈퍼모드일때 hp고정을 위해
                {

                    if (user.IntervalSum % 40 == 0) //hp올라가는 속도조절을 위해
                    {
                        user.Hp--;
                    }
                }
            }



        }

    }
}