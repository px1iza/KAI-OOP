using CharacterLib;
using System;

class Program
{
    static void Main(string[] args)
    {
        Ironman tony1 = new Ironman();
        Console.WriteLine($"Default Ironman: {tony1.GetName()}, {tony1.GetAge()}, " +
                         $"{tony1.GetSuitModel()}, {tony1.GetPowerLevel()}");

        Ironman tony2 = new Ironman("Tony Stark", 38, "Mark L", 9000);
        Console.WriteLine($"Custom Ironman: {tony2.GetName()}, {tony2.GetAge()}, " +
                         $"{tony2.GetSuitModel()}, {tony2.GetPowerLevel()}");

        Ironman tony3 = new Ironman(tony2);
        Console.WriteLine($"Copied Ironman: {tony3.GetName()}, {tony3.GetAge()}, " +
                         $"{tony3.GetSuitModel()}, {tony3.GetPowerLevel()}");
    }
}