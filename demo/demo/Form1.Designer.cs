namespace demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_bucket = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 143);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Controls.Add(this.btn_bucket);
            this.panel3.Controls.Add(this.btn_pencil);
            this.panel3.Location = new System.Drawing.Point(118, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.Navy;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eraser.Image = ((System.Drawing.Image)(resources.GetObject("btn_eraser.Image")));
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eraser.Location = new System.Drawing.Point(3, 68);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(57, 57);
            this.btn_eraser.TabIndex = 5;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            // 
            // btn_bucket
            // 
            this.btn_bucket.BackColor = System.Drawing.Color.Navy;
            this.btn_bucket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_bucket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_bucket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bucket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bucket.Image = ((System.Drawing.Image)(resources.GetObject("btn_bucket.Image")));
            this.btn_bucket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_bucket.Location = new System.Drawing.Point(3, 5);
            this.btn_bucket.Name = "btn_bucket";
            this.btn_bucket.Size = new System.Drawing.Size(57, 57);
            this.btn_bucket.TabIndex = 4;
            this.btn_bucket.Text = "Bucket";
            this.btn_bucket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_bucket.UseVisualStyleBackColor = false;
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.Navy;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pencil.Image = ((System.Drawing.Image)(resources.GetObject("btn_pencil.Image")));
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pencil.Location = new System.Drawing.Point(69, 5);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(57, 57);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 307);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 17);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAINT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_eraser;
        private Button btn_bucket;
        private Button btn_pencil;
    }
}