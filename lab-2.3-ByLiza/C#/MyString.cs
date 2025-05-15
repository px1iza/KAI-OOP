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
        var words = content.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string key = "";
        foreach (var word in words)
        {
            key += word[0];
        }
        return key;
    }

    public int Length => content.Length;

    public override string ToString() => content;
}