using Balls_Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Diffusion
{
    public partial class MainForm : Form
    {
        private List<DiffusionBall> _balls = new List<DiffusionBall>();
        private bool _isRunning = false;
        private int _ballsPerSide = 10;



        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.MouseClick += MainForm_MouseClick;
        }

        private void button_Start_Click(object sender, System.EventArgs e)
        {
            if (_isRunning) return;

            _balls.Clear();
            Invalidate();


            int centerLine = ClientSize.Width / 2;

            // Создаём синие шарики слева
            for (int i = 0; i < _ballsPerSide; i++)
            {
                var ball = new DiffusionBall(this, Color.DeepSkyBlue);
                ball.Radius = 15;
                ball.CenterX = Ball.Random.Next(ball.Radius, centerLine - ball.Radius);
                ball.CenterY = Ball.Random.Next(ball.Radius, ClientSize.Height - ball.Radius);
                ball.RandomSizeAndSpeedBalls();
                _balls.Add(ball);
            }

            // Создаём розовые шарики справа
            for (int i = 0; i < _ballsPerSide; i++)
            {
                var ball = new DiffusionBall(this, Color.HotPink);
                ball.Radius = 15;
                ball.CenterX = Ball.Random.Next(centerLine + ball.Radius, ClientSize.Width - ball.Radius);
                ball.CenterY = Ball.Random.Next(ball.Radius, ClientSize.Height - ball.Radius);
                ball.RandomSizeAndSpeedBalls();
                _balls.Add(ball);
            }

            foreach (var ball in _balls)
                ball.Start();

            _isRunning = true;
        }

        private void button_Stop_Click(object sender, System.EventArgs e)
        {
            StopDiffusion();
            ShowStats();
        }
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isRunning)
            {
                StopDiffusion();
                ShowStats();
            }
        }
        private void StopDiffusion()
        {
            foreach (var ball in _balls)
                ball.Stop();
            _isRunning = false;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Рисуем центральную пунктирную линию
            int centerLine = ClientSize.Width / 2;
            using (var pen = new Pen(Color.DarkGray, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
            {
                e.Graphics.DrawLine(pen, centerLine, 0, centerLine, ClientSize.Height);
            }

            // Рисуем все шарики
            foreach (var ball in _balls)
                ball.Show(e.Graphics);
        }
        public void BallMoved()
        {
            Invalidate();
            if (_isRunning)
                CheckDiffusionComplete();
        }
        private void CheckDiffusionComplete()
        {
            int centerLine = ClientSize.Width / 2;
            int blueLeft = _balls.Count(b => b.GasColor == Color.DeepSkyBlue && b.CenterX < centerLine);
            int blueRight = _balls.Count(b => b.GasColor == Color.DeepSkyBlue && b.CenterX >= centerLine);
            int pinkLeft = _balls.Count(b => b.GasColor == Color.HotPink && b.CenterX < centerLine);
            int pinkRight = _balls.Count(b => b.GasColor == Color.HotPink && b.CenterX >= centerLine);

            if (Math.Abs(blueLeft - blueRight) <= 1 && Math.Abs(pinkLeft - pinkRight) <= 1)
            {
                StopDiffusion();
                MessageBox.Show("Диффузия завершена!");
                ShowStats();
            }
        }
        private void ShowStats()
        {
            int blueLeftHits = _balls.Where(b => b.GasColor == Color.DeepSkyBlue).Sum(b => b.LeftHits);
            int blueRightHits = _balls.Where(b => b.GasColor == Color.DeepSkyBlue).Sum(b => b.RightHits);
            int blueTopHits = _balls.Where(b => b.GasColor == Color.DeepSkyBlue).Sum(b => b.TopHits);
            int blueBottomHits = _balls.Where(b => b.GasColor == Color.DeepSkyBlue).Sum(b => b.BottomHits);
            int blueCenterHits = _balls.Where(b => b.GasColor == Color.DeepSkyBlue).Sum(b => b.CenterHits);

            int pinkLeftHits = _balls.Where(b => b.GasColor == Color.HotPink).Sum(b => b.LeftHits);
            int pinkRightHits = _balls.Where(b => b.GasColor == Color.HotPink).Sum(b => b.RightHits);
            int pinkTopHits = _balls.Where(b => b.GasColor == Color.HotPink).Sum(b => b.TopHits);
            int pinkBottomHits = _balls.Where(b => b.GasColor == Color.HotPink).Sum(b => b.BottomHits);
            int pinkCenterHits = _balls.Where(b => b.GasColor == Color.HotPink).Sum(b => b.CenterHits);

            MessageBox.Show(
                $"Синие: Лев: {blueLeftHits}, Прав: {blueRightHits}, Верх: {blueTopHits}, Низ: {blueBottomHits}, Центр: {blueCenterHits}\n" +
                $"Розовые: Лев: {pinkLeftHits}, Прав: {pinkRightHits}, Верх: {pinkTopHits}, Низ: {pinkBottomHits}, Центр: {pinkCenterHits}"
            );
        }
    }
}
