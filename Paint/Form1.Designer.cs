using System.Drawing;

namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Redo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Undo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tLP_Shape = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Circle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Rectangle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Line = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Triangle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel_PaintTool = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Bucket = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Eraser = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Brush = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Shape = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Fill = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Eyedropper = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_SelectColor = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pt_draw = new System.Windows.Forms.PictureBox();
            this.panel_paint = new System.Windows.Forms.Panel();
            this.lb_MousePos = new System.Windows.Forms.Label();
            this.panel_Color = new System.Windows.Forms.Panel();
            this.subTableLayoutPanel_Color2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_ColorPreview = new System.Windows.Forms.PictureBox();
            this.label_ColorPreview = new System.Windows.Forms.Label();
            this.subTableLayoutPanel_Color = new System.Windows.Forms.TableLayoutPanel();
            this.subPanelBtextBox = new System.Windows.Forms.Panel();
            this.textBox_Bvalue = new System.Windows.Forms.TextBox();
            this.label_B_value = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.subPanelGtextBox = new System.Windows.Forms.Panel();
            this.textBox_Gvalue = new System.Windows.Forms.TextBox();
            this.label_G_value = new System.Windows.Forms.Label();
            this.subPanelColorPicked = new System.Windows.Forms.Panel();
            this.pictureBox_Color_Front = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color_Back = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.subPanelRtextBox = new System.Windows.Forms.Panel();
            this.textBox_Rvalue = new System.Windows.Forms.TextBox();
            this.label_R_value = new System.Windows.Forms.Label();
            this.lb_Color = new System.Windows.Forms.Label();
            this.panel_BrushControl = new System.Windows.Forms.Panel();
            this.lb_value_size = new System.Windows.Forms.Label();
            this.trackBar_Size = new System.Windows.Forms.TrackBar();
            this.lb_Size = new System.Windows.Forms.Label();
            this.lb_BrushControl = new System.Windows.Forms.Label();
            this.panel_Brush = new System.Windows.Forms.Panel();
            this.lb_y = new System.Windows.Forms.Label();
            this.lb_x = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_pos = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.colorPicker = new AboControls.ExtendedControls.ColorPickerControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tLP_Shape.SuspendLayout();
            this.tableLayoutPanel_PaintTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_draw)).BeginInit();
            this.panel_paint.SuspendLayout();
            this.panel_Color.SuspendLayout();
            this.subTableLayoutPanel_Color2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorPreview)).BeginInit();
            this.subTableLayoutPanel_Color.SuspendLayout();
            this.subPanelBtextBox.SuspendLayout();
            this.panel7.SuspendLayout();
            this.subPanelGtextBox.SuspendLayout();
            this.subPanelColorPicked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color_Front)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color_Back)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.subPanelRtextBox.SuspendLayout();
            this.panel_BrushControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Size)).BeginInit();
            this.panel_Brush.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openfileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 26);
            this.toolStripMenuItem2.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.undoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeToolStripMenuItem,
            this.colorBarToolStripMenuItem});
            this.colorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // initializeToolStripMenuItem
            // 
            this.initializeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.initializeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.initializeToolStripMenuItem.Name = "initializeToolStripMenuItem";
            this.initializeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.initializeToolStripMenuItem.Text = "Initialize";
            // 
            // colorBarToolStripMenuItem
            // 
            this.colorBarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.colorBarToolStripMenuItem.CheckOnClick = true;
            this.colorBarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.colorBarToolStripMenuItem.Name = "colorBarToolStripMenuItem";
            this.colorBarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorBarToolStripMenuItem.Text = "Color Bar";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brushToolStripMenuItem,
            this.eraserToolStripMenuItem,
            this.shapeBrushToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.fillToolStripMenuItem});
            this.toolToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.brushToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.brushToolStripMenuItem.Text = "Brush";
            // 
            // eraserToolStripMenuItem
            // 
            this.eraserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.eraserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            this.eraserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eraserToolStripMenuItem.Text = "Eraser";
            // 
            // shapeBrushToolStripMenuItem
            // 
            this.shapeBrushToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.shapeBrushToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.shapeBrushToolStripMenuItem.Name = "shapeBrushToolStripMenuItem";
            this.shapeBrushToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shapeBrushToolStripMenuItem.Text = "Shape brush";
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.moveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.moveToolStripMenuItem.Text = "Move";
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.fillToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fillToolStripMenuItem.Text = "Fill";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tLP_Shape);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 36);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Redo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Undo, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(78, 36);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btn_Redo
            // 
            this.btn_Redo.AllowAnimations = true;
            this.btn_Redo.AllowMouseEffects = true;
            this.btn_Redo.AllowToggling = false;
            this.btn_Redo.AnimationSpeed = 200;
            this.btn_Redo.AutoGenerateColors = false;
            this.btn_Redo.AutoRoundBorders = false;
            this.btn_Redo.AutoSizeLeftIcon = true;
            this.btn_Redo.AutoSizeRightIcon = true;
            this.btn_Redo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Redo.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Redo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Redo.BackgroundImage")));
            this.btn_Redo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Redo.ButtonText = "";
            this.btn_Redo.ButtonTextMarginLeft = 0;
            this.btn_Redo.ColorContrastOnClick = 45;
            this.btn_Redo.ColorContrastOnHover = 45;
            this.btn_Redo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Redo.CustomizableEdges = borderEdges1;
            this.btn_Redo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Redo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Redo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Redo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Redo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Redo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Redo.ForeColor = System.Drawing.Color.White;
            this.btn_Redo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Redo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Redo.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btn_Redo.IconMarginLeft = 11;
            this.btn_Redo.IconPadding = 5;
            this.btn_Redo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Redo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Redo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Redo.IconSize = 25;
            this.btn_Redo.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Redo.IdleBorderRadius = 10;
            this.btn_Redo.IdleBorderThickness = 1;
            this.btn_Redo.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Redo.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Redo.IdleIconLeftImage")));
            this.btn_Redo.IdleIconRightImage = null;
            this.btn_Redo.IndicateFocus = false;
            this.btn_Redo.Location = new System.Drawing.Point(42, 3);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Redo.OnDisabledState.BorderRadius = 10;
            this.btn_Redo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Redo.OnDisabledState.BorderThickness = 1;
            this.btn_Redo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Redo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Redo.OnDisabledState.IconLeftImage = null;
            this.btn_Redo.OnDisabledState.IconRightImage = null;
            this.btn_Redo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Redo.onHoverState.BorderRadius = 10;
            this.btn_Redo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Redo.onHoverState.BorderThickness = 1;
            this.btn_Redo.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Redo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Redo.onHoverState.IconLeftImage = null;
            this.btn_Redo.onHoverState.IconRightImage = null;
            this.btn_Redo.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Redo.OnIdleState.BorderRadius = 10;
            this.btn_Redo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Redo.OnIdleState.BorderThickness = 1;
            this.btn_Redo.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Redo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Redo.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Redo.OnIdleState.IconLeftImage")));
            this.btn_Redo.OnIdleState.IconRightImage = null;
            this.btn_Redo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Redo.OnPressedState.BorderRadius = 10;
            this.btn_Redo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Redo.OnPressedState.BorderThickness = 1;
            this.btn_Redo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Redo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Redo.OnPressedState.IconLeftImage = null;
            this.btn_Redo.OnPressedState.IconRightImage = null;
            this.btn_Redo.Size = new System.Drawing.Size(30, 30);
            this.btn_Redo.TabIndex = 49;
            this.btn_Redo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Redo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Redo.TextMarginLeft = 0;
            this.btn_Redo.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Redo, "Redo");
            this.btn_Redo.UseDefaultRadiusAndThickness = true;
            this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.AllowAnimations = true;
            this.btn_Undo.AllowMouseEffects = true;
            this.btn_Undo.AllowToggling = false;
            this.btn_Undo.AnimationSpeed = 200;
            this.btn_Undo.AutoGenerateColors = false;
            this.btn_Undo.AutoRoundBorders = false;
            this.btn_Undo.AutoSizeLeftIcon = true;
            this.btn_Undo.AutoSizeRightIcon = true;
            this.btn_Undo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Undo.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Undo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Undo.BackgroundImage")));
            this.btn_Undo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Undo.ButtonText = "";
            this.btn_Undo.ButtonTextMarginLeft = 0;
            this.btn_Undo.ColorContrastOnClick = 45;
            this.btn_Undo.ColorContrastOnHover = 45;
            this.btn_Undo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Undo.CustomizableEdges = borderEdges2;
            this.btn_Undo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Undo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Undo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Undo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Undo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Undo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Undo.ForeColor = System.Drawing.Color.White;
            this.btn_Undo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Undo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Undo.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btn_Undo.IconMarginLeft = 11;
            this.btn_Undo.IconPadding = 5;
            this.btn_Undo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Undo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Undo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Undo.IconSize = 25;
            this.btn_Undo.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Undo.IdleBorderRadius = 10;
            this.btn_Undo.IdleBorderThickness = 1;
            this.btn_Undo.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Undo.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Undo.IdleIconLeftImage")));
            this.btn_Undo.IdleIconRightImage = null;
            this.btn_Undo.IndicateFocus = false;
            this.btn_Undo.Location = new System.Drawing.Point(3, 3);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Undo.OnDisabledState.BorderRadius = 10;
            this.btn_Undo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Undo.OnDisabledState.BorderThickness = 1;
            this.btn_Undo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Undo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Undo.OnDisabledState.IconLeftImage = null;
            this.btn_Undo.OnDisabledState.IconRightImage = null;
            this.btn_Undo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Undo.onHoverState.BorderRadius = 10;
            this.btn_Undo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Undo.onHoverState.BorderThickness = 1;
            this.btn_Undo.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Undo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Undo.onHoverState.IconLeftImage = null;
            this.btn_Undo.onHoverState.IconRightImage = null;
            this.btn_Undo.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Undo.OnIdleState.BorderRadius = 10;
            this.btn_Undo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Undo.OnIdleState.BorderThickness = 1;
            this.btn_Undo.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Undo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Undo.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Undo.OnIdleState.IconLeftImage")));
            this.btn_Undo.OnIdleState.IconRightImage = null;
            this.btn_Undo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Undo.OnPressedState.BorderRadius = 10;
            this.btn_Undo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Undo.OnPressedState.BorderThickness = 1;
            this.btn_Undo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Undo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Undo.OnPressedState.IconLeftImage = null;
            this.btn_Undo.OnPressedState.IconRightImage = null;
            this.btn_Undo.Size = new System.Drawing.Size(30, 30);
            this.btn_Undo.TabIndex = 48;
            this.btn_Undo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Undo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Undo.TextMarginLeft = 0;
            this.btn_Undo.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Undo, "Undo");
            this.btn_Undo.UseDefaultRadiusAndThickness = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // tLP_Shape
            // 
            this.tLP_Shape.ColumnCount = 6;
            this.tLP_Shape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP_Shape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP_Shape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP_Shape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP_Shape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP_Shape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP_Shape.Controls.Add(this.btn_Circle, 3, 0);
            this.tLP_Shape.Controls.Add(this.btn_Rectangle, 2, 0);
            this.tLP_Shape.Controls.Add(this.btn_Line, 0, 0);
            this.tLP_Shape.Controls.Add(this.btn_Triangle, 1, 0);
            this.tLP_Shape.Location = new System.Drawing.Point(99, 0);
            this.tLP_Shape.Name = "tLP_Shape";
            this.tLP_Shape.RowCount = 1;
            this.tLP_Shape.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Shape.Size = new System.Drawing.Size(227, 36);
            this.tLP_Shape.TabIndex = 4;
            this.tLP_Shape.Visible = false;
            // 
            // btn_Circle
            // 
            this.btn_Circle.AllowAnimations = true;
            this.btn_Circle.AllowMouseEffects = true;
            this.btn_Circle.AllowToggling = false;
            this.btn_Circle.AnimationSpeed = 200;
            this.btn_Circle.AutoGenerateColors = false;
            this.btn_Circle.AutoRoundBorders = false;
            this.btn_Circle.AutoSizeLeftIcon = true;
            this.btn_Circle.AutoSizeRightIcon = true;
            this.btn_Circle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Circle.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Circle.BackgroundImage")));
            this.btn_Circle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Circle.ButtonText = "";
            this.btn_Circle.ButtonTextMarginLeft = 0;
            this.btn_Circle.ColorContrastOnClick = 45;
            this.btn_Circle.ColorContrastOnHover = 45;
            this.btn_Circle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_Circle.CustomizableEdges = borderEdges3;
            this.btn_Circle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Circle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Circle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Circle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Circle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Circle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Circle.ForeColor = System.Drawing.Color.White;
            this.btn_Circle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Circle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Circle.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btn_Circle.IconMarginLeft = 11;
            this.btn_Circle.IconPadding = 5;
            this.btn_Circle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Circle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Circle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Circle.IconSize = 25;
            this.btn_Circle.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Circle.IdleBorderRadius = 10;
            this.btn_Circle.IdleBorderThickness = 1;
            this.btn_Circle.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Circle.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Circle.IdleIconLeftImage")));
            this.btn_Circle.IdleIconRightImage = null;
            this.btn_Circle.IndicateFocus = false;
            this.btn_Circle.Location = new System.Drawing.Point(114, 3);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Circle.OnDisabledState.BorderRadius = 10;
            this.btn_Circle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Circle.OnDisabledState.BorderThickness = 1;
            this.btn_Circle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Circle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Circle.OnDisabledState.IconLeftImage = null;
            this.btn_Circle.OnDisabledState.IconRightImage = null;
            this.btn_Circle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Circle.onHoverState.BorderRadius = 10;
            this.btn_Circle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Circle.onHoverState.BorderThickness = 1;
            this.btn_Circle.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Circle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Circle.onHoverState.IconLeftImage = null;
            this.btn_Circle.onHoverState.IconRightImage = null;
            this.btn_Circle.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Circle.OnIdleState.BorderRadius = 10;
            this.btn_Circle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Circle.OnIdleState.BorderThickness = 1;
            this.btn_Circle.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Circle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Circle.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Circle.OnIdleState.IconLeftImage")));
            this.btn_Circle.OnIdleState.IconRightImage = null;
            this.btn_Circle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Circle.OnPressedState.BorderRadius = 10;
            this.btn_Circle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Circle.OnPressedState.BorderThickness = 1;
            this.btn_Circle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Circle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Circle.OnPressedState.IconLeftImage = null;
            this.btn_Circle.OnPressedState.IconRightImage = null;
            this.btn_Circle.Size = new System.Drawing.Size(29, 30);
            this.btn_Circle.TabIndex = 51;
            this.btn_Circle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Circle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Circle.TextMarginLeft = 0;
            this.btn_Circle.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Circle, "Circle");
            this.btn_Circle.UseDefaultRadiusAndThickness = true;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.AllowAnimations = true;
            this.btn_Rectangle.AllowMouseEffects = true;
            this.btn_Rectangle.AllowToggling = false;
            this.btn_Rectangle.AnimationSpeed = 200;
            this.btn_Rectangle.AutoGenerateColors = false;
            this.btn_Rectangle.AutoRoundBorders = false;
            this.btn_Rectangle.AutoSizeLeftIcon = true;
            this.btn_Rectangle.AutoSizeRightIcon = true;
            this.btn_Rectangle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Rectangle.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Rectangle.BackgroundImage")));
            this.btn_Rectangle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Rectangle.ButtonText = "";
            this.btn_Rectangle.ButtonTextMarginLeft = 0;
            this.btn_Rectangle.ColorContrastOnClick = 45;
            this.btn_Rectangle.ColorContrastOnHover = 45;
            this.btn_Rectangle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_Rectangle.CustomizableEdges = borderEdges4;
            this.btn_Rectangle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Rectangle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Rectangle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Rectangle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Rectangle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Rectangle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Rectangle.ForeColor = System.Drawing.Color.White;
            this.btn_Rectangle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Rectangle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Rectangle.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btn_Rectangle.IconMarginLeft = 11;
            this.btn_Rectangle.IconPadding = 5;
            this.btn_Rectangle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Rectangle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Rectangle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Rectangle.IconSize = 25;
            this.btn_Rectangle.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Rectangle.IdleBorderRadius = 10;
            this.btn_Rectangle.IdleBorderThickness = 1;
            this.btn_Rectangle.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Rectangle.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Rectangle.IdleIconLeftImage")));
            this.btn_Rectangle.IdleIconRightImage = null;
            this.btn_Rectangle.IndicateFocus = false;
            this.btn_Rectangle.Location = new System.Drawing.Point(77, 3);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Rectangle.OnDisabledState.BorderRadius = 10;
            this.btn_Rectangle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Rectangle.OnDisabledState.BorderThickness = 1;
            this.btn_Rectangle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Rectangle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Rectangle.OnDisabledState.IconLeftImage = null;
            this.btn_Rectangle.OnDisabledState.IconRightImage = null;
            this.btn_Rectangle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Rectangle.onHoverState.BorderRadius = 10;
            this.btn_Rectangle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Rectangle.onHoverState.BorderThickness = 1;
            this.btn_Rectangle.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Rectangle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Rectangle.onHoverState.IconLeftImage = null;
            this.btn_Rectangle.onHoverState.IconRightImage = null;
            this.btn_Rectangle.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Rectangle.OnIdleState.BorderRadius = 10;
            this.btn_Rectangle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Rectangle.OnIdleState.BorderThickness = 1;
            this.btn_Rectangle.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Rectangle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Rectangle.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Rectangle.OnIdleState.IconLeftImage")));
            this.btn_Rectangle.OnIdleState.IconRightImage = null;
            this.btn_Rectangle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Rectangle.OnPressedState.BorderRadius = 10;
            this.btn_Rectangle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Rectangle.OnPressedState.BorderThickness = 1;
            this.btn_Rectangle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Rectangle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Rectangle.OnPressedState.IconLeftImage = null;
            this.btn_Rectangle.OnPressedState.IconRightImage = null;
            this.btn_Rectangle.Size = new System.Drawing.Size(29, 30);
            this.btn_Rectangle.TabIndex = 50;
            this.btn_Rectangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Rectangle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Rectangle.TextMarginLeft = 0;
            this.btn_Rectangle.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Rectangle, "Rectangle");
            this.btn_Rectangle.UseDefaultRadiusAndThickness = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.AllowAnimations = true;
            this.btn_Line.AllowMouseEffects = true;
            this.btn_Line.AllowToggling = false;
            this.btn_Line.AnimationSpeed = 200;
            this.btn_Line.AutoGenerateColors = false;
            this.btn_Line.AutoRoundBorders = false;
            this.btn_Line.AutoSizeLeftIcon = true;
            this.btn_Line.AutoSizeRightIcon = true;
            this.btn_Line.BackColor = System.Drawing.Color.Transparent;
            this.btn_Line.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Line.BackgroundImage")));
            this.btn_Line.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Line.ButtonText = "";
            this.btn_Line.ButtonTextMarginLeft = 0;
            this.btn_Line.ColorContrastOnClick = 45;
            this.btn_Line.ColorContrastOnHover = 45;
            this.btn_Line.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btn_Line.CustomizableEdges = borderEdges5;
            this.btn_Line.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Line.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Line.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Line.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Line.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Line.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Line.ForeColor = System.Drawing.Color.White;
            this.btn_Line.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Line.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Line.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btn_Line.IconMarginLeft = 11;
            this.btn_Line.IconPadding = 5;
            this.btn_Line.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Line.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Line.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Line.IconSize = 25;
            this.btn_Line.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Line.IdleBorderRadius = 10;
            this.btn_Line.IdleBorderThickness = 1;
            this.btn_Line.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Line.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Line.IdleIconLeftImage")));
            this.btn_Line.IdleIconRightImage = null;
            this.btn_Line.IndicateFocus = false;
            this.btn_Line.Location = new System.Drawing.Point(3, 3);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Line.OnDisabledState.BorderRadius = 10;
            this.btn_Line.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Line.OnDisabledState.BorderThickness = 1;
            this.btn_Line.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Line.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Line.OnDisabledState.IconLeftImage = null;
            this.btn_Line.OnDisabledState.IconRightImage = null;
            this.btn_Line.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Line.onHoverState.BorderRadius = 10;
            this.btn_Line.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Line.onHoverState.BorderThickness = 1;
            this.btn_Line.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Line.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Line.onHoverState.IconLeftImage = null;
            this.btn_Line.onHoverState.IconRightImage = null;
            this.btn_Line.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Line.OnIdleState.BorderRadius = 10;
            this.btn_Line.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Line.OnIdleState.BorderThickness = 1;
            this.btn_Line.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Line.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Line.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Line.OnIdleState.IconLeftImage")));
            this.btn_Line.OnIdleState.IconRightImage = null;
            this.btn_Line.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Line.OnPressedState.BorderRadius = 10;
            this.btn_Line.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Line.OnPressedState.BorderThickness = 1;
            this.btn_Line.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Line.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Line.OnPressedState.IconLeftImage = null;
            this.btn_Line.OnPressedState.IconRightImage = null;
            this.btn_Line.Size = new System.Drawing.Size(29, 30);
            this.btn_Line.TabIndex = 48;
            this.btn_Line.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Line.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Line.TextMarginLeft = 0;
            this.btn_Line.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Line, "Line");
            this.btn_Line.UseDefaultRadiusAndThickness = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Triangle
            // 
            this.btn_Triangle.AllowAnimations = true;
            this.btn_Triangle.AllowMouseEffects = true;
            this.btn_Triangle.AllowToggling = false;
            this.btn_Triangle.AnimationSpeed = 200;
            this.btn_Triangle.AutoGenerateColors = false;
            this.btn_Triangle.AutoRoundBorders = false;
            this.btn_Triangle.AutoSizeLeftIcon = true;
            this.btn_Triangle.AutoSizeRightIcon = true;
            this.btn_Triangle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Triangle.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Triangle.BackgroundImage")));
            this.btn_Triangle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Triangle.ButtonText = "";
            this.btn_Triangle.ButtonTextMarginLeft = 0;
            this.btn_Triangle.ColorContrastOnClick = 45;
            this.btn_Triangle.ColorContrastOnHover = 45;
            this.btn_Triangle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btn_Triangle.CustomizableEdges = borderEdges6;
            this.btn_Triangle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Triangle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Triangle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Triangle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Triangle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Triangle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Triangle.ForeColor = System.Drawing.Color.White;
            this.btn_Triangle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Triangle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Triangle.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btn_Triangle.IconMarginLeft = 11;
            this.btn_Triangle.IconPadding = 5;
            this.btn_Triangle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Triangle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Triangle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Triangle.IconSize = 25;
            this.btn_Triangle.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Triangle.IdleBorderRadius = 10;
            this.btn_Triangle.IdleBorderThickness = 1;
            this.btn_Triangle.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Triangle.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Triangle.IdleIconLeftImage")));
            this.btn_Triangle.IdleIconRightImage = null;
            this.btn_Triangle.IndicateFocus = false;
            this.btn_Triangle.Location = new System.Drawing.Point(40, 3);
            this.btn_Triangle.Name = "btn_Triangle";
            this.btn_Triangle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Triangle.OnDisabledState.BorderRadius = 10;
            this.btn_Triangle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Triangle.OnDisabledState.BorderThickness = 1;
            this.btn_Triangle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Triangle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Triangle.OnDisabledState.IconLeftImage = null;
            this.btn_Triangle.OnDisabledState.IconRightImage = null;
            this.btn_Triangle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Triangle.onHoverState.BorderRadius = 10;
            this.btn_Triangle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Triangle.onHoverState.BorderThickness = 1;
            this.btn_Triangle.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Triangle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Triangle.onHoverState.IconLeftImage = null;
            this.btn_Triangle.onHoverState.IconRightImage = null;
            this.btn_Triangle.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Triangle.OnIdleState.BorderRadius = 10;
            this.btn_Triangle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Triangle.OnIdleState.BorderThickness = 1;
            this.btn_Triangle.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Triangle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Triangle.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Triangle.OnIdleState.IconLeftImage")));
            this.btn_Triangle.OnIdleState.IconRightImage = null;
            this.btn_Triangle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Triangle.OnPressedState.BorderRadius = 10;
            this.btn_Triangle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Triangle.OnPressedState.BorderThickness = 1;
            this.btn_Triangle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Triangle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Triangle.OnPressedState.IconLeftImage = null;
            this.btn_Triangle.OnPressedState.IconRightImage = null;
            this.btn_Triangle.Size = new System.Drawing.Size(29, 30);
            this.btn_Triangle.TabIndex = 52;
            this.btn_Triangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Triangle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Triangle.TextMarginLeft = 0;
            this.btn_Triangle.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Triangle, "Triangle");
            this.btn_Triangle.UseDefaultRadiusAndThickness = true;
            this.btn_Triangle.Click += new System.EventHandler(this.btn_Triangle_Click);
            // 
            // tableLayoutPanel_PaintTool
            // 
            this.tableLayoutPanel_PaintTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel_PaintTool.ColumnCount = 1;
            this.tableLayoutPanel_PaintTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_PaintTool.Controls.Add(this.btn_Bucket, 0, 5);
            this.tableLayoutPanel_PaintTool.Controls.Add(this.btn_Eraser, 0, 1);
            this.tableLayoutPanel_PaintTool.Controls.Add(this.btn_Brush, 0, 0);
            this.tableLayoutPanel_PaintTool.Controls.Add(this.btn_Shape, 0, 2);
            this.tableLayoutPanel_PaintTool.Controls.Add(this.btn_Fill, 0, 4);
            this.tableLayoutPanel_PaintTool.Controls.Add(this.btn_Eyedropper, 0, 3);
            this.tableLayoutPanel_PaintTool.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel_PaintTool.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel_PaintTool.Name = "tableLayoutPanel_PaintTool";
            this.tableLayoutPanel_PaintTool.RowCount = 13;
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_PaintTool.Size = new System.Drawing.Size(36, 497);
            this.tableLayoutPanel_PaintTool.TabIndex = 3;
            // 
            // btn_Bucket
            // 
            this.btn_Bucket.AllowAnimations = true;
            this.btn_Bucket.AllowMouseEffects = true;
            this.btn_Bucket.AllowToggling = false;
            this.btn_Bucket.AnimationSpeed = 200;
            this.btn_Bucket.AutoGenerateColors = false;
            this.btn_Bucket.AutoRoundBorders = false;
            this.btn_Bucket.AutoSizeLeftIcon = true;
            this.btn_Bucket.AutoSizeRightIcon = true;
            this.btn_Bucket.BackColor = System.Drawing.Color.Transparent;
            this.btn_Bucket.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Bucket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Bucket.BackgroundImage")));
            this.btn_Bucket.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Bucket.ButtonText = "";
            this.btn_Bucket.ButtonTextMarginLeft = 0;
            this.btn_Bucket.ColorContrastOnClick = 45;
            this.btn_Bucket.ColorContrastOnHover = 45;
            this.btn_Bucket.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btn_Bucket.CustomizableEdges = borderEdges7;
            this.btn_Bucket.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Bucket.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Bucket.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Bucket.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Bucket.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Bucket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Bucket.ForeColor = System.Drawing.Color.White;
            this.btn_Bucket.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bucket.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Bucket.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btn_Bucket.IconMarginLeft = 11;
            this.btn_Bucket.IconPadding = 5;
            this.btn_Bucket.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Bucket.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Bucket.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Bucket.IconSize = 25;
            this.btn_Bucket.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Bucket.IdleBorderRadius = 10;
            this.btn_Bucket.IdleBorderThickness = 1;
            this.btn_Bucket.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Bucket.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Bucket.IdleIconLeftImage")));
            this.btn_Bucket.IdleIconRightImage = null;
            this.btn_Bucket.IndicateFocus = false;
            this.btn_Bucket.Location = new System.Drawing.Point(3, 193);
            this.btn_Bucket.Name = "btn_Bucket";
            this.btn_Bucket.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Bucket.OnDisabledState.BorderRadius = 10;
            this.btn_Bucket.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Bucket.OnDisabledState.BorderThickness = 1;
            this.btn_Bucket.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Bucket.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Bucket.OnDisabledState.IconLeftImage = null;
            this.btn_Bucket.OnDisabledState.IconRightImage = null;
            this.btn_Bucket.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Bucket.onHoverState.BorderRadius = 10;
            this.btn_Bucket.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Bucket.onHoverState.BorderThickness = 1;
            this.btn_Bucket.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Bucket.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Bucket.onHoverState.IconLeftImage = null;
            this.btn_Bucket.onHoverState.IconRightImage = null;
            this.btn_Bucket.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Bucket.OnIdleState.BorderRadius = 10;
            this.btn_Bucket.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Bucket.OnIdleState.BorderThickness = 1;
            this.btn_Bucket.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Bucket.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Bucket.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Bucket.OnIdleState.IconLeftImage")));
            this.btn_Bucket.OnIdleState.IconRightImage = null;
            this.btn_Bucket.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Bucket.OnPressedState.BorderRadius = 10;
            this.btn_Bucket.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Bucket.OnPressedState.BorderThickness = 1;
            this.btn_Bucket.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Bucket.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Bucket.OnPressedState.IconLeftImage = null;
            this.btn_Bucket.OnPressedState.IconRightImage = null;
            this.btn_Bucket.Size = new System.Drawing.Size(30, 30);
            this.btn_Bucket.TabIndex = 52;
            this.btn_Bucket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Bucket.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Bucket.TextMarginLeft = 0;
            this.btn_Bucket.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Bucket, "Bucket Tool");
            this.btn_Bucket.UseDefaultRadiusAndThickness = true;
            this.btn_Bucket.Click += new System.EventHandler(this.btn_Bucket_Click);
            // 
            // btn_Eraser
            // 
            this.btn_Eraser.AllowAnimations = true;
            this.btn_Eraser.AllowMouseEffects = true;
            this.btn_Eraser.AllowToggling = false;
            this.btn_Eraser.AnimationSpeed = 200;
            this.btn_Eraser.AutoGenerateColors = false;
            this.btn_Eraser.AutoRoundBorders = false;
            this.btn_Eraser.AutoSizeLeftIcon = true;
            this.btn_Eraser.AutoSizeRightIcon = true;
            this.btn_Eraser.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eraser.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eraser.BackgroundImage")));
            this.btn_Eraser.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Eraser.ButtonText = "";
            this.btn_Eraser.ButtonTextMarginLeft = 0;
            this.btn_Eraser.ColorContrastOnClick = 45;
            this.btn_Eraser.ColorContrastOnHover = 45;
            this.btn_Eraser.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btn_Eraser.CustomizableEdges = borderEdges8;
            this.btn_Eraser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Eraser.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Eraser.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Eraser.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Eraser.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Eraser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Eraser.ForeColor = System.Drawing.Color.White;
            this.btn_Eraser.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eraser.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Eraser.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btn_Eraser.IconMarginLeft = 11;
            this.btn_Eraser.IconPadding = 5;
            this.btn_Eraser.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eraser.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Eraser.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Eraser.IconSize = 25;
            this.btn_Eraser.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Eraser.IdleBorderRadius = 10;
            this.btn_Eraser.IdleBorderThickness = 1;
            this.btn_Eraser.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Eraser.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Eraser.IdleIconLeftImage")));
            this.btn_Eraser.IdleIconRightImage = null;
            this.btn_Eraser.IndicateFocus = false;
            this.btn_Eraser.Location = new System.Drawing.Point(3, 41);
            this.btn_Eraser.Name = "btn_Eraser";
            this.btn_Eraser.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Eraser.OnDisabledState.BorderRadius = 10;
            this.btn_Eraser.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Eraser.OnDisabledState.BorderThickness = 1;
            this.btn_Eraser.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Eraser.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Eraser.OnDisabledState.IconLeftImage = null;
            this.btn_Eraser.OnDisabledState.IconRightImage = null;
            this.btn_Eraser.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Eraser.onHoverState.BorderRadius = 10;
            this.btn_Eraser.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Eraser.onHoverState.BorderThickness = 1;
            this.btn_Eraser.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Eraser.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Eraser.onHoverState.IconLeftImage = null;
            this.btn_Eraser.onHoverState.IconRightImage = null;
            this.btn_Eraser.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Eraser.OnIdleState.BorderRadius = 10;
            this.btn_Eraser.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Eraser.OnIdleState.BorderThickness = 1;
            this.btn_Eraser.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Eraser.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Eraser.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Eraser.OnIdleState.IconLeftImage")));
            this.btn_Eraser.OnIdleState.IconRightImage = null;
            this.btn_Eraser.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Eraser.OnPressedState.BorderRadius = 10;
            this.btn_Eraser.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Eraser.OnPressedState.BorderThickness = 1;
            this.btn_Eraser.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Eraser.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Eraser.OnPressedState.IconLeftImage = null;
            this.btn_Eraser.OnPressedState.IconRightImage = null;
            this.btn_Eraser.Size = new System.Drawing.Size(30, 30);
            this.btn_Eraser.TabIndex = 48;
            this.btn_Eraser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eraser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Eraser.TextMarginLeft = 0;
            this.btn_Eraser.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Eraser, "Eraser Tool");
            this.btn_Eraser.UseDefaultRadiusAndThickness = true;
            this.btn_Eraser.Click += new System.EventHandler(this.btn_Eraser_Click);
            // 
            // btn_Brush
            // 
            this.btn_Brush.AllowAnimations = true;
            this.btn_Brush.AllowMouseEffects = true;
            this.btn_Brush.AllowToggling = false;
            this.btn_Brush.AnimationSpeed = 200;
            this.btn_Brush.AutoGenerateColors = false;
            this.btn_Brush.AutoRoundBorders = false;
            this.btn_Brush.AutoSizeLeftIcon = true;
            this.btn_Brush.AutoSizeRightIcon = true;
            this.btn_Brush.BackColor = System.Drawing.Color.Transparent;
            this.btn_Brush.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Brush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Brush.BackgroundImage")));
            this.btn_Brush.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Brush.ButtonText = "";
            this.btn_Brush.ButtonTextMarginLeft = 0;
            this.btn_Brush.ColorContrastOnClick = 45;
            this.btn_Brush.ColorContrastOnHover = 45;
            this.btn_Brush.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btn_Brush.CustomizableEdges = borderEdges9;
            this.btn_Brush.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Brush.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Brush.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Brush.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Brush.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Brush.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Brush.ForeColor = System.Drawing.Color.White;
            this.btn_Brush.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Brush.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Brush.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btn_Brush.IconMarginLeft = 11;
            this.btn_Brush.IconPadding = 5;
            this.btn_Brush.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Brush.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Brush.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Brush.IconSize = 25;
            this.btn_Brush.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Brush.IdleBorderRadius = 10;
            this.btn_Brush.IdleBorderThickness = 1;
            this.btn_Brush.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Brush.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Brush.IdleIconLeftImage")));
            this.btn_Brush.IdleIconRightImage = null;
            this.btn_Brush.IndicateFocus = false;
            this.btn_Brush.Location = new System.Drawing.Point(3, 3);
            this.btn_Brush.Name = "btn_Brush";
            this.btn_Brush.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Brush.OnDisabledState.BorderRadius = 10;
            this.btn_Brush.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Brush.OnDisabledState.BorderThickness = 1;
            this.btn_Brush.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Brush.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Brush.OnDisabledState.IconLeftImage = null;
            this.btn_Brush.OnDisabledState.IconRightImage = null;
            this.btn_Brush.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Brush.onHoverState.BorderRadius = 10;
            this.btn_Brush.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Brush.onHoverState.BorderThickness = 1;
            this.btn_Brush.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Brush.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Brush.onHoverState.IconLeftImage = null;
            this.btn_Brush.onHoverState.IconRightImage = null;
            this.btn_Brush.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Brush.OnIdleState.BorderRadius = 10;
            this.btn_Brush.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Brush.OnIdleState.BorderThickness = 1;
            this.btn_Brush.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Brush.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Brush.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Brush.OnIdleState.IconLeftImage")));
            this.btn_Brush.OnIdleState.IconRightImage = null;
            this.btn_Brush.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Brush.OnPressedState.BorderRadius = 10;
            this.btn_Brush.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Brush.OnPressedState.BorderThickness = 1;
            this.btn_Brush.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Brush.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Brush.OnPressedState.IconLeftImage = null;
            this.btn_Brush.OnPressedState.IconRightImage = null;
            this.btn_Brush.Size = new System.Drawing.Size(30, 30);
            this.btn_Brush.TabIndex = 47;
            this.btn_Brush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Brush.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Brush.TextMarginLeft = 0;
            this.btn_Brush.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Brush, "Brush Tool");
            this.btn_Brush.UseDefaultRadiusAndThickness = true;
            this.btn_Brush.Click += new System.EventHandler(this.btn_Brush_Click);
            // 
            // btn_Shape
            // 
            this.btn_Shape.AllowAnimations = true;
            this.btn_Shape.AllowMouseEffects = true;
            this.btn_Shape.AllowToggling = false;
            this.btn_Shape.AnimationSpeed = 200;
            this.btn_Shape.AutoGenerateColors = false;
            this.btn_Shape.AutoRoundBorders = false;
            this.btn_Shape.AutoSizeLeftIcon = true;
            this.btn_Shape.AutoSizeRightIcon = true;
            this.btn_Shape.BackColor = System.Drawing.Color.Transparent;
            this.btn_Shape.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Shape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Shape.BackgroundImage")));
            this.btn_Shape.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Shape.ButtonText = "";
            this.btn_Shape.ButtonTextMarginLeft = 0;
            this.btn_Shape.ColorContrastOnClick = 45;
            this.btn_Shape.ColorContrastOnHover = 45;
            this.btn_Shape.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btn_Shape.CustomizableEdges = borderEdges10;
            this.btn_Shape.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Shape.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Shape.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Shape.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Shape.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Shape.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Shape.ForeColor = System.Drawing.Color.White;
            this.btn_Shape.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Shape.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Shape.IconLeftPadding = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.btn_Shape.IconMarginLeft = 11;
            this.btn_Shape.IconPadding = 5;
            this.btn_Shape.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Shape.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Shape.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Shape.IconSize = 25;
            this.btn_Shape.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Shape.IdleBorderRadius = 10;
            this.btn_Shape.IdleBorderThickness = 1;
            this.btn_Shape.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Shape.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Shape.IdleIconLeftImage")));
            this.btn_Shape.IdleIconRightImage = null;
            this.btn_Shape.IndicateFocus = false;
            this.btn_Shape.Location = new System.Drawing.Point(3, 79);
            this.btn_Shape.Name = "btn_Shape";
            this.btn_Shape.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Shape.OnDisabledState.BorderRadius = 10;
            this.btn_Shape.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Shape.OnDisabledState.BorderThickness = 1;
            this.btn_Shape.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Shape.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Shape.OnDisabledState.IconLeftImage = null;
            this.btn_Shape.OnDisabledState.IconRightImage = null;
            this.btn_Shape.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Shape.onHoverState.BorderRadius = 10;
            this.btn_Shape.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Shape.onHoverState.BorderThickness = 1;
            this.btn_Shape.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Shape.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Shape.onHoverState.IconLeftImage = null;
            this.btn_Shape.onHoverState.IconRightImage = null;
            this.btn_Shape.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Shape.OnIdleState.BorderRadius = 10;
            this.btn_Shape.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Shape.OnIdleState.BorderThickness = 1;
            this.btn_Shape.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Shape.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Shape.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Shape.OnIdleState.IconLeftImage")));
            this.btn_Shape.OnIdleState.IconRightImage = null;
            this.btn_Shape.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Shape.OnPressedState.BorderRadius = 10;
            this.btn_Shape.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Shape.OnPressedState.BorderThickness = 1;
            this.btn_Shape.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Shape.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Shape.OnPressedState.IconLeftImage = null;
            this.btn_Shape.OnPressedState.IconRightImage = null;
            this.btn_Shape.Size = new System.Drawing.Size(30, 30);
            this.btn_Shape.TabIndex = 50;
            this.btn_Shape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Shape.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Shape.TextMarginLeft = 0;
            this.btn_Shape.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Shape, "Shape Brush Tool");
            this.btn_Shape.UseDefaultRadiusAndThickness = true;
            this.btn_Shape.Click += new System.EventHandler(this.btn_Shape_Click);
            // 
            // btn_Fill
            // 
            this.btn_Fill.AllowAnimations = true;
            this.btn_Fill.AllowMouseEffects = true;
            this.btn_Fill.AllowToggling = false;
            this.btn_Fill.AnimationSpeed = 200;
            this.btn_Fill.AutoGenerateColors = false;
            this.btn_Fill.AutoRoundBorders = false;
            this.btn_Fill.AutoSizeLeftIcon = true;
            this.btn_Fill.AutoSizeRightIcon = true;
            this.btn_Fill.BackColor = System.Drawing.Color.Transparent;
            this.btn_Fill.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Fill.BackgroundImage")));
            this.btn_Fill.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Fill.ButtonText = "";
            this.btn_Fill.ButtonTextMarginLeft = 0;
            this.btn_Fill.ColorContrastOnClick = 45;
            this.btn_Fill.ColorContrastOnHover = 45;
            this.btn_Fill.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btn_Fill.CustomizableEdges = borderEdges11;
            this.btn_Fill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Fill.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Fill.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Fill.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Fill.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Fill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Fill.ForeColor = System.Drawing.Color.White;
            this.btn_Fill.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Fill.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Fill.IconLeftPadding = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.btn_Fill.IconMarginLeft = 11;
            this.btn_Fill.IconPadding = 5;
            this.btn_Fill.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Fill.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Fill.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Fill.IconSize = 25;
            this.btn_Fill.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Fill.IdleBorderRadius = 10;
            this.btn_Fill.IdleBorderThickness = 1;
            this.btn_Fill.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Fill.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Fill.IdleIconLeftImage")));
            this.btn_Fill.IdleIconRightImage = null;
            this.btn_Fill.IndicateFocus = false;
            this.btn_Fill.Location = new System.Drawing.Point(3, 155);
            this.btn_Fill.Name = "btn_Fill";
            this.btn_Fill.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Fill.OnDisabledState.BorderRadius = 10;
            this.btn_Fill.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Fill.OnDisabledState.BorderThickness = 1;
            this.btn_Fill.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Fill.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Fill.OnDisabledState.IconLeftImage = null;
            this.btn_Fill.OnDisabledState.IconRightImage = null;
            this.btn_Fill.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Fill.onHoverState.BorderRadius = 10;
            this.btn_Fill.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Fill.onHoverState.BorderThickness = 1;
            this.btn_Fill.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Fill.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Fill.onHoverState.IconLeftImage = null;
            this.btn_Fill.onHoverState.IconRightImage = null;
            this.btn_Fill.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Fill.OnIdleState.BorderRadius = 10;
            this.btn_Fill.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Fill.OnIdleState.BorderThickness = 1;
            this.btn_Fill.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Fill.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Fill.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Fill.OnIdleState.IconLeftImage")));
            this.btn_Fill.OnIdleState.IconRightImage = null;
            this.btn_Fill.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Fill.OnPressedState.BorderRadius = 10;
            this.btn_Fill.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Fill.OnPressedState.BorderThickness = 1;
            this.btn_Fill.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Fill.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Fill.OnPressedState.IconLeftImage = null;
            this.btn_Fill.OnPressedState.IconRightImage = null;
            this.btn_Fill.Size = new System.Drawing.Size(30, 30);
            this.btn_Fill.TabIndex = 49;
            this.btn_Fill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Fill.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Fill.TextMarginLeft = 0;
            this.btn_Fill.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Fill, "Fill Tool");
            this.btn_Fill.UseDefaultRadiusAndThickness = true;
            this.btn_Fill.Click += new System.EventHandler(this.btn_Fill_Click);
            // 
            // btn_Eyedropper
            // 
            this.btn_Eyedropper.AllowAnimations = true;
            this.btn_Eyedropper.AllowMouseEffects = true;
            this.btn_Eyedropper.AllowToggling = false;
            this.btn_Eyedropper.AnimationSpeed = 200;
            this.btn_Eyedropper.AutoGenerateColors = false;
            this.btn_Eyedropper.AutoRoundBorders = false;
            this.btn_Eyedropper.AutoSizeLeftIcon = true;
            this.btn_Eyedropper.AutoSizeRightIcon = true;
            this.btn_Eyedropper.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eyedropper.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_Eyedropper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eyedropper.BackgroundImage")));
            this.btn_Eyedropper.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Eyedropper.ButtonText = "";
            this.btn_Eyedropper.ButtonTextMarginLeft = 0;
            this.btn_Eyedropper.ColorContrastOnClick = 45;
            this.btn_Eyedropper.ColorContrastOnHover = 45;
            this.btn_Eyedropper.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.btn_Eyedropper.CustomizableEdges = borderEdges12;
            this.btn_Eyedropper.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Eyedropper.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Eyedropper.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Eyedropper.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Eyedropper.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Eyedropper.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Eyedropper.ForeColor = System.Drawing.Color.White;
            this.btn_Eyedropper.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eyedropper.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Eyedropper.IconLeftPadding = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.btn_Eyedropper.IconMarginLeft = 11;
            this.btn_Eyedropper.IconPadding = 5;
            this.btn_Eyedropper.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eyedropper.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Eyedropper.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Eyedropper.IconSize = 25;
            this.btn_Eyedropper.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Eyedropper.IdleBorderRadius = 10;
            this.btn_Eyedropper.IdleBorderThickness = 1;
            this.btn_Eyedropper.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_Eyedropper.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Eyedropper.IdleIconLeftImage")));
            this.btn_Eyedropper.IdleIconRightImage = null;
            this.btn_Eyedropper.IndicateFocus = false;
            this.btn_Eyedropper.Location = new System.Drawing.Point(3, 117);
            this.btn_Eyedropper.Name = "btn_Eyedropper";
            this.btn_Eyedropper.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Eyedropper.OnDisabledState.BorderRadius = 10;
            this.btn_Eyedropper.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Eyedropper.OnDisabledState.BorderThickness = 1;
            this.btn_Eyedropper.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Eyedropper.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Eyedropper.OnDisabledState.IconLeftImage = null;
            this.btn_Eyedropper.OnDisabledState.IconRightImage = null;
            this.btn_Eyedropper.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Eyedropper.onHoverState.BorderRadius = 10;
            this.btn_Eyedropper.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Eyedropper.onHoverState.BorderThickness = 1;
            this.btn_Eyedropper.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Eyedropper.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Eyedropper.onHoverState.IconLeftImage = null;
            this.btn_Eyedropper.onHoverState.IconRightImage = null;
            this.btn_Eyedropper.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Eyedropper.OnIdleState.BorderRadius = 10;
            this.btn_Eyedropper.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Eyedropper.OnIdleState.BorderThickness = 1;
            this.btn_Eyedropper.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_Eyedropper.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Eyedropper.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Eyedropper.OnIdleState.IconLeftImage")));
            this.btn_Eyedropper.OnIdleState.IconRightImage = null;
            this.btn_Eyedropper.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Eyedropper.OnPressedState.BorderRadius = 10;
            this.btn_Eyedropper.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Eyedropper.OnPressedState.BorderThickness = 1;
            this.btn_Eyedropper.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Eyedropper.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Eyedropper.OnPressedState.IconLeftImage = null;
            this.btn_Eyedropper.OnPressedState.IconRightImage = null;
            this.btn_Eyedropper.Size = new System.Drawing.Size(30, 30);
            this.btn_Eyedropper.TabIndex = 56;
            this.btn_Eyedropper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eyedropper.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Eyedropper.TextMarginLeft = 0;
            this.btn_Eyedropper.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_Eyedropper, "Eyedropper Tool");
            this.btn_Eyedropper.UseDefaultRadiusAndThickness = true;
            this.btn_Eyedropper.Click += new System.EventHandler(this.btn_Eyedropper_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // btn_SelectColor
            // 
            this.btn_SelectColor.AllowAnimations = true;
            this.btn_SelectColor.AllowMouseEffects = true;
            this.btn_SelectColor.AllowToggling = false;
            this.btn_SelectColor.AnimationSpeed = 200;
            this.btn_SelectColor.AutoGenerateColors = false;
            this.btn_SelectColor.AutoRoundBorders = false;
            this.btn_SelectColor.AutoSizeLeftIcon = true;
            this.btn_SelectColor.AutoSizeRightIcon = true;
            this.btn_SelectColor.BackColor = System.Drawing.Color.Transparent;
            this.btn_SelectColor.BackColor1 = System.Drawing.Color.DimGray;
            this.btn_SelectColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SelectColor.BackgroundImage")));
            this.btn_SelectColor.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SelectColor.ButtonText = "";
            this.btn_SelectColor.ButtonTextMarginLeft = 0;
            this.btn_SelectColor.ColorContrastOnClick = 45;
            this.btn_SelectColor.ColorContrastOnHover = 45;
            this.btn_SelectColor.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.btn_SelectColor.CustomizableEdges = borderEdges13;
            this.btn_SelectColor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_SelectColor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_SelectColor.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_SelectColor.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_SelectColor.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_SelectColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SelectColor.ForeColor = System.Drawing.Color.White;
            this.btn_SelectColor.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SelectColor.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_SelectColor.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btn_SelectColor.IconMarginLeft = 11;
            this.btn_SelectColor.IconPadding = 5;
            this.btn_SelectColor.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SelectColor.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_SelectColor.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_SelectColor.IconSize = 25;
            this.btn_SelectColor.IdleBorderColor = System.Drawing.Color.White;
            this.btn_SelectColor.IdleBorderRadius = 8;
            this.btn_SelectColor.IdleBorderThickness = 1;
            this.btn_SelectColor.IdleFillColor = System.Drawing.Color.DimGray;
            this.btn_SelectColor.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_SelectColor.IdleIconLeftImage")));
            this.btn_SelectColor.IdleIconRightImage = null;
            this.btn_SelectColor.IndicateFocus = false;
            this.btn_SelectColor.Location = new System.Drawing.Point(6, 140);
            this.btn_SelectColor.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.btn_SelectColor.Name = "btn_SelectColor";
            this.btn_SelectColor.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_SelectColor.OnDisabledState.BorderRadius = 8;
            this.btn_SelectColor.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SelectColor.OnDisabledState.BorderThickness = 1;
            this.btn_SelectColor.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_SelectColor.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_SelectColor.OnDisabledState.IconLeftImage = null;
            this.btn_SelectColor.OnDisabledState.IconRightImage = null;
            this.btn_SelectColor.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_SelectColor.onHoverState.BorderRadius = 8;
            this.btn_SelectColor.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SelectColor.onHoverState.BorderThickness = 1;
            this.btn_SelectColor.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_SelectColor.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_SelectColor.onHoverState.IconLeftImage = null;
            this.btn_SelectColor.onHoverState.IconRightImage = null;
            this.btn_SelectColor.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_SelectColor.OnIdleState.BorderRadius = 8;
            this.btn_SelectColor.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SelectColor.OnIdleState.BorderThickness = 1;
            this.btn_SelectColor.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btn_SelectColor.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_SelectColor.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_SelectColor.OnIdleState.IconLeftImage")));
            this.btn_SelectColor.OnIdleState.IconRightImage = null;
            this.btn_SelectColor.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_SelectColor.OnPressedState.BorderRadius = 8;
            this.btn_SelectColor.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SelectColor.OnPressedState.BorderThickness = 1;
            this.btn_SelectColor.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_SelectColor.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_SelectColor.OnPressedState.IconLeftImage = null;
            this.btn_SelectColor.OnPressedState.IconRightImage = null;
            this.btn_SelectColor.Size = new System.Drawing.Size(28, 28);
            this.btn_SelectColor.TabIndex = 48;
            this.btn_SelectColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SelectColor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_SelectColor.TextMarginLeft = 0;
            this.btn_SelectColor.TextPadding = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.btn_SelectColor, "Brush Tool");
            this.btn_SelectColor.UseDefaultRadiusAndThickness = true;
            this.btn_SelectColor.Click += new System.EventHandler(this.btn_SelectColor_Click);
            // 
            // pt_draw
            // 
            this.pt_draw.BackColor = System.Drawing.Color.White;
            this.pt_draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pt_draw.Location = new System.Drawing.Point(0, 0);
            this.pt_draw.Name = "pt_draw";
            this.pt_draw.Size = new System.Drawing.Size(788, 497);
            this.pt_draw.TabIndex = 12;
            this.pt_draw.TabStop = false;
            this.pt_draw.Paint += new System.Windows.Forms.PaintEventHandler(this.pt_draw_Paint);
            this.pt_draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_paint_MouseDown);
            this.pt_draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_paint_MouseMove);
            this.pt_draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_paint_MouseUp);
            // 
            // panel_paint
            // 
            this.panel_paint.BackColor = System.Drawing.Color.DimGray;
            this.panel_paint.Controls.Add(this.pt_draw);
            this.panel_paint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_paint.Location = new System.Drawing.Point(250, 64);
            this.panel_paint.Name = "panel_paint";
            this.panel_paint.Size = new System.Drawing.Size(788, 497);
            this.panel_paint.TabIndex = 13;
            // 
            // lb_MousePos
            // 
            this.lb_MousePos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lb_MousePos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_MousePos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MousePos.ForeColor = System.Drawing.Color.White;
            this.lb_MousePos.Location = new System.Drawing.Point(0, 0);
            this.lb_MousePos.Name = "lb_MousePos";
            this.lb_MousePos.Size = new System.Drawing.Size(220, 28);
            this.lb_MousePos.TabIndex = 5;
            this.lb_MousePos.Text = "Mouse";
            this.lb_MousePos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Color
            // 
            this.panel_Color.BackColor = System.Drawing.Color.DimGray;
            this.panel_Color.Controls.Add(this.subTableLayoutPanel_Color2);
            this.panel_Color.Controls.Add(this.subTableLayoutPanel_Color);
            this.panel_Color.Controls.Add(this.lb_Color);
            this.panel_Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Color.Location = new System.Drawing.Point(0, 0);
            this.panel_Color.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Color.Name = "panel_Color";
            this.panel_Color.Size = new System.Drawing.Size(214, 217);
            this.panel_Color.TabIndex = 4;
            // 
            // subTableLayoutPanel_Color2
            // 
            this.subTableLayoutPanel_Color2.ColumnCount = 1;
            this.subTableLayoutPanel_Color2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subTableLayoutPanel_Color2.Controls.Add(this.colorPicker, 0, 0);
            this.subTableLayoutPanel_Color2.Controls.Add(this.panel2, 0, 1);
            this.subTableLayoutPanel_Color2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subTableLayoutPanel_Color2.Location = new System.Drawing.Point(62, 28);
            this.subTableLayoutPanel_Color2.Name = "subTableLayoutPanel_Color2";
            this.subTableLayoutPanel_Color2.RowCount = 2;
            this.subTableLayoutPanel_Color2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.subTableLayoutPanel_Color2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.subTableLayoutPanel_Color2.Size = new System.Drawing.Size(152, 189);
            this.subTableLayoutPanel_Color2.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox_ColorPreview);
            this.panel2.Controls.Add(this.label_ColorPreview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 19);
            this.panel2.TabIndex = 65;
            // 
            // pictureBox_ColorPreview
            // 
            this.pictureBox_ColorPreview.BackColor = System.Drawing.Color.Black;
            this.pictureBox_ColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_ColorPreview.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_ColorPreview.Location = new System.Drawing.Point(94, 0);
            this.pictureBox_ColorPreview.Name = "pictureBox_ColorPreview";
            this.pictureBox_ColorPreview.Size = new System.Drawing.Size(58, 19);
            this.pictureBox_ColorPreview.TabIndex = 64;
            this.pictureBox_ColorPreview.TabStop = false;
            // 
            // label_ColorPreview
            // 
            this.label_ColorPreview.AutoSize = true;
            this.label_ColorPreview.BackColor = System.Drawing.Color.Transparent;
            this.label_ColorPreview.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_ColorPreview.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ColorPreview.ForeColor = System.Drawing.Color.White;
            this.label_ColorPreview.Location = new System.Drawing.Point(0, 0);
            this.label_ColorPreview.Name = "label_ColorPreview";
            this.label_ColorPreview.Size = new System.Drawing.Size(94, 16);
            this.label_ColorPreview.TabIndex = 63;
            this.label_ColorPreview.Text = "Color Preview:";
            // 
            // subTableLayoutPanel_Color
            // 
            this.subTableLayoutPanel_Color.ColumnCount = 1;
            this.subTableLayoutPanel_Color.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subTableLayoutPanel_Color.Controls.Add(this.btn_SelectColor, 0, 4);
            this.subTableLayoutPanel_Color.Controls.Add(this.subPanelBtextBox, 0, 3);
            this.subTableLayoutPanel_Color.Controls.Add(this.panel7, 0, 2);
            this.subTableLayoutPanel_Color.Controls.Add(this.subPanelColorPicked, 0, 0);
            this.subTableLayoutPanel_Color.Controls.Add(this.panel3, 0, 1);
            this.subTableLayoutPanel_Color.Dock = System.Windows.Forms.DockStyle.Left;
            this.subTableLayoutPanel_Color.Location = new System.Drawing.Point(0, 28);
            this.subTableLayoutPanel_Color.Name = "subTableLayoutPanel_Color";
            this.subTableLayoutPanel_Color.RowCount = 5;
            this.subTableLayoutPanel_Color.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.subTableLayoutPanel_Color.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.39754F));
            this.subTableLayoutPanel_Color.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.39754F));
            this.subTableLayoutPanel_Color.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.39754F));
            this.subTableLayoutPanel_Color.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.80738F));
            this.subTableLayoutPanel_Color.Size = new System.Drawing.Size(62, 189);
            this.subTableLayoutPanel_Color.TabIndex = 57;
            // 
            // subPanelBtextBox
            // 
            this.subPanelBtextBox.Controls.Add(this.textBox_Bvalue);
            this.subPanelBtextBox.Controls.Add(this.label_B_value);
            this.subPanelBtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPanelBtextBox.Location = new System.Drawing.Point(0, 110);
            this.subPanelBtextBox.Margin = new System.Windows.Forms.Padding(0);
            this.subPanelBtextBox.Name = "subPanelBtextBox";
            this.subPanelBtextBox.Size = new System.Drawing.Size(62, 27);
            this.subPanelBtextBox.TabIndex = 4;
            // 
            // textBox_Bvalue
            // 
            this.textBox_Bvalue.BackColor = System.Drawing.Color.DimGray;
            this.textBox_Bvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Bvalue.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_Bvalue.Font = new System.Drawing.Font("Century Schoolbook", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Bvalue.ForeColor = System.Drawing.Color.White;
            this.textBox_Bvalue.Location = new System.Drawing.Point(23, 0);
            this.textBox_Bvalue.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Bvalue.Multiline = true;
            this.textBox_Bvalue.Name = "textBox_Bvalue";
            this.textBox_Bvalue.ReadOnly = true;
            this.textBox_Bvalue.Size = new System.Drawing.Size(30, 27);
            this.textBox_Bvalue.TabIndex = 57;
            this.textBox_Bvalue.Text = "0";
            // 
            // label_B_value
            // 
            this.label_B_value.AutoSize = true;
            this.label_B_value.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_B_value.Font = new System.Drawing.Font("Century Schoolbook", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B_value.ForeColor = System.Drawing.Color.White;
            this.label_B_value.Location = new System.Drawing.Point(0, 0);
            this.label_B_value.Margin = new System.Windows.Forms.Padding(6);
            this.label_B_value.Name = "label_B_value";
            this.label_B_value.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label_B_value.Size = new System.Drawing.Size(23, 16);
            this.label_B_value.TabIndex = 53;
            this.label_B_value.Text = "B:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.subPanelGtextBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 83);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(62, 27);
            this.panel7.TabIndex = 3;
            // 
            // subPanelGtextBox
            // 
            this.subPanelGtextBox.Controls.Add(this.textBox_Gvalue);
            this.subPanelGtextBox.Controls.Add(this.label_G_value);
            this.subPanelGtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPanelGtextBox.Location = new System.Drawing.Point(0, 0);
            this.subPanelGtextBox.Margin = new System.Windows.Forms.Padding(0);
            this.subPanelGtextBox.Name = "subPanelGtextBox";
            this.subPanelGtextBox.Size = new System.Drawing.Size(62, 27);
            this.subPanelGtextBox.TabIndex = 3;
            // 
            // textBox_Gvalue
            // 
            this.textBox_Gvalue.BackColor = System.Drawing.Color.DimGray;
            this.textBox_Gvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Gvalue.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_Gvalue.Font = new System.Drawing.Font("Century Schoolbook", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Gvalue.ForeColor = System.Drawing.Color.White;
            this.textBox_Gvalue.Location = new System.Drawing.Point(23, 0);
            this.textBox_Gvalue.Multiline = true;
            this.textBox_Gvalue.Name = "textBox_Gvalue";
            this.textBox_Gvalue.ReadOnly = true;
            this.textBox_Gvalue.Size = new System.Drawing.Size(28, 27);
            this.textBox_Gvalue.TabIndex = 56;
            this.textBox_Gvalue.Text = "0";
            // 
            // label_G_value
            // 
            this.label_G_value.AutoSize = true;
            this.label_G_value.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_G_value.Font = new System.Drawing.Font("Century Schoolbook", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_G_value.ForeColor = System.Drawing.Color.White;
            this.label_G_value.Location = new System.Drawing.Point(0, 0);
            this.label_G_value.Margin = new System.Windows.Forms.Padding(6);
            this.label_G_value.Name = "label_G_value";
            this.label_G_value.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label_G_value.Size = new System.Drawing.Size(23, 16);
            this.label_G_value.TabIndex = 52;
            this.label_G_value.Text = "G:";
            // 
            // subPanelColorPicked
            // 
            this.subPanelColorPicked.Controls.Add(this.pictureBox_Color_Front);
            this.subPanelColorPicked.Controls.Add(this.pictureBox_Color_Back);
            this.subPanelColorPicked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPanelColorPicked.Location = new System.Drawing.Point(0, 0);
            this.subPanelColorPicked.Margin = new System.Windows.Forms.Padding(0);
            this.subPanelColorPicked.Name = "subPanelColorPicked";
            this.subPanelColorPicked.Size = new System.Drawing.Size(62, 56);
            this.subPanelColorPicked.TabIndex = 0;
            // 
            // pictureBox_Color_Front
            // 
            this.pictureBox_Color_Front.BackColor = System.Drawing.Color.Black;
            this.pictureBox_Color_Front.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Color_Front.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Color_Front.Location = new System.Drawing.Point(8, 6);
            this.pictureBox_Color_Front.Name = "pictureBox_Color_Front";
            this.pictureBox_Color_Front.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_Color_Front.TabIndex = 50;
            this.pictureBox_Color_Front.TabStop = false;
            this.pictureBox_Color_Front.BackColorChanged += new System.EventHandler(this.pictureBox_Color_Front_BackColorChanged);
            this.pictureBox_Color_Front.Click += new System.EventHandler(this.color_Swap);
            // 
            // pictureBox_Color_Back
            // 
            this.pictureBox_Color_Back.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox_Color_Back.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Color_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Color_Back.Location = new System.Drawing.Point(22, 19);
            this.pictureBox_Color_Back.Name = "pictureBox_Color_Back";
            this.pictureBox_Color_Back.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_Color_Back.TabIndex = 49;
            this.pictureBox_Color_Back.TabStop = false;
            this.pictureBox_Color_Back.Click += new System.EventHandler(this.color_Swap);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(62, 27);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 27);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.subPanelRtextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(62, 27);
            this.panel5.TabIndex = 3;
            // 
            // subPanelRtextBox
            // 
            this.subPanelRtextBox.Controls.Add(this.textBox_Rvalue);
            this.subPanelRtextBox.Controls.Add(this.label_R_value);
            this.subPanelRtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPanelRtextBox.Location = new System.Drawing.Point(0, 0);
            this.subPanelRtextBox.Margin = new System.Windows.Forms.Padding(0);
            this.subPanelRtextBox.Name = "subPanelRtextBox";
            this.subPanelRtextBox.Size = new System.Drawing.Size(62, 27);
            this.subPanelRtextBox.TabIndex = 3;
            // 
            // textBox_Rvalue
            // 
            this.textBox_Rvalue.BackColor = System.Drawing.Color.DimGray;
            this.textBox_Rvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Rvalue.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_Rvalue.Font = new System.Drawing.Font("Century Schoolbook", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Rvalue.ForeColor = System.Drawing.Color.White;
            this.textBox_Rvalue.Location = new System.Drawing.Point(23, 0);
            this.textBox_Rvalue.Multiline = true;
            this.textBox_Rvalue.Name = "textBox_Rvalue";
            this.textBox_Rvalue.ReadOnly = true;
            this.textBox_Rvalue.Size = new System.Drawing.Size(30, 27);
            this.textBox_Rvalue.TabIndex = 54;
            this.textBox_Rvalue.Text = "0";
            // 
            // label_R_value
            // 
            this.label_R_value.AutoSize = true;
            this.label_R_value.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_R_value.Font = new System.Drawing.Font("Century Schoolbook", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_R_value.ForeColor = System.Drawing.Color.White;
            this.label_R_value.Location = new System.Drawing.Point(0, 0);
            this.label_R_value.Margin = new System.Windows.Forms.Padding(6);
            this.label_R_value.Name = "label_R_value";
            this.label_R_value.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label_R_value.Size = new System.Drawing.Size(23, 16);
            this.label_R_value.TabIndex = 51;
            this.label_R_value.Text = "R:";
            // 
            // lb_Color
            // 
            this.lb_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lb_Color.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Color.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Color.ForeColor = System.Drawing.Color.White;
            this.lb_Color.Location = new System.Drawing.Point(0, 0);
            this.lb_Color.Name = "lb_Color";
            this.lb_Color.Size = new System.Drawing.Size(214, 28);
            this.lb_Color.TabIndex = 5;
            this.lb_Color.Text = "Color";
            this.lb_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_BrushControl
            // 
            this.panel_BrushControl.BackColor = System.Drawing.Color.DimGray;
            this.panel_BrushControl.Controls.Add(this.lb_value_size);
            this.panel_BrushControl.Controls.Add(this.trackBar_Size);
            this.panel_BrushControl.Controls.Add(this.lb_Size);
            this.panel_BrushControl.Controls.Add(this.lb_BrushControl);
            this.panel_BrushControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BrushControl.Location = new System.Drawing.Point(0, 235);
            this.panel_BrushControl.Margin = new System.Windows.Forms.Padding(0);
            this.panel_BrushControl.Name = "panel_BrushControl";
            this.panel_BrushControl.Size = new System.Drawing.Size(214, 122);
            this.panel_BrushControl.TabIndex = 6;
            // 
            // lb_value_size
            // 
            this.lb_value_size.AutoSize = true;
            this.lb_value_size.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_value_size.Location = new System.Drawing.Point(27, 60);
            this.lb_value_size.Name = "lb_value_size";
            this.lb_value_size.Size = new System.Drawing.Size(15, 17);
            this.lb_value_size.TabIndex = 8;
            this.lb_value_size.Text = "1";
            this.lb_value_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_Size
            // 
            this.trackBar_Size.Location = new System.Drawing.Point(81, 46);
            this.trackBar_Size.Maximum = 100;
            this.trackBar_Size.Minimum = 1;
            this.trackBar_Size.Name = "trackBar_Size";
            this.trackBar_Size.Size = new System.Drawing.Size(124, 56);
            this.trackBar_Size.TabIndex = 7;
            this.trackBar_Size.Value = 1;
            this.trackBar_Size.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // lb_Size
            // 
            this.lb_Size.AutoSize = true;
            this.lb_Size.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Size.ForeColor = System.Drawing.Color.White;
            this.lb_Size.Location = new System.Drawing.Point(21, 43);
            this.lb_Size.Name = "lb_Size";
            this.lb_Size.Size = new System.Drawing.Size(39, 21);
            this.lb_Size.TabIndex = 6;
            this.lb_Size.Text = "Size";
            // 
            // lb_BrushControl
            // 
            this.lb_BrushControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lb_BrushControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_BrushControl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BrushControl.ForeColor = System.Drawing.Color.White;
            this.lb_BrushControl.Location = new System.Drawing.Point(0, 0);
            this.lb_BrushControl.Name = "lb_BrushControl";
            this.lb_BrushControl.Size = new System.Drawing.Size(214, 33);
            this.lb_BrushControl.TabIndex = 5;
            this.lb_BrushControl.Text = "Brush Control";
            this.lb_BrushControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Brush
            // 
            this.panel_Brush.BackColor = System.Drawing.Color.DimGray;
            this.panel_Brush.Controls.Add(this.lb_y);
            this.panel_Brush.Controls.Add(this.lb_x);
            this.panel_Brush.Controls.Add(this.label2);
            this.panel_Brush.Controls.Add(this.label1);
            this.panel_Brush.Controls.Add(this.lb_pos);
            this.panel_Brush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Brush.Location = new System.Drawing.Point(0, 357);
            this.panel_Brush.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Brush.Name = "panel_Brush";
            this.panel_Brush.Size = new System.Drawing.Size(214, 140);
            this.panel_Brush.TabIndex = 7;
            // 
            // lb_y
            // 
            this.lb_y.AutoSize = true;
            this.lb_y.Location = new System.Drawing.Point(136, 59);
            this.lb_y.Name = "lb_y";
            this.lb_y.Size = new System.Drawing.Size(15, 17);
            this.lb_y.TabIndex = 9;
            this.lb_y.Text = "0";
            // 
            // lb_x
            // 
            this.lb_x.AutoSize = true;
            this.lb_x.Location = new System.Drawing.Point(54, 58);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(15, 17);
            this.lb_x.TabIndex = 8;
            this.lb_x.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "X:";
            // 
            // lb_pos
            // 
            this.lb_pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lb_pos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_pos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pos.ForeColor = System.Drawing.Color.White;
            this.lb_pos.Location = new System.Drawing.Point(0, 0);
            this.lb_pos.Name = "lb_pos";
            this.lb_pos.Size = new System.Drawing.Size(214, 28);
            this.lb_pos.TabIndex = 5;
            this.lb_pos.Text = "Mouse";
            this.lb_pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel_Brush, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel_BrushControl, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel_Color, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(36, 64);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.66197F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.62173F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.60457F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.76801F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(214, 497);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // colorPicker
            // 
            this.colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPicker.Location = new System.Drawing.Point(3, 3);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(146, 145);
            this.colorPicker.TabIndex = 64;
            this.colorPicker.ColorPicked += new System.EventHandler(this.colorPicker_ColorPicked);
            this.colorPicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1038, 561);
            this.Controls.Add(this.panel_paint);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel_PaintTool);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tLP_Shape.ResumeLayout(false);
            this.tableLayoutPanel_PaintTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pt_draw)).EndInit();
            this.panel_paint.ResumeLayout(false);
            this.panel_Color.ResumeLayout(false);
            this.subTableLayoutPanel_Color2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorPreview)).EndInit();
            this.subTableLayoutPanel_Color.ResumeLayout(false);
            this.subPanelBtextBox.ResumeLayout(false);
            this.subPanelBtextBox.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.subPanelGtextBox.ResumeLayout(false);
            this.subPanelGtextBox.PerformLayout();
            this.subPanelColorPicked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color_Front)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color_Back)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.subPanelRtextBox.ResumeLayout(false);
            this.subPanelRtextBox.PerformLayout();
            this.panel_BrushControl.ResumeLayout(false);
            this.panel_BrushControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Size)).EndInit();
            this.panel_Brush.ResumeLayout(false);
            this.panel_Brush.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
  
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_PaintTool;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tLP_Shape;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Bucket;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Shape;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Fill;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Eraser;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Brush;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Eyedropper;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Redo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Undo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Triangle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Circle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Rectangle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Line;
        private System.Windows.Forms.Panel panel_Navigator;
        private System.Windows.Forms.Panel panel_BrushSize;
        private System.Windows.Forms.Label lb_BrushSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem initializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBarToolStripMenuItem;
        public System.Windows.Forms.PictureBox pt_draw;
        private System.Windows.Forms.Panel panel_paint;
        private System.Windows.Forms.Label lb_MousePos;
        private System.Windows.Forms.Panel panel_Color;
        private System.Windows.Forms.TableLayoutPanel subTableLayoutPanel_Color2;
        private AboControls.ExtendedControls.ColorPickerControl colorPicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_ColorPreview;
        private System.Windows.Forms.Label label_ColorPreview;
        private System.Windows.Forms.TableLayoutPanel subTableLayoutPanel_Color;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_SelectColor;
        private System.Windows.Forms.Panel subPanelBtextBox;
        private System.Windows.Forms.TextBox textBox_Bvalue;
        private System.Windows.Forms.Label label_B_value;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel subPanelGtextBox;
        private System.Windows.Forms.TextBox textBox_Gvalue;
        private System.Windows.Forms.Label label_G_value;
        private System.Windows.Forms.Panel subPanelColorPicked;
        private System.Windows.Forms.PictureBox pictureBox_Color_Front;
        private System.Windows.Forms.PictureBox pictureBox_Color_Back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel subPanelRtextBox;
        private System.Windows.Forms.TextBox textBox_Rvalue;
        private System.Windows.Forms.Label label_R_value;
        private System.Windows.Forms.Label lb_Color;
        private System.Windows.Forms.Panel panel_BrushControl;
        private System.Windows.Forms.Label lb_value_size;
        private System.Windows.Forms.TrackBar trackBar_Size;
        private System.Windows.Forms.Label lb_Size;
        private System.Windows.Forms.Label lb_BrushControl;
        private System.Windows.Forms.Panel panel_Brush;
        private System.Windows.Forms.Label lb_y;
        public System.Windows.Forms.Label lb_x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_pos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}

