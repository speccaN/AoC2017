using AoC2017.Helpers.Interfaces;
using System;

namespace AoC2017.Helpers
{
    public class MathHelper : IMath
    {
        public int CalculateManhattanDistance(int x1, int x2, int y1, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
    }
}