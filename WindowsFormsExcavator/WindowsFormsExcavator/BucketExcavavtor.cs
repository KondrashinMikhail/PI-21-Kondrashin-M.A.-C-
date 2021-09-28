using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsExcavator
{
    class BucketExcavavtor : Excavator
    {
        public Color DopColor { private set; get; }
        public bool FrontBucket { private set; get; }
        public bool BackBucket { private set; get; }

        public BucketExcavavtor(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontBucket, bool backBucket):
			base(maxSpeed, weight, mainColor, 170, 70)
		{
            DopColor = dopColor;
            FrontBucket = frontBucket;
            BackBucket = backBucket;
        }

		public override void DrawExcavator(Graphics g)
		{
			Pen mainPen = new Pen(MainColor);
			Pen dopPen = new Pen(DopColor);
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

			base.DrawExcavator(g);
		}
	}
}

