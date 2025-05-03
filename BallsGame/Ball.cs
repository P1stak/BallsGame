using System.Drawing;


namespace BallsGame
{
    public class Ball //дефолт
    {
        private MainForm form;
        protected int x = 150;
        protected int y = 150;
        private int vx = 5;
        private int vy = 5;
        protected int size = 70;
        public Ball(MainForm form)
        {
            this.form = form;
        }
        public void Show()
        {
            var graphics = form.CreateGraphics(); //холст
            var brash = Brushes.Aqua; //кисточка
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
            Show();
        }
        public void Stop()
        {
            x = 0; y = 0;
        }
    }
}
