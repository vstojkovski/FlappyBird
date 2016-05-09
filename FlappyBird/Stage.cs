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

        public Stage()
        {
            Obstructions = new List<Obstruction>();
        }

        public void AddObstruction(Point point, int height)
        {
            Obstruction o = new Obstruction(point, height);
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

        public void Draw(Graphics g)
        {
            foreach (Obstruction o in Obstructions)
            {
                o.Draw(g);
            }
        }
    }
}
