//using FtpLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accueil
{
    public partial class Accueil : Form
    {
        static int codeUser;
        Image songOn = Properties.Resources.songOn;
        Image songOff = Properties.Resources.songOff;
        Image connect = Properties.Resources.connect;
        Image connectOff = Properties.Resources.connectOff;
        Image connectPause = Properties.Resources.connectPause;
        private static void UploadFile(string source)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential("hermes", "U3IleJnC3pO");
                client.UploadFile("ftp://195.154.107.234/var/www/html/image" + "/" + new FileInfo("test").Name, "STOR", source);
            }
        }

        /*public void Download(string filename)
        {
            string destination = "c:/"
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://195.154.107.234/var/www/html/image/connect.png");

            request.Method = WebRequestMethods.Ftp.DownloadFile;

            request.Credentials = new NetworkCredential("hermes", "U3IleJnC3pO");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);

            StreamWriter writer = new StreamWriter(destination);

            writer.Write(reader.ReadToEnd());

            writer.Close();

            reader.Close();

            response.Close() ;
        }*/
        public void UploadFile2(string source)
        {
            string filename = Path.GetFileName(source);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://195.154.107.234/var/www/html/image/connect.png");

            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential("hermes", "U3IleJnC3pO");

            StreamReader sourceStream = new StreamReader(source);

            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());

            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();

            requestStream.Write(fileContents, 0, fileContents.Length);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            response.Close();

            requestStream.Close();

            sourceStream.Close();

        }

        public Accueil(int id)
        {
            InitializeComponent();
            Utilisateurs u = new Utilisateurs();
            DataTable d = u.SelectOneUser(id);
            DataTable d2 = u.SelectAllUsers();
            foreach (DataRow row in d.Rows)
            {
               lblName.Text = row["nom"].ToString() + " "   + row["prenom"].ToString();
            if (row["statut"].Equals(1))
            {
                btnConnexion.BackColor = Color.FromArgb(229, 229, 229);

            }
            else if (row["statut"].Equals(2))
            {
                btnAbsence.BackColor = Color.FromArgb(229, 229, 229);
            }
            else {
                btnHG.BackColor = Color.FromArgb(229, 229, 229);
            }
            if (row["img"].ToString() != null && row["img"].ToString()!="")
            {
            imgAvatar.ImageLocation = row["img"].ToString();
            }
            
            imgAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            btnImgChange.Visible = false;
            codeUser = id;
            
             foreach (DataRow row in d2.Rows)
             {
                 if (row["statut"].Equals(1))
                 {
                     listBox1.Items.Add(row["nom"] + " " + row["prenom"]);

                 }
                 else if (row["statut"].Equals(2))
                 {
                     listBox1.Items.Add(row["nom"] + " " + row["prenom"]);
                 }
                 else
                 {
                     listBox1.Items.Add(row["nom"] + " " + row["prenom"]);
                 }
                 

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
            Utilisateurs u = new Utilisateurs();
            u.updateSituation(1, codeUser);
            btnConnexion.BackColor = Color.FromArgb(229, 229, 229);
            btnAbsence.BackColor = Color.Empty;
            btnHG.BackColor = Color.Empty;
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
            Utilisateurs u = new Utilisateurs();
            u.updateSituation(3, codeUser);
            btnHG.BackColor = Color.FromArgb(229, 229, 229);
            btnAbsence.BackColor = Color.Empty;
            btnConnexion.BackColor = Color.Empty;

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
            Cursor = Cursors.Default;
        }

        private void btnSong_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void imgAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog(); //création d'une fenetre d'exploration 

            if (f.ShowDialog() == DialogResult.OK)
            {
                string fileName = f.FileName;
                //MessageBox.Show(fileName);
                string codeName = lblName.Text.Replace(" ", "_");
                UploadFile(fileName);
            }
            else
                return;
        }

        private void btnImgChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog(); //création d'une fenetre d'exploration 

            if (f.ShowDialog() == DialogResult.OK)
            {
                string fileName = f.FileName;
                string codeName = lblName.Text.Replace(" ", "_");
                //MessageBox.Show(fileName);
                UploadFile(fileName);
            }
            else
                return;
        }
        private void imgAvatar_MouseEnter(object sender, EventArgs e)
        {
            btnImgChange.Visible = true;
            Cursor = Cursors.Hand;
        }

        private void imgAvatar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btnImgChange.Visible = false;
        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            Utilisateurs u = new Utilisateurs();
            u.updateSituation(2, codeUser);
            btnAbsence.BackColor = Color.FromArgb(229, 229, 229);
            btnHG.BackColor= Color.Empty;
            btnConnexion.BackColor = Color.Empty;
        }

        private void btnAbsence_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnHG_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnHG_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

        }

        private void btnAbsence_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

        }

        private void btnImgChange_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnImgChange_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void imgAvatar_MouseEnter_1(object sender, EventArgs e)
        {
            btnImgChange.Visible = true;
        }

        private void imgAvatar_MouseLeave_1(object sender, EventArgs e)
        {
            btnImgChange.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Accès à l'écran Discussion
            Discussion discussion = new Discussion();
            discussion.Show();
        }

    }
}
