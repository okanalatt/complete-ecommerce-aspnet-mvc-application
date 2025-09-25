using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync(); //Tum aktorleri getir
        Task<Actor> GetByIdAsync(int id); //Id ye gore aktor getir
        Task AddAsync(Actor actor); //Yeni aktor ekle
        Actor Update(int id, Actor newActor); //Id ye gore aktor guncelle
        void Delete(int id); //Id ye gore aktor sil
    }
}
