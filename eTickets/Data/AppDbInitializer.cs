using eTickets.Data;
using eTickets.Data.Enums;
using eTickets.Models;

public static class AppDbInitializer
{
    public static void Seed(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
        var random = new Random();

   

        var cinemas = Enumerable.Range(1, 20).Select(i => new Cinema
        {
            Name = $"Cinema {i}",
            Logo = $"https://picsum.photos/seed/cinema{i}/200/300",
            Description = $"Description for Cinema {i}"
        }).ToList();
        context.Cinemas.AddRange(cinemas);
        context.SaveChanges();

        var producers = Enumerable.Range(1, 20).Select(i => new Producer
        {
            FullName = $"Producer {i}",
            Bio = $"Bio for Producer {i}",
            ProfilePictureURL = $"https://picsum.photos/seed/producer{i}/200/300"
        }).ToList();
        context.Producers.AddRange(producers);
        context.SaveChanges();

        var actors = Enumerable.Range(1, 20).Select(i => new Actor
        {
            FullName = $"Actor {i}",
            Bio = $"Bio for Actor {i}",
            ProfilePictureURL = $"https://picsum.photos/seed/actor{i}/200/300"
        }).ToList();
        context.Actors.AddRange(actors);
        context.SaveChanges();


        var movies = Enumerable.Range(1, 20).Select(i => new Movie
        {
            Name = $"Movie {i}",
            Description = $"Description for Movie {i}",
            Price = random.Next(10, 50),
            ImageURL = $"https://picsum.photos/seed/movie{i}/200/300",
            StartDate = DateTime.Now.AddDays(-random.Next(1, 100)),
            EndDate = DateTime.Now.AddDays(random.Next(10, 100)),
            MovieCategory = (MovieCategory)random.Next(1, 5),
            CinemaId = cinemas[random.Next(cinemas.Count)].CinemaId,
            ProducerId = producers[random.Next(producers.Count)].ProducerId
        }).ToList();
        context.Movies.AddRange(movies);
        context.SaveChanges();

        var actorMovies = new List<Actor_Movie>();
        foreach (var movie in movies)
        {
            var selectedActors = actors.OrderBy(x => random.Next()).Take(3).ToList(); // Her film için 3 oyuncu
            foreach (var actor in selectedActors)
            {
                actorMovies.Add(new Actor_Movie
                {
                    MovieId = movie.MovieId,
                    ActorId = actor.ActorId
                });
            }
        }
        context.Actors_Movies.AddRange(actorMovies);
        context.SaveChanges();
    }
}
