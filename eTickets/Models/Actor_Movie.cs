namespace eTickets.Models
{
    public class Actor_Movie // Join entity for Actor and Movie many-to-many relationship
    {
        //Navigation Properties
        public int ActorId { get; set; } // Foreign Key
        public Actor Actor { get; set; } // Navigation Property
        public int MovieId { get; set; } // Foreign Key
        public Movie Movie { get; set; } // Navigation Property

    }
}
