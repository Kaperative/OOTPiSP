
﻿using Newtonsoft.Json;
using System;

using System.Collections.Generic;
using System.Drawing;

namespace GraphicEditorKhmylko.classes.figure
{
    public class BrokenLine : baseShape
    {

        [JsonProperty("Type")]
        public string Type { get; set; } = "BrokenLine";

        [JsonProperty("Points")]
        public List<Point> Points { get; set; }

        public BrokenLine(List<Point> points, Color color, float width)
            : base(color, width)
        {
            Points = new List<Point>(points);

        }

        public override void Draw(Graphics graphics)
        {

            if (Points.Count < 2) return;

            pen.Color = ColorLine;
            pen.Width = WidthLine;
            graphics.DrawLines(pen, Points.ToArray());
        }


        public void ClearPoints()
        {

            Points.Clear();
        }

     
    }
}