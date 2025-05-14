using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditorKhmylko.classes.figure
{
    internal class LineShape : baseShape
    {
        [JsonProperty("Type")]
        public string Type { get; set; } = "Line";

        [JsonProperty("StartX")]
        public int StartX { get; set; }

        [JsonProperty("StartY")]
        public int StartY { get; set; }

        [JsonProperty("EndX")]
        public int EndX { get; set; }

        [JsonProperty("EndY")]
        public int EndY { get; set; }

        [JsonIgnore]
        public Point startPosition => new Point(StartX, StartY);

        [JsonIgnore]
        public Point endPosition => new Point(EndX, EndY);



        public LineShape(Point start, Point end, Color colorL, float widthL) : base(colorL, widthL)
        {
            StartX = start.X;
            StartY = start.Y;
            EndX = end.X;
            EndY = end.Y;
        }

        public override void Draw(Graphics graphics)
        {
             
            graphics.DrawLine(pen, startPosition, endPosition);
        }
        //public override Dictionary<string, object> GetShapeData()
        //{
        //    return new Dictionary<string, object>
        //    {
        //         { "Type", "Line" },
        //         { "StartX", startPosition.X },
        //         { "StartY", startPosition.Y },
        //         { "EndX", endPosition.X },
        //         { "EndY", endPosition.Y },
        //         { "StrokeColor", ColorLine.ToArgb() },
        //         { "Width", WidthLine }
        //    };
        //}
    }
}
