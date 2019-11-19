using Runpath.Data.Models;
using System.Collections.Generic;

namespace Runpath.UnitTests.Fakes
{
    public class BaseFake
    {
        public List<Photo> Photos = new List<Photo>();
        public List<Album> Albums = new List<Album>();

        public BaseFake()
        {
            GenerateFakeAlbums();
            GenerateFakePhotos();
        }

        private void GenerateFakePhotos()
        {
            var _photo1 = new Photo { AlbumID = 1, PhotoID = 1, Title = "accusamus beatae ad facilis cum similique qui sunt", URL = "https://via.placeholder.com/600/92c952", ThumbnailURL = "https://via.placeholder.com/150/92c952" };
            var _photo2 = new Photo { AlbumID = 1, PhotoID = 2, Title = "reprehenderit est deserunt velit ipsam", URL = "https://via.placeholder.com/600/771796", ThumbnailURL = "https://via.placeholder.com/150/771796" };
            var _photo3 = new Photo { AlbumID = 1, PhotoID = 3, Title = "officia porro iure quia iusto qui ipsa ut modi", URL = "https://via.placeholder.com/600/24f355", ThumbnailURL = "https://via.placeholder.com/150/24f355" };
            var _photo4 = new Photo { AlbumID = 2, PhotoID = 4, Title = "culpa odio esse rerum omnis laboriosam voluptate repudiandae", URL = "https://via.placeholder.com/600/d32776", ThumbnailURL = "https://via.placeholder.com/150/d32776" };
            var _photo5 = new Photo { AlbumID = 2, PhotoID = 5, Title = "natus nisi omnis corporis facere molestiae rerum in", URL = "https://via.placeholder.com/600/f66b97", ThumbnailURL = "https://via.placeholder.com/150/f66b97" };

            Photos.Add(_photo1);
            Photos.Add(_photo2);
            Photos.Add(_photo3);
            Photos.Add(_photo4);
            Photos.Add(_photo5);
        }

        private void GenerateFakeAlbums()
        {
            var _album1 = new Album { AlbumID = 1, UserID = 1, Title = "quidem molestiae enim" };
            var _album2 = new Album { AlbumID = 2, UserID = 1, Title = "sunt qui excepturi placeat culpa" };

            Albums.Add(_album1);
            Albums.Add(_album2);
        }
    }
}