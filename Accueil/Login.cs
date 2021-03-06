﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Accueil
{
    public partial class Login : Form
    {

        public static String GetMD5Hash(String TextToHash)
        {
            if ((TextToHash == null) || (TextToHash.Length == 0))
            {
                return String.Empty;
            }
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(TextToHash);
            byte[] result = md5.ComputeHash(textToHash);

            return System.BitConverter.ToString(result);
        }

        public Login()
        {
            InitializeComponent();
            txtId.GotFocus += new EventHandler(this.loginGotFocus);
            txtId.LostFocus += new EventHandler(this.loginLostFocus);
            txtMdp.GotFocus += new EventHandler(this.MdpGotFocus);
            txtMdp.LostFocus += new EventHandler(this.MdpLostFocus);
        }

        private void reset()
        {
            if (txtId.BackColor == Color.FromArgb(255, 255, 255))
            {
            txtId.BackColor = Color.FromArgb(255, 255, 255);
            txtMdp.BackColor = Color.FromArgb(255, 255, 255);
            txtId.ForeColor = System.Drawing.Color.FromArgb(45, 217, 56);
            txtMdp.ForeColor = System.Drawing.Color.FromArgb(45, 217, 56);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilisateurs u = new Utilisateurs();
            string mdp = GetMD5Hash(txtMdp.Text);
            mdp = mdp.Replace("-", "").ToLower();
            DataTable d = u.ConnectOneUser(txtId.Text, mdp);

            //Traitement de connexion avec Active Directory 
            if (d.Rows.Count > 0 && d.Rows.Count < 2)
            {
                //Accès à l'écran accueil
                foreach (DataRow row in d.Rows) // Loop over the rows.
	            {
                   int id = Int32.Parse(row["idUser"].ToString());
                    Accueil accueil = new Accueil(id);
                    accueil.Show();
                    this.Hide();
                    //this.Close(); 
                }
            }
            else
            {
                MessageBox.Show("Erreur de connexion, l'identifiant ou le mot de passe est incorrecte");
                txtId.BackColor = Color.FromArgb(243, 229, 229);
                txtMdp.BackColor = Color.FromArgb(243, 229, 229);
                txtId.ForeColor = System.Drawing.Color.FromArgb(196, 150, 152);
                txtMdp.ForeColor = System.Drawing.Color.FromArgb(196, 150, 152);
                txtId.Text = "   Login";
                txtMdp.UseSystemPasswordChar = false;
                txtMdp.Text = "   Mot de passe";
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
        }


        public void loginLostFocus(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "   Login";
            }
        }

        public void loginGotFocus(object sender, EventArgs e)
        {
            if (txtId.Text == "   Login")
            {
                txtId.Text = "";
            }
        }

        public void MdpLostFocus(object sender, EventArgs e)
        {
            if (txtMdp.Text == "")
            {
                //txtMdp.Text = "   Mot de passe";
            }
        }

        public void MdpGotFocus(object sender, EventArgs e)
        {
            if (txtMdp.Text == "   Mot de passe")
            {
                txtMdp.Text = "";
                txtMdp.UseSystemPasswordChar = true;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMdp_MouseLeave(object sender, EventArgs e)
        {
            txtMdp.UseSystemPasswordChar = true;
            if (txtMdp.Text == "   Mot de passe")
            {
                txtMdp.Text = "";
            }
        }

        private void btnMdp_MouseEnter(object sender, EventArgs e)
        {
            txtMdp.UseSystemPasswordChar = false;
        }

        private void txtId_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void txtMdp_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnMdp_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


     /*   private void button1_Click_1(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
        }*/
    }
}
