using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls_Core
{
    public class RandomPointBall : MoveBall //в рандом месте
    {
        public RandomPointBall(Form form) : base(form)
        {
            // переопределяем коррдинаты точек для отрисовки на области
            size = random.Next(5,70);
            x = random.Next(0, form.ClientSize.Width - size);
            y = random.Next(0, form.ClientSize.Height - size);
        }
    }
}
