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
        // TextInfo — це клас з простору імен System.Globalization,
        // який містить методи та властивості для роботи з текстом у контексті певної культури.
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        content = textInfo.ToTitleCase(content.ToLower());

        // Функцію CapitalizeWords() цілком реально зробити вручну через string:
        // розбити рядок на слова, кожне слово зробити маленькими літерами,
        // потім першу літеру — великою, і склеїти назад.
    }

    public string GenerateKey()
    {
        string[] words = content.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        //StringSplitOptions.RemoveEmptyEntries означає: не включати пусті рядки, якщо між словами випадково буде кілька пробілів
        string key = "";

        for (int i = 0; i < words.Length; i++)
        {
            key += words[i][0];
        }

        return key;
    }
    // Це метод, який повертає рядок (string). 
    // Його задача — взяти весь текст, який зберігається в content, і зробити з нього “ключ” — перші літери всіх слів.
    // абревіатура з перших літер слів у рядку.

}