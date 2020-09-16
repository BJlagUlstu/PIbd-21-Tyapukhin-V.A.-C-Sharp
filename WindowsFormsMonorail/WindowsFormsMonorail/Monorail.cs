using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsMonorail
{
    class Monorail
    {
        private float _startPosX;

        private float _startPosY;

        private float _pictureWidth;

        private float _pictureHeight;

        private readonly int monorailWidth = 260;

        private readonly int monorailHeight = 60;

        private readonly int monorailWidthMagnet = 20;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool SportLine { private set; get; }

        public bool Headlights { private set; get; }

        public bool Bottom_monorail { private set; get; }

        public Monorail(int maxSpeed, float weight, Color mainColor, Color dopColor, bool sportLine, bool headlights, bool bottom_monorail)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            SportLine = sportLine;
            Headlights = headlights;
            Bottom_monorail = bottom_monorail;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;

            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - monorailWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step - monorailWidthMagnet > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - monorailHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            //Фара
            if (Headlights)
            {
                Brush headlights = new SolidBrush(Color.Yellow);
                g.FillEllipse(headlights, _startPosX + 245, _startPosY + 25, 8, 10);
                g.DrawEllipse(pen, _startPosX + 245, _startPosY + 25, 8, 10);
            }

            //нижняя часть корпуса
            if (Bottom_monorail)
            {
                g.DrawRectangle(pen, _startPosX - 10, _startPosY + 34, 25, 8);
                Brush bottom_monorail = new SolidBrush(DopColor);
                g.FillRectangle(bottom_monorail, _startPosX + 5, _startPosY + 40, 240, 8);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 40, 240, 8);

            }

            //корпус монорельса
            Brush body_monorail = new SolidBrush(MainColor);
            g.FillPie(body_monorail, _startPosX + 150, _startPosY, 100, 85, 0, -90);
            g.DrawPie(pen, _startPosX + 150, _startPosY, 100, 85, 0, -90);
            g.FillPie(body_monorail, _startPosX, _startPosY, 100, 85, 180, 90);
            g.DrawPie(pen, _startPosX, _startPosY, 100, 85, 180, 90);
            g.FillRectangle(body_monorail, _startPosX + 50, _startPosY, 150, 42);
            g.DrawRectangle(pen, _startPosX + 50, _startPosY, 150, 42);
            Brush brDarkGray = new SolidBrush(Color.DarkGray);
            g.FillRectangle(brDarkGray, _startPosX + 50, _startPosY, 150, 30);
            g.DrawRectangle(pen, _startPosX + 50, _startPosY, 150, 30);

            //стекла
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 55, _startPosY + 5, 12, 20);
            g.DrawRectangle(pen, _startPosX + 55, _startPosY + 5, 12, 20);
            g.FillRectangle(brBlue, _startPosX + 70, _startPosY + 5, 12, 20);
            g.DrawRectangle(pen, _startPosX + 70, _startPosY + 5, 12, 20);
            g.FillRectangle(brBlue, _startPosX + 120, _startPosY + 5, 12, 20);
            g.DrawRectangle(pen, _startPosX + 120, _startPosY + 5, 12, 20);
            g.FillRectangle(brBlue, _startPosX + 170, _startPosY + 5, 12, 20);
            g.DrawRectangle(pen, _startPosX + 170, _startPosY + 5, 12, 20);
            g.FillRectangle(brBlue, _startPosX + 185, _startPosY + 5, 12, 20);
            g.DrawRectangle(pen, _startPosX + 185, _startPosY + 5, 12, 20);
            g.FillRectangle(brBlue, _startPosX + 88, _startPosY + 5, 12, 20);
            g.FillRectangle(brBlue, _startPosX + 102, _startPosY + 5, 12, 20);
            g.FillRectangle(brBlue, _startPosX + 138, _startPosY + 5, 12, 20);
            g.FillRectangle(brBlue, _startPosX + 152, _startPosY + 5, 12, 20);
            g.DrawLine(pen, _startPosX + 88, _startPosY + 25, _startPosX + 100, _startPosY + 25);
            g.DrawLine(pen, _startPosX + 102, _startPosY + 25, _startPosX + 114, _startPosY + 25);
            g.DrawLine(pen, _startPosX + 138, _startPosY + 25, _startPosX + 150, _startPosY + 25);
            g.DrawLine(pen, _startPosX + 152, _startPosY + 25, _startPosX + 164, _startPosY + 25);
            g.FillPie(brBlue, _startPosX + 168, _startPosY + 5, 70, 40, 0, -90);
            g.DrawPie(pen, _startPosX + 168, _startPosY + 5, 70, 40, 0, -90);
            g.FillPie(brBlue, _startPosX + 12, _startPosY + 5, 70, 40, 180, 90);
            g.DrawPie(pen, _startPosX + 12, _startPosY + 5, 70, 40, 180, 90);

            //двери
            g.DrawRectangle(pen, _startPosX + 88, _startPosY + 5, 12, 32);
            g.DrawRectangle(pen, _startPosX + 102, _startPosY + 5, 12, 32);
            g.DrawRectangle(pen, _startPosX + 138, _startPosY + 5, 12, 32);
            g.DrawRectangle(pen, _startPosX + 152, _startPosY + 5, 12, 32);

            Brush brBlack = new SolidBrush(Color.Black);
            g.FillRectangle(brBlack, _startPosX + 88, _startPosY + 25, 12, 12);
            g.FillRectangle(brBlack, _startPosX + 102, _startPosY + 25, 12, 12);
            g.FillRectangle(brBlack, _startPosX + 138, _startPosY + 25, 12, 12);
            g.FillRectangle(brBlack, _startPosX + 152, _startPosY + 25, 12, 12);

            //полоска на корпусе
            if (SportLine)
            {
                Pen pen_2 = new Pen(Color.Blue, 5);
                g.DrawArc(pen_2, _startPosX + 10, _startPosY + 30, 90, 30, 180, 90);
                g.DrawArc(pen_2, _startPosX + 150, _startPosY + 30, 90, 30, 0, -90);
                g.DrawLine(pen_2, _startPosX + 50, _startPosY + 30, _startPosX + 200, _startPosY + 30);
                g.DrawLine(pen, _startPosX + 50, _startPosY + 28, _startPosX + 200, _startPosY + 28);
                g.DrawLine(pen, _startPosX + 50, _startPosY + 32, _startPosX + 200, _startPosY + 32);
            }
        }
    }
}
