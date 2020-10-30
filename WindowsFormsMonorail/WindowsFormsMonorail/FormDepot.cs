﻿using System;
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

        private void buttonSetTrain_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var train = new Train(200, 1750, dialog.Color);
                    if (depotCollection[listBoxDepot.SelectedItem.ToString()] + train)
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

        private void buttonSetMonorail_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var train = new Monorail(200, 1750, dialog.Color, dialogDop.Color, true, true, true);
                        if (depotCollection[listBoxDepot.SelectedItem.ToString()] + train)
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
    }
}
