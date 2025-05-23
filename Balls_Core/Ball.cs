﻿using System;
using System.Drawing;
using System.Windows.Forms;


namespace Balls_Core
{
    public class Ball //дефолт
    {
        protected Form form;
        protected float vx = 5;
        protected float vy = 5;
        protected float centerX = 10;
        protected float centerY = 10;
        protected int radius = 25;
        protected static Random random = new Random();
        private Timer timer;

        public Color BallColor { get; set; } = Color.Aqua;

        public static Random Random => random;

        public Ball(Form form)
        {
            this.form = form;
            //timer = new Timer();
            //timer.Interval = random.Next(1, 5);
            //timer.Tick += Timer_Tick;
        }
        public virtual void Show(Graphics graphics)
        {
            using (var brush = new SolidBrush(BallColor))
            {
                var rect = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
                graphics.FillEllipse(brush, rect);
            }
        }

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    Move();
        //    form.Invalidate();
        //}
        //public void Start() => timer.Start();
        //public void Stop() => timer.Stop();

        public void Show()
        {
            using (var graphics = form.CreateGraphics())
            {
                Show(graphics);
            }
        }
        public virtual void Move()
        {
            Go();
            HandleCollisions();
        }
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }
        protected virtual void HandleCollisions() // базовый метод, который не отражает шарики от поверхностей
        {
            //protected override void HandleCollisions()
            //{ 
            //        base.HandleCollisions();

            //        if (centerX - radius < 0)
            //        {
            //            vx = -vx;
            //            centerX = radius;
            //        }
            //        if (centerX + radius > form.ClientSize.Width)
            //        {
            //            vx = -vx;
            //            centerX = form.ClientSize.Width - radius;
            //        }
            //        if (centerY - radius < 0)
            //        {
            //            vy = -vy;
            //            centerY = radius;
            //        }
            //        if (centerY + radius > form.ClientSize.Height)
            //        {
            //            vy = -vy;
            //            centerY = form.ClientSize.Height - radius;
            //        }
            //}
        }

        // пойман ли шар
        public bool IsCaught()
        {
            return centerX >= radius && centerX <= form.ClientSize.Width - radius &&
                   centerY >= radius && centerY <= form.ClientSize.Height - radius;
        }
        public bool IsClicked(int pointX, int pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;
            return dx * dx + dy * dy <= radius * radius;
        }
        public void RandomSizeAndSpeedBalls()
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
            radius = random.Next(5, 25);
        }

        // метод определяющий, находится ли шар за пределами формочки
        public bool IsOutOfBounds()
        {
            return centerX + radius < 0 || centerX - radius > form.ClientSize.Width ||
                   centerY + radius < 0 || centerY - radius > form.ClientSize.Height;
        }
    }
}
