namespace AddFindID
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesAgentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unPseudonymeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.françaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anglaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesAgentsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.quitterToolStripMenuItem1});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.TextChanged += new System.EventHandler(this.menuStrip1_TextChanged);
            // 
            // gestionDesAgentsToolStripMenuItem
            // 
            this.gestionDesAgentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unIDToolStripMenuItem,
            this.unPseudonymeToolStripMenuItem,
            this.tagToolStripMenuItem});
            resources.ApplyResources(this.gestionDesAgentsToolStripMenuItem, "gestionDesAgentsToolStripMenuItem");
            this.gestionDesAgentsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.gestionDesAgentsToolStripMenuItem.Name = "gestionDesAgentsToolStripMenuItem";
            this.gestionDesAgentsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesAgentsToolStripMenuItem_Click);
            // 
            // unIDToolStripMenuItem
            // 
            this.unIDToolStripMenuItem.Name = "unIDToolStripMenuItem";
            resources.ApplyResources(this.unIDToolStripMenuItem, "unIDToolStripMenuItem");
            this.unIDToolStripMenuItem.Click += new System.EventHandler(this.unIDToolStripMenuItem_Click);
            // 
            // unPseudonymeToolStripMenuItem
            // 
            this.unPseudonymeToolStripMenuItem.Name = "unPseudonymeToolStripMenuItem";
            resources.ApplyResources(this.unPseudonymeToolStripMenuItem, "unPseudonymeToolStripMenuItem");
            this.unPseudonymeToolStripMenuItem.Click += new System.EventHandler(this.unPseudonymeToolStripMenuItem_Click);
            // 
            // tagToolStripMenuItem
            // 
            this.tagToolStripMenuItem.Name = "tagToolStripMenuItem";
            resources.ApplyResources(this.tagToolStripMenuItem, "tagToolStripMenuItem");
            this.tagToolStripMenuItem.Click += new System.EventHandler(this.tagToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.françaisToolStripMenuItem,
            this.anglaisToolStripMenuItem});
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // françaisToolStripMenuItem
            // 
            resources.ApplyResources(this.françaisToolStripMenuItem, "françaisToolStripMenuItem");
            this.françaisToolStripMenuItem.Name = "françaisToolStripMenuItem";
            this.françaisToolStripMenuItem.Click += new System.EventHandler(this.françaisToolStripMenuItem_Click);
            // 
            // anglaisToolStripMenuItem
            // 
            resources.ApplyResources(this.anglaisToolStripMenuItem, "anglaisToolStripMenuItem");
            this.anglaisToolStripMenuItem.Name = "anglaisToolStripMenuItem";
            this.anglaisToolStripMenuItem.Click += new System.EventHandler(this.anglaisToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            resources.ApplyResources(this.quitterToolStripMenuItem1, "quitterToolStripMenuItem1");
            this.quitterToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(102)))));
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // FormMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesAgentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unPseudonymeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem françaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anglaisToolStripMenuItem;
    }
}