using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync(); //Tum aktorleri getir
        Task<Actor> GetByIdAsync(int id); //Id ye gore aktor getir
        Task AddAsync(Actor actor); //Yeni aktor ekle
        Task <Actor> UpdateAsync(int id, Actor newActor); //Id ye gore aktor guncelle
        Task DeleteAsync(int id); //Id ye gore aktor sil
    }
}
