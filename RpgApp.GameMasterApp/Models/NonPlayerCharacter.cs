namespace RpgApp.GameMasterApp.Models
{
    public class NonPlayerCharacter
    {
        public int Id { get; set; }
        public int ChapterId { get; set; }
        public int DamageResistanceId { get; set; }
        public string Name { get; set; }
        public int ImageId { get; set; }
        public string CharacterDescription { get; set; }
        public string Note { get; set; }
    }
}
