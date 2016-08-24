using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList; //protected -- чтобы лист был виден у наследников

        public virtual void Draw() //virtual -- Любой наследник может переопределить метод
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
