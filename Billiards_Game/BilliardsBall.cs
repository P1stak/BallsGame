using Balls_Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Billiards_Game
{
    public class BilliardsBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public BilliardsBall(Form form) : base(form)
        {
            // чтобы щарик не спавнился в координатах 0 0 и не делал +2 вначале своего появления
            centerX = random.Next(radius, form.ClientSize.Width - radius);
            centerY = random.Next(radius, form.ClientSize.Height - radius);
        }
        protected override void Go()
        {
            base.Go();

            if (centerX <= leftSide())
            {
                vx = -vx;
                centerX = leftSide() + 1;
                OnHited?.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= rightSide())
            {
                vx = -vx;
                centerX = rightSide() - 1;
                OnHited?.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= topSide())
            {
                vy = -vy;
                centerY = topSide() + 1;
                OnHited?.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= downSide())
            {
                vy = -vy;
                centerY = downSide() - 1;
                OnHited?.Invoke(this, new HitEventArgs(Side.Down));
            }
        }


    }
}
