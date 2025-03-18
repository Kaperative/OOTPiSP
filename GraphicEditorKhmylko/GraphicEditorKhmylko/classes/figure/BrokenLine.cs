using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditorKhmylko.classes.figure
{
    internal class BrokenLine: baseShape
    {

        List<Point> points;
 

        public BrokenLine(List<Point> ps, Color colorL, float widthL) : base(colorL, widthL)
        {  
            points = ps;
        }

        public override void Draw(Graphics graphics)
        {
            
            for (int i = 0; i < points.Count-1; i++)
            {
                graphics.DrawLine(pen, points[i], points[i+1]);
            }

        }

    }
}
