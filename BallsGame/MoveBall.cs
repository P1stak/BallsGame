

using System.Windows.Forms;

namespace BallsGame
{
    public class MoveBall : RandomPointBall
    {
        private Timer timer;
        public MoveBall(MainForm form) : base(form)
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }

    }
}
