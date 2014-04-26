using MusicDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDataAccess
{
    public class AlbumDataAccess
    {
        public List<Album> GetAll()
        {
            var dataEntity = new MusicBuzzIncEntities();
            return dataEntity.Albums.ToList();
        }

        public void Add(Album newAlbum)
        {
            var dataEntity = new MusicBuzzIncEntities();
            dataEntity.Albums.Add(newAlbum);
            dataEntity.SaveChanges();
        }

        public void Modify(Album oldAlbum)
        {
            var dataEntity = new MusicBuzzIncEntities();

            foreach (Album x in dataEntity.Albums)
            {
                if (x.AlbumId == oldAlbum.AlbumId)
                {
                    x.AlbumName = oldAlbum.AlbumName;
                    x.ArtistName = oldAlbum.ArtistName;
                    x.Label = oldAlbum.Label;
                    x.Genre = oldAlbum.Genre;
                    x.Year = oldAlbum.Year;
                    x.Artwork = oldAlbum.Artwork;
                    dataEntity.SaveChanges();
                    return;
                }
            }
        }

        public void Delete(int ripId)
        {
            Album rip = FindAlbum(ripId);

            var dataEntity = new MusicBuzzIncEntities();
            dataEntity.Albums.Attach(rip);
            foreach (Album x in dataEntity.Albums.ToList())
            {
                if (x.AlbumId == rip.AlbumId)
                {
                    dataEntity.Albums.Remove(rip);
                    dataEntity.SaveChanges();
                    return;
                }
            }
        }

        public Album FindAlbum(int id)
        {
            var dataEntity = new MusicBuzzIncEntities();
            Album found = new Album();
            foreach (Album x in dataEntity.Albums.ToList())
            {
                if (x.AlbumId == id)
                {
                    found = x;
                }
            }
            return found;
        }
    }
}
