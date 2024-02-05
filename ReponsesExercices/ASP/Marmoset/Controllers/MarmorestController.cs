using Marmoset.Data;
using Marmoset.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exo.Controllers
{
    public class MarmorestController : Controller
    {
        private FakeDb _fakeDb;

        public MarmorestController(FakeDb fakeDb)
        {
            _fakeDb = fakeDb;
        }

        public IActionResult Index()
        {
            return View(_fakeDb.GetAll());
        }

        public IActionResult Details(int id)
        {
            MarmosetViewModel marmorest = _fakeDb.GetById(id);

            return View(marmorest);              
        }

        public IActionResult CreateRandom()
        {
            string randomName = FakeDb.RandomString("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 10);
            MarmosetViewModel randomMarmoset = new MarmosetViewModel { Id = ++_fakeDb._lastId, Name = randomName };
            _fakeDb.Add(randomMarmoset);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var success = _fakeDb.Delete(id);

            if (success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, "La suppression a échoué.");
                return View("Index", _fakeDb.GetAll());
            }
        }


    }
}
