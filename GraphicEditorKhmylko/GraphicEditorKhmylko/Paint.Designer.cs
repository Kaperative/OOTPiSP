﻿using System.Windows.Forms;

namespace GraphicEditorKhmylko
{
    partial class Paint
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShapeButton = new System.Windows.Forms.Button();
            this.menuStripUP = new System.Windows.Forms.MenuStrip();
            this.menuStripUP_FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStripBaseFigure = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.buttonFillColor = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.addPlugin = new System.Windows.Forms.Button();
            this.buttonUNDO = new System.Windows.Forms.Button();
            this.buttonREDO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();

            this.trackBar2 = new System.Windows.Forms.TrackBar();

            this.panel1.SuspendLayout();
            this.menuStripUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.ShapeButton);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 467);
            this.panel1.TabIndex = 0;
            // 
            // ShapeButton
            // 
            this.ShapeButton.Location = new System.Drawing.Point(3, 14);
            this.ShapeButton.Name = "ShapeButton";
            this.ShapeButton.Size = new System.Drawing.Size(50, 45);
            this.ShapeButton.TabIndex = 0;
            this.ShapeButton.UseVisualStyleBackColor = true;
            this.ShapeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShapeButton_MouseDown);
            // 
            // menuStripUP
            // 
            this.menuStripUP.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStripUP.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripUP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripUP_FILE});
            this.menuStripUP.Location = new System.Drawing.Point(0, 0);
            this.menuStripUP.Name = "menuStripUP";
            this.menuStripUP.Size = new System.Drawing.Size(1074, 28);
            this.menuStripUP.TabIndex = 1;
            this.menuStripUP.Text = "menuStrip1";
            // 
            // menuStripUP_FILE
            // 
            this.menuStripUP_FILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.menuStripUP_FILE.Name = "menuStripUP_FILE";
            this.menuStripUP_FILE.Size = new System.Drawing.Size(46, 24);
            this.menuStripUP_FILE.Text = "FIle";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem3.Text = "1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem4.Text = "2";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem5.Text = "3";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem6.Text = "4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(67, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(892, 467);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // contextMenuStripBaseFigure
            // 
            this.contextMenuStripBaseFigure.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripBaseFigure.Name = "contextMenuStripBaseFigure";
            this.contextMenuStripBaseFigure.Size = new System.Drawing.Size(61, 4);
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.Black;
            this.ColorButton.Location = new System.Drawing.Point(129, 32);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(43, 38);
            this.ColorButton.TabIndex = 3;
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // buttonFillColor
            // 
            this.buttonFillColor.BackColor = System.Drawing.Color.White;
            this.buttonFillColor.Location = new System.Drawing.Point(191, 32);
            this.buttonFillColor.Name = "buttonFillColor";
            this.buttonFillColor.Size = new System.Drawing.Size(43, 38);
            this.buttonFillColor.TabIndex = 4;
            this.buttonFillColor.UseVisualStyleBackColor = false;
            this.buttonFillColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(244, 32);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(243, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // addPlugin
            // 
            this.addPlugin.Location = new System.Drawing.Point(823, 32);
            this.addPlugin.Name = "addPlugin";
            this.addPlugin.Size = new System.Drawing.Size(136, 38);
            this.addPlugin.TabIndex = 7;
            this.addPlugin.Text = "add plugin";
            this.addPlugin.UseVisualStyleBackColor = true;
            this.addPlugin.Click += new System.EventHandler(this.addPlugin_Click);
            // 
            // buttonUNDO
            // 
            this.buttonUNDO.Location = new System.Drawing.Point(607, 31);
            this.buttonUNDO.Name = "buttonUNDO";
            this.buttonUNDO.Size = new System.Drawing.Size(75, 39);
            this.buttonUNDO.TabIndex = 8;
            this.buttonUNDO.Text = "CTRL+Z";
            this.buttonUNDO.UseVisualStyleBackColor = true;
            this.buttonUNDO.Click += new System.EventHandler(this.buttonUNDO_Click);
            // 
            // buttonREDO
            // 
            this.buttonREDO.Location = new System.Drawing.Point(688, 32);
            this.buttonREDO.Name = "buttonREDO";
            this.buttonREDO.Size = new System.Drawing.Size(75, 39);
            this.buttonREDO.TabIndex = 9;
            this.buttonREDO.Text = "CTRL+Y";
            this.buttonREDO.UseVisualStyleBackColor = true;
            this.buttonREDO.Click += new System.EventHandler(this.buttonREDO_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(981, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(981, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 

            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(0, 32);
            this.trackBar2.Maximum = 25;
            this.trackBar2.Minimum = 5;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(120, 56);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.Value = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 

            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1074, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonREDO);
            this.Controls.Add(this.buttonUNDO);
            this.Controls.Add(this.addPlugin);
            this.Controls.Add(this.buttonFillColor);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripUP);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.trackBar2);
            this.MainMenuStrip = this.menuStripUP;
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStripUP.ResumeLayout(false);
            this.menuStripUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            ShapeButton.MouseDown += new MouseEventHandler(ShapeButton_MouseDown);
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStripUP;
        private System.Windows.Forms.ToolStripMenuItem menuStripUP_FILE;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBaseFigure;
        private System.Windows.Forms.Button ShapeButton;
        private System.Windows.Forms.ColorDialog colorDialogPen;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button buttonFillColor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button addPlugin;
        private System.Windows.Forms.Button buttonUNDO;
        private System.Windows.Forms.Button buttonREDO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private TrackBar trackBar2;

    }
}

