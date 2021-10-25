using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExcavator
{
    public partial class ParkingForm : Form
    {
        private readonly ParkingCollection parkingCollection;
        public ParkingForm()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        public void ReloadLevels() 
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index < listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }

        }

        public void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }

        }

        private void buttonParkingExcavator_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var excavator = new Excavator(100, 1000, dialog.Color);
                    if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + excavator)
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

        private void buttonParkingBucketExcavator_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var bucketExcavator = new BucketExcavavtor(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + bucketExcavator)
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

        private void buttonGetExcavator_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var excavator = parkingCollection[listBoxParkings.SelectedItem.ToString()] -
               Convert.ToInt32(maskedTextBox.Text);
                if (excavator != null)
                {
                    ExcavatorForm form = new ExcavatorForm();
                    form.SetExcavator(excavator);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();

        }

        private void buttonDeletePaking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(textBoxNewLevelName.Text);
                    ReloadLevels();
                }
            }

        }
    }
}
