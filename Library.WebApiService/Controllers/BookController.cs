using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Library.SpecsExtractManager.Contrete;
using Library.SpecsExtractManager.DTO;
using Library.SpecsExtractManager.Interface;


namespace Library.WebApiService.Controllers
{

    [RoutePrefix("jato.mmix3.services/Book")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
  //  [BasicAuthorizationFilter]
    public class BookController : ApiController
    {
    private ISpecsExtractManager<List<Book>, Book> fetchBookForSpecsExtractManager; 
      //private ICountryEmailListManager<bool, CountryEmail> saveCountryEmailListManager;
      //private ICountryEmailListManager<string, CountryEmail> sendEmailManager;

      public BookController()
      { }
      // GET: ManageCountryEmails
      public BookController(ISpecsExtractManager<List<Book>, Book >fetchBookForSpecsExtractManager)
      {
        this.fetchBookForSpecsExtractManager = fetchBookForSpecsExtractManager;
      }
      //public ManageCountryEmailController(ICountryEmailListManager<bool, CountryEmail> saveCountryEmailListManager)
      //{
      //  this.saveCountryEmailListManager = saveCountryEmailListManager;
      //}
      //public ManageCountryEmailController(ICountryEmailListManager<string, CountryEmail> sendEmailManager)
      //{
      //  this.sendEmailManager = sendEmailManager;
      //}

      [Route("fetch")]
      [HttpPost]
    public List<Book> Load(Book bk)
      {
        if (fetchBookForSpecsExtractManager == null)
        fetchBookForSpecsExtractManager = new FetchBooks();

        return fetchBookForSpecsExtractManager.Manage(bk);
      }

      //[Route("save")]
      //[HttpPost]
      //public bool Save(CountryEmail cntEmail)
      //{
      //  if (saveCountryEmailListManager == null)
      //    saveCountryEmailListManager = new SaveCountryEmailList();
      //  return saveCountryEmailListManager.Manage("", cntEmail);
      //}


      //[Route("sendemail")]
      //[HttpPost]
      //public string SendEmail(CountryEmail cnt)
      //{
      //  if (sendEmailManager == null)
      //    sendEmailManager = new SendEmail();
      //  return sendEmailManager.Manage(cnt.Sender, cnt);
      //}

    }
  }