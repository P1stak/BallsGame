﻿namespace Billiards_Game
{
    public class HitEventArgs
    {
        public Side Side;
        public HitEventArgs(Side side)
        {
            Side = side;
        }
    }
}
