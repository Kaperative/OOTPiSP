using GraphicEditorKhmylko.classes.figure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GraphicEditorKhmylko
{
    public partial class Form1 : Form
    {
        private List<baseShape> shapes; 
        private Point tempStartPoint;
        private Point tempEndPoint;
        Color FillColor = Color.FromArgb(255, 255, 255, 255);
        
        private bool isDrawing;
        private string selectedShape;
        private Pen tempPen;
        private List<Point> curentPoints_BrokenLine = new List<Point> { };
        public Form1()
        {
            InitializeComponent();
            shapes = new List<baseShape> { };
            tempPen = new Pen(Color.Black, 2);
            FillColor= Color.FromArgb(255, 255, 255, 255);

            LineToolStripMenuItem.Image = Properties.Resources.Line;
            rectangleToolStripMenuItem.Image = Properties.Resources.Rectangle;
            EllipsToolStripMenuItem.Image = Properties.Resources.Ellips;
            PolygonToolStripMenuItem.Image = Properties.Resources.Polygon;
            BrokenLineToolStripMenuItem.Image = Properties.Resources.BrokenLine;

            contextMenuStripBaseFigure.ImageScalingSize = new Size(32, 32);
            ShapeButton.ContextMenuStrip = contextMenuStripBaseFigure;

            ShapeButton.Image = Properties.Resources.Line;
            ShapeButton.MouseDown += new MouseEventHandler(ShapeButton_MouseDown);
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectedShape = "Line";
            ColorButton.BackColor= Color.Black;
        }

 

        private void ShapeButton_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Right)
            {

                Point location = new Point(ShapeButton.Left + ShapeButton.Width , ShapeButton.Top);

               
                ShapeButton.ContextMenuStrip.Show(ShapeButton, location);
               
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics); 
            }

            if (isDrawing)
            {
                baseShape temporaryShape = null;
                bool isRotateX = false;
                bool isRotateY = false;
                if ((selectedShape == "Rectangle") || (selectedShape == "Ellips"))
                {
                    if (tempStartPoint.X > tempEndPoint.X)
                    {
                        int tempP = tempStartPoint.X;
                        tempStartPoint.X = tempEndPoint.X;
                        tempEndPoint.X = tempP;
                        isRotateX = true;
                    }
                    if (tempStartPoint.Y > tempEndPoint.Y)
                    {
                        int tempP = tempStartPoint.Y;
                        tempStartPoint.Y = tempEndPoint.Y;
                        tempEndPoint.Y = tempP;
                        isRotateY = true;
                    }


                }

                if (selectedShape == "Line")
                {
                    temporaryShape = new LineShape(tempStartPoint, tempEndPoint, tempPen.Color, tempPen.Width);
                }
                else if (selectedShape == "Rectangle")
                {
                    temporaryShape = new RectangleShape(tempStartPoint, tempEndPoint, tempPen.Color, tempPen.Width,FillColor);
                }
                else if (selectedShape == "Ellips")
                {
                    temporaryShape = new EllipsShape(tempStartPoint, tempEndPoint, tempPen.Color, tempPen.Width, FillColor);
                }
                else if (selectedShape == "Polygon")
                {
                    temporaryShape = new Polygon(tempStartPoint, tempEndPoint, tempPen.Color, tempPen.Width, FillColor,5);
                }
                else if (selectedShape == "BrokenLine")
                {
                    temporaryShape = new BrokenLine (curentPoints_BrokenLine, tempPen.Color, tempPen.Width);
                }

                if (temporaryShape != null)
                {
                    temporaryShape.Draw(e.Graphics);
                }

                if (isRotateX)
                {
                    int tempP = tempStartPoint.X;
                    tempStartPoint.X = tempEndPoint.X;
                    tempEndPoint.X = tempP;
                    isRotateX = false;
                }
                if (isRotateY)
                {
                    int tempP = tempStartPoint.Y;
                    tempStartPoint.Y = tempEndPoint.Y;
                    tempEndPoint.Y = tempP;
                    isRotateY = false;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !string.IsNullOrEmpty(selectedShape))
            {
                tempStartPoint = e.Location; 
                isDrawing = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && selectedShape != "BrokenLine")
            {
                tempEndPoint = e.Location;
                pictureBox1.Invalidate();
            }
           

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedShape == "BrokenLine")
            {
                if (e.Button == MouseButtons.Left)
                { curentPoints_BrokenLine.Add(e.Location); }
                pictureBox1.Invalidate();
            }

            if (e.Button == MouseButtons.Left && isDrawing && !string.IsNullOrEmpty(selectedShape))
            {
         
                tempEndPoint = e.Location;
                baseShape newShape = null;

                if ((selectedShape == "Rectangle") || (selectedShape == "Ellips"))
                {
                    if (tempStartPoint.X > tempEndPoint.X)
                    {
                        int tempP = tempStartPoint.X;
                        tempStartPoint.X = tempEndPoint.X;
                        tempEndPoint.X = tempP;
                        
                    }
                    if (tempStartPoint.Y > tempEndPoint.Y)
                    {
                        int tempP = tempStartPoint.Y;
                        tempStartPoint.Y = tempEndPoint.Y;
                        tempEndPoint.Y = tempP;
                       
                    }


                }

                if (selectedShape == "Line")
                {
                    newShape = new LineShape(tempStartPoint, tempEndPoint, tempPen.Color, tempPen.Width);
                }
                else if (selectedShape == "Rectangle")
                {
                    newShape = new RectangleShape(tempStartPoint, tempEndPoint, tempPen.Color, tempPen.Width, FillColor);
                }
                else if (selectedShape == "Ellips")
                {
                    newShape = new EllipsShape(tempStartPoint, tempEndPoint, tempPen.Color, tempPen.Width, FillColor);
                }
                else if (selectedShape == "Polygon")
                {
                    newShape = new Polygon(tempStartPoint, tempEndPoint, tempPen.Color, tempPen.Width, FillColor, 5);
                }
                else if (selectedShape == "BrokenLine")
                {
                    newShape = new BrokenLine(curentPoints_BrokenLine, tempPen.Color, tempPen.Width);
                   
                }

                if (newShape != null)
                {
                    shapes.Add(newShape);
                }

                
                isDrawing = false;
                pictureBox1.Invalidate();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            pictureBox1.Invalidate();
            selectedShape = "Line";
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Rectangle";
        }
        private void PolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Polygon";
        }
        private void EllipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Ellips";
        }

        private void BrokenLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "BrokenLine";
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    tempPen.Color = colorDialog.Color; 
                    ColorButton.BackColor = colorDialog.Color;
                }
            }
        }
    }
}
