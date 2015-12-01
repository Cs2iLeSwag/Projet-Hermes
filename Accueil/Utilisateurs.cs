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

            public DataTable SelectOneUser(int pidUser)
            {
                DataTable MyData = new DataTable();
                NpgsqlDataAdapter da;
                MyCnx = new NpgsqlConnection(Conx);
                MyCnx.Open();
                string select = "SELECT * FROM \"U_USER\" WHERE \"idUser\"=:pidUser";
                MyCmd = new NpgsqlCommand(select, MyCnx);
                MyCmd.Parameters.Add(new NpgsqlParameter("pidUser", NpgsqlDbType.Integer)).Value = pidUser;
                da = new NpgsqlDataAdapter(MyCmd);
                da.Fill(MyData);
                MyCnx.Close();
                return MyData;
            }

            public DataTable ConnectOneUser(string login, string mdp)
            {
                DataTable MyData = new DataTable();
                NpgsqlDataAdapter da;
                MyCnx = new NpgsqlConnection(Conx);
                MyCnx.Open();
                string select = "SELECT * FROM \"U_USER\" WHERE \"login\"=:login AND \"mdp\"=:mdp";
                MyCmd = new NpgsqlCommand(select, MyCnx);
                MyCmd.Parameters.Add(new NpgsqlParameter("login", NpgsqlDbType.Varchar)).Value = login;
                MyCmd.Parameters.Add(new NpgsqlParameter("mdp", NpgsqlDbType.Varchar)).Value = mdp;
                da = new NpgsqlDataAdapter(MyCmd);
                da.Fill(MyData);
                MyCnx.Close();
                return MyData;
            }
    }
}
