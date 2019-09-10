using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMusicStore.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }
        [Display(Name = "Favorite Genre")]
        public string FavoriteGenre { get; set; }
        [Display(Name = "Favorite Song")]
        public string FavoriteSong { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePic { get; set; }
       
    }
}
