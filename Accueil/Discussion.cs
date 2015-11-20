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
        }
    }
}
