using System;
using System.Linq;

namespace LibraryRepository.Interfaces
{
  public interface IRepository<T> :IDisposable
  {
    IQueryable<T> GetAll();
    T FindById(int id);
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    int Commit();
  }
}
