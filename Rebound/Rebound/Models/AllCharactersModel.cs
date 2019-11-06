namespace Rebound.Models
{
    public class AllCharactersModel
    {
        public AllCharactersModel(string name, string description, int life, int maxLife, int blockChance, int hitChance)
        {
            Name = name;
            Description = description;
            Life = life;
            MaxLife = maxLife;
            BlockChance = blockChance;
            HitChance = hitChance;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Life { get; set; }
        public int MaxLife { get; set; }
        public int BlockChance { get; set; }
        public int HitChance { get; set; }

    }
}
