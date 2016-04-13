using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Joueur;
using MySQL;

namespace AddFindID
{
    public partial class FormTrouverTag : Form
    {
        public MySqlDataAdapter DA0 = new MySqlDataAdapter();
        public MySqlDataAdapter DA1 = new MySqlDataAdapter();
        public MySqlCommandBuilder CB1;
        public DataTable DT0 = new DataTable();
        public DataTable DT1 = new DataTable();

        string indice13;
        string indice14;
        string indice15;
        string indice16;
        string indice17;
        string indice18;
        string indice19;

        string indice29;
        string indice30;
        string indice31;
        string indice32;
        string indice33;
        string indice34;

        int indice800;

        public void charger(MySqlDataAdapter DA, DataTable DT, string requete)
        {
            if (!ClassMySQL.connopen) return; // pour vérifier que la BD est bien ouverte
            
            
            DA.SelectCommand = new MySqlCommand(requete, ClassMySQL.myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(DA);

            try
            {
                DT.Clear();
                DA.Fill(DT);
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataset : " + err, "PBS table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClassMySQL.errgrave = true;
            }
        }

        public FormTrouverTag(string labelText3, string listBox3, string btnretour3, string btnmodifier3)
        {
            InitializeComponent();
            this.lbltag.Text = labelText3;
            // listBoxID.Items.Clear();
            this.btnretour.Text = btnretour3;
            this.boutonmodifier.Text = btnmodifier3;
        }

        private void FormTrouverTag_Load(object sender, EventArgs e)
        {
            ClassMySQL.seconnecter();

            if (ClassMySQL.connopen == false)
            {
                if (lbltag.Text == "Veuillez entrer le Tag du joueur :")
                {
                    MessageBox.Show("Erreur dans la connexion à la base de donnée.");
                }
                else if (lbltag.Text == "Please enter the Player Tag :")
                {
                    MessageBox.Show("Error in the connection to the database.");
                }
                this.Close();
            }

            //form ajouter
            if (boutonmodifier.Text == "Modifier ↻")
            {
                indice13 = "Ajout/Modification du joueur ID :";
                indice14 = "Pseudonyme :";
                indice15 = "Tag :";
                indice16 = "Ajouté avec succès √";
                indice17 = "Sans guilde : laisser vide";
                indice18 = "Ajouter";
                indice19 = "Accueil ⇒";

                indice29 = "Entrez votre prénom :";
                indice30 = "Votre adresse mail :";
                indice31 = "Envoyer";
                indice32 = "Envoyé avec succès √";
                indice33 = "Vérifiez votre boîte de récéption.";
                indice34 = "Accueil ⇒";
            }
            else if (boutonmodifier.Text == "Edit ↻")
            {
                indice13 = "Add / Change Player ID :";
                indice14 = "Pseudonym :";
                indice15 = "Tag :";
                indice16 = "Added successfully √";
                indice17 = "Without Guild : leave empty";
                indice18 = "Add";
                indice19 = "Home ⇒";

                indice29 = "Enter your first name :";
                indice30 = "Your email address :";
                indice31 = "Send";
                indice32 = "Successfully sent √";
                indice33 = "Check your mailbox.";
                indice34 = "Home ⇒";
            }





            // test


            dataGridViewTag.Visible = false;

            comboBoxTag.Items.Clear();

            charger(DA0, DT0, "SELECT DISTINCT tag_player FROM player order by tag_player ASC"); // order by tag_player ASC

            for (int i = 0; i < DT0.Rows.Count; i++)
            {
                comboBoxTag.Items.Add(DT0.Rows[i]["tag_player"].ToString());
            }

        }




        private void btnretour_Click(object sender, EventArgs e)
        {
            ClassMySQL.sedeconnecter();
            FormMenu form = (FormMenu)this.MdiParent;
            form.MyMenu.Items[0].Enabled = true;
            form.MyMenu.Items[1].Enabled = true;
            form.MyMenu.Items[2].Enabled = true;
            this.Close();
        }

        private void boutonmodifier_Click(object sender, EventArgs e)
        {
            #region Mot de passe Admin
            string value = "";
            string mdp = "8g78HyETNq2g";
            #endregion

            FormMenu te = (FormMenu)this.MdiParent;

            if (te.nb8 != 0)
            {
                FormAjout FA = new FormAjout(indice13, indice14, indice15, indice16, indice17, indice18, indice19);
                FA.MdiParent = (FormMenu)this.MdiParent;
                FA.Show();
                this.Close();
            }
            else
            {
                if (lbltag.Text == "Veuillez entrer le Tag du joueur :")
                {
                    DialogResult test = InputBox("Vérification", "Entrez le mot de passe :", ref value);

                    if (test == DialogResult.Abort)
                    {
                        FormMail FM = new FormMail(indice29, indice30, indice31, indice32, indice33, indice34);
                        FM.MdiParent = (FormMenu)this.MdiParent;
                        FM.Show();
                        this.Close();
                    }
                    else if (test == DialogResult.OK)
                    {
                        if (value == mdp)
                        {
                            FormAjout FA = new FormAjout(indice13, indice14, indice15, indice16, indice17, indice18, indice19);
                            FA.MdiParent = (FormMenu)this.MdiParent;
                            FA.Show();
                            this.Close();

                            te.nb8 = te.nb8 + 1;

                            MessageBox.Show("Pour les joueurs ayant plusieurs pseudonymes et/ou tag, veuillez les ajouter du plus ancien au plus récent svp, merci.", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Vous n'avez pas la permission d'ajouter ou de modifier un joueur. \r\nSi vous souhaitez acquérir cette permission : \r\n\r\nDemander directement le mot de passe, si vous me connaissez. \r\n\r\nOU\r\n\r\nDemander par mail, je vous enverrai votre mot de passe.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else if (lbltag.Text == "Please enter the Player Tag :")
                {
                    DialogResult test = InputBox2("Checking", "Enter password :", ref value);

                    if (test == DialogResult.Abort)
                    {
                        FormMail FM = new FormMail(indice29, indice30, indice31, indice32, indice33, indice34);
                        FM.MdiParent = (FormMenu)this.MdiParent;
                        FM.Show();
                        this.Close();
                    }
                    else if (test == DialogResult.OK)
                    {
                        if (value == mdp)
                        {
                            FormAjout FA = new FormAjout(indice13, indice14, indice15, indice16, indice17, indice18, indice19);
                            FA.MdiParent = this;
                            FA.Show();

                            te.nb8 = te.nb8 + 1;

                            MessageBox.Show("For players with many pseudonyms and / or tag, please add them from oldest to most recent please, thank you.", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("You do not have permission to add or modify a player. \r\nIf you want to have this permission : \r\n\r\nRequest the password directly, if you know me. \r\n\r\nOR\r\n\r\nRequest by email, I will send you your password.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            Button buttonYes = new Button();
            Button button = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Recevoir par mail";
            buttonYes.Text = "Annuler";

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Abort;
            buttonYes.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(117, 72, 75, 23);
            buttonCancel.SetBounds(198, 72, 105, 23);
            buttonYes.SetBounds(309, 72, 75, 23);
            textBox.PasswordChar = Convert.ToChar("*");

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonYes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel, buttonYes });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.AcceptButton = buttonCancel;
            form.CancelButton = buttonYes;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static DialogResult InputBox2(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            Button buttonYes = new Button();
            Button button = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Receive by mail";
            buttonYes.Text = "Cancel";

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Abort;
            buttonYes.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(117, 72, 75, 23);
            buttonCancel.SetBounds(198, 72, 105, 23);
            buttonYes.SetBounds(309, 72, 75, 23);
            textBox.PasswordChar = Convert.ToChar("*");

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonYes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel, buttonYes });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.AcceptButton = buttonCancel;
            form.CancelButton = buttonYes;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void textBoxTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice800 = comboBoxTag.SelectedIndex;
            //DT0.Rows[indice800]["tag_player"].ToString()

            System.Text.Encoding utf_8 = System.Text.Encoding.UTF8;

            /*
            string s = textBoxTag.Text;
            byte[] utf = System.Text.Encoding.UTF8.GetBytes(s);
            string s2 = System.Text.Encoding.UTF8.GetString(utf);
            */

            charger(DA1, DT1, "select DISTINCT tag_player as 'Tag', pseudo_player as 'Pseudonyme', id_player as 'ID' from player where tag_player='" + DT0.Rows[indice800]["tag_player"].ToString() + "' order by id_player ASC;"); //  

            //charger(DA1, DT1, "select DISTINCT tag_player as 'Tag', pseudo_player as 'Pseudonyme', id_player as 'ID' from player WHERE tag_player= '"+ DT0.Rows[indice800]["tag_player"].ToString() + "' ;"); //  order by id_player ASC
            //charger(DA1, DT1, "select nom_tag as 'Tag', nom_pseudo as 'Pseudonyme', p.id_player as 'Identifiant' from player as p inner join tag as t on p.id_player = t.id_player inner join pseudo as ps on t.id_player = ps.id_player WHERE nom_tag= " + textBoxTag.Text.ToString() + " order by p.id_player;");

            //MessageBox.Show("nb : " + DT0.Rows[indice800]["tag_player"]);
            //MessageBox.Show("nb : " + DT0.Rows[indice800]["tag_player"].ToString());

            dataGridViewTag.DataSource = DT1;

            DataGridViewColumn column = dataGridViewTag.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DataGridViewColumn column2 = dataGridViewTag.Columns[1];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column3 = dataGridViewTag.Columns[2];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dataGridViewTag.Visible = true;

            if (lbltag.Text == "Veuillez séléctionner le Tag de guilde :")
            {
                dataGridViewTag.Columns[0].HeaderText = "Tag";
                dataGridViewTag.Columns[1].HeaderText = "Pseudonyme";
                dataGridViewTag.Columns[2].HeaderText = "Identifiant";
            }
            else
            {
                dataGridViewTag.Columns[0].HeaderText = "Tag";
                dataGridViewTag.Columns[1].HeaderText = "Pseudonym";
                dataGridViewTag.Columns[2].HeaderText = "Login";
            }
        }

        private void comboBoxTag_Click(object sender, EventArgs e)
        {
            dataGridViewTag.Visible = false;
        }
    }
}
