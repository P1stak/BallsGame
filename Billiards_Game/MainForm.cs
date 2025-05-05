using System;
using System.Windows.Forms;

namespace Billiards_Game
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                var ball = new BilliardsBall(this);
                ball.OnHited += Ball_OnHited;
                ball.Start();
            }

        }
        private void Ball_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    label_Left.Text = (Convert.ToInt32(label_Left.Text) + 1).ToString();
                    break;
                case Side.Right:
                    label_Right.Text = (Convert.ToInt32(label_Right.Text) + 1).ToString();
                    break;
                case Side.Top:
                    label_Top.Text = (Convert.ToInt32(label_Top.Text) + 1).ToString();
                    break;
                case Side.Down:
                    label_Down.Text = (Convert.ToInt32(label_Down.Text) + 1).ToString();
                    break;
            }
        }
    }
}
