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
    public partial class ExcavatorForm : Form
    {
        private Excavavtor excavator;
        public ExcavatorForm()
        {
            InitializeComponent();
        }

        private void Draw() {
            Bitmap bmp = new Bitmap(pictureBoxExcavator.Width, pictureBoxExcavator.Height);
            Graphics g = Graphics.FromImage(bmp);
            excavator.DrawExcavator(g);
            pictureBoxExcavator.Image = bmp;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            excavator = new Excavavtor();
            excavator.Init(random.Next(100, 150), random.Next(2000, 3000), Color.DarkKhaki, Color.Black, true, true);
            excavator.SetPosition(random.Next(0, 100), random.Next(0, 100), pictureBoxExcavator.Width, pictureBoxExcavator.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e) {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    excavator.MoveExcavator(Direction.Up);
                    break;
                case "buttonDown":
                    excavator.MoveExcavator(Direction.Down);
                    break;
                case "buttonLeft":
                    excavator.MoveExcavator(Direction.Left);
                    break;
                case "buttonRight":
                    excavator.MoveExcavator(Direction.Right);
                    break;
            }
            Draw();

        } 
    }
}
