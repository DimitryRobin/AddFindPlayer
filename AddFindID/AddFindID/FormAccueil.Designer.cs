namespace AddFindID
{
    partial class FormAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelmaj = new System.Windows.Forms.Label();
            this.labeldatemaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-171, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(453, 37);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 129);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.Transparent;
            this.btnajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnajouter.BackgroundImage")));
            this.btnajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnajouter.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.btnajouter.Location = new System.Drawing.Point(23, 161);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(207, 67);
            this.btnajouter.TabIndex = 31;
            this.btnajouter.Text = "AddFindPlayer";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(6, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "By ♪.·тιгđﺕιмραcт·.♪ЯĞC - Dimy";
            // 
            // labelmaj
            // 
            this.labelmaj.AutoSize = true;
            this.labelmaj.BackColor = System.Drawing.Color.Transparent;
            this.labelmaj.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.labelmaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.labelmaj.Location = new System.Drawing.Point(20, 141);
            this.labelmaj.Name = "labelmaj";
            this.labelmaj.Size = new System.Drawing.Size(46, 19);
            this.labelmaj.TabIndex = 33;
            this.labelmaj.Text = "MAJ :";
            // 
            // labeldatemaj
            // 
            this.labeldatemaj.AutoSize = true;
            this.labeldatemaj.BackColor = System.Drawing.Color.Transparent;
            this.labeldatemaj.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.labeldatemaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.labeldatemaj.Location = new System.Drawing.Point(72, 141);
            this.labeldatemaj.Name = "labeldatemaj";
            this.labeldatemaj.Size = new System.Drawing.Size(0, 19);
            this.labeldatemaj.TabIndex = 34;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(258, 268);
            this.ControlBox = false;
            this.Controls.Add(this.labeldatemaj);
            this.Controls.Add(this.labelmaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAccueil";
            this.Text = "AddFindPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAccueil_FormClosed);
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelmaj;
        private System.Windows.Forms.Label labeldatemaj;


    }
}

