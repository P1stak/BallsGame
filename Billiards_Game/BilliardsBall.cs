using Balls_Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Billiards_Game
{
    public class BilliardsBall : Ball
    {
        public event EventHandler<HitEventArgs> OnHited;
        public BilliardsBall(Form form) : base(form)
        {
            // чтобы щарик не спавнился в координатах 0 0 и не делал +2 вначале своего появления
            centerX = random.Next(radius, form.ClientSize.Width - radius);
            centerY = random.Next(radius, form.ClientSize.Height - radius);
        }

        protected override void HandleCollisions()
        {
            base.HandleCollisions();

            if (centerX - radius < 0)
            {
                vx = -vx;
                centerX = radius;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX + radius > form.ClientSize.Width)
            {
                vx = -vx;
                centerX = form.ClientSize.Width - radius;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY - radius < 0)
            {
                vy = -vy;
                centerY = radius;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY + radius > form.ClientSize.Height)
            {
                vy = -vy;
                centerY = form.ClientSize.Height - radius;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }


    }
}
