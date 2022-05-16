using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    public class BrokenLine : Figure
    {
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
        }

        public override Image Draw() 
        {
            if (points.Count == 2)
            {
                graphics.DrawLine(Set.Pen, points[0], points[1]);
                points.RemoveAt(0);

                Bitmap nBitmap = new Bitmap(Set.Bitmap);
                Set.Bitmaps.Add(nBitmap);
                Set.BitmapsCut();
            }
            return bitmap;
        }
    }
}
