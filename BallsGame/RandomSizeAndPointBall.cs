namespace BallsGame
{
    public class RandomSizeAndPointBall : RandomPointBall //в разных местах с разными размерами
    {
        public RandomSizeAndPointBall(MainForm form) : base(form)
        {
            RandomSizeAndSpeedBalls();
        }
    }
}
