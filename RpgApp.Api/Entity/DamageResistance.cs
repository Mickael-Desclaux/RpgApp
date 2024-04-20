namespace RpgApp.Api.Entity
{
    public class DamageResistance
    {
        public int Id { get; set; }
        public int DamageTypeId { get; set; }
        public int ResistanceTypeId { get; set; }
    }
}
