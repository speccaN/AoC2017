using AoC2017.Days.Interfaces;
using AoC2017.Helpers.Interfaces;

namespace AoC2017.Days
{
    public abstract class Day<T, U> : IExecute
    {
        protected readonly ITextReader _reader;
        protected readonly ITextWriter _writer;
        protected readonly ITimer _timer;

        protected T Input { get; set; }
        protected U Output { get; set; }

        protected Day(
            ITimer timer,
            ITextReader reader,
            ITextWriter writer)
        {
            _timer = timer;
            _reader = reader;
            _writer = writer;
        }

        internal abstract void PartOne();
        internal abstract void PartTwo();

        public void Run()
        {
            _writer.WriteToConsole(GetType().Name, true);
            _timer.Start();
            PartOne();
            _timer.Stop();
            WriteResult("Part One", true);

            _timer.Restart();
            PartTwo();
            _timer.Stop();
            WriteResult("Part Two");

            _writer.WriteDaySeparation();
        }

        private void WriteResult(string part, bool writeSeparation = false)
        {
            _writer.WriteToConsole($"{part}: ", $"Result: {Output}");
            var executionTime = _timer.GetExecutionTime();
            _writer.WriteToConsole("Elapsed: ",
                $"Span: {executionTime.span.TotalMilliseconds}",
                $"Milliseconds: {executionTime.milliseconds}",
                $"Ticks: {executionTime.ticks}");
            if(writeSeparation) _writer.WriteSeparation();
        }
    }
}