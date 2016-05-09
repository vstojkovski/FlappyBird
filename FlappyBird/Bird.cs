using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public class Bird
    {
        public static readonly int RADIUS = 10;
        public static readonly int MOVE_UP =  40;
        public static readonly int MOVE_DOWN = 10;
        public static readonly Color COLOR = Color.OrangeRed;

        public Point Center { get; set; }

        public bool MovingUp { get; set; }

        public bool IsMoving { get; set; }

        public bool IsHit { get; set; }
        public Bird(Point center)
        {
            Center = center;
            MovingUp = false;
            IsMoving = false;
            IsHit = false;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(COLOR);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            b.Dispose();
        }

        public void Move(int height)
        {
            if (!IsHit)
            {
                if (IsMoving == true)
                {
                    if (MovingUp)
                    {
                        Center = new Point(Center.X, Center.Y - MOVE_UP);
                        MovingUp = false;
                    }

                    else if (!MovingUp)
                    {
                        Center = new Point(Center.X, Center.Y + MOVE_DOWN);
                    }

                }
            }
            else
            {
                if(Center.Y + 30 <= 560)
                {
                    Center = new Point(Center.X, Center.Y + 30);
                }
                else
                {
                    Center = new Point(Center.X, 550);
                }
            }
            
        }

        public void MoveBottom()
        {
            Center = new Point(Center.X, Center.Y + 50);
        }
    }
}
