namespace RpgApp.GameMasterApp.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public int AlignmentId { get; set; }
        public int BaseStatId { get; set; }
        public int SavingStatId { get; set; }
        public int SkillStatId { get; set; }
        public int PassiveSkillId { get; set; }
        public int MonsterActionId { get; set; }
        public int DamageResistanceId { get; set; }
        public string Name { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public string Note { get; set; }
    }
}
