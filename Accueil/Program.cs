using System;
using System.Windows.Forms;
using System.Net.Sockets;

using System.Threading;

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
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 1800);
                NetworkStream stream = client.GetStream();
                AuthPaquet ap = new AuthPaquet("erwann", "lapinou");
                Paquet.Send(ap, stream);
                Thread.Sleep(100); //On doit mettre un sleep, vu que notre application de termine tout suite apres l'envoi
                //On doit laisser le temps au paquet de se faire envoyer
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de connexion");
            }
        }
    }
}
