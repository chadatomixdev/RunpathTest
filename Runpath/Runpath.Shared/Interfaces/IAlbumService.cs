using Runpath.Data.Models;
using System.Collections.Generic;

namespace Runpath.Shared.Interfaces
{
    public interface IAlbumService
    {
        List<Album> GetAlbumsByUserId(int userID);
    }
}