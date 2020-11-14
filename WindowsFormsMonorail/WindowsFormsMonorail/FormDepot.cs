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

        private readonly DepotCollection depotCollection;

        public FormDepot()
        {
            InitializeComponent();
            depotCollection = new DepotCollection(pictureBoxDepot.Width, pictureBoxDepot.Height);
        }

        private void ReloadLevels()
        {
            int index = listBoxDepot.SelectedIndex;

            listBoxDepot.Items.Clear();

            for (int i = 0; i < depotCollection.Keys.Count; i++)
            {
                listBoxDepot.Items.Add(depotCollection.Keys[i]);
            }
            if (listBoxDepot.Items.Count > 0 && (index == -1 || index >= listBoxDepot.Items.Count))
            {
                listBoxDepot.SelectedIndex = 0;
            }
            else if (listBoxDepot.Items.Count > 0 && index > -1 && index < listBoxDepot.Items.Count)
            {
                listBoxDepot.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxDepot.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depotCollection[listBoxDepot.SelectedItem.ToString()].Draw(gr);
                pictureBoxDepot.Image = bmp;
            }
        }

        private void buttonAddDepot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            depotCollection.AddDepot(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        private void buttonDelDepot_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxDepot.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    depotCollection.DelDepot(listBoxDepot.SelectedItem.ToString());
                    ReloadLevels();
                    Draw();
                }
            }
        }

        private void AddTrain(Vehicle train)
        {
            if (train != null && listBoxDepot.SelectedIndex > -1)
            {
                if ((depotCollection[listBoxDepot.SelectedItem.ToString()]) + train)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Поезд не удалось поставить");
                }
            }
        }

        private void buttonPickUpTrain_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1 && maskedTextBoxTrain.Text != "")
            {
                var train = depotCollection[listBoxDepot.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxTrain.Text);
                if (train != null)
                {
                    FormMonorail form = new FormMonorail();
                    form.SetMonorail(train);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void listBoxDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonSetTransport_Click(object sender, EventArgs e)
        {
            var formTrainConfig = new FormTrainConfig();
            formTrainConfig.AddEvent(AddTrain);
            formTrainConfig.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (depotCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение успешно завершено", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (depotCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузка успешно завершена", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
    }
}