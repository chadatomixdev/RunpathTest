namespace Runpath.Shared.Models
{
    public class Photos
    {
            public int AlbumID { get; set; }
            public int PhotoID { get; set; }
            public string Title { get; set; }
            public string URL { get; set; }
            public string ThumbnailURL { get; set; }
            public Album Album { get; set; }
    }
}