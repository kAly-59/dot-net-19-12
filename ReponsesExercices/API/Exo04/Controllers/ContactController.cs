using Exo04.Model;
using Exo04.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Exo04.Controllers
{
    [Route("contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IRepository<Contact> _repository;

        public ContactsController(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        // Get /contacts
        [HttpGet]
        public IActionResult GetAll(string startLastName)
        {
            if (string.IsNullOrEmpty(startLastName))
                return Ok(_repository.GetAll());

            return Ok(_repository.GetAll(c => c.LastName.StartsWith(startLastName.ToLower())));
        }

        // Get /contacts/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Contact contact = _repository.Get(id);

            if (contact == null)
                return NotFound(new { Message = "No Contact" });

            return Ok(new { Message = "Contact found", Contact = contact });
        }

        //POST /contact
        [HttpGet]
        public IActionResult Post([FromBody] Contact contact)
        {
            var contactAdded = _repository.Add(contact);

            if (contactAdded != null)
                return CreatedAtAction(nameof(GetById), new { id = 0}, "Contact Adead !");

            return BadRequest("Something was wrong");
        }
    }
}
