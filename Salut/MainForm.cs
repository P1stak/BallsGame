using Balls_Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Salut
{
    public partial class MainForm : Form
    {
        private List<Ball> listBalls;
        private Timer timer;
        private Timer spawnTimer;

        public MainForm()
        {
            InitializeComponent();
            listBalls = new List<Ball>();
            DoubleBuffered = true;

            // Настройка таймера анимации
            timer = new Timer();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Настройка таймера создания ExplosionBall
            spawnTimer = new Timer();
            spawnTimer.Interval = 3000;
            spawnTimer.Tick += Spawn_Tick;
            spawnTimer.Start();

            MouseDown += MainForm_MouseDown;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                var ball = new SalutBall(this, e.X, e.Y);
                listBalls.Add(ball);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Создаем временный список для новых шаров, которые нужно добавить
            var newBallsToAdd = new List<Ball>();

            // Обновляем позиции всех шаров
            foreach (var ball in listBalls)
            {
                ball.Move();

                // Если это ExplosionBall, проверяем, есть ли новые шары для добавления
                if (ball is ExplosionBall explosionBall)
                {
                    var newBalls = explosionBall.GetNewBalls();
                    newBallsToAdd.AddRange(newBalls); // Добавляем новые шары во временный список
                }
            }

            // Добавляем все новые шары в общий список после завершения цикла
            listBalls.AddRange(newBallsToAdd);

            // Создаем временный список для шаров, которые нужно удалить
            var ballsToRemove = new List<Ball>();

            // Проверяем каждый шар в списке
            foreach (var ball in listBalls)
            {
                // Если это ExplosionBall
                if (ball is ExplosionBall)
                {
                    var explosionBall = (ExplosionBall)ball;
                    // Если он взорвался, добавляем в список на удаление
                    if (explosionBall.HasExploded)
                    {
                        ballsToRemove.Add(ball);
                    }
                }
                // Если это не ExplosionBall (например, SalutBall)
                else
                {
                    // Если шар вышел за пределы формы, добавляем в список на удаление
                    if (ball.IsOutOfBounds())
                    {
                        ballsToRemove.Add(ball);
                    }
                }
            }

            // Удаляем все шары из списка на удаление
            foreach (var ball in ballsToRemove)
            {
                listBalls.Remove(ball);
            }

            // Перерисовываем форму
            Invalidate();
        }

        private void Spawn_Tick(object sender, EventArgs e)
        {
            var explosionBall = new ExplosionBall(this, listBalls);
            listBalls.Add(explosionBall);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Сглаживание
            foreach (var ball in listBalls)
            {
                ball.Show(e.Graphics);
            }
        }
    }
}