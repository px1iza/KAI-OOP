using System.Collections.Generic;
using System.Linq;

public class TextContainer
{
    private List<IKeyGenerator> lines = new();

    public void AddLine(IKeyGenerator input)
    {
        lines.Add(input);
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
        for (int i = 0; i < lines.Count; i++)
        {
            lines[i].CapitalizeWords();
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
        int count = 0;
        for (int i = 0; i < lines.Count; i++)
        {
            if (lines[i].Content.Length == length)
                count++;
        }
        return count;
    }

    public void PrintAll()
    {
        for (int i = 0; i < lines.Count; i++)
        {
            System.Console.WriteLine(lines[i].Content);
        }
    }
}