using Microsoft.AspNetCore.Mvc;
using Runpath.API.Controllers;
using Runpath.Shared.Interfaces;
using Runpath.Shared.Representers;
using Runpath.UnitTests.Fakes;
using System.Collections.Generic;
using Xunit;

namespace Runpath.UnitTests
{
    public class PhotosControllerTests
    {
        private readonly IAlbumService _albumService;
        private readonly IPhotoService _photoService;
        PhotosController _photoController;

        public PhotosControllerTests()
        {
            _albumService = new AlbumServiceFake();
            _photoService = new PhotoServiceFake();
            _photoController = new PhotosController(_albumService, _photoService);
        }

        [Fact]
        public void GetPhotosByUserIdValidObjectPassedReturnOkObjectResult()
        {
            // Arrange
            var userID = 1;

            // Act
            var createdResponse = _photoController.GetPhotosByUserId(userID);

            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }

        [Fact]
        public void GetPhotosByUserIdValidUserIDPassedReturnsValidObject()
        {
            // Arrange
            var userID = 1;

            // Act
            var okResult = _photoController.GetPhotosByUserId(userID) as OkObjectResult;

            // Assert
            Assert.IsType<List<AlbumRepresenter>>(okResult.Value);
        }

        [Fact]
        public void GetPhotosByUserIdValidUserIDPassedReturnsAllItems()
        {
            // Arrange
            var userID = 1;

            // Act
            var okResult = _photoController.GetPhotosByUserId(userID) as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<AlbumRepresenter>>(okResult.Value);
            Assert.Equal(2, items.Count);
        }

        [Fact]
        public void GetPhotosByUserInvalidUserIDPassedReturnsBadRequest()
        {
            // Arrange
            var userID = 12222;

            // Act
            var badRequestResult = _photoController.GetPhotosByUserId(userID);

            // Assert
            var items = Assert.IsType<BadRequestObjectResult>(badRequestResult);
        }
    }
}
