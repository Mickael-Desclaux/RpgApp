namespace RpgApp.Api.Entity
{
    public class PlayerCharacter
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int RaceId { get; set; }
        public int RaceTraitId { get; set; }
        public int CharacterDescriptionId { get; set; }
        public int PlayerCharacterSpellId { get; set; }
        public int PlayerCharacterEquipmentId { get; set; }
        public int PlayerCharacterFeatId { get; set; }
        public int BackgroundId { get; set; }
        public int AlignmentId { get; set; }
        public int RolePlayId { get; set; }
        public int ImageId { get; set; }
        public int CroppedImageId { get; set; }
        public string PlayerName { get; set; }
        public string CharacterName { get; set; }
        public string BackStory { get; set; }
        public int Gold { get; set; }
        public string Notes { get; set; }
    }
}
