using Microsoft.AspNetCore.Mvc;
using Exo05.Model;
using System.Collections.Generic;
using Exo05.Data;

namespace Exo05.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly FakeDb _db; // Suppose que FakeDb est une classe qui gère les données en mémoire

        public PizzaController(FakeDb db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Pizza> GetPizzas()
        {
            // Retourner toutes les pizzas de la base de données
        }

        [HttpGet("{id}")]
        public IActionResult GetPizzaById(int id)
        {
            // Retourner une pizza par son ID
        }

        [HttpPost]
        public IActionResult AddPizza(Pizza pizza)
        {
            // Ajouter une nouvelle pizza à la base de données
            // Retourner une réponse appropriée
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePizza(int id, Pizza pizza)
        {
            // Mettre à jour une pizza existante dans la base de données
            // Retourner une réponse appropriée
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePizza(int id)
        {
            // Supprimer une pizza de la base de données
            // Retourner une réponse appropriée
        }

        // Vous pouvez ajouter des méthodes similaires pour la gestion des ingrédients
    }
}
