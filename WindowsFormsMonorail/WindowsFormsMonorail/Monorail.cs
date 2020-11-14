using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsMonorail
{
    class Monorail : Train
    {
        public Color DopColor { private set; get; }

        public bool SportLine { private set; get; }

        public bool Headlights { private set; get; }

        public bool Bottom_monorail { private set; get; }

        public Monorail(int maxSpeed, float weight, Color mainColor, Color dopColor, bool sportLine, bool headlights, bool bottom_monorail) : base(maxSpeed, weight, mainColor, 270, 70)

        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            SportLine = sportLine;
            Headlights = headlights;
            Bottom_monorail = bottom_monorail;
        }

        public Monorail(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                string[] MaincolorRGB = strs[2].Split(',');
                MainColor = Color.FromArgb(255, Convert.ToInt32(MaincolorRGB[0]), Convert.ToInt32(MaincolorRGB[1]), Convert.ToInt32(MaincolorRGB[2]));
                string[] DopcolorRGB = strs[3].Split(',');
                DopColor = Color.FromArgb(255, Convert.ToInt32(DopcolorRGB[0]), Convert.ToInt32(DopcolorRGB[1]), Convert.ToInt32(DopcolorRGB[2]));
                SportLine = Convert.ToBoolean(strs[4]);
                Headlights = Convert.ToBoolean(strs[5]);
                Bottom_monorail = Convert.ToBoolean(strs[6]);
            }
        }

        public override void DrawTransport(Graphics g)
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

            base.DrawTransport(g);

            //полоска на корпусе
            if (SportLine)
            {
                Pen pen_2 = new Pen(DopColor, 5);
                g.DrawArc(pen_2, _startPosX + 10, _startPosY + 30, 90, 30, 180, 90);
                g.DrawArc(pen_2, _startPosX + 150, _startPosY + 30, 90, 30, 0, -90);
                g.DrawLine(pen_2, _startPosX + 50, _startPosY + 30, _startPosX + 200, _startPosY + 30);
                g.DrawLine(pen, _startPosX + 50, _startPosY + 28, _startPosX + 200, _startPosY + 28);
                g.DrawLine(pen, _startPosX + 50, _startPosY + 32, _startPosX + 200, _startPosY + 32);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.R},{DopColor.G},{DopColor.B}{separator}{SportLine}{separator}{Headlights}{separator}{Bottom_monorail}";
        }
    }
}