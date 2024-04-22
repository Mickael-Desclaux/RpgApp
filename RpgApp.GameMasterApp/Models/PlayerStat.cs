namespace RpgApp.GameMasterApp.Models
{
    public class PlayerStat
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int DiceTypeId { get; set; }
        public int BaseStatId { get; set; }
        public int SavingStatId { get; set; }
        public int SkillStatId { get; set; }
        public int Level { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
    }
}
