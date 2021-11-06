﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsExcavator
{
    class Parking<T> where T : class, ITransport
    {
        private readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureHeight;
        private readonly int pictureWidth;

        private readonly int _placeSizeWidth = 210;
        private readonly int _placeSizeHeight = 80;

        private int width;
        private int height;


        public Parking(int picWidth, int picHeight)
        {
            width = picWidth / _placeSizeWidth;
            height = picHeight / _placeSizeHeight;
            _places = new List<T>();
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Parking<T> p, T excavator)
        {
            if (p._places.Count != p._maxCount)
            {
                int i = 0;

                while (i < p.height)
                {
                    int j = 0;
                    while (j < p.width)
                    {
                        excavator.SetPosition(5 + j * p._placeSizeWidth, 5 + i * p._placeSizeHeight, p.pictureWidth, p.pictureHeight);
                        p._places.Add(excavator);
                        return true;
                        j++;
                    }
                    i++;
                }
            }

            else
            {
                return false;
            }

            return true;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index > -1 && index < p._maxCount)
            {
                T excavator = p._places[index];
                p._places.RemoveAt(index);
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
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(40 + i / 5 * _placeSizeWidth, i % 5 * _placeSizeHeight + 30, pictureWidth, pictureHeight);
                _places[i].DrawExcavator(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }

    }
}

