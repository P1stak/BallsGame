using Balls_Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallsGame
{
    public partial class MainForm : Form
    {
        private List<RandomSizeAndPointBall> _listMoveBall;
        public MainForm()
        {
            InitializeComponent();
            _listMoveBall = new List<RandomSizeAndPointBall>();
            DoubleBuffered = true;
        }
        private void button_Create_Balls_Click(object sender, EventArgs e)
        {
            foreach (var ball in _listMoveBall)
            { 
                ball.Stop();
            }
            _listMoveBall.Clear();

            Form form = this;
            Invalidate();

            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomSizeAndPointBall(this);
                _listMoveBall.Add(ball);
                ball.Start();
            }
        }

        private void button_Stop_Balls_Click(object sender, EventArgs e)
        {
            foreach (var ball in _listMoveBall)
            {
                ball.Stop();
            }

            var ballsCount = 0;

            foreach (var ball in _listMoveBall)
            {
                if (ball.IsCaught())
                {
                    ballsCount++;
                }
            }
            MessageBox.Show($"Вы поймали {ballsCount} шариков");
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var ball in _listMoveBall)
            {
                ball.Show(e.Graphics);
            }
        }
    }
}
