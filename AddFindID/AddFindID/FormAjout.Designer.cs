namespace AddFindID
{
    partial class FormAjout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjout));
            this.textBoxajoutid = new System.Windows.Forms.TextBox();
            this.lblajoutid = new System.Windows.Forms.Label();
            this.boutonmodifier = new System.Windows.Forms.Button();
            this.labelajoutpseudo = new System.Windows.Forms.Label();
            this.textBoxajoutpseudo = new System.Windows.Forms.TextBox();
            this.labelajouttag = new System.Windows.Forms.Label();
            this.textBoxajouttag = new System.Windows.Forms.TextBox();
            this.labelinfotag = new System.Windows.Forms.Label();
            this.btnajouterjoueur = new System.Windows.Forms.Button();
            this.labelconfirmation = new System.Windows.Forms.Label();
            this.textboxmaj = new System.Windows.Forms.TextBox();
            this.labelerreur = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelinfoerreur1 = new System.Windows.Forms.Label();
            this.labelinfoerreur2 = new System.Windows.Forms.Label();
            this.labelinfoerreur3 = new System.Windows.Forms.Label();
            this.labelinfoerreur4 = new System.Windows.Forms.Label();
            this.richTextBoxerreur = new System.Windows.Forms.RichTextBox();
            this.labelerreur2 = new System.Windows.Forms.Label();
            this.labelerreur3 = new System.Windows.Forms.Label();
            this.buttonenvoyer = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // textBoxajoutid
            // 
            this.textBoxajoutid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxajoutid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxajoutid.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.textBoxajoutid.ForeColor = System.Drawing.Color.Black;
            this.textBoxajoutid.Location = new System.Drawing.Point(111, 62);
            this.textBoxajoutid.Name = "textBoxajoutid";
            this.textBoxajoutid.Size = new System.Drawing.Size(134, 22);
            this.textBoxajoutid.TabIndex = 36;
            this.textBoxajoutid.TextChanged += new System.EventHandler(this.textBoxajoutid_TextChanged);
            // 
            // lblajoutid
            // 
            this.lblajoutid.AutoSize = true;
            this.lblajoutid.BackColor = System.Drawing.Color.Transparent;
            this.lblajoutid.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblajoutid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.lblajoutid.Location = new System.Drawing.Point(21, 29);
            this.lblajoutid.Name = "lblajoutid";
            this.lblajoutid.Size = new System.Drawing.Size(298, 22);
            this.lblajoutid.TabIndex = 37;
            this.lblajoutid.Text = "Ajout/Modification du joueur ID :";
            // 
            // boutonmodifier
            // 
            this.boutonmodifier.BackColor = System.Drawing.Color.Transparent;
            this.boutonmodifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonmodifier.BackgroundImage")));
            this.boutonmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boutonmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boutonmodifier.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonmodifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.boutonmodifier.Location = new System.Drawing.Point(277, 243);
            this.boutonmodifier.Name = "boutonmodifier";
            this.boutonmodifier.Size = new System.Drawing.Size(107, 35);
            this.boutonmodifier.TabIndex = 39;
            this.boutonmodifier.Text = "Accueil ⇒";
            this.boutonmodifier.UseVisualStyleBackColor = false;
            this.boutonmodifier.Click += new System.EventHandler(this.boutonmodifier_Click);
            // 
            // labelajoutpseudo
            // 
            this.labelajoutpseudo.AutoSize = true;
            this.labelajoutpseudo.BackColor = System.Drawing.Color.Transparent;
            this.labelajoutpseudo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelajoutpseudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.labelajoutpseudo.Location = new System.Drawing.Point(53, 102);
            this.labelajoutpseudo.Name = "labelajoutpseudo";
            this.labelajoutpseudo.Size = new System.Drawing.Size(130, 22);
            this.labelajoutpseudo.TabIndex = 41;
            this.labelajoutpseudo.Text = "Pseudonyme :";
            // 
            // textBoxajoutpseudo
            // 
            this.textBoxajoutpseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxajoutpseudo.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.textBoxajoutpseudo.ForeColor = System.Drawing.Color.Black;
            this.textBoxajoutpseudo.Location = new System.Drawing.Point(46, 135);
            this.textBoxajoutpseudo.Name = "textBoxajoutpseudo";
            this.textBoxajoutpseudo.Size = new System.Drawing.Size(155, 22);
            this.textBoxajoutpseudo.TabIndex = 40;
            this.textBoxajoutpseudo.TextChanged += new System.EventHandler(this.textBoxajoutpseudo_TextChanged);
            // 
            // labelajouttag
            // 
            this.labelajouttag.AutoSize = true;
            this.labelajouttag.BackColor = System.Drawing.Color.Transparent;
            this.labelajouttag.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelajouttag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.labelajouttag.Location = new System.Drawing.Point(87, 178);
            this.labelajouttag.Name = "labelajouttag";
            this.labelajouttag.Size = new System.Drawing.Size(50, 22);
            this.labelajouttag.TabIndex = 43;
            this.labelajouttag.Text = "Tag :";
            // 
            // textBoxajouttag
            // 
            this.textBoxajouttag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxajouttag.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.textBoxajouttag.ForeColor = System.Drawing.Color.Black;
            this.textBoxajouttag.Location = new System.Drawing.Point(80, 211);
            this.textBoxajouttag.Name = "textBoxajouttag";
            this.textBoxajouttag.Size = new System.Drawing.Size(75, 22);
            this.textBoxajouttag.TabIndex = 42;
            this.textBoxajouttag.TextChanged += new System.EventHandler(this.textBoxajouttag_TextChanged);
            // 
            // labelinfotag
            // 
            this.labelinfotag.AutoSize = true;
            this.labelinfotag.BackColor = System.Drawing.Color.Transparent;
            this.labelinfotag.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfotag.ForeColor = System.Drawing.Color.Silver;
            this.labelinfotag.Location = new System.Drawing.Point(33, 239);
            this.labelinfotag.Name = "labelinfotag";
            this.labelinfotag.Size = new System.Drawing.Size(141, 14);
            this.labelinfotag.TabIndex = 44;
            this.labelinfotag.Text = "Sans guilde : laisser vide";
            // 
            // btnajouterjoueur
            // 
            this.btnajouterjoueur.BackColor = System.Drawing.Color.Transparent;
            this.btnajouterjoueur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnajouterjoueur.BackgroundImage")));
            this.btnajouterjoueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnajouterjoueur.Enabled = false;
            this.btnajouterjoueur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnajouterjoueur.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterjoueur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.btnajouterjoueur.Location = new System.Drawing.Point(219, 120);
            this.btnajouterjoueur.Name = "btnajouterjoueur";
            this.btnajouterjoueur.Size = new System.Drawing.Size(155, 48);
            this.btnajouterjoueur.TabIndex = 45;
            this.btnajouterjoueur.Text = "Ajouter";
            this.btnajouterjoueur.UseVisualStyleBackColor = false;
            this.btnajouterjoueur.Click += new System.EventHandler(this.btnajouterjoueur_Click);
            // 
            // labelconfirmation
            // 
            this.labelconfirmation.AutoSize = true;
            this.labelconfirmation.BackColor = System.Drawing.Color.Transparent;
            this.labelconfirmation.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconfirmation.ForeColor = System.Drawing.Color.Lime;
            this.labelconfirmation.Location = new System.Drawing.Point(170, 189);
            this.labelconfirmation.Name = "labelconfirmation";
            this.labelconfirmation.Size = new System.Drawing.Size(188, 22);
            this.labelconfirmation.TabIndex = 46;
            this.labelconfirmation.Text = "Ajouté avec succès √";
            this.labelconfirmation.Visible = false;
            // 
            // textboxmaj
            // 
            this.textboxmaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textboxmaj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxmaj.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.textboxmaj.ForeColor = System.Drawing.Color.Black;
            this.textboxmaj.Location = new System.Drawing.Point(231, 92);
            this.textboxmaj.Name = "textboxmaj";
            this.textboxmaj.Size = new System.Drawing.Size(134, 22);
            this.textboxmaj.TabIndex = 47;
            this.textboxmaj.Visible = false;
            // 
            // labelerreur
            // 
            this.labelerreur.AutoSize = true;
            this.labelerreur.BackColor = System.Drawing.Color.Transparent;
            this.labelerreur.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerreur.ForeColor = System.Drawing.Color.Red;
            this.labelerreur.Location = new System.Drawing.Point(12, 9);
            this.labelerreur.Name = "labelerreur";
            this.labelerreur.Size = new System.Drawing.Size(323, 19);
            this.labelerreur.TabIndex = 48;
            this.labelerreur.Text = "En cas d\'erreur dans l\'ajout, cochez la case :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(345, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelinfoerreur1
            // 
            this.labelinfoerreur1.AutoSize = true;
            this.labelinfoerreur1.BackColor = System.Drawing.Color.Transparent;
            this.labelinfoerreur1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfoerreur1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.labelinfoerreur1.Location = new System.Drawing.Point(9, 30);
            this.labelinfoerreur1.Name = "labelinfoerreur1";
            this.labelinfoerreur1.Size = new System.Drawing.Size(289, 22);
            this.labelinfoerreur1.TabIndex = 50;
            this.labelinfoerreur1.Text = "Vous avez fait une erreur dans le";
            this.labelinfoerreur1.Visible = false;
            // 
            // labelinfoerreur2
            // 
            this.labelinfoerreur2.AutoSize = true;
            this.labelinfoerreur2.BackColor = System.Drawing.Color.Transparent;
            this.labelinfoerreur2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfoerreur2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.labelinfoerreur2.Location = new System.Drawing.Point(9, 57);
            this.labelinfoerreur2.Name = "labelinfoerreur2";
            this.labelinfoerreur2.Size = new System.Drawing.Size(249, 22);
            this.labelinfoerreur2.TabIndex = 51;
            this.labelinfoerreur2.Text = "pseudonyme, le tag ou l\'ID ?";
            this.labelinfoerreur2.Visible = false;
            // 
            // labelinfoerreur3
            // 
            this.labelinfoerreur3.AutoSize = true;
            this.labelinfoerreur3.BackColor = System.Drawing.Color.Transparent;
            this.labelinfoerreur3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfoerreur3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.labelinfoerreur3.Location = new System.Drawing.Point(8, 87);
            this.labelinfoerreur3.Name = "labelinfoerreur3";
            this.labelinfoerreur3.Size = new System.Drawing.Size(369, 22);
            this.labelinfoerreur3.TabIndex = 52;
            this.labelinfoerreur3.Text = "Faite-le moi savoir pour que je corrige cet";
            this.labelinfoerreur3.Visible = false;
            // 
            // labelinfoerreur4
            // 
            this.labelinfoerreur4.AutoSize = true;
            this.labelinfoerreur4.BackColor = System.Drawing.Color.Transparent;
            this.labelinfoerreur4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfoerreur4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.labelinfoerreur4.Location = new System.Drawing.Point(8, 117);
            this.labelinfoerreur4.Name = "labelinfoerreur4";
            this.labelinfoerreur4.Size = new System.Drawing.Size(90, 22);
            this.labelinfoerreur4.TabIndex = 53;
            this.labelinfoerreur4.Text = "incident :";
            this.labelinfoerreur4.Visible = false;
            // 
            // richTextBoxerreur
            // 
            this.richTextBoxerreur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBoxerreur.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.richTextBoxerreur.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxerreur.Location = new System.Drawing.Point(14, 150);
            this.richTextBoxerreur.Name = "richTextBoxerreur";
            this.richTextBoxerreur.Size = new System.Drawing.Size(360, 83);
            this.richTextBoxerreur.TabIndex = 54;
            this.richTextBoxerreur.Text = "";
            this.richTextBoxerreur.Visible = false;
            this.richTextBoxerreur.TextChanged += new System.EventHandler(this.richTextBoxerreur_TextChanged);
            // 
            // labelerreur2
            // 
            this.labelerreur2.AutoSize = true;
            this.labelerreur2.BackColor = System.Drawing.Color.Transparent;
            this.labelerreur2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerreur2.ForeColor = System.Drawing.Color.Red;
            this.labelerreur2.Location = new System.Drawing.Point(12, 240);
            this.labelerreur2.Name = "labelerreur2";
            this.labelerreur2.Size = new System.Drawing.Size(258, 19);
            this.labelerreur2.TabIndex = 55;
            this.labelerreur2.Text = "Donnez-moi le plus d\'informations";
            this.labelerreur2.Visible = false;
            // 
            // labelerreur3
            // 
            this.labelerreur3.AutoSize = true;
            this.labelerreur3.BackColor = System.Drawing.Color.Transparent;
            this.labelerreur3.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerreur3.ForeColor = System.Drawing.Color.Red;
            this.labelerreur3.Location = new System.Drawing.Point(12, 257);
            this.labelerreur3.Name = "labelerreur3";
            this.labelerreur3.Size = new System.Drawing.Size(123, 14);
            this.labelerreur3.TabIndex = 56;
            this.labelerreur3.Text = "concernant l\'incident.";
            this.labelerreur3.Visible = false;
            // 
            // buttonenvoyer
            // 
            this.buttonenvoyer.BackColor = System.Drawing.Color.Transparent;
            this.buttonenvoyer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonenvoyer.BackgroundImage")));
            this.buttonenvoyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonenvoyer.Enabled = false;
            this.buttonenvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonenvoyer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonenvoyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.buttonenvoyer.Location = new System.Drawing.Point(277, 243);
            this.buttonenvoyer.Name = "buttonenvoyer";
            this.buttonenvoyer.Size = new System.Drawing.Size(107, 35);
            this.buttonenvoyer.TabIndex = 57;
            this.buttonenvoyer.Text = "Envoyer ⇒";
            this.buttonenvoyer.UseVisualStyleBackColor = false;
            this.buttonenvoyer.Visible = false;
            this.buttonenvoyer.Click += new System.EventHandler(this.buttonenvoyer_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 247);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(255, 23);
            this.progressBar1.TabIndex = 58;
            this.progressBar1.Visible = false;
            // 
            // FormAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(386, 282);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonenvoyer);
            this.Controls.Add(this.labelerreur3);
            this.Controls.Add(this.labelerreur2);
            this.Controls.Add(this.richTextBoxerreur);
            this.Controls.Add(this.labelinfoerreur4);
            this.Controls.Add(this.labelinfoerreur3);
            this.Controls.Add(this.labelinfoerreur2);
            this.Controls.Add(this.labelinfoerreur1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelerreur);
            this.Controls.Add(this.textboxmaj);
            this.Controls.Add(this.labelconfirmation);
            this.Controls.Add(this.btnajouterjoueur);
            this.Controls.Add(this.labelinfotag);
            this.Controls.Add(this.labelajouttag);
            this.Controls.Add(this.textBoxajouttag);
            this.Controls.Add(this.labelajoutpseudo);
            this.Controls.Add(this.textBoxajoutpseudo);
            this.Controls.Add(this.boutonmodifier);
            this.Controls.Add(this.lblajoutid);
            this.Controls.Add(this.textBoxajoutid);
            this.Name = "FormAjout";
            this.Text = "FormAjout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAjout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxajoutid;
        private System.Windows.Forms.Label lblajoutid;
        private System.Windows.Forms.Button boutonmodifier;
        private System.Windows.Forms.Label labelajoutpseudo;
        private System.Windows.Forms.TextBox textBoxajoutpseudo;
        private System.Windows.Forms.Label labelajouttag;
        private System.Windows.Forms.TextBox textBoxajouttag;
        private System.Windows.Forms.Label labelinfotag;
        private System.Windows.Forms.Button btnajouterjoueur;
        private System.Windows.Forms.Label labelconfirmation;
        private System.Windows.Forms.TextBox textboxmaj;
        private System.Windows.Forms.Label labelerreur;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelinfoerreur1;
        private System.Windows.Forms.Label labelinfoerreur2;
        private System.Windows.Forms.Label labelinfoerreur3;
        private System.Windows.Forms.Label labelinfoerreur4;
        private System.Windows.Forms.RichTextBox richTextBoxerreur;
        private System.Windows.Forms.Label labelerreur2;
        private System.Windows.Forms.Label labelerreur3;
        private System.Windows.Forms.Button buttonenvoyer;
        private System.Windows.Forms.ProgressBar progressBar1;


    }
}