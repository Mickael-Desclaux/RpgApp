namespace RpgApp.Api.Entity
{
    public class CharacterResistance
    {
        public int Id { get; set; }
        public int DamageTypeId { get; set; }
        public int ResistanceTypeId { get; set; }
        public int? PlayerCharacterId { get; set; }
        public int? NonPlayerCharacterId { get; set; }
        public int? MonsterId { get; set; }
    }
}
