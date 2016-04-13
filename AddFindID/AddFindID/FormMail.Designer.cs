namespace AddFindID
{
    partial class FormMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMail));
            this.lblprenom = new System.Windows.Forms.Label();
            this.labelmail = new System.Windows.Forms.Label();
            this.textBoxprenom = new System.Windows.Forms.TextBox();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.progressBarAgent = new System.Windows.Forms.ProgressBar();
            this.labelconfirmationmail = new System.Windows.Forms.Label();
            this.labelinfomail = new System.Windows.Forms.Label();
            this.boutonmodifier = new System.Windows.Forms.Button();
            this.btnenvoyermail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.BackColor = System.Drawing.Color.Transparent;
            this.lblprenom.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.lblprenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.lblprenom.Location = new System.Drawing.Point(90, 17);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(199, 22);
            this.lblprenom.TabIndex = 28;
            this.lblprenom.Text = "Entrez votre prénom :";
            // 
            // labelmail
            // 
            this.labelmail.AutoSize = true;
            this.labelmail.BackColor = System.Drawing.Color.Transparent;
            this.labelmail.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.labelmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.labelmail.Location = new System.Drawing.Point(98, 97);
            this.labelmail.Name = "labelmail";
            this.labelmail.Size = new System.Drawing.Size(182, 22);
            this.labelmail.TabIndex = 29;
            this.labelmail.Text = "Votre adresse mail :";
            // 
            // textBoxprenom
            // 
            this.textBoxprenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxprenom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxprenom.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.textBoxprenom.ForeColor = System.Drawing.Color.Black;
            this.textBoxprenom.Location = new System.Drawing.Point(125, 50);
            this.textBoxprenom.Name = "textBoxprenom";
            this.textBoxprenom.Size = new System.Drawing.Size(134, 22);
            this.textBoxprenom.TabIndex = 30;
            this.textBoxprenom.TextChanged += new System.EventHandler(this.textBoxprenom_TextChanged);
            // 
            // textBoxmail
            // 
            this.textBoxmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxmail.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.textBoxmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxmail.Location = new System.Drawing.Point(95, 130);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(190, 22);
            this.textBoxmail.TabIndex = 31;
            this.textBoxmail.TextChanged += new System.EventHandler(this.textBoxmail_TextChanged);
            // 
            // progressBarAgent
            // 
            this.progressBarAgent.Location = new System.Drawing.Point(60, 198);
            this.progressBarAgent.Name = "progressBarAgent";
            this.progressBarAgent.Size = new System.Drawing.Size(255, 23);
            this.progressBarAgent.TabIndex = 35;
            this.progressBarAgent.Visible = false;
            // 
            // labelconfirmationmail
            // 
            this.labelconfirmationmail.AutoSize = true;
            this.labelconfirmationmail.BackColor = System.Drawing.Color.Transparent;
            this.labelconfirmationmail.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.labelconfirmationmail.ForeColor = System.Drawing.Color.Lime;
            this.labelconfirmationmail.Location = new System.Drawing.Point(86, 168);
            this.labelconfirmationmail.Name = "labelconfirmationmail";
            this.labelconfirmationmail.Size = new System.Drawing.Size(201, 23);
            this.labelconfirmationmail.TabIndex = 47;
            this.labelconfirmationmail.Text = "Envoyé avec succès √";
            this.labelconfirmationmail.Visible = false;
            // 
            // labelinfomail
            // 
            this.labelinfomail.AutoSize = true;
            this.labelinfomail.BackColor = System.Drawing.Color.Transparent;
            this.labelinfomail.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.labelinfomail.ForeColor = System.Drawing.Color.Red;
            this.labelinfomail.Location = new System.Drawing.Point(98, 198);
            this.labelinfomail.Name = "labelinfomail";
            this.labelinfomail.Size = new System.Drawing.Size(211, 16);
            this.labelinfomail.TabIndex = 48;
            this.labelinfomail.Text = "Vérifiez votre boîte de récéption.";
            this.labelinfomail.Visible = false;
            // 
            // boutonmodifier
            // 
            this.boutonmodifier.BackColor = System.Drawing.Color.Transparent;
            this.boutonmodifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonmodifier.BackgroundImage")));
            this.boutonmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boutonmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boutonmodifier.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.boutonmodifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.boutonmodifier.Location = new System.Drawing.Point(280, 246);
            this.boutonmodifier.Name = "boutonmodifier";
            this.boutonmodifier.Size = new System.Drawing.Size(107, 35);
            this.boutonmodifier.TabIndex = 49;
            this.boutonmodifier.Text = "Accueil ⇒";
            this.boutonmodifier.UseVisualStyleBackColor = false;
            this.boutonmodifier.Click += new System.EventHandler(this.boutonmodifier_Click);
            // 
            // btnenvoyermail
            // 
            this.btnenvoyermail.BackColor = System.Drawing.Color.Transparent;
            this.btnenvoyermail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnenvoyermail.BackgroundImage")));
            this.btnenvoyermail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnenvoyermail.Enabled = false;
            this.btnenvoyermail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnenvoyermail.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btnenvoyermail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.btnenvoyermail.Location = new System.Drawing.Point(116, 175);
            this.btnenvoyermail.Name = "btnenvoyermail";
            this.btnenvoyermail.Size = new System.Drawing.Size(155, 48);
            this.btnenvoyermail.TabIndex = 50;
            this.btnenvoyermail.Text = "Envoyer";
            this.btnenvoyermail.UseVisualStyleBackColor = false;
            this.btnenvoyermail.Click += new System.EventHandler(this.btnenvoyermail_Click);
            // 
            // FormMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(386, 282);
            this.ControlBox = false;
            this.Controls.Add(this.btnenvoyermail);
            this.Controls.Add(this.boutonmodifier);
            this.Controls.Add(this.labelinfomail);
            this.Controls.Add(this.labelconfirmationmail);
            this.Controls.Add(this.progressBarAgent);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.textBoxprenom);
            this.Controls.Add(this.labelmail);
            this.Controls.Add(this.lblprenom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMail";
            this.Text = "Recevoir mot de passe par mail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label labelmail;
        private System.Windows.Forms.TextBox textBoxprenom;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.ProgressBar progressBarAgent;
        private System.Windows.Forms.Label labelconfirmationmail;
        private System.Windows.Forms.Label labelinfomail;
        private System.Windows.Forms.Button boutonmodifier;
        private System.Windows.Forms.Button btnenvoyermail;
    }
}