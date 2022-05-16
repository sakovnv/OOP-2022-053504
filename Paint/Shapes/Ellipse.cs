using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    public class Ellipse : Figure
    {
        public Ellipse() : base()
        { 
        }

        public override Image Update(Point point)
        {
            if (points.Count == 1)
            {
                graphics.DrawImage(cpBitmap, 0, 0);

                int width = point.X - points[0].X;
                int height = point.Y - points[0].Y;

                graphics.FillEllipse(Set.Brush, points[0].X, points[0].Y, width, height);
                graphics.DrawEllipse(Set.Pen, points[0].X, points[0].Y, width, height);
            }
            return bitmap;
        }

        public override void AddPoint(Point point)
        {
            points.Add(point);

            cpBitmap = new Bitmap(bitmap);
        }

        public override Image Draw()
        {
            if (points.Count == 2)
            {
                int width = points[1].X - points[0].X;
                int height = points[1].Y - points[0].Y;

                graphics.FillEllipse(Set.Brush, points[0].X, points[0].Y, width, height);
                graphics.DrawEllipse(Set.Pen, points[0].X, points[0].Y, width, height);

                points.Clear();

                Bitmap nBitmap = new Bitmap(Set.Bitmap);
                Set.Bitmaps.Add(nBitmap);
                Set.BitmapsCut();
            }
            return bitmap;
        }
    }
}
