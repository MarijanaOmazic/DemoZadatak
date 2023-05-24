using DemoZadatak.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DemoZadatak.Controllers
{
    public class PersonController : Controller
    {
        private readonly DatabaseContext _context;

        public PersonController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listofPeople = _context.Person.ToList();
            return View(listofPeople);
        }
        public IActionResult Details(int id)
        {
            var person = _context.Person.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("_DetailPersonPartialView", person);
        }
    }
}

