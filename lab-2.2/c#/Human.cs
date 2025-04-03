namespace CharacterLib
{
    public class Human
    {
        private string name;
        private int age;

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

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        // Віртуальний метод
        public virtual string Identify()
        {
            return $"I am a human named {name}";
        }
    }
}