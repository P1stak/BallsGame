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
            this.newBallsToAdd = new List<Ball>(); // Инициализируем временный список
            centerX = form.ClientSize.Width / 2; // Начинаем в середине формы по X
            centerY = form.ClientSize.Height - radius; // Начинаем у нижней стенки
            vx = 0; // Скорость по X
            vy = -10; // Скорость по Y (вверх)
            radius = 20; // Размер шарика
            BallColor = Color.OrangeRed; // Цвет шарика
        }

        public override void Move()
        {
            if (!hasExploded) // Двигаем шарик только если он не взорвался
            {
                base.Move(); // Вызываем базовый метод Move
                blinkCounter++; // Увеличиваем счетчик для мигания

                // Если вертикальная скорость становится больше или равна нулю, взрываем шарик
                if (vy >= 0)
                {
                    Explode();
                }
            }
        }

        protected override void Go()
        {
            base.Go(); // Вызываем базовый метод для изменения позиции
            vy += g; // Добавляем гравитацию
            vx *= 0.99f; // Трение по X
            vy *= 0.99f; // Трение по Y
        }

        private void Explode()
        {
            hasExploded = true; // Устанавливаем флаг взрыва

            // Создаем случайное количество шаров от 5 до 8
            int countBalls = random.Next(5, 9); // 9, чтобы включить 8
            for (int i = 0; i < countBalls; i++)
            {
                var ball = new SalutBall(form, (int)centerX, (int)centerY); // Новый маленький шарик
                ball.BallColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); // Случайный цвет
                newBallsToAdd.Add(ball); // Добавляем во временный список
            }
        }

        public bool HasExploded => hasExploded; // Свойство для проверки, взорвался ли шарик

        public override void Show(Graphics graphics)
        {
            if (!hasExploded && vy > -2) // Начинаем мигать, когда скорость близка к нулю
            {
                // Чередуем цвета каждые 4 тика (для равномерного мигания)
                if (blinkCounter % 4 < 2)
                    BallColor = Color.White;
                else
                    BallColor = Color.OrangeRed;
            }
            base.Show(graphics); // Вызываем базовый метод для отрисовки
        }

        // Метод для получения новых шаров, которые нужно добавить в общий список
        public List<Ball> GetNewBalls()
        {
            var balls = new List<Ball>(newBallsToAdd); // Создаем копию списка новых шаров
            newBallsToAdd.Clear(); // Очищаем временный список
            return balls; // Возвращаем список новых шаров
        }
    }
}