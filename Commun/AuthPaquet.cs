using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

using Commun;

//Un simple TcpListener gérant plusiquers connexions grâce au thread

namespace Accueil
{
    [Serializable()]
    public class AuthPaquet : Paquet
    {
        public String Id { get; private set; }
        public String MotDePasse { get; private set; }

        public AuthPaquet(String Id, String MotDePasse)
            : base(TypePaquet.Authentification)
        {
            this.Id = Id;
            this.MotDePasse = MotDePasse;
        }
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 1800);
            listener.Start();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                ParameterizedThreadStart ts = new ParameterizedThreadStart(acceptConnection);
                Thread t = new Thread(ts);
                t.Start(client);

            }
        }

        public static void acceptConnection(object obj)
        {
            TcpClient client = (TcpClient)obj;

            NetworkStream stream = client.GetStream();

            Paquet paquet = Paquet.Receive(stream);

            if (paquet is AuthPaquet)
            {
                AuthPaquet ap = (AuthPaquet)paquet;

                Console.WriteLine(ap.Id);
                Console.WriteLine(ap.MotDePasse);
            }
        }
    }
}
