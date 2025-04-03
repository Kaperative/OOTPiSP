using GraphicEditorKhmylko;
using GraphicEditorKhmylko.classes.figure;
using GraphicEditorKhmylko.classes.lists;
using GraphicEditorKhmylko.classes.settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GraphicEditorKhmylko
{
    public partial class Form1 : Form
    {
        private List<baseShape> shapes;
        private settingsTempShape settingShape = new settingsTempShape();
        private UndoRedoShapes undoRedoShapes = new UndoRedoShapes();

        private List<string> shapeKeys = new List<string>(); // check consist of

        private List<Point> currentBrokenLinePoints = new List<Point> { };
        private Dictionary<string, Func<baseShape>> shapeFactory = new Dictionary<string, Func<baseShape>>();
        private string selectedShapeKey;

        public Form1()
        {
            InitializeComponent();
            InitializeDefaultShapes();
            shapes = new List<baseShape> { };

            settingShape.FillColor = Color.FromArgb(255, 255, 255, 255);
            contextMenuStripBaseFigure.ImageScalingSize = new Size(32, 32);
            ShapeButton.ContextMenuStrip = contextMenuStripBaseFigure;
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlugins();
            ColorButton.BackColor = Color.Black;
        }

        private void AddShape(string key, string name, Image icon, Func<baseShape> factory)
        {
            if (!shapeKeys.Contains(key))
                shapeKeys.Add(key);

            shapeFactory[key] = factory;


            var menuItem = new ToolStripMenuItem(name)
            {
                Tag = key,
                Image = icon
            };
            menuItem.Click += ShapeMenuItem_Click;
            contextMenuStripBaseFigure.Items.Add(menuItem);
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            shapes = undoRedoShapes.Shapes;
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }

            if (settingShape.isDrawing && selectedShapeKey != null)
            {
                baseShape temporaryShape = null;
                temporaryShape = shapeFactory[selectedShapeKey]();

                if (temporaryShape != null)
                {
                    temporaryShape.Draw(e.Graphics);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                settingShape.tempStartPoint = e.Location;
                settingShape.isDrawing = true;
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (settingShape.isDrawing && selectedShapeKey != "BrokenLine")
            {
                settingShape.tempEndPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (selectedShapeKey == "BrokenLine")
            {
                if (e.Button == MouseButtons.Left)
                { currentBrokenLinePoints.Add(e.Location); }

                pictureBox1.Invalidate();
            }

            if (e.Button == MouseButtons.Left && settingShape.isDrawing && selectedShapeKey != null)
            {

                settingShape.tempEndPoint = e.Location;
                baseShape temporaryShape = null;
                temporaryShape = shapeFactory[selectedShapeKey]();

                if (temporaryShape != null)
                {
                    undoRedoShapes.AddShape(temporaryShape);
                }
                settingShape.isDrawing = false;
                pictureBox1.Invalidate();
            }
        }



        private void ShapeMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.Tag is string key)
            {
                selectedShapeKey = key;
                ShapeButton.Image = menuItem.Image;
            }
        }
        private void LoadPlugins()
        {
            string pluginsPath = "C:\\Users\\user\\Desktop\\Новая папка (4)\\OOTPiSP\\GraphicEditorKhmylko\\GraphicEditorKhmylko\\Plugins\\";

            if (!Directory.Exists(pluginsPath))
            {
                Directory.CreateDirectory(pluginsPath);
            }

            foreach (string dll in Directory.GetFiles(pluginsPath, "*.dll"))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(dll);

                    foreach (Type type in assembly.GetTypes())
                    {
                        if (type.IsSubclassOf(typeof(baseShape)) && !type.IsAbstract)
                        {
                            AddPlugin(type);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки плагина {dll}: {ex.Message}");
                }
            }
        }


        private void AddPlugin(Type shapeType)
        {
            string key = shapeType.Name;

            if (!shapeKeys.Contains(key))
                shapeKeys.Add(key);

            shapeFactory[key] = () => (baseShape)Activator.CreateInstance(
                shapeType,
                settingShape.tempStartPoint,
                settingShape.tempEndPoint,
                settingShape.StrokeColor,
                settingShape.Width,
                settingShape.FillColor
            );
            Tag = key;
            Image tempImage = (System.Drawing.Image)Properties.Resources.Undefine;

            AddShape(key, key, tempImage, shapeFactory[key]);

        }


        private void addPlugin_Click(object sender, EventArgs e)
        {
            LoadPlugins();
        }

        private void InitializeDefaultShapes()
        {
            AddShape(
                key: "Line",
                name: "Line",
                icon: Properties.Resources.Line,
                factory: () => new LineShape(settingShape.tempStartPoint, settingShape.tempEndPoint, settingShape.StrokeColor, settingShape.Width)
            );

            AddShape(
                key: "Rectangle",
                name: "Rectangle",
                icon: Properties.Resources.Rectangle,
                factory: () => new RectangleShape(settingShape.tempStartPoint, settingShape.tempEndPoint, settingShape.StrokeColor, settingShape.Width, settingShape.FillColor)
            );

            AddShape(
                key: "Ellips",
                name: "Ellips",
                icon: Properties.Resources.Ellips,
                factory: () => new EllipsShape(settingShape.tempStartPoint, settingShape.tempEndPoint, settingShape.StrokeColor, settingShape.Width, settingShape.FillColor)
            );

            AddShape(
                key: "Polygon",
                name: "Polygon",
                icon: Properties.Resources.Polygon,
                factory: () => new Polygon(settingShape.tempStartPoint, settingShape.tempEndPoint, settingShape.StrokeColor, settingShape.Width, settingShape.FillColor, 5)
            );

            AddShape(
                key: "BrokenLine",
                name: "BrokenLine",
                icon: Properties.Resources.BrokenLine,
                factory: () => new BrokenLine(currentBrokenLinePoints, settingShape.StrokeColor, settingShape.Width)
            );
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            settingShape.Width = trackBar1.Value;
        }

        private void buttonUNDO_Click(object sender, EventArgs e)
        {
            undoRedoShapes.Undo();
            pictureBox1.Invalidate();
        }

        private void buttonREDO_Click(object sender, EventArgs e)
        {
            undoRedoShapes.Redo();
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    settingShape.FillColor = colorDialog.Color;
                    buttonFillColor.BackColor = colorDialog.Color;
                }
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    settingShape.StrokeColor = colorDialog.Color;
                    ColorButton.BackColor = colorDialog.Color;
                }
            }
        }
        private void ShapeButton_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                Point location = new Point(ShapeButton.Left + ShapeButton.Width, ShapeButton.Top);
                ShapeButton.ContextMenuStrip.Show(ShapeButton, location);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          //  undoRedoShapes.SaveShapes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // undoRedoShapes.LoadShapes();
        }
    }
}
