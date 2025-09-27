using eTickets.Models;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T:class,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllAsync(); //Tum aktorleri getir
        Task<T> GetByIdAsync(int id); //Id ye gore aktor getir
        Task AddAsync(T entity); //Yeni aktor ekle
        Task<T> UpdateAsync(int id, T entity); //Id ye gore aktor guncelle
        Task DeleteAsync(int id); //Id ye gore aktor sil
    }
}
