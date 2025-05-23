using System;
using System.Globalization;

public class MyString : IKeyGenerator
{
    private string content;

    public string Content
    {
        get { return content; }
    }

    public MyString(string input)
    {
        content = input;
    }

    public string GenerateKey()
    {
        string[] words = content.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        string key = "";
        for (int i = 0; i < words.Length; i++)
        {
            key += words[i][0];
        }

        return key;
    }

    public void CapitalizeWords()
    {
        string[] words = content.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
        }
        content = string.Join(" ", words);
    }
}