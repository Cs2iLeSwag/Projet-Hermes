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
            txtId.GotFocus += new EventHandler(this.loginGotFocus);
            txtId.LostFocus += new EventHandler(this.loginLostFocus);
            txtMdp.GotFocus += new EventHandler(this.MdpGotFocus);
            txtMdp.LostFocus += new EventHandler(this.MdpLostFocus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilisateurs u = new Utilisateurs();
            DataTable d = u.ConnectOneUser(txtId.Text, txtMdp.Text);

            //Traitement de connexion avec Active Directory 
            if (d.Rows.Count > 0)
            {
                //Accès à l'écran accueil
                Accueil accueil = new Accueil();
                accueil.Show();
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
                txtMdp.Text = "   Mot de passe";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtMdp.UseSystemPasswordChar = false;
        }

        private void btnMdp_MouseLeave(object sender, EventArgs e)
        {
            txtMdp.UseSystemPasswordChar = true;
        }

     /*   private void button1_Click_1(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
        }*/
    }
}
