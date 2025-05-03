using System;

namespace BallsGame
{
    public class RandomPointBall : Ball //в рандом месте
    {
        protected static Random random = new Random();
        public RandomPointBall(MainForm form) : base(form)
        {
            // переопределяем коррдинаты точек для отрисовки на области
            x = random.Next(0, form.ClientSize.Width);
            y = random.Next(0, form.ClientSize.Height);
        }
    }
}
