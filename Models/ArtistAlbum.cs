using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sk611715MIS4200.Models
{
    public class ArtistAlbum
    {
        [Key]
        public int artistAlbumID { get; set; }

        //connect ArtistAlbum to Artist using the two commands:
        public int artistID { get; set; }
        public virtual Artist Artist { get; set; }

        //connect ArtistAlbum to Album using the two commands:
        public int albumID { get; set; }
        public virtual Album Album { get; set; }


}
}