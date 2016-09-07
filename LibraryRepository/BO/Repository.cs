using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRepository.Interfaces;

namespace LibraryRepository.BO
{
  public class Repository<T> : IRepository<T> where T : class
  {
    private readonly DbContext dbContext;
    private readonly DbSet<T> dbSet;

    public Repository(DbContext dbContext)
    {
      this.dbContext = dbContext;
      this.dbContext.Configuration.LazyLoadingEnabled = false;
      this.dbContext.Configuration.AutoDetectChangesEnabled = false;
      this.dbContext.Configuration.ValidateOnSaveEnabled = false;
      dbSet = dbContext.Set<T>();

    }

    public void Add(T entity)
    {
      dbContext.Entry(entity).State=EntityState.Added;
    }


    public int Commit()
    {
      return dbContext.SaveChanges();
    }

    public void Delete(T entity)
    {
      dbContext.Entry(entity).State=EntityState.Added;
    }

    public void Dispose()
    {
      dbContext.Dispose();
    }

    public T FindById(int id)
    {
      return dbSet.Find(id);
    }

    public IQueryable<T> GetAll()
    {
      return dbSet.AsNoTracking();
    }

    public void Update(T entity)
    {
      dbContext.Entry(entity).State=EntityState.Modified;
    }
  }
}
