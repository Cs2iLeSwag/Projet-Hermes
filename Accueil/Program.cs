using System;
using System.Windows.Forms;
using System.Net.Sockets;
using Npgsql;
using System.Threading;
using System.Data;
using WindowsFormsApplication1;
using System.Net;

namespace Accueil
{
    static class Program
    {
      /*  private UdpClient _client;

        private bool _continuer;

        private Thread _thEcouteur;*/
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
           
                
                //On doit mettre un sleep, vu que notre application de termine tout suite apres l'envoi
                //On doit laisser le temps au paquet de se faire envoyer
            /*try
            {
                //On crée automatiquement le client qui sera en charge d'envoyer les messages au serveur.
                _client = new UdpClient();
                _client.Connect("127.0.0.1", 1800);

                //Initialisation des objets nécessaires au client. On lance également le thread qui en charge d'écouter.
                _continuer = true;
                _thEcouteur = new Thread(new ThreadStart(Discussion.ThreadEcouteur));
                _thEcouteur.Start();

                /*UdpClient client = new UdpClient("192.168.1.55", 1800);
                NetworkStream stream = client.GetStream();
                AuthPaquet ap = new AuthPaquet("erwann", "lapinou");
                Paquet.Send(ap, stream);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de connexion");
            }*/
        }

        internal static void DisplayText(string p)
        {
            throw new NotImplementedException();
        }

        public static int IntTotalAllowedConnectionAttempts { get; set; }
    }
}
