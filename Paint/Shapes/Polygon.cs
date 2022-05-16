using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    public class Polygon : Figure
    {
        private int vertexAmount = 6;

        public override Image Update(Point point)
        {
            if (points.Count >= 1)
            {
                graphics.DrawImage(cpBitmap, 0, 0);
                graphics.DrawLine(Set.Pen, points[points.Count - 1], point);
            }
            return bitmap;
        }

        public override void AddPoint(Point point)
        {
            points.Add(point);

            cpBitmap = new Bitmap(bitmap);

            if (points.Count >= 2)
            {
                graphics.DrawLine(Set.Pen, points[points.Count - 2], points[points.Count - 1]);
            }
        }

        public override Image Draw()
        {
            if (points.Count == vertexAmount)
            { 
                graphics.FillPolygon(Set.Brush, points.ToArray());
                graphics.DrawPolygon(Set.Pen, points.ToArray());

                points.Clear();

                Bitmap nBitmap = new Bitmap(Set.Bitmap);
                Set.Bitmaps.Add(nBitmap);
                Set.BitmapsCut();
            }

            return bitmap;
        }
    }
}
