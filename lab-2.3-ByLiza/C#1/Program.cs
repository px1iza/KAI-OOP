using System;

class Program
{
    static void Main()
    {
        TextContainer text = new();

        text.AddLine("привіт світ");
        text.AddLine("відкрити штучний інтелект");
        text.AddLine("об'єктно орієнтоване програмування");

        Console.WriteLine("Початковий текст:");
        text.PrintAll();

        text.CapitalizeAll();
        Console.WriteLine("\nПісля приведення перших літер слів до верхнього регістру:");
        text.PrintAll();

        Console.WriteLine($"\nКлюч з першого рядка: {text.GetKeyFromLine(0)}");
        Console.WriteLine($"Кількість рядків довжиною 33 символи: {text.CountLinesOfLength(33)}");

        text.RemoveLine(1);
        Console.WriteLine("\nПісля видалення другого рядка:");
        text.PrintAll();

        text.Clear();
        Console.WriteLine("\nПісля очищення тексту:");
        text.PrintAll();
    }
}