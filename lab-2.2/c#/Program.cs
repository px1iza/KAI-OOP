using CharacterLib;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів
        Human human = new Human("John Doe", 30);
        Ironman tony = new Ironman("Tony Stark", 38, "Mark L", 9000);

        // Демонстрація поліморфізму через посилання
        Human ref1 = human;
        Human ref2 = tony;

        Console.WriteLine(ref1.Identify()); // Виклик методу Human
        Console.WriteLine(ref2.Identify()); // Виклик методу Ironman (поліморфізм)
    }
}
