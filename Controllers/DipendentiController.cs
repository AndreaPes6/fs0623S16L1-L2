using Microsoft.AspNetCore.Mvc;
using MuratoriFortissimi.Models;

namespace MuratoriFortissimi.Controllers
{
    public class DipendentiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string nome, string cognome, string indirizzo, string codiceFiscale, bool statoConiugazione, int numFigli, string mansione)
        {
            var dipendenti = StaticDB.Add(nome, cognome, indirizzo, codiceFiscale, statoConiugazione, numFigli, mansione);

            return RedirectToAction("VisualizzaDipendenti", new { Id = dipendenti.IdDipendenti });
        }

        public IActionResult VisualizzaDipendenti()
        {
            return View(StaticDB.GetAll());
        }
    }
}
