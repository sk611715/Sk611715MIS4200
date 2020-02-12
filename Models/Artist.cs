using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sk611715MIS4200.Models
{
    public class Artist
    {
        public int artistID { get; set; }
        public string artistName { get; set; }
        public int age { get; set; }

        //connect to ArtistAlbum
        public ICollection<ArtistAlbum> ArtistAlbum { get; set; }
    }
}