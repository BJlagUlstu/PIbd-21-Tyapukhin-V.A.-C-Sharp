using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsMonorail
{
	public class Depot<T> where T : class, ITransport
	{
		private readonly T[] _places;

		private readonly int pictureWidth;

		private readonly int pictureHeight;

		private readonly int _placeSizeWidth = 380;

		private readonly int _placeSizeHeight = 100;

		public Depot(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_places = new T[width * height];
			pictureWidth = picWidth;
			pictureHeight = picHeight;
		}

		public static bool operator +(Depot<T> p, T train)
		{
			int tmp = 0;
			while (tmp < p._places.Length)
			{
				if (p._places[tmp] == null)
				{
					p._places[tmp] = train;
					int x = tmp / (p.pictureHeight / p._placeSizeHeight);
					int y = tmp - x * (p.pictureHeight / p._placeSizeHeight);
					train.SetPosition(x * p._placeSizeWidth + 15, y * p._placeSizeHeight + 25, p.pictureWidth, p.pictureHeight);
					return true;
				}
				tmp++;
			}
			return false;
		}

		public static T operator -(Depot<T> p, int index)
		{
			if (index < 0 || index >= p._places.Length)
				return null;

			if (p._places[index] == null)
				return null;

			T train = p._places[index];
			p._places[index] = null;
			return train;
		}

		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Length; i++)
			{
				_places[i]?.DrawTransport(g);
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
	}
}


