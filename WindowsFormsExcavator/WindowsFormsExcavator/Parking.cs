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

        private readonly int _placeSizeWidth = 300;
        private readonly int _placeSizeHeight = 70;

        private int width;
        private int height;


        public Parking(int picWidth, int picHeight)
        {
            width = picWidth / _placeSizeWidth;
            height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static int operator +(Parking<T> p, T excavator)
        {
            int i = 0;

            while (i < p.height)
            {
                int j = 0;
                while (j < p.width)
                {
                    if (p._places[i * p.width + j] == null)
                    {
                        excavator.SetPosition(50 + j * p._placeSizeWidth, 30 + i * p._placeSizeHeight, p.pictureWidth, p.pictureHeight);
                        p._places[i * p.width + j] = excavator;
                        return (i * p.width + j);
                    }
                    j++;
                }
                i++;
            }
            return -1;
    }

        public static T operator -(Parking<T> p, int index)
        {
            if (index > -1 && index < p._places.Length && p._places[index] != null)
            {
                T excavator = p._places[index];
                p._places[index] = null;
                return excavator;
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
            Pen pen = new Pen(Color.Black, 2);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *_placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
        

    }
}

