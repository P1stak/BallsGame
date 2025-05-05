using Balls_Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diffusion
{
    public class DiffusionBall : Ball
    {
        public Color GasColor { get; }
        public int LeftHits { get; private set; }
        public int RightHits { get; private set; }
        public int TopHits { get; private set; }
        public int BottomHits { get; private set; }
        public int CenterHits { get; private set; }

        public int CenterCrossings { get; private set; }

        private int prevCenterX;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public int CenterX
        {
            get { return centerX; }
            set { centerX = value; }
        }

        public int CenterY
        {
            get { return centerY; }
            set { centerY = value; }
        }
        public static Random Random
        {
            get { return random; }
        }


        public DiffusionBall(Form form, Color color) : base(form)
        {
            GasColor = color;
            BallColor = color;
        }
        protected override void HandleCollisions()
        {
            int centerLine = form.ClientSize.Width / 2;

            if (centerX - radius < 0)
            {
                vx = -vx;
                centerX = radius;
                LeftHits++;
            }
            if (centerX + radius > form.ClientSize.Width)
            {
                vx = -vx;
                centerX = form.ClientSize.Width - radius;
                RightHits++;
            }
            if (centerY - radius < 0)
            {
                vy = -vy;
                centerY = radius;
                TopHits++;
            }
            if (centerY + radius > form.ClientSize.Height)
            {
                vy = -vy;
                centerY = form.ClientSize.Height - radius;
                BottomHits++;
            }
            //Центральная линия
            if (Math.Abs(centerX - centerLine) < radius)
            {
                vx = -vx;
                CenterHits++;
            }
        }
        public override void Move()
        {
            prevCenterX = CenterX;
            base.Move();

            // Проверка пересечения центральной линии
            int centerLine = form.ClientSize.Width / 2;
            if ((prevCenterX < centerLine && CenterX >= centerLine) ||
                (prevCenterX > centerLine && CenterX <= centerLine))
            {
                CenterCrossings++;
            }
        }
    }
}
