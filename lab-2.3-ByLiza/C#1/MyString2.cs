using System;
using System.Globalization;

public class MyString2 : IKeyGenerator
{
    private string content;

    public string Content
    {
        get { return content + " 2"; }
    }

    public MyString2(string input)
    {
        content = input;
    }

    public string GenerateKey()
    {
        string[] words = content.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        string key = "";

        for (int i = 0; i < words.Length; i++)
        {
            key += words[words.Length-i-1][0];
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
                words[i] = char.ToLower(words[i][0]) + words[i].Substring(1);
            }
        }
        content = string.Join(" ", words);
    }
}