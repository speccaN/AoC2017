using AoC2017.Helpers.Interfaces;
using System;
using System.Diagnostics;

namespace AoC2017.Helpers
{
    public class Timer : ITimer
    {
        private readonly Stopwatch _s = new Stopwatch();

        public void Start() => _s.Restart();
        public void Restart() => _s.Restart();

        public void Stop() => _s.Stop();

        public (TimeSpan span, long milliseconds, long ticks) GetExecutionTime() => (_s.Elapsed, _s.ElapsedMilliseconds, _s.ElapsedTicks);
    }
}