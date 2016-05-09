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

        public static readonly int HEIGHT = 300;

        public Point Point { get; set; }

        public int Height { get; set; }

        public bool Delete { get; set; }

        public Obstruction(Point point, int height)
        {
            Point = point;
            Height = height;
            Delete = false;
        }

        public void Move()
        {
            Point = new Point(Point.X - 10, Point.Y);
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Green);
            g.FillRectangle(brush, Point.X, Point.Y, WIDTH, Height);
            brush.Dispose();
        }
    }
}
