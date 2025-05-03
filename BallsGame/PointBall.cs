namespace BallsGame
{
    public class PointBall : Ball // по клику на форму
    {
        public PointBall(MainForm form, int x, int y) : base(form)
        {
            this.x = x - 70 / 2;
            this.y = y - 70 / 2;
        }
    }
}
