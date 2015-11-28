using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accueil
{
    public partial class Discussion : Form
    {
        public Discussion()
        {
            InitializeComponent();
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
            richTxtBoxMessage.Text = "";
            richTxtBoxMessage.Focus();
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
                richTxtBoxMessage.Text = "";
                richTxtBoxMessage.Focus();
            }
        }
    }
}
