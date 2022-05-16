using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Массив Bitmap'ов*/

namespace Paint.Shapes
{
    public abstract class Figure
    {
        protected List<Point> points;

        protected Bitmap bitmap;
        protected Graphics graphics;
        protected Bitmap cpBitmap;


        public Figure()
        {
            points = new List<Point>();

            bitmap = Set.Bitmap;

            graphics = Set.Graphics;
        }

        public virtual Image Update(Point point)
        {
            return bitmap;
        }

        public abstract void AddPoint(Point point);

        public abstract Image Draw();

    }
}
