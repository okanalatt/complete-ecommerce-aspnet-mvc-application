using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema // Cinema entity
    {
        [Key] // Primary Key
        public int CinemaId { get; set; } // Cinema Id Property

        [Display(Name = "Logo")]
        public string Logo { get; set; } // Cinema Logo Property   

        [Display(Name = "Name")]
        public string Name { get; set; } // Cinema Name Property

        [Display(Name = "Description")]
        public string Description { get; set; } // Cinema Description Property

        // Navigation Property
        public List<Movie> Movies { get; set; } // List of Movies associated with the Cinema
    }
}
