using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls_Core
{
    public class RandomSizeAndPointBall : RandomPointBall //в разных местах с разными размерами
    {
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            RandomSizeAndSpeedBalls();
        }
    }
}
