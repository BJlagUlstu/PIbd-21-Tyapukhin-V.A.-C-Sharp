using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMonorail
{
    public partial class FormMonorail : Form
    {
        private Monorail monorail;

        public FormMonorail()
        {
            InitializeComponent();
        }

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxMonorail.Width, pictureBoxMonorail.Height);
			Graphics gr = Graphics.FromImage(bmp);
			monorail.DrawTransport(gr);
			pictureBoxMonorail.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			monorail = new Monorail(rnd.Next(150, 300), rnd.Next(1500, 2000), Color.White,
		   Color.Blue, true, true, true);
			monorail.SetPosition(rnd.Next(50, 100), rnd.Next(50, 100), pictureBoxMonorail.Width,
		   pictureBoxMonorail.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			try
			{
				//получаем имя кнопки
				string name = (sender as Button).Name;
				switch (name)
				{
					case "buttonUp":
						monorail.MoveTransport(Direction.Up);
						break;
					case "buttonDown":
						monorail.MoveTransport(Direction.Down);
						break;
					case "buttonLeft":
						monorail.MoveTransport(Direction.Left);
						break;
					case "buttonRight":
						monorail.MoveTransport(Direction.Right);
						break;
				}
			}
			catch
			{

			}
			Draw();
		}
	}
}
