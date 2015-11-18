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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDiscussion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHG = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(161, 51);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Accueil.Properties.Resources.songOff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 51);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnHG
            // 
            this.btnHG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHG.ForeColor = System.Drawing.Color.Transparent;
            this.btnHG.Image = global::Accueil.Properties.Resources.connectOff;
            this.btnHG.Location = new System.Drawing.Point(322, 110);
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
            this.btnAbsence.Location = new System.Drawing.Point(247, 110);
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
            this.btnConnexion.Location = new System.Drawing.Point(171, 110);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(51, 50);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 101);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHG);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.btnDiscussion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDiscussion;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Button btnHG;
        private System.Windows.Forms.Button button1;
    }
}