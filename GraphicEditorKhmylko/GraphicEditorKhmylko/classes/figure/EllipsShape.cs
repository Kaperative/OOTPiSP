﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditorKhmylko.classes.figure
{
    internal class EllipsShape: baseShape
    {
        protected Point startPosition { set; get; }
        protected Point endPosition { set; get; }

        protected Color ColorFill { get; set; }

        public EllipsShape(Point start, Point end, Color colorL, float widthL, Color colorF) : base(colorL, widthL)
        {
            this.startPosition = start;
            this.endPosition = end;
            this.ColorFill = colorF;
        }

        public override void Draw(Graphics graphics)
        {
            AdjustCoordinates();
            Brush brush = (ColorFill != Color.FromArgb(255, 255, 255, 255)) ? new SolidBrush(ColorFill) : null;
            Rectangle rect = new Rectangle(startPosition.X, startPosition.Y, Math.Abs(endPosition.X-startPosition.X), Math.Abs(endPosition.Y - startPosition.Y));
            if (brush != null)
            {
                graphics.FillEllipse(brush, rect);
            }
          
            graphics.DrawEllipse(pen, rect);
        }
        public void AdjustCoordinates()
        {
            if (startPosition.X > endPosition.X)
            {
                int temp = startPosition.X;
                startPosition = new Point(endPosition.X, startPosition.Y);
                endPosition = new Point(temp, endPosition.Y);
            }
            if (startPosition.Y > endPosition.Y)
            {
                int temp = startPosition.Y;
                startPosition = new Point(startPosition.X, endPosition.Y);
                endPosition = new Point(endPosition.X, temp);
            }
        }
    }
}
