namespace CharacterLib
{
    public class Ironman : Human
    {
        private string suitModel;
        private int powerLevel;

        // Конструктори
        public Ironman() : base()
        {
            suitModel = "Mark I";
            powerLevel = 100;
        }

        public Ironman(string name, int age, string suitModel, int powerLevel) 
            : base(name, age)
        {
            this.suitModel = suitModel;
            this.powerLevel = powerLevel;
        }

        public Ironman(Ironman other) : base(other)
        {
            suitModel = other.suitModel;
            powerLevel = other.powerLevel;
        }

        // Гетери
        public string GetSuitModel()
        {
            return suitModel;
        }

        public int GetPowerLevel()
        {
            return powerLevel;
        }
    }
}