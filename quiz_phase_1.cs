using projet_tic_tac_toe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_tic_tac_toe
{
    public partial class jeu_snake : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        int maxWidth;
        int maxHeight;
        Random rand = new Random();
        bool goLeft, goRight, goDown, goUp;
        int Width = 15;
        int Height = 15;
        string directions = "left";
        int score;
        SoundPlayer player = new SoundPlayer(@"C:\Users\jerbi\Documents\1 BI\des projets\les jeux snake quiz et xo en c #\projet tic tac toe et snake en c#\projet tic tac toe\wav\Super-Mario-Bros.wav");
        public jeu_snake()
        {
            InitializeComponent();
            
        }


       
       

        private void keyisdown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Left && directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && directions != "up")
            {
                goDown = true;
            }



        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.BlueViolet;
                }
                else
                {
                    snakeColour = Brushes.DarkBlue;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Width,
                    Snake[i].Y * Height,
                    Width, Height
                    ));
            }

            if (score != 50 && score != 150 && score != 250)
            {
                canvas.FillEllipse(Brushes.Red, new Rectangle
                (
                food.X * Width,
                food.Y * Height,
                Width, Height
                ));
            }
            else
            {
                canvas.FillEllipse(Brushes.Yellow, new Rectangle
                (
                food.X * Width+10,
                food.Y * Height+10,
                Width+10, Height+10
                ));
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (goLeft)
            {
                directions = "left";
            }
            if (goRight)
            {
                directions = "right";
            }
            if (goDown)
            {
                directions = "down";
            }
            if (goUp)
            {
               directions = "up";
            }
            

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }

                    }


                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }


            pbCanvas.Invalidate();
        }

        private void joue_btn_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            RestartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            player.Play();
            player.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void RestartGame()
        {
            maxWidth = pbCanvas.Width / Width - 1;
            maxHeight = pbCanvas.Height / Height - 1;

            Snake.Clear();

            joue_btn.Enabled = false;
           
            score = 0;
            txtScore.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); 

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            gameTimer.Start();

        }

        private void EatFood()
        {
            if (score != 50 && score != 150 && score != 250)
                score += 10;
            else
                score += 30;

            txtScore.Text = "Score: " + score;
            if (score != 80 && score != 180 && score != 280)
            {
                Circle body = new Circle
                {
                    X = Snake[Snake.Count - 1].X,
                    Y = Snake[Snake.Count - 1].Y
                };

                Snake.Add(body);
            }
            else
            {
                for(int i=0; i<3;i++)
                {
                    Circle body = new Circle
                    {
                        X = Snake[Snake.Count - 1].X,
                        Y = Snake[Snake.Count - 1].Y
                    };

                    Snake.Add(body);
                }
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };


        }

        private void GameOver()
        {
            gameTimer.Stop();
            MessageBox.Show("you lost :(","game over",MessageBoxButtons.OK,MessageBoxIcon.Information);
            player.Stop();
            button1.Enabled = true;
            button2.Enabled = true;
            joue_btn.Enabled = true;
            
        }
    }     
   
}
