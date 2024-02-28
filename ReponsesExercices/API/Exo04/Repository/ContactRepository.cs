using Exo04.Model;
using Exo04.Repository;
using System.Linq.Expressions;

namespace Exo04.Repositories
{
    public class ContactRepository : IRepository<Contact>
    {
        public ApplicationDbContext Db { get; }

        public ContactRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public Contact? Add(Contact contact)
        {
            var addEntry = _db.Contacts.Add(contact);
            _db.SaveChanges();

            if (addEntry.Entity.Id > 0)
                return addEntry.Entity;
            return null;
        }

        public Contact? Get(int id)
        {
            return _db.Contacts.FirstOrDefault(c => c.Id == id);
        }

        public Contact? Get(Expression<Func<Contact, bool>> predicate)
        {
            return _db.Contacts.FirstOrDefault(predicate);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _db.Contacts;
        }
        public IEnumerable<Contact> GetAll(Expression<Func<Contact, bool>> predicate)
        {
            return _db.Contacts.Where(predicate);
        }

        //Update
        public Contact Update(Contact contact)
        {
            var contactFromDb = Get(contact.Id);
            if (contactFromDb != null)
                return null;
            if (contactFromDb.FirstName != contact.FirstName)
                (contactFromDb.FirstName = contact.FirstName);
            if (contactFromDb.LastName != contact.LastName)
                (contactFromDb.LastName = contact.LastName);
            if (contactFromDb.DateOfBirth != contact.DateOfBirth)
                (contactFromDb.DateOfBirth = contact.DateOfBirth);
            if (contactFromDb.Gender != contact.Gender)
                (contactFromDb.Gender = contact.Gender);
            if (_db.SaveChanges() == 0)
                return null;
            return contactFromDb;
        }

        //Delete
        public Contact Delete(int id)
        {
            var contactFromDb = Get(id);
            if (contactFromDb == null)
                return false;

            _db.Contact.Remove(contactFromDb);
            return _db.SaveChanges() > 0;
        }

        public Contact? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
