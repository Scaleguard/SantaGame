using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaGame
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int objectSpeed = 6;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Santa.Top += gravity;
            Tree.Left -= objectSpeed;
            House.Left -= objectSpeed;
            HouseTwo.Left -= objectSpeed;
            Snowflake.Left -= objectSpeed;
            Score.Text = $"score: {score}";
            //The moon will not move 

            if (Tree.Left < -100)
            {
                Tree.Left = 500;
                score++;
            }

            if (Snowflake.Left < -100)
            {
                Snowflake.Left = 600;
                score++;
            }

            if (House.Left < -100)
            {
                House.Left = 500;
                score++;
            }

            if (HouseTwo.Left < -100)
            {
                HouseTwo.Left = 500;
                score++;
            }

            if (Santa.Top < -25)
            {
                gameOver();
            }

            if(Santa.Bounds.IntersectsWith(Tree.Bounds) || Santa.Bounds.IntersectsWith(Snowflake.Bounds) || Santa.Bounds.IntersectsWith(ground.Bounds) || Santa.Bounds.IntersectsWith(House.Bounds) || Santa.Bounds.IntersectsWith(HouseTwo.Bounds))
            {
                gameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            Score.Text = $"Game Over!";
            playAgain.Visible = true;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void Santa_Click(object sender, EventArgs e)
        {

        }
    }
}
