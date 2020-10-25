namespace AoC2017.Helpers.Interfaces
{
    public interface ITextWriter
    {
        void WriteToConsole(string text, bool newLine = false);
        void WriteToConsole(params string[] text);
        void WriteSeparation();
        void WriteDaySeparation();
    }
}