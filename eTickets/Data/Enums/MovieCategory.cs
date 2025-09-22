using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.Enums
{
    public enum MovieCategory
    {
        [Display(Name = "Action")]
        Action = 1,

        [Display(Name = "Comedy")]
        Comedy,

        [Display(Name = "Drama")]
        Drama,

        [Display(Name = "Documentary")]
        Documentary,

        [Display(Name = "Horror")]
        Horror,

        [Display(Name = "Cartoon")]
        Cartoon
    }
}