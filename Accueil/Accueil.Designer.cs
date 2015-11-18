namespace Accueil
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.btnDiscussion = new System.Windows.Forms.Button();
            this.btnSong = new System.Windows.Forms.Button();
            this.btnHG = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(162, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(272, 56);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Batiste Mouton";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDiscussion
            // 
            this.btnDiscussion.Location = new System.Drawing.Point(631, 51);
            this.btnDiscussion.Name = "btnDiscussion";
            this.btnDiscussion.Size = new System.Drawing.Size(73, 29);
            this.btnDiscussion.TabIndex = 6;
            this.btnDiscussion.Text = "Discussion";
            this.btnDiscussion.UseVisualStyleBackColor = true;
            this.btnDiscussion.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSong
            // 
            this.btnSong.BackColor = System.Drawing.Color.Transparent;
            this.btnSong.BackgroundImage = global::Accueil.Properties.Resources.songOff;
            this.btnSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSong.ForeColor = System.Drawing.Color.Transparent;
            this.btnSong.Location = new System.Drawing.Point(13, 19);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(48, 51);
            this.btnSong.TabIndex = 9;
            this.btnSong.UseVisualStyleBackColor = false;
            // 
            // btnHG
            // 
            this.btnHG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHG.ForeColor = System.Drawing.Color.Transparent;
            this.btnHG.Image = global::Accueil.Properties.Resources.connectOff;
            this.btnHG.Location = new System.Drawing.Point(323, 89);
            this.btnHG.Name = "btnHG";
            this.btnHG.Size = new System.Drawing.Size(51, 50);
            this.btnHG.TabIndex = 8;
            this.btnHG.UseVisualStyleBackColor = true;
            // 
            // btnAbsence
            // 
            this.btnAbsence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsence.ForeColor = System.Drawing.Color.Transparent;
            this.btnAbsence.Image = global::Accueil.Properties.Resources.connectPause;
            this.btnAbsence.Location = new System.Drawing.Point(248, 89);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(51, 50);
            this.btnAbsence.TabIndex = 7;
            this.btnAbsence.UseVisualStyleBackColor = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.ForeColor = System.Drawing.Color.Transparent;
            this.btnConnexion.Image = global::Accueil.Properties.Resources.connect;
            this.btnConnexion.Location = new System.Drawing.Point(172, 89);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(51, 50);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgAvatar.Image = global::Accueil.Properties.Resources.avatar;
            this.imgAvatar.Location = new System.Drawing.Point(37, 38);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(107, 101);
            this.imgAvatar.TabIndex = 1;
            this.imgAvatar.TabStop = false;
            this.imgAvatar.Click += new System.EventHandler(this.imgAvatar_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnSong);
            this.Controls.Add(this.btnHG);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.btnDiscussion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.imgAvatar);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDiscussion;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Button btnHG;
        private System.Windows.Forms.Button btnSong;
    }
}