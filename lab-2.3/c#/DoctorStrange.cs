namespace CharacterLib
{
    public class DoctorStrange : IDescribable
    {
        private string name;
        private int magicLevel;

        public DoctorStrange()
        {
            name = "Unknown";
            magicLevel = 50;
        }

        public DoctorStrange(string name, int magicLevel)
        {
            this.name = name;
            this.magicLevel = magicLevel;
        }

        public DoctorStrange(DoctorStrange other)
        {
            name = other.name;
            magicLevel = other.magicLevel;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPower()
        {
            return magicLevel;
        }

        public string Describe()
        {
            return $"Doctor Strange: {name}, Magic: {magicLevel}";
        }
    }
}