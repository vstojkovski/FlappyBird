using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        private Stage Stage;
        private int generateObstruction;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            Stage = new Stage(Width, Height);
            generateObstruction = 0;
            random = new Random();
            DoubleBuffered = true;
            lbScore.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Stage.Collision() || Stage.Bird.IsHit)
            {
                Stage.Hit();
                Stage.changeBestPoints();
                timer1.Stop();

                DisplayScore displayScore = new DisplayScore(Stage.Points, Stage.BestPoints);

                if (displayScore.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lbStart.Show();
                    Stage = new Stage(Width, Height);
                }
                else
                {
                    this.Close();
                }
            }
            
            if (generateObstruction % 20 == 0)
            {      
                int height = random.Next(150, 300);
                int formHeight = Height - 40;
                int tmp = formHeight - height - 100;
                int y = formHeight - tmp;
                int x = Width + 100;

                Stage.AddObstruction(new Point(x, 0), height, true);
                Stage.AddObstruction(new Point(x, y), formHeight - y, false);


            }
            ++generateObstruction;
            Stage.Move(Width);
            Invalidate(true);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Stage.MoveBird(Height);
            Stage.CalculatePoints();
            lbScore.Text = string.Format("{0}", Stage.Points);
            Invalidate(true);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Stage.Draw(e.Graphics);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Stage.stopBird();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lbStart.Hide();
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (!Stage.Bird.IsHit)
                {
                    timer1.Start();
                    timer2.Start();
                }
                Stage.startBird();
            }
        }
    }
}
