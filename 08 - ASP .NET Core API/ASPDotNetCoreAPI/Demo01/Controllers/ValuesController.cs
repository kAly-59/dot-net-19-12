﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //[HttpGet("bonjour")] // api/Values/bonjour?nom=guillaume
        //[HttpGet("/bonjour")] // /bonjour?nom=guillaume
        //[HttpGet("[action]")] // api/Values/DitBonjour?nom=guillaume
        //public string DitBonjour([FromQuery] string? nom = null)
        [HttpGet("[action]/{nom?}")] // api/Values/DitBonjour/guillaume
        public string DitBonjour([FromRoute] string? nom = null)
        {
            if (nom == null)
                return "Pas de nom !";

            return "Bonjour " + nom + " !";
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
