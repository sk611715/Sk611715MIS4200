using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sk611715MIS4200.Models
{
    public class Album
    {
        public int albumID { get; set; }
        public string albumName { get; set; }
        public string genre { get; set; }
        public DateTime releaseDate { get; set; }

        //Connect to Artist Album
        public ICollection<ArtistAlbum> ArtistAlbum { get; set; }
    }
}