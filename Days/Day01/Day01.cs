using AoC2017.Helpers.Interfaces;
using System;

namespace AoC2017.Days.Day01
{
    public class Day01 : Day<int[], int>
    {
        public Day01(
            ITimer timer,
            ITextReader reader,
            ITextWriter writer) : base(timer, reader, writer)
        {
            Input = Array.ConvertAll(_reader.ReadText("Day01").ToCharArray(),
                c => (int) char.GetNumericValue(c));
        }

        internal override void PartOne()
        {
            Output = Input[0] == Input[^1] ? Input[0] : 0;

            for (int i = 0; i < Input.Length; i++)
                if (i < Input.Length - 1 && Input[i] == Input[i + 1])
                    Output += Input[i];
        }

        internal override void PartTwo()
        {
            var sum = 0;
            var step = new Func<int, int>(i => (i + (Input.Length) / 2) % Input.Length);

            for (int i = 0; i < Input.Length; i++)
                if (Input[i] == Input[step(i)])
                    sum += Input[i];
        }
    }
}