using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using NLog;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMonorail
{
    public partial class FormDepot : Form
    {

        private readonly DepotCollection depotCollection;

        private readonly Logger logger;

        public FormDepot()
        {
            InitializeComponent();
            depotCollection = new DepotCollection(pictureBoxDepot.Width, pictureBoxDepot.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                logger.Warn("При добавлении депо отсутствовало название");
                MessageBox.Show("Введите название депо", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили депо {textBoxNewLevelName.Text}");
            depotCollection.AddDepot(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        private void buttonDelDepot_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить депо {listBoxDepot.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили депо {listBoxDepot.SelectedItem.ToString()}");
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
                try
                {
                    if ((depotCollection[listBoxDepot.SelectedItem.ToString()]) + train)
                    {
                        Draw();
                        logger.Info($"Добавлен поезд {train}");
                    }
                    else
                    {
                        logger.Warn("Поезд не удалось добавить в депо");
                        MessageBox.Show("Поезд не удалось поставить");
                    }
                }
                catch (DepotOverflowException ex)
                {
                    logger.Warn("Произошло переполнение депо");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Возникла неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonPickUpTrain_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1 && maskedTextBoxTrain.Text != "")
            {
                try
                {
                    var train = depotCollection[listBoxDepot.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxTrain.Text);
                    if (train != null)
                    {
                        FormMonorail form = new FormMonorail();
                        form.SetMonorail(train);
                        form.ShowDialog();
                        logger.Info($"Изъят поезд {train} с места {maskedTextBoxTrain.Text}");
                        Draw();
                    }
                }
                catch (DepotNotFoundException ex)
                {
                    logger.Warn($"Поезд по месту {maskedTextBoxTrain.Text} не найден");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Возникла неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBoxDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли в депо {listBoxDepot.SelectedItem.ToString()}");
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
                try
                {
                    depotCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение успешно завершено", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Возникла неизвестная ошибка при сохранении");
                }
            }
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depotCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузка успешно завершена", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (DepotOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn("Не удалось загрузить поезд в депо");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Возникла неизвестная ошибка при загрузке");
                }
            }
        }
    }
}