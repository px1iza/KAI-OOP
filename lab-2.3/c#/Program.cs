using CharacterLib;
using System;

class Program
{
    static void Main(string[] args)
    {
        AvengersTeam team = new AvengersTeam();

        // Створення супергероїв
        IDescribable tony = new Ironman("Tony Stark", "Mark L", 9000);
        IDescribable stephen = new DoctorStrange("Stephen Strange", 8000);
        IDescribable bruce = new Hulk("Bruce Banner", 8500);
        IDescribable natasha = new Widow("Natasha Romanoff", 7000);

        // Додавання до команди
        team.AddMember(tony);
        team.AddMember(stephen);
        team.AddMember(bruce);
        team.AddMember(natasha);

        // Виведення команди
        Console.WriteLine("Team members:");
        foreach (var member in team.GetMembers())
        {
            Console.WriteLine(member.Describe());
        }

        // Видалення за ім'ям
        Console.WriteLine("\nRemoving Natasha Romanoff:");
        team.RemoveMember("Natasha Romanoff");
        foreach (var member in team.GetMembers())
        {
            Console.WriteLine(member.Describe());
        }

        // Найпотужніший член
        Console.WriteLine("\nMost powerful member:");
        if (team.GetMostPowerful() != null)
        {
            Console.WriteLine(team.GetMostPowerful().Describe());
        }

        // Очищення команди
        Console.WriteLine("\nClearing team:");
        team.ClearTeam();
        Console.WriteLine("Team is empty: " + (team.GetMembers().Count == 0 ? "Yes" : "No"));
    }
}