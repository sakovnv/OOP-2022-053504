
namespace Paint
{
    partial class MainForm
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
            this.PaintPictureBox = new System.Windows.Forms.PictureBox();
            this.ChooseColorDialog = new System.Windows.Forms.ColorDialog();
            this.ChoosePenColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LineRadioButton = new System.Windows.Forms.RadioButton();
            this.RectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.Figures = new System.Windows.Forms.GroupBox();
            this.PolygonRadioButton = new System.Windows.Forms.RadioButton();
            this.BrokenLineRadioButton = new System.Windows.Forms.RadioButton();
            this.EllipseRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseBrushColorButton = new System.Windows.Forms.Button();
            this.WidthTrackBar = new System.Windows.Forms.TrackBar();
            this.PosXTextBox = new System.Windows.Forms.TextBox();
            this.PosYTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddPointButton = new System.Windows.Forms.Button();
            this.PreviousActionButton = new System.Windows.Forms.Button();
            this.nextActionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaintPictureBox)).BeginInit();
            this.Figures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PaintPictureBox
            // 
            this.PaintPictureBox.BackColor = System.Drawing.Color.White;
            this.PaintPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintPictureBox.Location = new System.Drawing.Point(12, 12);
            this.PaintPictureBox.Name = "PaintPictureBox";
            this.PaintPictureBox.Size = new System.Drawing.Size(600, 400);
            this.PaintPictureBox.TabIndex = 0;
            this.PaintPictureBox.TabStop = false;
            this.PaintPictureBox.Click += new System.EventHandler(this.PaintPictureBox_Click);
            this.PaintPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintPictureBox_MouseDown);
            this.PaintPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintPictureBox_MouseMove);
            this.PaintPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintPictureBox_MouseUp);
            // 
            // ChoosePenColorButton
            // 
            this.ChoosePenColorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChoosePenColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ChoosePenColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosePenColorButton.Location = new System.Drawing.Point(746, 375);
            this.ChoosePenColorButton.Margin = new System.Windows.Forms.Padding(10);
            this.ChoosePenColorButton.Name = "ChoosePenColorButton";
            this.ChoosePenColorButton.Size = new System.Drawing.Size(35, 35);
            this.ChoosePenColorButton.TabIndex = 1;
            this.ChoosePenColorButton.UseVisualStyleBackColor = false;
            this.ChoosePenColorButton.Click += new System.EventHandler(this.ChooseColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(629, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pen color";
            // 
            // LineRadioButton
            // 
            this.LineRadioButton.AutoSize = true;
            this.LineRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LineRadioButton.Location = new System.Drawing.Point(6, 22);
            this.LineRadioButton.Name = "LineRadioButton";
            this.LineRadioButton.Size = new System.Drawing.Size(57, 25);
            this.LineRadioButton.TabIndex = 3;
            this.LineRadioButton.Text = "Line";
            this.LineRadioButton.UseVisualStyleBackColor = true;
            this.LineRadioButton.CheckedChanged += new System.EventHandler(this.LineRadioButton_CheckedChanged);
            // 
            // RectangleRadioButton
            // 
            this.RectangleRadioButton.AutoSize = true;
            this.RectangleRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RectangleRadioButton.Location = new System.Drawing.Point(6, 53);
            this.RectangleRadioButton.Name = "RectangleRadioButton";
            this.RectangleRadioButton.Size = new System.Drawing.Size(96, 25);
            this.RectangleRadioButton.TabIndex = 4;
            this.RectangleRadioButton.Text = "Rectangle";
            this.RectangleRadioButton.UseVisualStyleBackColor = true;
            this.RectangleRadioButton.CheckedChanged += new System.EventHandler(this.RectangleRadioButton_CheckedChanged);
            // 
            // Figures
            // 
            this.Figures.Controls.Add(this.PolygonRadioButton);
            this.Figures.Controls.Add(this.BrokenLineRadioButton);
            this.Figures.Controls.Add(this.EllipseRadioButton);
            this.Figures.Controls.Add(this.LineRadioButton);
            this.Figures.Controls.Add(this.RectangleRadioButton);
            this.Figures.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Figures.Location = new System.Drawing.Point(618, 12);
            this.Figures.Name = "Figures";
            this.Figures.Size = new System.Drawing.Size(170, 178);
            this.Figures.TabIndex = 5;
            this.Figures.TabStop = false;
            this.Figures.Text = "Figures";
            // 
            // PolygonRadioButton
            // 
            this.PolygonRadioButton.AutoSize = true;
            this.PolygonRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PolygonRadioButton.Location = new System.Drawing.Point(6, 146);
            this.PolygonRadioButton.Name = "PolygonRadioButton";
            this.PolygonRadioButton.Size = new System.Drawing.Size(84, 25);
            this.PolygonRadioButton.TabIndex = 7;
            this.PolygonRadioButton.Text = "Polygon";
            this.PolygonRadioButton.UseVisualStyleBackColor = true;
            this.PolygonRadioButton.CheckedChanged += new System.EventHandler(this.PolygonRadioButton_CheckedChanged);
            // 
            // BrokenLineRadioButton
            // 
            this.BrokenLineRadioButton.AutoSize = true;
            this.BrokenLineRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrokenLineRadioButton.Location = new System.Drawing.Point(6, 115);
            this.BrokenLineRadioButton.Name = "BrokenLineRadioButton";
            this.BrokenLineRadioButton.Size = new System.Drawing.Size(106, 25);
            this.BrokenLineRadioButton.TabIndex = 6;
            this.BrokenLineRadioButton.Text = "Broken line";
            this.BrokenLineRadioButton.UseVisualStyleBackColor = true;
            this.BrokenLineRadioButton.CheckedChanged += new System.EventHandler(this.BrokenLineRadioButton_CheckedChanged);
            // 
            // EllipseRadioButton
            // 
            this.EllipseRadioButton.AutoSize = true;
            this.EllipseRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EllipseRadioButton.Location = new System.Drawing.Point(6, 84);
            this.EllipseRadioButton.Name = "EllipseRadioButton";
            this.EllipseRadioButton.Size = new System.Drawing.Size(72, 25);
            this.EllipseRadioButton.TabIndex = 5;
            this.EllipseRadioButton.Text = "Ellipse";
            this.EllipseRadioButton.UseVisualStyleBackColor = true;
            this.EllipseRadioButton.CheckedChanged += new System.EventHandler(this.EllipseRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(622, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Brush color";
            // 
            // ChooseBrushColorButton
            // 
            this.ChooseBrushColorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChooseBrushColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ChooseBrushColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseBrushColorButton.Location = new System.Drawing.Point(746, 331);
            this.ChooseBrushColorButton.Margin = new System.Windows.Forms.Padding(10);
            this.ChooseBrushColorButton.Name = "ChooseBrushColorButton";
            this.ChooseBrushColorButton.Size = new System.Drawing.Size(35, 35);
            this.ChooseBrushColorButton.TabIndex = 6;
            this.ChooseBrushColorButton.UseVisualStyleBackColor = false;
            this.ChooseBrushColorButton.Click += new System.EventHandler(this.ChooseBrushColorButton_Click);
            // 
            // WidthTrackBar
            // 
            this.WidthTrackBar.Location = new System.Drawing.Point(629, 285);
            this.WidthTrackBar.Maximum = 15;
            this.WidthTrackBar.Minimum = 1;
            this.WidthTrackBar.Name = "WidthTrackBar";
            this.WidthTrackBar.Size = new System.Drawing.Size(152, 45);
            this.WidthTrackBar.TabIndex = 8;
            this.WidthTrackBar.Value = 1;
            this.WidthTrackBar.Scroll += new System.EventHandler(this.WidthTrackBar_Scroll);
            // 
            // PosXTextBox
            // 
            this.PosXTextBox.Location = new System.Drawing.Point(646, 196);
            this.PosXTextBox.Name = "PosXTextBox";
            this.PosXTextBox.Size = new System.Drawing.Size(50, 23);
            this.PosXTextBox.TabIndex = 9;
            // 
            // PosYTextBox
            // 
            this.PosYTextBox.Location = new System.Drawing.Point(731, 196);
            this.PosYTextBox.Name = "PosYTextBox";
            this.PosYTextBox.Size = new System.Drawing.Size(50, 23);
            this.PosYTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(619, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(705, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Y:";
            // 
            // AddPointButton
            // 
            this.AddPointButton.Location = new System.Drawing.Point(706, 225);
            this.AddPointButton.Name = "AddPointButton";
            this.AddPointButton.Size = new System.Drawing.Size(75, 23);
            this.AddPointButton.TabIndex = 14;
            this.AddPointButton.Text = "Add point";
            this.AddPointButton.UseVisualStyleBackColor = true;
            this.AddPointButton.Click += new System.EventHandler(this.AddPointButton_Click);
            // 
            // PreviousActionButton
            // 
            this.PreviousActionButton.Location = new System.Drawing.Point(624, 256);
            this.PreviousActionButton.Name = "PreviousActionButton";
            this.PreviousActionButton.Size = new System.Drawing.Size(33, 23);
            this.PreviousActionButton.TabIndex = 15;
            this.PreviousActionButton.Text = "<";
            this.PreviousActionButton.UseVisualStyleBackColor = true;
            this.PreviousActionButton.Click += new System.EventHandler(this.PreviousActionButton_Click);
            // 
            // nextActionButton
            // 
            this.nextActionButton.Location = new System.Drawing.Point(663, 256);
            this.nextActionButton.Name = "nextActionButton";
            this.nextActionButton.Size = new System.Drawing.Size(33, 23);
            this.nextActionButton.TabIndex = 16;
            this.nextActionButton.Text = ">";
            this.nextActionButton.UseVisualStyleBackColor = true;
            this.nextActionButton.Click += new System.EventHandler(this.nextActionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.nextActionButton);
            this.Controls.Add(this.PreviousActionButton);
            this.Controls.Add(this.AddPointButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PosYTextBox);
            this.Controls.Add(this.PosXTextBox);
            this.Controls.Add(this.WidthTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChooseBrushColorButton);
            this.Controls.Add(this.Figures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoosePenColorButton);
            this.Controls.Add(this.PaintPictureBox);
            this.Name = "MainForm";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.PaintPictureBox)).EndInit();
            this.Figures.ResumeLayout(false);
            this.Figures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PaintPictureBox;
        private System.Windows.Forms.ColorDialog ChooseColorDialog;
        private System.Windows.Forms.Button ChoosePenColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton LineRadioButton;
        private System.Windows.Forms.RadioButton RectangleRadioButton;
        private System.Windows.Forms.GroupBox Figures;
        private System.Windows.Forms.RadioButton BrokenLineRadioButton;
        private System.Windows.Forms.RadioButton EllipseRadioButton;
        private System.Windows.Forms.RadioButton PolygonRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChooseBrushColorButton;
        private System.Windows.Forms.TrackBar WidthTrackBar;
        private System.Windows.Forms.TextBox PosXTextBox;
        private System.Windows.Forms.TextBox PosYTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPointButton;
        private System.Windows.Forms.Button PreviousActionButton;
        private System.Windows.Forms.Button nextActionButton;
    }
}

