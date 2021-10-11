using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsExcavator
{
    class Parking<T> where T : class, ITransport
    {
        private readonly T[] _places;
        private readonly int pictureHeight;
        private readonly int pictureWidth;

        protected readonly int excavatorWidth = 60;
        protected readonly int excavatorHeight = 60;

        private readonly int _placeSizeWidth = 210;
        private readonly int _placeSizeHeight = 80;

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static int operator +(Parking<T> p, T excavator)
        {
            int i = 0;
            while (i < p._places.Length && p._places[i] != null)
            {
                i++;
            }
            if (i < p._places.Length && p._places[i] == null)
            {
                excavator.SetPosition(i % p.excavatorWidth* p._placeSizeWidth + 10, i / p.excavatorHeight * p._placeSizeHeight + 10, p.excavatorWidth, p.excavatorHeight);
                p._places[i] = excavator;
                return i;
            }
            else
            {
                return -1;
            }

        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index > -1 && index < p._places.Length && p._places[index] != null)
            {
                T bufPlane = p._places[index];
                p._places[index] = null;
                return bufPlane;
            }
            else
            {
                return null;
            }
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawExcavator(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
        

    }
}

