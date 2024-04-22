namespace RpgApp.GameMasterApp.Models
{
    public class GameMasterNote
    {
        public int Id { get; set; }
        public int ChapterId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ImageId { get; set; }
    }
}
