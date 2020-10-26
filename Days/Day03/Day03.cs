using AoC2017.Helpers.Interfaces;
using System;
using System.Collections.Generic;

namespace AoC2017.Days.Day03
{
    public class Day03 : Day<int, int>
    {
        private readonly IMath _math;

        public Day03(ITimer timer, ITextReader reader, ITextWriter writer, IMath math) : base(timer, reader, writer)
        {
            _math = math;
            Input = 368078;
        }

        internal override void PartOne()
        {
            var currentX = 0;
            var currentY = 0;
            var currentVal = 1;
            var steps = 1;
            var grid = new Dictionary<int, (int x, int y)> { {1, (x: 0, y: 0) } };

            var MoveRight = new Action(() =>
            {
                while (currentX < steps)
                {
                    grid.Add(++currentVal, (++currentX, currentY));
                }
            });

            var MoveUp = new Action(() =>
            {
                while (currentY < steps)
                {
                    grid.Add(++currentVal, (currentX, ++currentY));
                }
            });

            var MoveLeft = new Action(() =>
            {
                while (currentX > steps * -1)
                {
                    grid.Add(++currentVal, (--currentX, currentY));
                }
            });

            var MoveDown = new Action(() =>
            {
                while (currentY > steps * -1)
                {
                    grid.Add(++currentVal, (currentX, --currentY));
                }
            });

            while (!grid.ContainsKey(Input))
            {
                MoveRight();
                MoveUp();
                MoveLeft();
                MoveDown();
                steps++;
            }

            var coordinate = grid[Input];
            Output = _math.CalculateManhattanDistance(coordinate.x, 0, coordinate.y, 0);
        }

        internal override void PartTwo()
        {
            return;
        }
    }
}