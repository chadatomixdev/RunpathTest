using Runpath.Data.Models;
using Runpath.Data.Services;
using Runpath.Shared.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Runpath.Shared.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly RepositoryService _contextService;

        public PhotoService(RepositoryService contextService)
        {
            _contextService = contextService;
        }

        public List<Photo> GetPhotosByAlbumID(int albumID)
        {
            return _contextService.Find<Photo>(p => p.AlbumID == albumID).ToList();
        }
    }
}