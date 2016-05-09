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
            Stage = new Stage();
            generateObstruction = 0;
            random = new Random();
            DoubleBuffered = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(generateObstruction % 20 == 0)
            {      
                int height = random.Next(150, 300);

                int tmp = 560 - height - 100;
                int y = 560 - tmp;
                int x = 900;

                Stage.AddObstruction(new Point(x, 0), height);
                Stage.AddObstruction(new Point(x, y), 560 - y);

            }
            ++generateObstruction;
            Stage.Move(Width);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Stage.Draw(e.Graphics);
        }
    }
}
