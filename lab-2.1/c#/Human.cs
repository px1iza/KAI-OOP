namespace CharacterLib
{
    public class Human
    {
        private string name;
        private int age;

        // Конструктори
        public Human()
        {
            name = "Unknown";
            age = 0;
        }

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Human(Human other)
        {
            name = other.name;
            age = other.age;
        }

        // Гетери
        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }
    }
}