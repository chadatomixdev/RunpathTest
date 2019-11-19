using Runpath.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Runpath.UnitTests
{
    public class PhotosControllerTests
    {
        private readonly IAlbumService _albumService;
        private readonly IPhotoService _photoService;

        public PhotosControllerTests(IAlbumService albumService, IPhotoService photoService)
        {
            _albumService = albumService;
            _photoService = photoService;
        }




    }
}
