using Demo01.Data;
using Demo01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrepesController : ControllerBase
    {
        private readonly CrepeFakeDb _fakeDb;

        public CrepesController(CrepeFakeDb fakeDb)
        {
            _fakeDb = fakeDb;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var crepes = _fakeDb.Crepes;

            if (crepes.Any()) // la liste est-elle non vide
                return Ok(crepes); // statuscode 200

            //return NotFound(); // 404 => implique que le fait de ne pas trouver de crêpes soit une erreur
            return NoContent(); // 204 => implique que le fait de ne pas trouver de crêpes soit une réussite
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var crepe = _fakeDb.Crepes.FirstOrDefault(c => c.Id == id);

            if (crepe == null)
                return NotFound(new
                {
                    Message = "Crepe non trouvée !"
                });

            return Ok(new
            {
                Message = "Crepe trouvée !",
                Crepe = crepe
            });
        }

        [HttpPost]
        public IActionResult Post([FromBody]Crepe crepe)
        //public IActionResult Post([FromForm]Crepe crepe) // si formulaire
        {
            _fakeDb.Crepes.Add(crepe);

            //return Ok("Crepe ajoutée");
            return CreatedAtAction(nameof(GetById), new { id = crepe.Id }, "Crepe ajoutée"); // meilleure version à utiliser de préférence
            //return Created($"api/Crepe/{crepe.Id}", "Crepe ajoutée");

            // dans le cas ou l'ajout aura échoué, il convient de retourner un BadRequest() => 400
        }
    }
}
