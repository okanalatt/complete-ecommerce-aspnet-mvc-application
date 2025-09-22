using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll(); //Tum aktorleri getir
        Actor GetById(int id); //Id ye gore aktor getir
        void Add(Actor actor); //Yeni aktor ekle
        Actor Update(int id, Actor newActor); //Id ye gore aktor guncelle
        void Delete(int id); //Id ye gore aktor sil
    }
}
