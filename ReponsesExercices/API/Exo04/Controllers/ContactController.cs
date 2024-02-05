using Exo04.Data;
using Exo04.Model;
using Microsoft.AspNetCore.Mvc;

namespace Exo04.Controllers
{
    [Route("api/controller")]
    public class ContactsController : ControllerBase
    {
        private readonly FakeDb _fakeDb;

        public ContactsController(FakeDb fakeDb)
        {
            _fakeDb = fakeDb;
        }

        [HttpGet]
        public IActionResult GetById()
        {
            var contacts = _fakeDb.Contacts;
            if (contacts.Any())
                return Ok(contacts); // 200

            return NoContent(); // 204
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contacts = _fakeDb.Contacts.FirstOrDefault(c => c.Id == id);
            if (contacts == null)
                return NotFound(new
                {
                    Message = "Contact non trouvé"
                });

            return Ok(new
            {
                Message = "Contact trouvé",
                Contact = contacts
            });
        }

        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            _fakeDb.Contacts.Add(contact);
            return CreatedAtAction(nameof(GetById), new { id = contact.Id }, "Contact ajouter");
        }
    }
}
