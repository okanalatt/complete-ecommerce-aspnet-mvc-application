using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Producer:IEntityBase 
    {

        [Key]
        [Column("ProducerId")]
        public int Id { get; set; } // Producer Id Property


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
