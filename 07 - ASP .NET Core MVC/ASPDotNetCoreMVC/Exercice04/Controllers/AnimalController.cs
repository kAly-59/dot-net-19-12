using Exercice04.Data;
using Exercice04.Models;
using Exercice04.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exercice04.Controllers
{
    public class AnimalController : Controller
    {

        // Propriété FakeAnimalDb
        //private readonly AnimalFakeDb _fakeAnimalDb;
        //private readonly ApplicationDbContext _dbContext;
        //private readonly AnimalRepository _animalRepository;
        private readonly IRepository<Animal> _animalRepository;

        //Constructeur & injection de dépendances !!
        public AnimalController(
            //AnimalFakeDb fakeAnimalDb,
            //ApplicationDbContext dbContext,
            //AnimalRepository animalRepository,
            IRepository<Animal> animalRepository
            )
        {
            //_fakeAnimalDb = fakeAnimalDb;
            //_dbContext = dbContext;
            _animalRepository = animalRepository;
        }

        // Route => /Animal
        public IActionResult Index()
        {
            //return View(_fakeAnimalDb.GetAll());
            //return View(_dbContext.Animals.ToList());
            return View(_animalRepository.GetAll());
        }

        // Route =>  AnimalController/Details/5
        public IActionResult Details(int id)
        {
            //return View(_fakeAnimalDb.GetById(id));
            //return View(_dbContext.Animals.FirstOrDefault(a => a.Id == id));
            return View(_animalRepository.GetById(id));
        }

        // Route => AnimalController/CreateRandom
        public IActionResult CreateRandom()
        {
            Animal? an = new Animal()
            {
                FirstName = RandomString("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 5),
                Age = new Random().Next(40),
                Species = RandomString("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 5).ToLower(),
            };

            //_fakeAnimalDb.Add(an);

            //_dbContext.Animals.Add(an);
            //_dbContext.SaveChanges();

            _animalRepository.Add(an);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult SubmitAnimal(Animal animal)
        {
            _animalRepository.Add(animal);

            return RedirectToAction(nameof(Index));
        }

        // Route => AnimalController/Delete/5
        public IActionResult Delete(int id)
        {
            //_fakeAnimalDb.Delete(id);

            //var an = _dbContext.Animals.FirstOrDefault(a => a.Id == id);
            //if(an == null)
            //    return RedirectToAction(nameof(Index));
            //_dbContext.Animals.Remove(an);
            //_dbContext.SaveChanges();

            _animalRepository.Delete(id);

            return RedirectToAction(nameof(Index));

        }

        [NonAction] // ce n'est plus une action => un méthode classique sans route 
        public static string RandomString(string chars, int length)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
