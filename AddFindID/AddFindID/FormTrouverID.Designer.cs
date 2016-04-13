namespace AddFindID
{
    partial class FormTrouverID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrouverID));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnretour = new System.Windows.Forms.Button();
            this.boutonmodifier = new System.Windows.Forms.Button();
            this.dataGridViewID = new System.Windows.Forms.DataGridView();
            this.listBoxID = new System.Windows.Forms.ListBox();
            this.labelnbpseudo = new System.Windows.Forms.Label();
            this.nbpseudo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewID)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxID.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.textBoxID.ForeColor = System.Drawing.Color.Black;
            this.textBoxID.Location = new System.Drawing.Point(113, 42);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(134, 22);
            this.textBoxID.TabIndex = 26;
            this.textBoxID.Click += new System.EventHandler(this.textBoxID_Click);
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            this.textBoxID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxID_KeyDown);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.lblid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.lblid.Location = new System.Drawing.Point(37, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(285, 23);
            this.lblid.TabIndex = 27;
            this.lblid.Text = "Veuillez entrer l\'ID du joueur :";
            // 
            // btnretour
            // 
            this.btnretour.BackColor = System.Drawing.Color.Transparent;
            this.btnretour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnretour.BackgroundImage")));
            this.btnretour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnretour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnretour.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnretour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.btnretour.Location = new System.Drawing.Point(3, 244);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(107, 35);
            this.btnretour.TabIndex = 32;
            this.btnretour.Text = "↶ Retour";
            this.btnretour.UseVisualStyleBackColor = false;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // boutonmodifier
            // 
            this.boutonmodifier.BackColor = System.Drawing.Color.Transparent;
            this.boutonmodifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonmodifier.BackgroundImage")));
            this.boutonmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boutonmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boutonmodifier.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.boutonmodifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.boutonmodifier.Location = new System.Drawing.Point(277, 244);
            this.boutonmodifier.Name = "boutonmodifier";
            this.boutonmodifier.Size = new System.Drawing.Size(107, 35);
            this.boutonmodifier.TabIndex = 33;
            this.boutonmodifier.Text = "Modifier ↻";
            this.boutonmodifier.UseVisualStyleBackColor = false;
            this.boutonmodifier.Click += new System.EventHandler(this.boutonmodifier_Click);
            // 
            // dataGridViewID
            // 
            this.dataGridViewID.AllowUserToAddRows = false;
            this.dataGridViewID.AllowUserToDeleteRows = false;
            this.dataGridViewID.AllowUserToResizeColumns = false;
            this.dataGridViewID.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewID.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewID.GridColor = System.Drawing.Color.Black;
            this.dataGridViewID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewID.Location = new System.Drawing.Point(3, 68);
            this.dataGridViewID.Name = "dataGridViewID";
            this.dataGridViewID.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewID.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewID.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewID.Size = new System.Drawing.Size(381, 180);
            this.dataGridViewID.TabIndex = 34;
            this.dataGridViewID.Visible = false;
            // 
            // listBoxID
            // 
            this.listBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxID.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.listBoxID.ForeColor = System.Drawing.Color.Black;
            this.listBoxID.FormattingEnabled = true;
            this.listBoxID.ItemHeight = 22;
            this.listBoxID.Location = new System.Drawing.Point(113, 79);
            this.listBoxID.Name = "listBoxID";
            this.listBoxID.Size = new System.Drawing.Size(134, 26);
            this.listBoxID.TabIndex = 35;
            this.listBoxID.Visible = false;
            // 
            // labelnbpseudo
            // 
            this.labelnbpseudo.AutoSize = true;
            this.labelnbpseudo.BackColor = System.Drawing.Color.Transparent;
            this.labelnbpseudo.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.labelnbpseudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.labelnbpseudo.Location = new System.Drawing.Point(109, 256);
            this.labelnbpseudo.Name = "labelnbpseudo";
            this.labelnbpseudo.Size = new System.Drawing.Size(145, 17);
            this.labelnbpseudo.TabIndex = 36;
            this.labelnbpseudo.Text = "Nombre de pseudo :";
            this.labelnbpseudo.Visible = false;
            // 
            // nbpseudo
            // 
            this.nbpseudo.AutoSize = true;
            this.nbpseudo.BackColor = System.Drawing.Color.Transparent;
            this.nbpseudo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.nbpseudo.ForeColor = System.Drawing.Color.Red;
            this.nbpseudo.Location = new System.Drawing.Point(255, 256);
            this.nbpseudo.Name = "nbpseudo";
            this.nbpseudo.Size = new System.Drawing.Size(0, 19);
            this.nbpseudo.TabIndex = 37;
            // 
            // FormTrouverID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(386, 282);
            this.ControlBox = false;
            this.Controls.Add(this.nbpseudo);
            this.Controls.Add(this.labelnbpseudo);
            this.Controls.Add(this.listBoxID);
            this.Controls.Add(this.dataGridViewID);
            this.Controls.Add(this.boutonmodifier);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.textBoxID);
            this.Name = "FormTrouverID";
            this.Text = "Trouver grâce à l\'ID";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTrouverID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.Button boutonmodifier;
        private System.Windows.Forms.DataGridView dataGridViewID;
        private System.Windows.Forms.ListBox listBoxID;
        private System.Windows.Forms.Label labelnbpseudo;
        private System.Windows.Forms.Label nbpseudo;
    }
}