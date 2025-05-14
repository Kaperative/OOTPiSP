using GraphicEditorKhmylko;
using GraphicEditorKhmylko.classes.figure;
using GraphicEditorKhmylko.classes.lists;
using GraphicEditorKhmylko.classes.serialization;
using GraphicEditorKhmylko.classes.settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private List<string> shapeKeys = new List<string>();
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
            settingShape.CountOfAngle = 5;
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
            shapes = undoRedoShapes.shapes;
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }

            if (settingShape.isDrawing && selectedShapeKey != null)
            {
                baseShape temporaryShape = null;
                settingShape.currentBrokenLinePoints.Add(settingShape.endPosition);
                temporaryShape = shapeFactory[selectedShapeKey]();
                settingShape.currentBrokenLinePoints.Remove(settingShape.endPosition);
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
                settingShape.startPosition = e.Location;
                settingShape.isDrawing = true;
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (settingShape.isDrawing)
            {
                settingShape.endPosition = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && settingShape.isDrawing)
            {
               
                    settingShape.currentBrokenLinePoints.Add(e.Location);
                    settingShape.endPosition = e.Location;
                    baseShape temporaryShape = shapeFactory[selectedShapeKey]();
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
                settingShape.currentBrokenLinePoints.Clear();
                selectedShapeKey = key;
                ShapeButton.Image = menuItem.Image;
            }
        }
        private void LoadPlugins()
        {
            string pluginsPath = @"C:\Users\user\Desktop\4 сем\OOP\OOTPiSP\GraphicEditorKhmylko\GraphicEditorKhmylko\Plugins";

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
            else
                return;

                shapeFactory[key] = () => (baseShape)Activator.CreateInstance(
                    shapeType,
                    settingShape.startPosition,
                    settingShape.endPosition,
                    settingShape.StrokeColor,
                    settingShape.Width,
                    settingShape.FillColor
                );
            Tag = key;
            Image tempImage = Properties.Resources.Undefine;
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
                factory: () => new LineShape(settingShape.startPosition, settingShape.endPosition, settingShape.StrokeColor, settingShape.Width)
            );

            AddShape(
                key: "Rectangle",
                name: "Rectangle",
                icon: Properties.Resources.Rectangle,
                factory: () => new RectangleShape(settingShape.startPosition, settingShape.endPosition, settingShape.StrokeColor, settingShape.Width, settingShape.FillColor)
            );

            AddShape(
                key: "Ellips",
                name: "Ellips",
                icon: Properties.Resources.Ellips,
                factory: () => new EllipsShape(settingShape.startPosition, settingShape.endPosition, settingShape.StrokeColor, settingShape.Width, settingShape.FillColor)
            );

            AddShape(
                key: "Polygon",
                name: "Polygon",
                icon: Properties.Resources.Polygon,
                factory: () => new Polygon(settingShape.startPosition, settingShape.endPosition, settingShape.StrokeColor, settingShape.Width, settingShape.FillColor, settingShape.CountOfAngle)
            );

            AddShape(
                key: "BrokenLine",
                name: "BrokenLine",
                icon: Properties.Resources.BrokenLine,
                factory: () => new BrokenLine(settingShape.currentBrokenLinePoints, settingShape.StrokeColor, settingShape.Width)
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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Сохранить фигуры";
                saveFileDialog.DefaultExt = "json";
                saveFileDialog.FileName = "shapes.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Serialization serialization = new Serialization();
                    if(serialization.SaveShapesToJson(shapes,saveFileDialog.FileName)){
                        MessageBox.Show("Фигуры успешно сохранены!");
                    }
                    else{
                        MessageBox.Show($"Ошибка при сохранении");
                    }
                }
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                Title = "Открыть файл с фигурами",
                DefaultExt = "json",
                FileName = "shapes.json"
            })
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    Deserilization deserilization = new Deserilization(shapeFactory, settingShape);
                    var shapes = deserilization.LoadShapesFromJson(openFileDialog.FileName);

                    undoRedoShapes.shapes = shapes;
                    this.shapes = shapes;
                    pictureBox1.Invalidate();

                    MessageBox.Show("Фигуры успешно загружены!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (settingShape.currentBrokenLinePoints.Count >= 2)
            {
                var brokenLine = new BrokenLine(new List<Point>(settingShape.currentBrokenLinePoints),
                                              settingShape.StrokeColor,
                                              settingShape.Width);
                undoRedoShapes.AddShape(brokenLine);
                settingShape.currentBrokenLinePoints.Clear();
                settingShape.isDrawing = false;
                pictureBox1.Invalidate();
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            settingShape.CountOfAngle = trackBar2.Value;
        }
    }
}
