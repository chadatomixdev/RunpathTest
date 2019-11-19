using Microsoft.AspNetCore.Mvc;
using Runpath.Shared.Interfaces;

namespace Runpath.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotosController : ControllerBase
    {
        #region Properties

        private readonly IUserService  _userService;
        private readonly IAlbumService _albumService;
        private readonly IPhotoService _photoService;

        #endregion

        public PhotosController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Get transactionb by ID for reconcilliation purposes
        /// </summary>
        /// <param name="transactionID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPhotosByUserId")]
        public ActionResult GetPhotosByUserId(int UserID)
        {


            return Ok();
        }
    }
}