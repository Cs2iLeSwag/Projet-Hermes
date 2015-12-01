using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Linq;
using System.Data;

namespace Accueil
{
    public class Utilisateurs
    {
            string Conx = "Server=195.154.107.234;Port=5432;Database=hermes;User Id=erwann;Password=lapinou";
            NpgsqlCommand MyCmd = null;
            NpgsqlConnection MyCnx = null;

            public DataTable SelectAllUsers()
            {
                DataTable MyData = new DataTable();
                NpgsqlDataAdapter da;
                MyCnx = new NpgsqlConnection(Conx);
                MyCnx.Open();
                string select = "SELECT * FROM \"U_USER\"";
                MyCmd = new NpgsqlCommand(select, MyCnx);
                da = new NpgsqlDataAdapter(MyCmd);
                da.Fill(MyData);
                MyCnx.Close();
                return MyData;
            }

            public DataTable SelectOneUser(string pidUser)
            {
                DataTable MyData = new DataTable();
                NpgsqlDataAdapter da;
                MyCnx = new NpgsqlConnection(Conx);
                MyCnx.Open();
                string select = "SELECT * FROM \"U_USER\" WHERE idUser=:pidUser";
                MyCmd.Parameters.Add(new NpgsqlParameter("pidUser", NpgsqlDbType.Varchar)).Value = pidUser;
                MyCmd = new NpgsqlCommand(select, MyCnx);
                da = new NpgsqlDataAdapter(MyCmd);
                da.Fill(MyData);
                MyCnx.Close();
                return MyData;
            }
    }
}
