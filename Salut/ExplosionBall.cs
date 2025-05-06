using Balls_Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Salut
{
    public class ExplosionBall : Ball
    {
        private float g = 0.2f; // Гравитация
        private bool hasExploded = false; // Флаг, взорвался ли шарик
        private List<Ball> listBalls; // Список всех шаров
        private int blinkCounter = 0; // Счетчик для мигания
        private List<Ball> newBallsToAdd; // Временный список для новых шаров

        public ExplosionBall(Form form, List<Ball> listBalls) : base(form)
        {
            this.listBalls = listBalls;
            this.newBallsToAdd = new List<Ball>();
            centerX = form.ClientSize.Width / random.Next(1,10);
            centerY = form.ClientSize.Height - radius;
            vx = 0;
            vy = -10;
            radius = 20;
            BallColor = Color.OrangeRed;
        }

        public override void Move()
        {
            if (!hasExploded)
            {
                base.Move();
                blinkCounter++;

                if (vy >= 0)
                {
                    Explode();
                }
            }
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
            vx *= 0.99f;
            vy *= 0.99f;
        }

        private void Explode()
        {
            hasExploded = true; // Устанавливаем флаг взрыва

            int countBalls = random.Next(5, 20);
            for (int i = 0; i < countBalls; i++)
            {
                var ball = new SalutBall(form, (int)centerX, (int)centerY); // Новый маленький шарик
                ball.BallColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); // Случайный цвет
                newBallsToAdd.Add(ball);
            }
        }

        public bool HasExploded => hasExploded; // Свойство для проверки, взорвался ли шарик

        //public override void Show(Graphics graphics)
        //{
        //    if (!hasExploded && vy > -2) // Начинаем мигать, когда скорость близка к нулю
        //    {
        //        // Чередуем цвета каждые 4 тика (для равномерного мигания)
        //        if (blinkCounter % 4 < 2)
        //            BallColor = Color.White;
        //        else
        //            BallColor = Color.OrangeRed;
        //    }
        //    base.Show(graphics); // Вызываем базовый метод для отрисовки
        //}

        // Метод для получения новых шаров, которые нужно добавить в общий список
        public List<Ball> GetNewBalls()
        {
            var balls = new List<Ball>(newBallsToAdd);
            newBallsToAdd.Clear();
            return balls;
        }
    }
}