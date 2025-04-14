namespace CharacterLib
{
    public class Widow : IDescribable
    {
        private string name;
        private int skillLevel;

        public Widow()
        {
            name = "Unknown";
            skillLevel = 60;
        }

        public Widow(string name, int skillLevel)
        {
            this.name = name;
            this.skillLevel = skillLevel;
        }

        public Widow(Widow other)
        {
            name = other.name;
            skillLevel = other.skillLevel;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPower()
        {
            return skillLevel;
        }

        public string Describe()
        {
            return $"Black Widow: {name}, Skill: {skillLevel}";
        }
    }
}