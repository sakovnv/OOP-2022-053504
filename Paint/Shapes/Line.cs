using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    public class Line : Figure
    {
        public Line() : base()
        {
        }

        public override Image Update(Point point)
        {
            if (points.Count == 1)
            {
                graphics.DrawImage(cpBitmap, 0, 0);
                graphics.DrawLine(Set.Pen, points[0], point);
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
                Set.BitmapsCut();

                graphics.DrawLine(Set.Pen, points[0], points[1]);
                points.Clear();

                Bitmap cpyBitmap = new Bitmap(Set.Bitmap);
                Set.Bitmaps.Add(cpyBitmap);
            }
            return bitmap;
        }
    }
}
