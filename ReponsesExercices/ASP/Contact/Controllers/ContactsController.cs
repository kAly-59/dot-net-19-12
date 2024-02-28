using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            List<ContactViewModel> contactList = new List<ContactViewModel>
        {
            new ContactViewModel { Id = 1, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" },
            new ContactViewModel { Id = 2, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" },
            new ContactViewModel { Id = 3, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" },
            new ContactViewModel { Id = 4, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" },
            new ContactViewModel { Id = 5, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" },
            new ContactViewModel { Id = 6, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" },
        };
            return View(contactList);
        }      

        public IActionResult Details(int Id, string Prenom, string Nom, string Email)
        {
            ViewData["ContactId"] = Id;
            ViewData["ContactPrenom"] = Prenom;
            ViewData["ContactNom"] = Nom;
            ViewData["ContactEmail"] = Email;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
