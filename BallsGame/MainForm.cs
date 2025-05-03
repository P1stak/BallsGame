using Balls_Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallsGame
{
    public partial class MainForm : Form
    {
        private List<MoveBall> _listMoveBall;
        public MainForm()
        {
            InitializeComponent();
            _listMoveBall = new List<MoveBall>();
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
            form.Invalidate();

            for (int i = 1; i <= 10; i++)
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
                if (ball.IsCaught() == true)
                {
                    ballsCount++;
                }
            }
            MessageBox.Show($"Вы поймали {ballsCount} шариков");
        }
    }
}
