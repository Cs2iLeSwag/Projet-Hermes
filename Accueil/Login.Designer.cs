namespace Accueil
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnexion = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(168, 272);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(113, 28);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtId.Location = new System.Drawing.Point(143, 136);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 20);
            this.txtId.TabIndex = 6;
            this.txtId.Text = "Login";
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // txtMdp
            // 
            this.txtMdp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMdp.Location = new System.Drawing.Point(143, 186);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(161, 20);
            this.txtMdp.TabIndex = 7;
            this.txtMdp.Text = "Mot de passe";
            this.txtMdp.Click += new System.EventHandler(this.txtMdp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(427, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnConnexion);
            this.Name = "Login";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button button1;
    }
}

