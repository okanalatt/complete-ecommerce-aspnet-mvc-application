using System.ComponentModel.DataAnnotations;

namespace eTickets.Models 
{
    public class Actor //actor entity
    {
        [Key] // Primary Key
        public int ActorId { get; set; } // Actor Id Property
        public string ProfilePictureURL { get; set; } // Actor ProfilePictureURL Property   
        public string FullName { get; set; } // Actor FullName Property
        public string Bio { get; set; } // Actor Bio Property

        // Navigation Property
        public List<Actor_Movie> Actor_Movies { get; set; } // List of Movies associated with the Actor
    }
}
