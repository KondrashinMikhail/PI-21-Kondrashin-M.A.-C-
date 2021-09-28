using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExcavator
{
    public abstract class Vehicle : ITransport
    {
        protected float startPosX;
        protected float startPosY;
        
        protected int _pictureWidth;
        protected int _pictureHeight;

        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            startPosX = width / 2 + x;
            startPosY = height / 2 + y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public abstract void MoveExcavator(Direction direction);
        public abstract void DrawExcavator(Graphics g);

    }
}
