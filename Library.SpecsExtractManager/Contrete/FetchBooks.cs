using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.SpecsExtractManager.DTO;
using Library.SpecsExtractManager.Interface;
using LibraryRepository.DataContext;

namespace Library.SpecsExtractManager.Contrete
{
  public class FetchBooks : ISpecsExtractManager<List<Book>, Book>
  {

    //this method generated automatically kapiss :)
    public List<Book> Manage(Book inputValues)
    {
      List<Book> seBooks;
      List<Book> mmBooks;

      using (var dbContext = new LibraryDbContext())
      {
        var stmt =
             " SELECT SUBSTRING(name, 10, CHARINDEX('_', SUBSTRING(name, 10, 1000))-1) AS CountryCode" +
             " FROM sys.tables(NOLOCK)" +
             " WHERE name LIKE 'Specs_SSC%_%_155'" +
             " INTERSECT" +
             " SELECT SUBSTRING(name, 10, CHARINDEX('_', SUBSTRING(name, 10, 1000)) - 1)" +
             " FROM sys.tables(NOLOCK)" +
             " WHERE name LIKE 'Specs_NSC%_%_155'" +
             " ORDER BY 1" +
             "";

        seBooks = dbContext.Database.SqlQuery<Book>(stmt).ToList();
      }
      return seBooks;
    }
  }
}
