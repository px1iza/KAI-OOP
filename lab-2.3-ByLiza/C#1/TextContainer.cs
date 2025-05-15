using System.Collections.Generic;
using System.Linq;

public class TextContainer
{
    private List<MyString> lines = new();
    //List — це спеціальний контейнер або колекція в мові C#, який використовується для зберігання групи об’єктів одного типу.
    //Якщо масив — це як ящик з фіксованою кількістю осередків (скажімо, на 5 місць),
	// •	То List — це ящик, який може збільшуватись або зменшуватись, коли тобі треба додати або видалити предмети.
    //	1.	Динамічний розмір — ти не мусиш заздалегідь знати, скільки елементів буде.
	// 	2.	Зберігає об’єкти одного типу — наприклад, List<string> зберігає рядки, а List<int> — цілі числа.
	// 	3.	Зручні методи для роботи:
	// 	•	Add() — додати елемент
	// 	•	RemoveAt() — видалити елемент за індексом
	// 	•	Count — скільки елементів зараз у списку
	// 	•	Можна отримувати елементи за індексом, наприклад: myList[0] — перший елемент

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