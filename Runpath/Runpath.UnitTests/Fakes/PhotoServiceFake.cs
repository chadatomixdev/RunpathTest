using Runpath.Data.Models;
using Runpath.Shared.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Runpath.UnitTests.Fakes
{
    public class PhotoServiceFake : BaseFake, IPhotoService
    {
        public List<Photo> GetPhotosByAlbumID(int albumID)
        {
            return Photos.Where(p => p.AlbumID == albumID).ToList();
        }
    }
}