using System.Collections.Generic;
using System.Linq;

public class TextContainer
{
    private List<MyString> lines = new();

    public void AddLine(string input)
    {
        lines.Add(new MyString(input));
    }

    public void RemoveLine(int index)
    {
        if (index >= 0 && index < lines.Count)
            lines.RemoveAt(index);
    }

    public void Clear()
    {
        lines.Clear();
    }

    public void CapitalizeAll()
    {
        foreach (var line in lines)
        {
            line.CapitalizeWords();
        }
    }

    public string GetKeyFromLine(int index)
    {
        if (index >= 0 && index < lines.Count)
            return lines[index].GenerateKey();
        return "";
    }

    public int CountLinesOfLength(int length)
    {
        return lines.Count(line => line.Length == length);
    }

    public void PrintAll()
    {
        foreach (var line in lines)
        {
            System.Console.WriteLine(line);
        }
    }
}