using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer // Producer entity
    {
        [Key] // Primary Key
        public int ProducerId { get; set; } // Producer Id Property


        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; } // Actor ProfilePictureURL Property   


        [Display(Name = "Full Name")]
        public string FullName { get; set; } // Actor FullName Property


        [Display(Name = "Biography")]
        public string Bio { get; set; } // Actor Bio Property


        // Navigation Property

        public List<Movie> Movies { get; set; } // List of Movies associated with the Producer
    }
}
