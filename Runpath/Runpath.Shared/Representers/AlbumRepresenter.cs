﻿using Runpath.Data.Models;
using System.Collections.Generic;

namespace Runpath.Shared.Representers
{
    public class AlbumRepresenter
    {
        public Album Album { get; set; }
        public List<Photo> Photos { get; set; }
    }
}