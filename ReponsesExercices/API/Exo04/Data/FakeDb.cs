using Exo04.Model;
using System;
using System.Collections.Generic;

namespace Exo04.Data
{
    public class FakeDb
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public FakeDb()
        {
            Contacts.Add(new Contact()
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Bob",
                DateOfBirth = new DateTime(1989, 11, 22),
                Age = 34,
                Gender = "Homme",
                Avatar = "0"
            });
        }
    }
}
