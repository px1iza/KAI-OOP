namespace String{
class Program
    {
        public static void ProcessString(BaseString baseStr)
        {
            Console.WriteLine($"Оригінальний рядок: {baseStr.Value}");
            Console.WriteLine($"Довжина: {baseStr.GetLength()}");
            Console.WriteLine($"Оброблений рядок: {baseStr.Shift()}");
            Console.WriteLine();
        }

        static void Main()
        {
            LowerCaseString lowerCaseString = new LowerCaseString("Hello World!");
            NumbersString numbersString = new NumbersString("12345");

            ProcessString(lowerCaseString); 
            ProcessString(numbersString);    
        }
    }
}
