using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls_Core
{
    public class MoveBall : Ball
    {
        private Timer timer;

        public MoveBall(Form form) : base(form)
        {
            timer = new Timer();
            timer.Interval = random.Next(5, 30);
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
        public new void Stop()
        {
            timer.Stop();
        }

    }
}
