using System;
using System.Drawing;


namespace BallsGame
{
    public class Ball //дефолт
    {
        private MainForm form;
        protected int x = 150;
        protected int y = 150;

        //скорости
        protected int vx = 5;
        protected int vy = 5;

        //размер
        protected int size = 70;
        protected static Random random = new Random();

        public Ball(MainForm form)
        {
            this.form = form;
        }
        public void Show()
        {
            var graphics = form.CreateGraphics(); //холст
            var brash = Brushes.Aqua; //кисточка

            //визуализация пойманных и не пойманных шариков
            if (IsCaught() == true)
                brash = Brushes.Chartreuse;

            else brash = Brushes.Red;

            var rectangle = new Rectangle(x, y, size, size); //область на котром рисуется
            graphics.FillEllipse(brash, rectangle); //элепс
        }
        private void Go() //двигаем шарик
        {
            x += vx;
            y += vy;
        }
        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var brash = Brushes.White;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brash, rectangle);
        }
        public void Move() // инкапсулировали методы, тем самым скрыли от пользователя ненужные ему свойства объектов
        {
            Clear();
            Go();


            // чтобы шарики отскакивали от границ
            //if (x < 0 || x + size > form.ClientSize.Width)
            //    vx = -vx;

            //if (y < 0 || y + size > form.ClientSize.Height)
            //    vy = -vy;

            Show();
        }
        public void RandomSizeAndSpeedBalls()
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
            size = random.Next(5, 70);
        }
        public bool IsCaught() // метод для проверки находится ли шар внутри формочки
        {
            if ((x >= 0 && x + size <= form.ClientSize.Width) && (y >= 0 && y + size <= form.ClientSize.Height))
            {
                return true;
            }
            return false;
        }

    }
}
