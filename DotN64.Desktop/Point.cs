﻿namespace DotN64.Desktop
{
    internal struct Point
    {
        #region Fields
        public int X, Y;
        #endregion

        #region Constructors
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Methods
        public override string ToString() => $"X: {X}, Y: {Y}";
        #endregion
    }
}
