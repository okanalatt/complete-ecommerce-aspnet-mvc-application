
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie ///movie entity
    {
        [Key] //    Primary Key
        [Column("MovieId")]
        public int Id { get; set; } // Movie Id Property

        [Display(Name = "Movie Name")]
        public string Name { get; set; } // Movie Name Property

        [Display(Name = "Movie Description")]
        public string Description { get; set; } //  Movie Description Property

        [Display(Name = "Movie Price")]
        public double Price { get; set; } // Movie Price Property

        [Display(Name = "Movie Image")]
        public string ImageURL { get; set; } // Movie ImageURL Property

        [Display(Name = "Movie Start Date")]
        public DateTime StartDate { get; set; } // Movie StartDate Property

        [Display(Name = "Movie End Date")]
        public DateTime EndDate { get; set; } // Movie EndDate Property

        [Display(Name = "Movie Category")]
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
