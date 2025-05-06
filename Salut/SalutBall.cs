using Balls_Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Salut
{
    public class SalutBall : Ball
    {
        private float g = 0.2f; // Гравитация

        public SalutBall(Form form, float centerX, float cenetrY) : base(form)
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

        // для отражения шариков от стен

        //protected override void HandleCollisions()
        //{
        //    base.HandleCollisions();
        //    if (centerX - radius < 0)
        //    {
        //        vx = -vx;
        //        centerX = radius;
        //    }
        //    if (centerX + radius > form.ClientSize.Width)
        //    {
        //        vx = -vx;
        //        centerX = form.ClientSize.Width - radius;
        //    }
        //    if (centerY + radius > form.ClientSize.Height)
        //    {
        //        vy = -vy * 0.7f; // теряем часть энергии при отскоке
        //        centerY = form.ClientSize.Height - radius;
        //    }
        //}
    }
}
