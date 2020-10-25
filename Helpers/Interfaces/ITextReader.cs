namespace AoC2017.Helpers.Interfaces
{
    public interface ITextReader
    {
        string[] ReadAllLines(string day);
        string ReadText(string day);
    }
}