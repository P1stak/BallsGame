using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls_Core
{
    public class RandomPointBall : MoveBall //в рандом месте
    {
        public RandomPointBall(Form form) : base(form)
        {
            centerX = random.Next(radius, form.ClientSize.Width - radius);
            centerY = random.Next(radius, form.ClientSize.Height - radius);
        }
    }
}
