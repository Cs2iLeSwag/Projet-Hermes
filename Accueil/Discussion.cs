using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commun;
using WindowsFormsApplication1;

namespace Accueil
{
    public partial class Discussion : Form
    {
        //Déclaration des objets nécessaires au client.
        private UdpClient _client;

        private bool _continuer;
        private Thread _thEcouteur;

        public Discussion()
        {
            
            InitializeComponent();
            try
            {
                //On crée automatiquement le client qui sera en charge d'envoyer les messages au serveur.
                _client = new UdpClient();
                _client.Connect("192.168.43.64", 2454);

                //Initialisation des objets nécessaires au client. On lance également le thread qui en charge d'écouter.
                _continuer = true;
                _thEcouteur = new Thread(new ThreadStart(ThreadEcouteur));
                _thEcouteur.Start();

            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de connexion");
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            //Ouvre un panel de couleur pour changer la couleur d'écriture
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTxtBoxMessage.ForeColor = colorDialog1.Color;
            }
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            lstBoxMessage.Items.Add("Moi : " + richTxtBoxMessage.Text);
            byte[] data = Encoding.Default.GetBytes(richTxtBoxMessage.Text);
            _client.Send(data, data.Length);
            richTxtBoxMessage.Text = "";
            richTxtBoxMessage.Focus();
        }

        public void ThreadEcouteur()
        {
            //Déclaration du Socket d'écoute.
            UdpClient ecouteur = null;

            //Création sécurisée du Socket.
            try
            {
                ecouteur = new UdpClient(1800);
            }
            catch
            {
                MessageBox.Show("Impossible de se lier au port UDP 1800. Vérifiez vos configurations réseau.");
                return;
            }

            //Définition du Timeout.
            ecouteur.Client.ReceiveTimeout = 1000;

            //Bouclage infini d'écoute de port.
            while (_continuer)
            {
                try
                {
                    IPEndPoint ip = null;
                    byte[] data = ecouteur.Receive(ref ip);
                    lstBoxMessage.Items.Add("Moi : " + richTxtBoxMessage.Text);
                }
                catch
                {
                }
            }

            ecouteur.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter stw = File.CreateText(@"c:\chat.txt");

                foreach (object obj in lstBoxMessage.Items)
                {
                    stw.WriteLine(obj.ToString());
                }
                stw.Close();
                stw.Dispose();
            }
            catch(UnauthorizedAccessException unau)
            {
                MessageBox.Show("Erreur lors de la création du fichier" + unau);
            }
            catch(IOException ioe)
            {
                MessageBox.Show("Erreur lors de la création du fichier" + ioe);
            }
            try
            {
                StreamReader str = File.OpenText(@"c:\chat.txt");
                string ligne = string.Empty;
                while ((ligne = str.ReadLine()) != null)
                {
                    lstBoxMessage.Items.Add(ligne);
                }
            }
            catch(FileNotFoundException filnot)
            {
                MessageBox.Show("Problème de lecture " + filnot);
            }
        }

        private void richTxtBoxMessage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstBoxMessage.Items.Add("Moi : " + richTxtBoxMessage.Text);
                byte[] data = Encoding.Default.GetBytes(richTxtBoxMessage.Text);
                _client.Send(data, data.Length);
                richTxtBoxMessage.Text = "";
                richTxtBoxMessage.Focus();

            }
        }

        private void Discussion_Load(object sender, EventArgs e)
        {

        }
    }
}
