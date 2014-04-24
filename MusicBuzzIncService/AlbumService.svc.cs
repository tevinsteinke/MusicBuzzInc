﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MusicDataAccess;

namespace MusicBuzzIncService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlbumService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AlbumService.svc or AlbumService.svc.cs at the Solution Explorer and start debugging.
    public class AlbumService : IAlbumService
    {
        public List<Album> GetAll()
        {
            MusicDataAccess.AlbumDataAccess ad = new AlbumDataAccess();
            return ad.GetAll();
        }
    }
}
