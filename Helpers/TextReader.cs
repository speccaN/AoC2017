using AoC2017.Helpers.Interfaces;
using System;
using System.IO;

namespace AoC2017.Helpers
{
    public class TextReader : ITextReader
    {
        public string[] ReadAllLines(string day)
        {
            var combinedPath = Path.Combine(Environment.CurrentDirectory, "Days", day, Path.GetFileName($"{day}input.txt"));

            return File.ReadAllLines(combinedPath);
        }

        public string ReadText(string day)
        {
            var combinedPath = Path.Combine(Environment.CurrentDirectory, "Days", day,
                Path.GetFileName($"{day}input.txt"));

            using var reader = new StreamReader(combinedPath);
            return reader.ReadToEnd();
        }
    }
}