using System;
using System.Windows.Forms;
using System.Net.Sockets;
using Npgsql;
using System.Threading;
using System.Data;

namespace Accueil
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            string Conx = "Server=195.154.107.234;Port=5432;Database=hermes;User Id=erwann;Password=lapinou";
            NpgsqlConnection cnx = new NpgsqlConnection(Conx);

            NpgsqlCommand MyCmd = null;
            NpgsqlConnection MyCnx = null;
            DataTable MyData = new DataTable();
            NpgsqlDataAdapter da;
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();

            string select = "SELECT * FROM \"personne\"";
            MyCmd = new NpgsqlCommand(select, MyCnx);
            da = new NpgsqlDataAdapter(MyCmd);
            da.Fill(MyData);
            foreach
            MyCnx.Close();
           
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 1800);
                NetworkStream stream = client.GetStream();
                AuthPaquet ap = new AuthPaquet("erwann", "lapinou");
                Paquet.Send(ap, stream);
                Thread.Sleep(100); 
                
                //On doit mettre un sleep, vu que notre application de termine tout suite apres l'envoi
                //On doit laisser le temps au paquet de se faire envoyer
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de connexion");
            }
        }
    }
}
