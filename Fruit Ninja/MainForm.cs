using Balls_Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fruit_Ninja
{

    public partial class MainForm : Form
    {
        private List<Ball> listFruts;
        private Timer timer;
        private Timer spawnTimer;
        private Point lastMousePosition;

        public MainForm()
        {
            InitializeComponent();
            listFruts = new List<Ball>();
            DoubleBuffered = true;

            // Настройка таймера анимации
            timer = new Timer();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Настройка таймера создания шариков
            spawnTimer = new Timer();
            spawnTimer.Interval = 1500; // Создаем новый шарик каждый n
            spawnTimer.Tick += Spawn_Tick;
            spawnTimer.Start();

            MouseMove += MainForm_MouseMove;
            lastMousePosition = Cursor.Position; // Инициализируем последнюю позицию мыши
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

            foreach (var frut in listFruts)
            {
                if (frut is MoveFruts moveFrut && !moveFrut.HasCut)
                {
                    moveFrut.CheckCut(e.X, e.Y);
                }
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Обновляем позиции всех шаров
            foreach (var frut in listFruts)
            {
                frut.Move();
            }

            var frutsToRemove = new List<Ball>();

            foreach (var frut in listFruts)
            {
                if (frut is MoveFruts moveFrut)
                {
                    if (moveFrut.HasCut)
                    {
                        frutsToRemove.Add(frut);
                    }
                    else if (frut.IsOutOfBounds())
                    {
                        frutsToRemove.Add(frut);
                    }
                }
            }
            foreach (var frut in frutsToRemove)
            {
                listFruts.Remove(frut);
            }

            Invalidate();
        }
        private void Spawn_Tick(object sender, EventArgs e)
        {
            var frut = new MoveFruts(this);
            listFruts.Add(frut);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Сглаживание
            foreach (var frut in listFruts)
            {
                frut.Show(e.Graphics);
            }
        }
    }
}
