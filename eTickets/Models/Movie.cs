using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie ///movie entity
    {
        [Key] //    Primary Key
        public int MovieId { get; set; } // Movie Id Property
        public string Name { get; set; } // Movie Name Property
        public string Description { get; set; } //  Movie Description Property
        public double Price { get; set; } // Movie Price Property
        public string ImageURL { get; set; } // Movie ImageURL Property
        public DateTime StartDate { get; set; } // Movie StartDate Property
        public DateTime EndDate { get; set; } // Movie EndDate Property
        public MovieCategory MovieCategory { get; set; } // Movie Category Property

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; } // List of Actors associated with the Movie
        //Foreign Key
        public int CinemaId { get; set; } // Foreign Key
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; } // Navigation Property

        //Foreign Key
        public int ProducerId { get; set; } // Foreign Key
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; } // Navigation Property
    }
}
