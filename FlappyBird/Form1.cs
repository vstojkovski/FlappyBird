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
            if (Stage.Collision())
            {
                Stage.Hit();
                timer1.Stop();
            }
            if (generateObstruction % 20 == 0)
            {      
                int height = random.Next(150, 300);

                int tmp = 560 - height - 100;
                int y = 560 - tmp;
                int x = 900;

                Stage.AddObstruction(new Point(x, 0), height, true);
                Stage.AddObstruction(new Point(x, y), 560 - y, false);


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
            if (!Stage.Bird.IsHit)
            {
                timer1.Start();
                timer2.Start();
            }
            Stage.startBird();
        }

    }
}
