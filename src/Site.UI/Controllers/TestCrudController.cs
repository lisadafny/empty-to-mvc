using Microsoft.AspNetCore.Mvc;
using Site.UI.Data;
using Site.UI.Models;

namespace Site.UI.Controllers
{
    public class TestCrudController : Controller
    {
        private readonly DataDbContext _dataDb;
        public TestCrudController(DataDbContext dataDb) {
            _dataDb = dataDb;
        }
        public IActionResult Index()
        {
            var client = new Client {
            Name = "Lisa",
            Email = "lisa.dafny@notarealemail.com",
            Birthdate= DateTime.Now
            };

            _dataDb.Clients.Add(client);
            _dataDb.SaveChanges();


            return View(client);
        }
    }
}
