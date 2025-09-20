using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer // Producer entity
    {
        [Key] // Primary Key
        public int ProducerId { get; set; } // Producer Id Property
        public string ProfilePictureURL { get; set; } // Actor ProfilePictureURL Property   
        public string FullName { get; set; } // Actor FullName Property
        public string Bio { get; set; } // Actor Bio Property
        // Navigation Property
        public List<Movie> Movies { get; set; } // List of Movies associated with the Producer
    }
}
