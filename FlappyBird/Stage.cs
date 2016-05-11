using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public class Stage
    {
        public List<Obstruction> Obstructions { get; set;}
        public Bird Bird { get; set; }
        public int Points { get; set; }
        public int BestPoints { get; set; }

        public Stage(int widht, int height, int bestPoints)
        {
            Obstructions = new List<Obstruction>();
            Bird = new Bird(new Point(widht/2, height/2));
            Points = 0;
            BestPoints = bestPoints;
        }

        public void AddObstruction(Point point, int height, bool isPassed)
        {
            Obstruction o = new Obstruction(point, height, isPassed);
            Obstructions.Add(o);
        }

        public void Move(int width)
        {
            foreach (Obstruction o in Obstructions)
            {
                o.Move();
                if(o.Point.X + Obstruction.WIDTH / 2 < 0)
                {
                    o.Delete = true;
                }         
             }

            for (int i= Obstructions.Count - 1; i >=0; --i)
            {
                if (Obstructions[i].Delete)
                {
                    Obstructions.RemoveAt(i);
                }
            }

        }

        public void MoveBird(int height)
        {
            Bird.Move(height);
        }
        public void startBird()
        {
            Bird.IsMoving = true;
            Bird.MovingUp = true;          
        }

        public void stopBird()
        {
            Bird.MovingUp = false;
        }

        public void Draw(Graphics g)
        {
            foreach (Obstruction o in Obstructions)
            {
                o.Draw(g);
            }

            Bird.Draw(g);
        }

        public bool Collision()
        {
            foreach(Obstruction o in Obstructions)
            {
                if(Bird.Center.X < o.Point.X + Obstruction.WIDTH + Bird.RADIUS  && Bird.Center.X + 2 * Bird.RADIUS > o.Point.X && Bird.Center.Y < o.Point.Y + o.Height + Bird.RADIUS  && Bird.RADIUS + Bird.Center.Y > o.Point.Y)
                {
                    return true;
                }
            }
            return false;
        }

        public bool BirdPosition()
        {
            if(Bird.Center.Y == 560)
            {
                return true;
            }
            return false;
        }
        public void Hit()
        {
            Bird.IsHit = true;
        }

        public void CalculatePoints()
        {
            foreach (Obstruction o in Obstructions)
            {
                if (Bird.Center.X + Bird.RADIUS >= o.Point.X + Obstruction.WIDTH / 2 && !o.IsPassed)
                {
                    o.IsPassed = true;
                    Points++;
                }
               
            }
        }

        public void changeBestPoints()
        {
            if(BestPoints < Points)
            {
                BestPoints = Points;
            }
        }
    }
}
