using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GraphicEditorKhmylko
{
    public abstract class baseShape
{
        [JsonProperty("StrokeColor")]
        public Color StrokeColor { get; set; }

        [JsonProperty("Width")]
        public float WidthLine { get; set; }

        [JsonIgnore]
        public Pen pen;

        public baseShape(Color colorL, float widthL)
        {

            StrokeColor = colorL;
            WidthLine = widthL;
            pen = new Pen(StrokeColor, WidthLine);
        }

        public abstract void Draw(Graphics graphics);

       // public abstract Dictionary<string, object> GetShapeData();
    }
}
