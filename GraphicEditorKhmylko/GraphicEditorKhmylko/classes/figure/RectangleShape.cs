﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditorKhmylko.classes.figure
{
    internal class RectangleShape:baseShape
    {
        protected Point startPosition { set; get; }
        protected Point endPosition { set; get; }

        protected Color ColorFill { get; set; }

        public RectangleShape(Point start, Point end, Color colorL, float widthL, Color colorF) : base(colorL, widthL)
        {
            this.startPosition = start;
            this.endPosition = end;
            ColorFill= colorF;
        }

        public override void Draw(Graphics graphics)
        {
            Brush brush = (ColorFill != Color.FromArgb(255, 255, 255, 255)) ? new SolidBrush(ColorFill) : null;
            Rectangle rect = new Rectangle(startPosition.X, startPosition.Y, Math.Abs(endPosition.X - startPosition.X), Math.Abs(endPosition.Y - startPosition.Y));
            if (brush != null)
            {
                graphics.FillRectangle(brush, rect);
            }
            graphics.DrawRectangle(pen, rect);

        }
    }
}
