using Exo04.Data;
using Exo04.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Exo04.Controllers
{
    [Route("api/contacts")]
    public class ContactsController : ControllerBase
    {
        //private readonly FakeDb _fakeDb;

        //public ContactsController(FakeDb fakeDb)
        //{
        //    _fakeDb = fakeDb;
        //}

        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contact = _context.Contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
                return NotFound(new { Message = "Contact non trouvé" });

            return Ok(new { Message = "Contact trouvé", Contact = contact });
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var contacts = _context.Contacts;
            if (contacts.Any())
                return Ok(contacts);

            return NoContent();
        }

        [HttpPost]
        public IActionResult AddContact([FromBody] Contact contact)
        {
            if (contact == null)
                return BadRequest(new { Message = "Les données du contact sont invalides" });

            _context.Contacts.Add(contact);
            return CreatedAtAction(nameof(Get), new { id = contact.Id }, new { Message = "Contact ajouté", Contact = contact });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, [FromBody] Contact updatedContact)
        {
            var existingContact = _context.Contacts.FirstOrDefault(c => c.Id == id);
            if (existingContact == null)
                return NotFound(new { Message = "Contact non trouvé" });

            existingContact.FirstName = updatedContact.FirstName;
            existingContact.LastName = updatedContact.LastName;
            existingContact.DateOfBirth = updatedContact.DateOfBirth;
            existingContact.Age = updatedContact.Age;
            existingContact.Gender = updatedContact.Gender;
            existingContact.Avatar = updatedContact.Avatar;

            return Ok(new { Message = "Contact mis à jour", Contact = existingContact });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var contactToRemove = _context.Contacts.FirstOrDefault(c => c.Id == id);
            if (contactToRemove == null)
                return NotFound(new { Message = "Contact non trouvé" });

            _context.Contacts.Remove(contactToRemove);
            return Ok(new { Message = "Contact supprimé", Contact = contactToRemove });
        }
    }
}
