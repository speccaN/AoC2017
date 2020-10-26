using AoC2017.Helpers.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AoC2017.Days.Day02
{
    public class Day02 : Day<IEnumerable<int[]>, int>
    {
        public Day02(
            ITimer timer, 
            ITextReader reader, 
            ITextWriter writer) : base(timer, reader, writer)
        {
            Input = _reader.ReadAllLines("Day02").Select(s => s.Split('\t').Select(int.Parse).ToArray());
        }

        internal override void PartOne()
        {
            Output = Input.Select(row => row.Max() - row.Min()).Sum();
        }

        internal override void PartTwo()
        {
            Output = 0;
            foreach (var row in Input.Select(row => row))
            {
                for (int i = 0; i < row.Length; i++)
                {
                    var found = false;
                    for (int j = 0; j < row.Length; j++)
                    {
                        if(i == j) continue;
                        if ((double)row[i] % row[j] == 0)
                        {
                            Output += row[i] / row[j];
                            found = !found;
                            break;
                        }
                        if ((double)row[j] % row[i] == 0)
                        {
                            Output += row[j] / row[i];
                            found = !found;
                            break;
                        }
                    }
                    if (found)
                        break;
                }
            }
        }
    }
}