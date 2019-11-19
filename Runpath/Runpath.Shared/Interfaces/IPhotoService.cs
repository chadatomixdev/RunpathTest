using Runpath.Data.Models;
using System.Collections.Generic;

namespace Runpath.Shared.Interfaces
{
    public interface IPhotoService
    {
        List<Photo> GetPhotosByAlbumID(int albumID);
    }
}