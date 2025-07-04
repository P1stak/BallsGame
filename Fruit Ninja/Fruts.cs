using Balls_Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fruit_Ninja
{
    public class Fruts : Ball
    {
        private float g = 0.2f;
        public Fruts(Form form, float centerX, float cenetrY) : base(form)
        {
            radius = 15;
            this.centerX = centerX;
            this.centerY = cenetrY;
            RandomSizeAndSpeedBalls();
            BallColor = Color.FromArgb(Random.Next(256), Random.Next(256), Random.Next(256)); // Случайный цвет
            vy = -Math.Abs(vy);
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
