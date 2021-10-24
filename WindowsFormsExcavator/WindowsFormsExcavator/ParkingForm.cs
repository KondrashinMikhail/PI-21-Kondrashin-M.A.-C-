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
        private readonly Parking<Excavator> parking;
        public ParkingForm()
        {
            InitializeComponent();
            parking = new Parking<Excavator>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        public void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonParkingExcavator_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var excavator = new Excavator(100, 2000, dialog.Color);
                if ((parking + excavator) != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonParkingBucketExcavator_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var excavator = new BucketExcavavtor(100, 2500, dialog.Color, dialogDop.Color, true, true);

                    if ((parking + excavator) != -1)
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

        private void buttonGetExcavator_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var excavator = parking - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (excavator != null)
                {
                    ExcavatorForm form = new ExcavatorForm();
                    form.SetExcavator(excavator);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
