using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    public static class Set
    {
        private static Bitmap _bitmap;
        private static Graphics _graphics;
        private static Line _line;
        private static Rectangle _rectangle;
        private static Ellipse _ellipse;
        private static BrokenLine _brokenLine;
        private static Polygon _polygon;
        private static int _currentIndex = -1;

        private static List<Bitmap> _bitmaps;

        public static Pen Pen { get; set; } = new Pen(Color.Black);
        public static SolidBrush Brush { get; set; } = new SolidBrush(Color.Red);

        public static void MarkBitmap()
        {
            Bitmap cpyBitmap = new Bitmap(Bitmap);
            Bitmaps.Add(cpyBitmap);
            BitmapsCut();
        }

        public static void BitmapsCut()
        {
            if (_currentIndex != -1)
            { 
                int count = Bitmaps.Count - CurIndex;
                Bitmaps.RemoveRange(CurIndex, count);
            }
            _currentIndex = -1;
            
        }

        public static Bitmap NextBitmap
        {
            get
            {
                if (CurIndex < Bitmaps.Count - 1)
                {
                    return Bitmaps[NextIndex];
                }
                return Bitmaps[CurIndex];
            }
        }
        public static Bitmap PrevBitmap
        {
            get
            {
                if (CurIndex > 0)
                {
                    return Bitmaps[PrevIndex];
                }
                return Bitmaps[CurIndex];
            }
        }

        private static int NextIndex
        {
            get
            {
                return CurIndex += 1;
            }
        }

        private static int CurIndex
        {
            get
            {
                if (_currentIndex == -1)
                {
                    _currentIndex = Bitmaps.Count - 1;
                }
                return _currentIndex;
            }
            set
            {
                if (value >= 0 && value < Bitmaps.Count)
                { 
                    _currentIndex = value;
                }
            }
        }
        private static int PrevIndex
        {
            get
            {
                return CurIndex -= 1;
            }
        }

        public static List<Bitmap> Bitmaps 
        { 
            get
            {
                if (_bitmaps == null)
                {
                    _bitmaps = new List<Bitmap>();
                }
                return _bitmaps;
            }
        }

        public static Bitmap Bitmap 
        { 
            get
            {
                if (_bitmap == null)
                {
                    _bitmap = new Bitmap(600, 400);
                }
                return _bitmap;
            }
        }

        public static Graphics Graphics
        {
            get
            {
                if (_graphics == null)
                {
                    _graphics = System.Drawing.Graphics.FromImage(Bitmap);
                    _graphics.Clear(Color.White);

                    MarkBitmap();
                }
                return _graphics;
            }
        }

        public static Line Line
        {
            get
            {
                if (_line == null)
                {
                    _line = new Line();
                }
                return _line;
            }
        }

        public static Rectangle Rectangle
        {
            get
            {
                if (_rectangle == null)
                {
                    _rectangle = new Rectangle();
                }
                return _rectangle;
            }
        }

        public static Ellipse Ellipse
        {
            get
            {
                if (_ellipse == null)
                {
                    _ellipse = new Ellipse();
                }
                return _ellipse;
            }
        }

        public static BrokenLine BrokenLine
        {
            get
            {
                if (_brokenLine == null)
                {
                    _brokenLine = new BrokenLine();
                }
                return _brokenLine;
            }
        }

        public static Polygon Polygon
        {
            get
            {
                if (_polygon == null)
                {
                    _polygon = new Polygon();
                }
                return _polygon;
            }
        }
    }
}
