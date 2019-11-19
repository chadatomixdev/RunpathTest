﻿using Microsoft.AspNetCore.Mvc;
using Runpath.API.Representer;
using Runpath.Shared.Interfaces;
using System.Collections.Generic;

namespace Runpath.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotosController : ControllerBase
    {
        #region Properties

        private readonly IAlbumService _albumService;
        private readonly IPhotoService _photoService;

        #endregion

        #region Constructor
        
        public PhotosController(IAlbumService albumService, IPhotoService photoService)
        {
            _albumService = albumService;
            _photoService = photoService;
        }

        #endregion

        //TODO The Database in an in memory DB and is built on the fly thus the initial call is slow and needs to be optimised by caching the DB and only recompiling when required.
        /// <summary>
        /// Get transactionb by ID for reconcilliation purposes
        /// </summary>
        /// <param name="transactionID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPhotosByUserId")]
        public ActionResult GetPhotosByUserId(int userID)
        {
            var response = new List<AlbumRepresenter>();

            var albums = _albumService.GetAlbumsByUserId(userID);

            //Get Photos per Album
            foreach (var album in albums)
            {
                var photos = _photoService.GetPhotosByAlbumID(album.AlbumID);

                var albumRepresenter = new AlbumRepresenter
                {
                    Album = album,
                    Photos = photos
                };
                response.Add(albumRepresenter);
            }

            return Ok(response);
        }
    }
}