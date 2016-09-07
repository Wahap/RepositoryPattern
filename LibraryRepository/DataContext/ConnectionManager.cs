using System.Configuration;
using LibraryRepository.Interfaces;

namespace LibraryRepository.DataContext
{
  public class ConnectionManager : IConnectionManager
  {
    public string GetLibraryConnectionString()
    {
      //Dont forget to add   System.Configuration  as a References
      var connectionString = ConfigurationManager.ConnectionStrings["SpecsHistoryForPriceLinking"].ConnectionString;
      return connectionString;
    }
  }
}
