using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsExcavator
{
    public class Excavator : Vehicle
    {
        protected readonly int excavatorWidth = 60;
        protected readonly int excavatorHeight = 60;

        protected readonly char separator = ';';

        public Excavator(int maxSpeed, float weight, Color mainColor)
        {
            MainColor = mainColor;
            MaxSpeed = maxSpeed;
            Weight = weight;
        }

        protected Excavator(int maxSpeed, float weight, Color mainColor, int excavatorWidth, int excavatorHeight)
        {
            MainColor = mainColor;
            MaxSpeed = maxSpeed;
            Weight = weight;
            this.excavatorHeight = excavatorHeight;
            this.excavatorWidth = excavatorWidth;
        }

        public Excavator(string info) 
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3) 
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);

            }
        }

        public override void MoveExcavator(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Down:
                    if (startPosY + step < _pictureHeight - excavatorHeight)
                        startPosY += step;
                    break;

                case Direction.Up:
                    if (startPosY > 20)
                        startPosY -= step;
                    break;
                case Direction.Left:
                    if (startPosX > 0)
                        startPosX -= step;
                    break;

                case Direction.Right:
                    if (startPosX + step < _pictureWidth - excavatorWidth)
                        startPosX += step;
                    break;
            }
        }

        public override void DrawExcavator(Graphics g)
        {
            Pen mainPen = new Pen(MainColor);
            Brush mainBrush = new SolidBrush(MainColor);
            Brush grayBrush = new SolidBrush(Color.Gray);
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush blackBrush = new SolidBrush(Color.Black);

            //Кабина
            g.FillRectangle(blueBrush, startPosX + 40, startPosY - 20, 20, 20);
            //Кузов
            g.FillRectangle(mainBrush, startPosX, startPosY, 40, 20);
            g.FillRectangle(blackBrush, startPosX + 40, startPosY, 20, 20);
            g.DrawRectangle(mainPen, startPosX + 40, startPosY - 20, 20, 20);
            //Гусеницы
            g.FillEllipse(mainBrush, startPosX, startPosY + 20, 60, 20);
            g.FillEllipse(grayBrush, startPosX, startPosY + 20, 20, 20);
            g.FillEllipse(grayBrush, startPosX + 40, startPosY + 20, 20, 20);
            g.FillEllipse(grayBrush, startPosX + 25, startPosY + 25, 10, 10);
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}