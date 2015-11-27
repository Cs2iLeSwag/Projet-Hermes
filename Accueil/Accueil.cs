using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Windows.Forms;

namespace Accueil
{
    public partial class Accueil : Form
    {
        Bitmap songOn = Properties.Resources.songOn;
        Bitmap songOff = Properties.Resources.songOff;

        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Accès à l'écran Discussion
            Discussion discussion = new Discussion();
            discussion.Show();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {

        }

        private void btnSong_Click(object sender, EventArgs e)
        {
            if (btnSong.Image == songOff)
            {
                btnSong.Image = songOn;
            }
            else
            {
                btnSong.Image = songOff;
            }
        }

        private void btnHG_Click(object sender, EventArgs e)
        {

        }

        private void Accueil_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnConnexion_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnConnexion_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnConnexion_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnConnexion_MouseLeave(object sender, EventArgs e)
        {
            btnConnexion.BackColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void btnSong_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

    }
}
