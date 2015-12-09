namespace Accueil
{
    partial class Discussion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTxtBoxMessage = new System.Windows.Forms.RichTextBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lstBoxMessage = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lui";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vous";
            // 
            // richTxtBoxMessage
            // 
            this.richTxtBoxMessage.AcceptsTab = true;
            this.richTxtBoxMessage.Location = new System.Drawing.Point(15, 241);
            this.richTxtBoxMessage.Name = "richTxtBoxMessage";
            this.richTxtBoxMessage.Size = new System.Drawing.Size(308, 70);
            this.richTxtBoxMessage.TabIndex = 6;
            this.richTxtBoxMessage.Text = "Entrez votre message ici";
            this.richTxtBoxMessage.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.richTxtBoxMessage_PreviewKeyDown);
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(246, 317);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(77, 20);
            this.btnEnvoyer.TabIndex = 7;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnColor.Location = new System.Drawing.Point(85, 220);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(36, 21);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "$";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lstBoxMessage
            // 
            this.lstBoxMessage.FormattingEnabled = true;
            this.lstBoxMessage.Location = new System.Drawing.Point(15, 17);
            this.lstBoxMessage.Name = "lstBoxMessage";
            this.lstBoxMessage.Size = new System.Drawing.Size(308, 186);
            this.lstBoxMessage.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Discussion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstBoxMessage);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.richTxtBoxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Discussion";
            this.Text = "Discussion";
            this.Load += new System.EventHandler(this.Discussion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTxtBoxMessage;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox lstBoxMessage;
        private System.Windows.Forms.Button button1;
    }
}