using System;

namespace AoC2017.Helpers.Interfaces
{
    public interface ITimer
    {
        void Start();
        void Restart();
        void Stop();
        (TimeSpan span, long milliseconds, long ticks) GetExecutionTime();
    }
}