using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace Commun
{
    class CommunicationData
    {
        public IPEndPoint Client { get; private set; }

        public byte[] Data { get; private set; }

        private UdpClient serveur = null;

        public CommunicationData(IPEndPoint client, byte[] data)
            {
                Client = client;
                Data = data;
            }

        private void EcouterReseau()
        {
            //Création d'un Socket qui servira de serveur de manière sécurisée.
            bool erreur = false;
            int attempts = 0;

            //J'essaie 3 fois car je veux éviter un plantage au serveur juste pour une question de millisecondes.
            do
            {
                try
                {
                    serveur = new UdpClient(1800);
                }
                catch
                {
                    erreur = true;
                    attempts++;
                    Thread.Sleep(400);
                }
            } while (erreur && attempts < 4);

            //Si c'est vraiment impossible de se lier, on en informe le serveur et on quitte le thread.
            if (serveur == null)
            {
                Console.WriteLine("Erreur de liaison Client/Serveur");
                return;
            }

            serveur.Client.ReceiveTimeout = 1000;

            //Boucle infinie d'écoute du réseau.
            while (true)
            {
                try
                {
                    IPEndPoint ip = null;
                    byte[] data = serveur.Receive(ref ip);

                    //Préparation des données à l'aide de la classe interne.
                    CommunicationData cd = new CommunicationData(ip, data);
                    //On lance un nouveau thread avec les données en paramètre.
                    new Thread(new ParameterizedThreadStart(TraiterMessage)).Start(cd);
                }
                catch
                {
                }
            }
            //serveur.Close();
        }

        private void TraiterMessage(object messageArgs)
        {
            try
            {
                //On récupère les données entrantes et on les formatte comme il faut.
                CommunicationData data = messageArgs as CommunicationData;
                string message = string.Format("{0}:{1} > {2}", data.Client.Address.ToString(), data.Client.Port, Encoding.Default.GetString(data.Data));

                //On renvoie le message formatté à travers le réseau.
                byte[] donnees = Encoding.Default.GetBytes(message);
                serveur.Send(donnees, donnees.Length);
            }
            catch { }
        }

    }
}
