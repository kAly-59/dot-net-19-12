using System.Collections.Generic;
using System.Linq;
using Marmoset.Models;

namespace Marmoset.Data
{
    public class FakeDb
    {
        private List<MarmosetViewModel> _marmorest;
        public int _lastId = 0;

        public FakeDb()
        {
            _marmorest = new List<MarmosetViewModel>()
            {
                new MarmosetViewModel { Id = ++_lastId, Name = "Bob" },
                new MarmosetViewModel { Id = ++_lastId, Name = "Boby" },
                new MarmosetViewModel { Id = ++_lastId, Name = "Bybou" }
            };
        }

        public List<MarmosetViewModel> GetAll()
        {
            return _marmorest;
        }

        public MarmosetViewModel GetById(int id)
        {
            return _marmorest.FirstOrDefault(c => c.Id == id);
        }

        public bool Add(MarmosetViewModel marmorest)
        {
            marmorest.Id = _lastId;
            _marmorest.Add(marmorest);
            return true;
        }


        public bool Edit(MarmosetViewModel marmorest)
        {
            var marmorestFromDb = GetById(marmorest.Id);
            if (marmorestFromDb == null)
                return false;
            marmorestFromDb.Name = marmorest.Name;
            return true;
        }

        public bool Delete(int id)
        {
            var marmorest = GetById(id);
            if (marmorest == null)
                return false;
            _marmorest.Remove(marmorest);
            return true;
        }

        public static string RandomString(string chars, int length)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
