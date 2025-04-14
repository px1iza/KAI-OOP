namespace CharacterLib
{
    public class Hulk : IDescribable
    {
        private string name;
        private int strengthLevel;

        public Hulk()
        {
            name = "Unknown";
            strengthLevel = 80;
        }

        public Hulk(string name, int strengthLevel)
        {
            this.name = name;
            this.strengthLevel = strengthLevel;
        }

        public Hulk(Hulk other)
        {
            name = other.name;
            strengthLevel = other.strengthLevel;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPower()
        {
            return strengthLevel;
        }

        public string Describe()
        {
            return $"Hulk: {name}, Strength: {strengthLevel}";
        }
    }
}