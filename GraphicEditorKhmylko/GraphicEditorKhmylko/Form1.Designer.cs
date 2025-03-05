namespace GraphicEditorKhmylko
{
    partial class Form1
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
            this.LineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrokenLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStripUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStripBaseFigure.SuspendLayout();
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
            // 
            // menuStripUP
            // 
            this.menuStripUP.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStripUP.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripUP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripUP_FILE});
            this.menuStripUP.Location = new System.Drawing.Point(0, 0);
            this.menuStripUP.Name = "menuStripUP";
            this.menuStripUP.Size = new System.Drawing.Size(971, 28);
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
            // 
            // contextMenuStripBaseFigure
            // 
            this.contextMenuStripBaseFigure.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripBaseFigure.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.PolygonToolStripMenuItem,
            this.EllipsToolStripMenuItem,
            this.BrokenLineToolStripMenuItem});
            this.contextMenuStripBaseFigure.Name = "contextMenuStripBaseFigure";
            this.contextMenuStripBaseFigure.Size = new System.Drawing.Size(156, 124);
            // 
            // LineToolStripMenuItem
            // 
            this.LineToolStripMenuItem.Name = "LineToolStripMenuItem";
            this.LineToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.LineToolStripMenuItem.Text = "Line";
            this.LineToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // PolygonToolStripMenuItem
            // 
            this.PolygonToolStripMenuItem.Name = "PolygonToolStripMenuItem";
            this.PolygonToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.PolygonToolStripMenuItem.Text = "Polygon";
            this.PolygonToolStripMenuItem.Click += new System.EventHandler(this.PolygonToolStripMenuItem_Click);
            // 
            // EllipsToolStripMenuItem
            // 
            this.EllipsToolStripMenuItem.Name = "EllipsToolStripMenuItem";
            this.EllipsToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.EllipsToolStripMenuItem.Text = "Ellips";
            this.EllipsToolStripMenuItem.Click += new System.EventHandler(this.EllipsToolStripMenuItem_Click);
            // 
            // BrokenLineToolStripMenuItem
            // 
            this.BrokenLineToolStripMenuItem.Name = "BrokenLineToolStripMenuItem";
            this.BrokenLineToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.BrokenLineToolStripMenuItem.Text = "Broken Line";
            this.BrokenLineToolStripMenuItem.Click += new System.EventHandler(this.BrokenLineToolStripMenuItem_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(129, 32);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(43, 38);
            this.ColorButton.TabIndex = 3;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(971, 549);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripUP);
            this.MainMenuStrip = this.menuStripUP;
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStripUP.ResumeLayout(false);
            this.menuStripUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStripBaseFigure.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStripMenuItem LineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EllipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BrokenLineToolStripMenuItem;
        private System.Windows.Forms.Button ShapeButton;
        private System.Windows.Forms.ColorDialog colorDialogPen;
        private System.Windows.Forms.Button ColorButton;
    }
}

