using AoC2017.Helpers.Interfaces;
using System;
using System.Linq;

namespace AoC2017.Helpers
{
    public class TextWriter : ITextWriter
    {
        public void WriteToConsole(string text, bool newLine = false)
        {
            if (newLine)
                Console.WriteLine(text);
            else
                Console.Write(text);
        }

        public void WriteToConsole(params string[] text)
        {
            for (int i = 0; i < text.Length; i++)
                Console.WriteLine(text[i]);
        }

        public void WriteSeparation()
        {
            var line = new char[20];
            Array.Fill(line, '-');
            Console.Write(line);
            Console.WriteLine();
        }

        public void WriteDaySeparation()
        {
            Console.WriteLine();
            var line = new char[40];
            Array.Fill(line, '=');
            Console.Write(line);
            Console.WriteLine();
        }
    }
}