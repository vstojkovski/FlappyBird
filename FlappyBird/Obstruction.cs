using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public class Obstruction
    {
        public static readonly int WIDTH = 80;
        public static readonly int SPEED = 10;

        public Point Point { get; set; }

        public int Height { get; set; }

        public bool Delete { get; set; }

        public bool IsPassed { get; set; }

        public Obstruction(Point point, int height, bool isPassed)
        {
            Point = point;
            Height = height;
            Delete = false;
            IsPassed = isPassed;
        }

        public void Move()
        {
            Point = new Point(Point.X - SPEED, Point.Y);
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.GreenYellow);
            g.FillRectangle(brush, Point.X, Point.Y, WIDTH, Height);
            brush.Dispose();
        }
    }
}
