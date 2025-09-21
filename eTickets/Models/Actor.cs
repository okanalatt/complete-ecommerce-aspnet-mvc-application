using System.ComponentModel.DataAnnotations;

namespace eTickets.Models 
{
    public class Actor //actor entity
    {
        [Key] // Primary Key
        public int ActorId { get; set; } // Actor Id Property

        [Display(Name = "Profile Picture")] // Display Name for Profile Picture
        public string ProfilePictureURL { get; set; } // Actor ProfilePictureURL Property   

        [Display(Name = "Full Name")] // Display Name for Full Name
        public string FullName { get; set; } // Actor FullName Property

        [Display(Name = "Biography")] // Display Name for Biography
        public string Bio { get; set; } // Actor Bio Property

        // Navigation Property
        public List<Actor_Movie> Actor_Movies { get; set; } // List of Movies associated with the Actor
    }
}
