using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public virtual void Draw() 
        // virtual означает, что любой наследник класса Figure может переопределить и
        // написать свою реализацию метода Draw класса Figure
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}