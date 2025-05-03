using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallsGame
{
    public partial class MainForm : Form
    {
        private PointBall pointBall;
        private List<MoveBall> moveBalls;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y); // MousePosition.X, MousePosition.Y
            pointBall.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (MoveBall moveBall in moveBalls)
            {
                moveBall.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();
            for (int i = 0; i < 5; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

    }
}
