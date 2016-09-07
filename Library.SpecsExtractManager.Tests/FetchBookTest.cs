using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.SpecsExtractManager.Contrete;
using Library.SpecsExtractManager.DTO;
using Library.SpecsExtractManager.Interface;
using NUnit.Framework;

namespace Library.SpecsExtractManager.Tests
{
  [TestFixture]
  public class FetchBookTest
  {
    private ISpecsExtractManager<List<Book>, Book> fetchBookForSpecsExtractManager;
    private Book book;


    [SetUp]
    public void Init()
    {
      fetchBookForSpecsExtractManager = new FetchBooks();
      //vehicleVolumeInfo = new VehicleVolumeInfo
      //{
      //  VehProductGroup = "V"
      //};
    }

    [Test]
    public void TestFetchBook()
    {
      var result = fetchBookForSpecsExtractManager.Manage(book);
      Assert.IsTrue(result.Any());
    }

  }
}
