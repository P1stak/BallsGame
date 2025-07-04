using Balls_Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fruit_Ninja
{
    public class MoveFruts : Ball
    {
        private float g = 0.2f;
        private bool hasCut = false; // флаг, определяющий, разрезан ли фрукт

        public MoveFruts(Form form) : base(form)
        {
            centerX = random.Next(radius, form.ClientSize.Width - radius);
            centerY = form.ClientSize.Height - radius;
            vx = 0;
            vy = -random.Next(5, 15);
            radius = random.Next(10, 40);

            do
            {
                BallColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            } while (BallColor.R < 50 && BallColor.G < 50 && BallColor.B < 50); // Исключаем темные цвета, близкие к черному
        }
        public override void Move()
        {
            if (!hasCut)
            {
                base.Move();
            }
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
            vx *= 0.99f;
            vy *= 0.99f;
        }

        // Метод для проверки, разрезан ли шарик
        public void CheckCut(int mouseX, int mouseY)
        {
            float dx = mouseX - centerX;
            float dy = mouseY - centerY;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);
            if (distance <= radius)
            {
                hasCut = true;
            }
        }
        public bool HasCut => hasCut; // Свойство для проверки, разрезан ли шарик
    }
}
