using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsExcavator
{
    class Parking<T> : IEnumerator<T>, IEnumerable<T> 
        where T : class, ITransport
    {
        private readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureHeight;
        private readonly int pictureWidth;

        private readonly int _placeSizeWidth = 210;
        private readonly int _placeSizeHeight = 80;

        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];

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
            if (p._places.Count >= p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p._places.Contains(excavator))
            {
                throw new ParkingAlreadyHaveException();
            }
            p._places.Add(excavator);
            return true;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                throw new ParkingNotFoundException(index);
            }
            T excavator = p._places[index];
            p._places.RemoveAt(index);
            return excavator;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(i % (pictureWidth / _placeSizeWidth) * _placeSizeWidth + 40, i / (pictureWidth / _placeSizeWidth) * _placeSizeHeight + 40, pictureWidth, pictureHeight);
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

        public void Sort() => _places.Sort((IComparer<T>)new ExcavatorComparer());

        public void Dispose()
        {
        }
        public bool MoveNext()
        {
            if (_currentIndex < _places.Count - 1)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }
        
        public void Reset()
        {
            _currentIndex = -1;
        }
       
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

    }
}

