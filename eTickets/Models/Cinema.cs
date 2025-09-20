using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema // Cinema entity
    {
        [Key] // Primary Key
        public int CinemaId { get; set; } // Cinema Id Property
        public string Logo { get; set; } // Cinema Logo Property   
        public string Name { get; set; } // Cinema Name Property
        public string Description { get; set; } // Cinema Description Property

        // Navigation Property
        public List<Movie> Movies { get; set; } // List of Movies associated with the Cinema
    }
}
