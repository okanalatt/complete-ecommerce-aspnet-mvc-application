using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {

            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
            if (result != null)
            {
                _context.Actors.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            return await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            var existingActor = await _context.Actors.FirstOrDefaultAsync(a => a.ActorId == id);
            if (existingActor == null) return null;

            existingActor.FullName = newActor.FullName;
            existingActor.Bio = newActor.Bio;
            existingActor.ProfilePictureURL = newActor.ProfilePictureURL;

            await _context.SaveChangesAsync();
            return existingActor;
        }
    }
}
