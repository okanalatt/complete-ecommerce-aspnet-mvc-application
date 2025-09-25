using System.ComponentModel.DataAnnotations;

namespace eTickets.Models 
{
    public class Actor //actor entity
    {
        [Key] // Primary Key
        public int ActorId { get; set; } // Actor Id Property

        [Display(Name = "Profile Picture")] // Display Name for Profile Picture
        [Required(ErrorMessage ="Profil resmi gerekli")]
        public string ProfilePictureURL { get; set; } // Actor ProfilePictureURL Property   

        [Display(Name = "Full Name")] // Display Name for Full Name
        [Required(ErrorMessage ="Tam isim gerekli")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Ad soyad alani 3 ile 50 karakter arasinda olmalidir.")]
        public string FullName { get; set; } // Actor FullName Property

        [Display(Name = "Biography")] // Display Name for Biography
        [Required(ErrorMessage ="Biyografi gerekli")]
        public string Bio { get; set; } // Actor Bio Property

        // Navigation Property
        public List<Actor_Movie>? Actor_Movies { get; set; } = new List<Actor_Movie>();
    }
}
