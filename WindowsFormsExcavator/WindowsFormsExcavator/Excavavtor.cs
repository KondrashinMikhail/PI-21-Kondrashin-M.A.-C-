using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsExcavator
{
    class Excavavtor
    {
        private float startPosX;
        private float startPosY;

        private int _pictureWidth = 900;
        private int _pictureHeight = 500;

        private readonly int excavatorWidth = 150;
        private readonly int excavatorHeight = 70;

        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool FrontBucket { private set; get; }
        public bool BackBucket { private set; get; }

        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontBucket, bool backBucket) {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontBucket = frontBucket;
            BackBucket = backBucket;
        }

        public void SetPosition(int x, int y, int width, int height) {
            startPosX = width / 2 - excavatorWidth + x;
            startPosY = height / 2 + excavatorHeight / 2 + y;
        }

        public void MoveExcavator(Direction direction) {
            float step = MaxSpeed * 100 / Weight;
            switch (direction) {
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

		public void DrawExcavator(Graphics g)
		{
			Pen mainPen = new Pen(MainColor);
			Pen dopPen = new Pen(DopColor);
			Brush mainBrush = new SolidBrush(MainColor);
			Brush dopBrush = new SolidBrush(DopColor);
			Brush grayBrush = new SolidBrush(Color.Gray);
			Brush blueBrush = new SolidBrush(Color.Blue);
			if (FrontBucket)
			{
				//Ковш
				g.DrawLine(dopPen, startPosX + 100, startPosY, startPosX + 110, startPosY + 10);
				g.DrawLine(dopPen, startPosX + 110, startPosY + 10, startPosX + 110, startPosY + 20);
				g.DrawLine(dopPen, startPosX + 110, startPosY + 20, startPosX + 100, startPosY + 30);
				g.DrawLine(dopPen, startPosX + 105, startPosY + 25, startPosX + 100, startPosY + 10);
				g.DrawLine(dopPen, startPosX + 100, startPosY, startPosX + 100, startPosY + 10);
				//Рычаг
				g.DrawLine(mainPen, startPosX + 60, startPosY + 5, startPosX + 80, startPosY - 10);
				g.DrawLine(mainPen, startPosX + 80, startPosY - 10, startPosX + 90, startPosY - 10);
				g.DrawLine(mainPen, startPosX + 90, startPosY - 10, startPosX + 100, startPosY);

				g.DrawLine(mainPen, startPosX + 60, startPosY + 5 + 15, startPosX + 80, startPosY - 10 + 10);
				g.DrawLine(mainPen, startPosX + 80, startPosY - 10 + 10, startPosX + 90, startPosY - 10 + 10);
				g.DrawLine(mainPen, startPosX + 90, startPosY - 10 + 10, startPosX + 100, startPosY + 10);

				g.DrawLine(mainPen, startPosX + 70, startPosY, startPosX + 70, startPosY + 10);
				g.DrawLine(mainPen, startPosX + 80, startPosY - 10, startPosX + 80, startPosY);
				g.DrawLine(mainPen, startPosX + 90, startPosY - 10, startPosX + 90, startPosY);

			}
			if (BackBucket)
			{
				//Ковш
				g.DrawLine(dopPen, startPosX - 30, startPosY, startPosX - 40, startPosY + 10);
				g.DrawLine(dopPen, startPosX - 40, startPosY + 10, startPosX - 40, startPosY + 20);
				g.DrawLine(dopPen, startPosX - 40, startPosY + 20, startPosX - 30, startPosY + 30);
				g.DrawLine(dopPen, startPosX - 35, startPosY + 25, startPosX - 30, startPosY + 10);
				g.DrawLine(dopPen, startPosX - 30, startPosY + 10, startPosX - 30, startPosY);
				//Рычаг
				g.DrawLine(mainPen, startPosX, startPosY, startPosX - 10, startPosY - 10);
				g.DrawLine(mainPen, startPosX - 10, startPosY - 10, startPosX - 20, startPosY - 10);
				g.DrawLine(mainPen, startPosX - 20, startPosY - 10, startPosX - 30, startPosY);

				g.DrawLine(mainPen, startPosX, startPosY + 10, startPosX - 10, startPosY - 10 + 10);
				g.DrawLine(mainPen, startPosX - 10, startPosY - 10 + 10, startPosX - 20, startPosY - 10 + 10);
				g.DrawLine(mainPen, startPosX - 20, startPosY - 10 + 10, startPosX - 30, startPosY + 10);

				g.DrawLine(mainPen, startPosX - 10, startPosY - 10, startPosX - 10, startPosY);
				g.DrawLine(mainPen, startPosX - 20, startPosY - 10, startPosX - 20, startPosY);
			}
			//Кабина
			g.FillRectangle(blueBrush, startPosX + 40, startPosY - 20, 20, 20);
			//Кузов
			g.FillRectangle(mainBrush, startPosX, startPosY, 40, 20);
			g.FillRectangle(dopBrush, startPosX + 40, startPosY, 20, 20);
			g.DrawRectangle(mainPen, startPosX + 40, startPosY - 20, 20, 20);
			//Гусеницы
			g.FillEllipse(mainBrush, startPosX, startPosY + 20, 60, 20);
			g.FillEllipse(grayBrush, startPosX, startPosY + 20, 20, 20);
			g.FillEllipse(grayBrush, startPosX + 40, startPosY + 20, 20, 20);
			g.FillEllipse(grayBrush, startPosX + 25, startPosY + 25, 10, 10);
		}
	}
}

