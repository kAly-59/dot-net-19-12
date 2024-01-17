using Demo02Dao.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02Dao.Dao
{
    internal class MaitreDAO : BaseDAO<Maitre>
    {
        public override List<Maitre> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Maitre? GetOneById(int id)
        {
            request = "SELECT id, nom, prenom FROM maitre WHERE id=@id";

            using SqlConnection connection = DataConnection.GetConnection;

            using SqlCommand command = new SqlCommand(request, connection);

            command.Parameters.AddWithValue("@id", id);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                return new Maitre(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            }

            return null;

        }

        public override Maitre Save(Maitre element)
        {
            throw new NotImplementedException();
        }

        public override Maitre Update(Maitre element)
        {
            throw new NotImplementedException();
        }
    }
}
