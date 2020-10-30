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
    public partial class FormTrainConfig : Form
    {

        Vehicle train = null;

        private event Action<Vehicle> eventAddTrain;

        public FormTrainConfig()
        {
            InitializeComponent();

            panelRed.MouseDown += new MouseEventHandler(panelColor_MouseDown);
            panelYellow.MouseDown += new MouseEventHandler(panelColor_MouseDown);
            panelBlack.MouseDown += new MouseEventHandler(panelColor_MouseDown);
            panelWhite.MouseDown += new MouseEventHandler(panelColor_MouseDown);
            panelGrey.MouseDown += new MouseEventHandler(panelColor_MouseDown);
            panelOrange.MouseDown += new MouseEventHandler(panelColor_MouseDown);
            panelGreen.MouseDown += new MouseEventHandler(panelColor_MouseDown);
            panelBlue.MouseDown += new MouseEventHandler(panelColor_MouseDown);

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        public void AddEvent(Action<Vehicle> train)
        {
            if (eventAddTrain == null)
            {
                eventAddTrain = train;
            }
            else
            {
                eventAddTrain += train;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Color color = (sender as Panel).BackColor;
            (sender as Panel).DoDragDrop(color, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(Color)) != null)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            train.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawTrain();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train is Monorail)
            {
                (train as Monorail).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawTrain();
            }
        }

        private void DrawTrain()
        {
            if (train != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTrainConfig.Width, pictureBoxTrainConfig.Height);
                Graphics gr = Graphics.FromImage(bmp);
                train.SetPosition(20, 20, pictureBoxTrainConfig.Width, pictureBoxTrainConfig.Height);
                train.DrawTransport(gr);
                pictureBoxTrainConfig.Image = bmp;
            }
        }

        private void labelTrain_MouseDown(object sender, MouseEventArgs e)
        {
            labelTrain.DoDragDrop(labelTrain.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelMonorail_MouseDown(object sender, MouseEventArgs e)
        {
            labelMonorail.DoDragDrop(labelMonorail.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelTrain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelTrain_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Train":
                    train = new Train((int)numericUpDownMaxSpeed.Value, (int)numericUpDownTrainWeight.Value, Color.White);
                    break;

                case "Monorail":
                    train = new Monorail((int)numericUpDownMaxSpeed.Value, (int)numericUpDownTrainWeight.Value, Color.White, Color.Black, checkBoxSportLine.Checked, checkBoxHeadlights.Checked, checkBoxBottomMonorail.Checked);
                    break;
            }
            DrawTrain();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddTrain?.Invoke(train);
            Close();
        }
    }
}
