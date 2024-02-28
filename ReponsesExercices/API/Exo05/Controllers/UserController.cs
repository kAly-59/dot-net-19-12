using Microsoft.AspNetCore.Mvc;
using Exo05.Model;
using System.Collections.Generic;
using Exo05.Data;

namespace Exo05.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly FakeDb _db;

        public UserController(FakeDb db)
        {
            _db = db;
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            // Logique d'enregistrement de l'utilisateur
            // Ajouter l'utilisateur à la base de données (_db)
            // Retourner une réponse appropriée
        }

        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            // Logique de connexion de l'utilisateur
            // Vérifier les informations d'identification
            // Générer et retourner un jeton JWT si les informations sont correctes
        }

        // Vous pouvez ajouter d'autres méthodes pour la gestion des utilisateurs selon vos besoins
    }
}
