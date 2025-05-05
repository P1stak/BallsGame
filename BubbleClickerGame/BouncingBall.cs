using Balls_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleClickerGame
{
    public class BouncingBall : Ball
    {
        public BouncingBall(Form form) : base(form)
        {
            centerX = random.Next(radius, form.ClientSize.Width - radius);
            centerY = random.Next(radius, form.ClientSize.Height - radius);
            RandomSizeAndSpeedBalls();
        }
        protected override void HandleCollisions()
        {
            base.HandleCollisions();

            if (centerX - radius < 0)
            {
                vx = -vx;
                centerX = radius;
            }
            if (centerX + radius > form.ClientSize.Width)
            {
                vx = -vx;
                centerX = form.ClientSize.Width - radius;
            }
            if (centerY - radius < 0)
            {
                vy = -vy;
                centerY = radius;
            }
            if (centerY + radius > form.ClientSize.Height)
            {
                vy = -vy;
                centerY = form.ClientSize.Height - radius;
            }
        }
    }
}
