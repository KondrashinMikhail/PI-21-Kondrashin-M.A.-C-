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
    public partial class FormExcavatorConfig : Form
    {
        Vehicle excavator = null;

        private Action<Vehicle> EventAddExcavator;
        public FormExcavatorConfig()
        {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawExcavatorTransport() 
        {
            if (excavator != null) 
            {
                Bitmap bmp = new Bitmap(pictureBoxExcavator.Width, pictureBoxExcavator.Height);
                Graphics gr = Graphics.FromImage(bmp);
                excavator.SetPosition(60, 70, pictureBoxExcavator.Width, pictureBoxExcavator.Height);
                excavator.DrawExcavator(gr);
                pictureBoxExcavator.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (EventAddExcavator == null)
            {
                EventAddExcavator = new Action<Vehicle>(ev);
            }
            else
            {
                EventAddExcavator += ev;
            }
        }
        private void labelExcavator_MouseDown(object sender, MouseEventArgs e)
        {
            labelExcavator.DoDragDrop(labelExcavator.Text, DragDropEffects.Move |DragDropEffects.Copy);
        }
        private void labelBucketExcavator_MouseDown(object sender, MouseEventArgs e)
        {
            labelBucketExcavator.DoDragDrop(labelBucketExcavator.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelExcavator_DragEnter(object sender, DragEventArgs e)
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

        private void panelExcavator_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный экскаватор":
                    excavator = new Excavator((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Black);
                    break;
                case "Экскаватор с ковшами":
                    excavator = new BucketExcavator((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Black, Color.Black, checkBoxFrontBucket.Checked, checkBoxBackBucket.Checked);
                    break;
            }
            DrawExcavatorTransport();
        }



       
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (sender as Control);
            control.DoDragDrop(control.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        
         private void labelMainCol_DragEnter(object sender, DragEventArgs e)
         {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void labelMainCol_DragDrop(object sender, DragEventArgs e)
        {
            if (excavator != null)
            {
                excavator.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawExcavatorTransport();
            }
        }
       
        private void labelDopCol_DragDrop(object sender, DragEventArgs e)
        {
            if (excavator != null)
            {
                if (excavator is BucketExcavator)
                {
                    (excavator as BucketExcavator).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawExcavatorTransport();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EventAddExcavator?.Invoke(excavator);

            Close();
        }
    }
}

