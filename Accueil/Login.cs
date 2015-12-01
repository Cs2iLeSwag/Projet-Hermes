using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accueil
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Traitement de connexion avec Active Directory 
            if (txtId.Text == "admin" & txtMdp.Text == "admin")
            {
                //Accès à l'écran accueil
                Accueil accueil = new Accueil();
                accueil.Show();
            }
            else
            {
                MessageBox.Show("Erreur de connexion, l'identifiant ou le mot de passe est incorrecte");
                txtId.Text = "";
                txtMdp.Text = "";
                txtId.Focus();
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMdp.UseSystemPasswordChar = true;
                txtMdp.Focus();
            }
        }

        private void txtId_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
        }

        private void txtMdp_Click(object sender, EventArgs e)
        {
            txtMdp.Text = "";
            //Permet de cacher le champ par des "*"
            txtMdp.UseSystemPasswordChar = true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

     /*   private void button1_Click_1(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
        }*/
    }
}
