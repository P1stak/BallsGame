using Balls_Core;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BubbleClickerGame
{
    public partial class MainForm : Form
    {
        private List<MoveBall> _listBalls;
        private int _score;

        public MainForm()
        {
            InitializeComponent();
            MouseClick += MainForm_MouseClick;

            DoubleBuffered = true; // для устранения мерцания

            _listBalls = new List<MoveBall>();
            _score = 0;

            label_Show_Count.Text = $"Ваш результат: {_score}";
            label_Rules.Text = "Кликайте мышкой по шарикам, чтобы получать очки!";
        }

        private void button_Start_Click(object sender, System.EventArgs e)
        {
            label_Rules.Visible = false;
            button_Start.Visible = false;

            foreach (var ball in _listBalls)
            {
                ball.Stop();
            }

            Form form = this;
            form.Invalidate();

            _listBalls.Clear();


            for (int i = 1; i <= 20; i++)
            {
                var ball = new RandomSizeAndPointBall(this);
                _listBalls.Add(ball);
                ball.Start();
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            var clickedX = e.X;
            var clickedY = e.Y;

            foreach (var ball in _listBalls)
            {
                if (ball.IsClicked(clickedX, clickedY) == true)
                {
                    if (ball.IsCaught() == true)
                    {
                        ball.Stop();
                        _score++;
                        label_Show_Count.Text = _score.ToString();
                        _listBalls.Remove(ball);
                        Invalidate();
                        break;
                    }
                }
            }
        }
    }
}
