using System.Data.Entity;


namespace LibraryRepository.DataContext
{
  public class LibraryDbContext : DbContext
  {
    public LibraryDbContext()
    {
      Database.Connection.ConnectionString = new ConnectionManager().GetLibraryConnectionString();
    }

  }
}
