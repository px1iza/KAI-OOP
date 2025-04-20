namespace String{
class Program
    {
        // Метод для демонстрації поліморфізму
        public static void ProcessString(BaseString baseStr)
        {
            // Викликаємо віртуальні методи для кожного об'єкта
            Console.WriteLine($"Оригінальний рядок: {baseStr.Value}");
            Console.WriteLine($"Довжина: {baseStr.GetLength()}");
            Console.WriteLine($"Оброблений рядок: {baseStr.Shift()}");
            Console.WriteLine();
        }

        static void Main()
        {
            // Створення об'єктів
            LowerCaseString lowerCaseString = new LowerCaseString("Hello World!");
            NumbersString numbersString = new NumbersString("12345");

            // Викликаємо метод для кожного об'єкта, демонструючи поліморфізм
            ProcessString(lowerCaseString);  // Поліморфізм у дії
            ProcessString(numbersString);    // Поліморфізм у дії
        }
    }
}
