﻿using System;
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
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMdp.Focus();
            }
        }
    }
}