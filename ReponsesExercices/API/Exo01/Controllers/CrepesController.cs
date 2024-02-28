using Exo01.Data;
using Exo01.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exo01.Controllers
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
        public IActionResult GetById()
        {
            var crepes = _fakeDb.Crepes;
            if (crepes.Any())
                return Ok(crepes); // 200

            //return NotFound(); // 404 
            return NoContent(); // 204
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var crepes = _fakeDb.Crepes.FirstOrDefault(c => c.Id == id);
            if (crepes == null)
                return NotFound(new
                {
                    Message = "Crepe non trouvé"
                });

            return Ok(new
            {
                Message = "Crepe trouvé",
                Crepe = crepes
            });
        }

        [HttpPost]
        //public IActionResult Post([FromForm]Crepe crepe)
        public IActionResult Post([FromBody]Crepe crepe)        
        {
            _fakeDb.Crepes.Add(crepe);
            return CreatedAtAction(nameof(GetById), new { id = crepe.Id }, "Crepe ajouter");
        }
    }
}
