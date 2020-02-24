using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sk611715MIS4200.Models
{
    public class Album
    {
        public int albumID { get; set; }

        [Display(Name = "Album Name")]
        [Required(ErrorMessage = "Album name is required")]
        [StringLength(50)]
        public string albumName { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Genre is required")]
        [StringLength(50)]
        public string genre { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Release Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode = true)]
        public DateTime releaseDate { get; set; }

        //Connect to Artist Album
        public ICollection<ArtistAlbum> ArtistAlbum { get; set; }
    }
}