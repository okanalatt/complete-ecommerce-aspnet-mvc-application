using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            var random = new Random();


            context.Actors_Movies.RemoveRange(context.Actors_Movies);
            context.Movies.RemoveRange(context.Movies);
            context.Actors.RemoveRange(context.Actors);
            context.Producers.RemoveRange(context.Producers);
            context.Cinemas.RemoveRange(context.Cinemas);
            context.SaveChanges();

            var cinemas = new List<Cinema>();
            for (int i = 1; i <= 20; i++)
            {
                cinemas.Add(new Cinema
                {
                    Name = $"Cinema {i}",
                    Logo = $"https://example.com/cinema{i}.jpg",
                    Description = $"Description of Cinema {i}"
                });
            }
            context.Cinemas.AddRange(cinemas);
            context.SaveChanges();

            var producers = new List<Producer>();
            for (int i = 1; i <= 20; i++)
            {
                producers.Add(new Producer
                {
                    FullName = $"Producer {i}",
                    Bio = $"Bio of Producer {i}",
                    ProfilePictureURL = $"https://example.com/producer{i}.jpg"
                });
            }
            context.Producers.AddRange(producers);
            context.SaveChanges();

            // 4️⃣ Actors (30 adet)
            var actors = new List<Actor>();
            for (int i = 1; i <= 30; i++)
            {
                actors.Add(new Actor
                {
                    FullName = $"Actor {i}",
                    Bio = $"Bio of Actor {i}",
                    ProfilePictureURL = $"https://example.com/actor{i}.jpg"
                });
            }
            context.Actors.AddRange(actors);
            context.SaveChanges();

            // 5️⃣ Movies (50 adet)
            var movies = new List<Movie>();
            for (int i = 1; i <= 50; i++)
            {
                movies.Add(new Movie
                {
                    Name = $"Movie {i}",
                    Description = $"Description of Movie {i}",
                    Price = random.Next(10, 30),
                    ImageURL = $"https://example.com/movie{i}.jpg",
                    StartDate = DateTime.Now.AddYears(-random.Next(1, 5)),
                    EndDate = DateTime.Now.AddMonths(random.Next(1, 12)),
                    MovieCategory = (MovieCategory)random.Next(1, 5), // 1-4 arası enum örneği
                    CinemaId = cinemas[random.Next(cinemas.Count)].CinemaId,
                    ProducerId = producers[random.Next(producers.Count)].ProducerId
                });
            }
            context.Movies.AddRange(movies);
            context.SaveChanges();

            // 6️⃣ Actor-Movie ilişkileri
            var actorMovies = new List<Actor_Movie>();
            foreach (var movie in movies)
            {
                // Her film için rastgele 2-4 oyuncu ata
                var selectedActors = actors.OrderBy(a => random.Next()).Take(random.Next(2, 5)).ToList();
                foreach (var actor in selectedActors)
                {
                    actorMovies.Add(new Actor_Movie
                    {
                        ActorId = actor.ActorId,
                        MovieId = movie.MovieId
                    });
                }
            }
            context.Actors_Movies.AddRange(actorMovies);
            context.SaveChanges();
        }
    }
}
