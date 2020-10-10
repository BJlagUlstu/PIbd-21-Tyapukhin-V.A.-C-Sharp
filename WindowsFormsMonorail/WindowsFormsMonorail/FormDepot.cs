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
    public partial class FormDepot : Form
    {

        private readonly Depot<Train> depot;

        public FormDepot()
        {
            InitializeComponent();
            depot = new Depot<Train>(pictureBoxDepot.Width, pictureBoxDepot.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
            Graphics gr = Graphics.FromImage(bmp);
            depot.Draw(gr);
            pictureBoxDepot.Image = bmp;
        }

        private void buttonSetTrain_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var train = new Train(200, 1750, dialog.Color);
                if (depot + train)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonSetMonorail_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var train = new Monorail(200, 1750, dialog.Color, dialogDop.Color, true, true, true);
                    if (depot + train)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void buttonPickUpTrain_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxTrain.Text != "")
            {
                var train = depot - Convert.ToInt32(maskedTextBoxTrain.Text);
                if (train != null)
                {
                    FormMonorail form = new FormMonorail();
                    form.SetMonorail(train);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
