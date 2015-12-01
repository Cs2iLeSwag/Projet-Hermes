using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Accueil
{
    public partial class Accueil : Form
    {
        Bitmap songOn = Properties.Resources.songOn;
        Bitmap songOff = Properties.Resources.songOff;

        public Accueil()
        {
            InitializeComponent();
            Utilisateurs u = new Utilisateurs();
            DataTable d = u.SelectOneUser(1);
            foreach (DataRow row in d.Rows)
            {
                MessageBox.Show(row["nom"].ToString());
            }

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
            var msg = new Message();
            msg.HWnd = this.Handle;
            msg.Msg = 0x319;              // WM_APPCOMMAND
            msg.WParam = this.Handle;
            this.DefWndProc(ref msg);
            if (btnSong.Image == songOff && msg.LParam.Equals((IntPtr)0x80000))
            {
                btnSong.Image = songOn;

            }
            else
            {
            msg.LParam = (IntPtr)0x80000; // APPCOMMAND_VOLUME_MUTE
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
