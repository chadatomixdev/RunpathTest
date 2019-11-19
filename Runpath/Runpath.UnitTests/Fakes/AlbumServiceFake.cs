using Runpath.Data.Models;
using Runpath.Shared.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Runpath.UnitTests.Fakes
{
    public class AlbumServiceFake : BaseFake, IAlbumService
    {
        public List<Album> GetAlbumsByUserId(int userID)
        {
            return Albums.Where(a => a.UserID == userID).ToList();
        }
    }
}