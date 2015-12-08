using FtpLib;
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

        public static void UploadFileToFtp(string filePath)
        {

            var fileName = Path.GetFileName(@filePath);
            var request = (FtpWebRequest)WebRequest.Create("ftp://195.154.107.234/var/www/html/image");

            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("hermes", "U3IleJnC3pO");
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;

            using (var fileStream = File.OpenRead(@filePath))
            {
                using (var requestStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(requestStream);
                MessageBox.Show(fileName);
                    requestStream.Close();
                }
            }

            var response = (FtpWebResponse)request.GetResponse();
            Console.WriteLine("Upload done: {0}", response.StatusDescription);
            response.Close();
        }

        public static void ftpFile(string pathFile, string codeName)
        {
            using (FtpConnection ftp = new FtpConnection("195.154.107.234/var/www/html/image", 22, "hermes", "U3IleJnC3pO"))
            {

                ftp.Open(); /* Open the FTP connection */
                ftp.Login(); /* Login using previously provided credentials */

                if (ftp.DirectoryExists("/utilisateur")) /* check that a directory exists */
                    ftp.SetCurrentDirectory("/utilisateur"); /* change current directory */

                if (ftp.FileExists(codeName))  /* check that a file exists */
                    ftp.GetFile(codeName, false); /* download /incoming/file.txt as file.txt to current executing directory, overwrite if it exists */

                //do some processing

                try
                {
                    ftp.PutFile(@pathFile, codeName); /* upload c:\localfile.txt to the current ftp directory as file.txt */
                }
                catch (FtpException e)
                {
                    Console.WriteLine(String.Format("FTP Error: {0} {1}", e.ErrorCode, e.Message));
                }

                /*foreach (var dir in ftp.GetDirectories("/incoming/processed"))
                {
                    Console.WriteLine(dir.Name);
                    Console.WriteLine(dir.CreationTime);
                    foreach (var file in dir.GetFiles())
                    {
                        Console.WriteLine(file.Name);
                        Console.WriteLine(file.LastAccessTime);
                    }
                }*/
            }
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
                MessageBox.Show(fileName);
                string codeName = lblName.Text.Replace(" ", "_");
                UploadFileToFtp(fileName);
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
                MessageBox.Show(fileName);
                UploadFileToFtp(fileName);
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

    }
}
