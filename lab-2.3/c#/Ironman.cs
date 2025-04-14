namespace CharacterLib
{
    public class Ironman : IDescribable
    {
        private string name;
        private string suitModel;
        private int powerLevel;

        public Ironman()
        {
            name = "Unknown";
            suitModel = "Mark I";
            powerLevel = 100;
        }

        public Ironman(string name, string suitModel, int powerLevel)
        {
            this.name = name;
            this.suitModel = suitModel;
            this.powerLevel = powerLevel;
        }

        public Ironman(Ironman other)
        {
            name = other.name;
            suitModel = other.suitModel;
            powerLevel = other.powerLevel;
        }

        public string GetName()
        {
            return name;
        }

        public string GetSuitModel()
        {
            return suitModel;
        }

        public int GetPower()
        {
            return powerLevel;
        }

        public string Describe()
        {
            return $"Ironman: {name}, Suit: {suitModel}, Power: {powerLevel}";
        }
    }
}