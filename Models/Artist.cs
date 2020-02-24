using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sk611715MIS4200.Models
{
    public class Artist
    {
        public int artistID { get; set; }

        [Display (Name="Artist Name")]
        [Required(ErrorMessage = "Artist name is required")]
        [StringLength(50)]
        public string artistName { get; set; }

        [Display (Name = "Age")]
        [Required(ErrorMessage = "Artist Age is required")]
        [Range(0,150)]
        public int age { get; set; }

        //connect to ArtistAlbum
        public ICollection<ArtistAlbum> ArtistAlbum { get; set; }
    }
}