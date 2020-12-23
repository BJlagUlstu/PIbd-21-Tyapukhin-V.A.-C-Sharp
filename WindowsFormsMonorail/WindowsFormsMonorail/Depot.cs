using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;


namespace WindowsFormsMonorail
{
    public class Depot<T> : IEnumerator<T>, IEnumerable<T> where T : class, ITransport
    {
        private readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 380;

        private readonly int _placeSizeHeight = 100;

        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];

        public Depot(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            //_currentIndex = -1;
        }

        public static bool operator +(Depot<T> p, T train)
        {
            if (p._places.Count >= p._maxCount)
                throw new DepotOverflowException();

            if (p._places.Contains(train))
                throw new DepotAlreadyHaveException();

            p._places.Add(train);
            return true;
        }

        public static T operator -(Depot<T> p, int index)
        {
            if (index < 0 || index >= p._places.Count)
                throw new DepotNotFoundException(index);

            T train = p._places[index];
            p._places.RemoveAt(index);
            return train;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                int x = i / (pictureHeight / _placeSizeHeight);
                int y = i - x * (pictureHeight / _placeSizeHeight);
                _places[i].SetPosition(x * _placeSizeWidth + 10, y * _placeSizeHeight + 25, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; j++)
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

        public void Sort() => _places.Sort((IComparer<T>)new TrainComparer());

        public void Dispose() { }

        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                _currentIndex = -1;
                return false;
            }
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this;
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