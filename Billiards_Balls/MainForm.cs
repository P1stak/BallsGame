using System.Collections.Generic;
using System.Windows.Forms;
using Balls_Core;

namespace Billiards_Balls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            var ball = new BilliardBall(this);
            ball.Move();
        }
    }
}
