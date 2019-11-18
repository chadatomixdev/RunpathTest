namespace Runpath.Shared.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public User User { get; set; }
    }
}