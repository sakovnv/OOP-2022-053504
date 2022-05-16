using Paint.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        private bool isRadioSelected = false;

        private Color currentColor = Color.FromArgb(0);

        private Figure figure;
        public MainForm()
        {
            InitializeComponent();
                
            //----------------------------------------

            
        }

        private void ChooseColorButton_Click(object sender, EventArgs e)
        {
            if (ChooseColorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            Set.Pen.Color = ChooseColorDialog.Color;
            ChoosePenColorButton.BackColor = ChooseColorDialog.Color;
        }
        private void ChooseBrushColorButton_Click(object sender, EventArgs e)
        {
            if (ChooseColorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            Set.Brush.Color = ChooseColorDialog.Color;
            ChooseBrushColorButton.BackColor = ChooseColorDialog.Color;
        }

        private void PaintPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (isRadioSelected)
            { 
                figure.AddPoint(e.Location);
                PaintPictureBox.Image = figure.Draw();
            }
        }

        private void PaintPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void LineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LineRadioButton.Checked == true)
            {
                isRadioSelected = true;

                figure = Set.Line;
            }
        }

        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RectangleRadioButton.Checked == true)
            {
                isRadioSelected = true;

                figure = Set.Rectangle;
            }
        }

        private void EllipseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EllipseRadioButton.Checked == true)
            {
                isRadioSelected = true;

                figure = Set.Ellipse;
            }
        }

        private void BrokenLineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BrokenLineRadioButton.Checked == true)
            {
                isRadioSelected = true;

                figure = Set.BrokenLine;
            }
        }

        private void PolygonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PolygonRadioButton.Checked == true)
            {
                isRadioSelected = true;

                figure = Set.Polygon;
            }
        }

        private void WidthTrackBar_Scroll(object sender, EventArgs e)
        {
            Set.Pen.Width = WidthTrackBar.Value;
        }

        private void AddPointButton_Click(object sender, EventArgs e)
        {
            int x, y;
            try
            {
                x = Convert.ToInt32(PosXTextBox.Text);
                y = Convert.ToInt32(PosYTextBox.Text);
                Point point = new Point(x, y);
                if (isRadioSelected)
                {
                    figure.AddPoint(point);
                    PaintPictureBox.Image = figure.Draw();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void PaintPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void PaintPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRadioSelected)
            {
                PaintPictureBox.Image = figure.Update(e.Location);
            }
        }

        private void PreviousActionButton_Click(object sender, EventArgs e)
        {
            Set.Graphics.DrawImage(Set.PrevBitmap, 0, 0);
            PaintPictureBox.Image = Set.Bitmap;
        }

        private void nextActionButton_Click(object sender, EventArgs e)
        {
            Set.Graphics.DrawImage(Set.NextBitmap, 0, 0);
            PaintPictureBox.Image = Set.Bitmap;
        }
    }
}
