using Runpath.Data.Models;
using Runpath.Data.Services;
using Runpath.Shared.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Runpath.Shared.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly RepositoryService _contextService;

        public AlbumService(RepositoryService contextService)
        {
            _contextService = contextService;
        }

        public List<Album> GetAlbumsByUserId(int userID)
        {
            return _contextService.Find<Album>(a => a.UserID == userID).ToList();
        }
    }
}