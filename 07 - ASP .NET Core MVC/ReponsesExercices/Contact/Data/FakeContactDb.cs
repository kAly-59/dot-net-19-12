using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class FakeContactDb
    {
        private List<ContactViewModel> _contacts;
        private int _lastId = 0;

        public FakeContactDb()
        {
            _contacts = new List<ContactViewModel>();
            {
                new ContactViewModel { Id = ++_lastId, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" };
                new ContactViewModel { Id = ++_lastId, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" };
                new ContactViewModel { Id = ++_lastId, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" };
                new ContactViewModel { Id = ++_lastId, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" };
                new ContactViewModel { Id = ++_lastId, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" };
                new ContactViewModel { Id = ++_lastId, Prenom = "John", Nom = "Doe", Email = "john.doe@example.com" };
            };
        }

        public List<ContactViewModel> GetAll()
        {
            return _contacts;
        }

        public ContactViewModel? GetById(int id)
        {
            return _contacts.FirstOrDefault(c => c.Id == id);
        }

        public bool Add(ContactViewModel contact)
        {
            contact.Id = ++_lastId;
            _contacts.Add(contact);
            return true;
        }

        public bool Edit(ContactViewModel contact)
        {
            var contactFromDb = GetById(contact.Id);

            if (contactFromDb == null)
                return false;

            contactFromDb.Nom = contact.Nom;
            contactFromDb.Prenom = contact.Prenom;
            contactFromDb.Email = contact.Email;

            return true;
        }

        public bool Delete(int id)
        {
            var contact = GetById(id);

            if (contact == null)
                return false;

            _contacts.Remove(contact);

            return true;
        }
    }
}
