using Demo02Dao.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02Dao.Dao
{
    internal class ChienDao : BaseDao<Chien>
    {
        public override List<Chien> GetAll()
        {
            using SqlConnection connection = DataConnection.GetConnection;
        }

        public override Chien Save(Chien element)
        {
            throw new NotImplementedException();
        }

        public override Chien Update(Chien element)
        {
            throw new NotImplementedException();
        }
    }
}
