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

    public void CapitalizeWords()
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        content = textInfo.ToTitleCase(content.ToLower());

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

}