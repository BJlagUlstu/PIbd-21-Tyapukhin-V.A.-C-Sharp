using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsMonorail
{
    class Train : Vehicle
    {
        protected readonly int monorailWidth = 260;

        protected readonly int monorailHeight = 60;

        protected readonly int monorailWidthMagnet = 20;

        protected readonly char separator = ';';

        public Train(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Train(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                string[] MaincolorRGB = strs[2].Split(',');
                MainColor = Color.FromArgb(255, Convert.ToInt32(MaincolorRGB[0]), Convert.ToInt32(MaincolorRGB[1]), Convert.ToInt32(MaincolorRGB[2]));
            }
        }

        protected Train(int maxSpeed, float weight, Color mainColor, int monoWidth, int monoHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.monorailWidth = monoWidth;
            this.monorailHeight = monoHeight;
        }

        public override void MoveTransport(Direction direction)
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

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

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
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.R},{MainColor.G},{MainColor.B}";
        }
    }
}
