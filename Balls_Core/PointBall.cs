using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls_Core
{
    public class PointBall : Ball // по клику на форму
    {
        public PointBall(Form form, int x, int y) : base(form)
        {
            centerX = x;
            centerY = y;
        }
    }
}
