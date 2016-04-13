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
using Joueur;
using MySQL;

namespace AddFindID
{
    public partial class FormTrouverID : Form
    {
        public MySqlDataAdapter DA0 = new MySqlDataAdapter();
        public MySqlDataAdapter DA1 = new MySqlDataAdapter();
        public MySqlDataAdapter DA2 = new MySqlDataAdapter();
        public MySqlCommandBuilder CB1;
        public DataTable DT0 = new DataTable();
        public DataTable DT1 = new DataTable();
        public DataTable DT2 = new DataTable();

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

        public void charger(MySqlDataAdapter DA, DataTable DT, string requete)
        {
            if (!ClassMySQL.connopen) return; // pour vérifier que la BD est bien ouverte
            // exemple proposé à partir d’un select sur une table CATEGORIE,
            // à vous d’adapter la requête à votre BD
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

        public FormTrouverID(string labelText, string listBox, string btnretour, string btnmodifier, string to)
        {
            InitializeComponent();
            this.lblid.Text = labelText;
            // listBoxID.Items.Clear();
            this.listBoxID.Items.Add(listBox);
            this.btnretour.Text = btnretour;
            this.boutonmodifier.Text = btnmodifier;
            this.labelnbpseudo.Text = to;
        }

        public void FormTrouverID_Load(object sender, EventArgs e)
        {
            ClassMySQL.seconnecter();

            if (ClassMySQL.connopen == false)
            {
                if (lblid.Text == "Veuillez entrer l'ID du joueur :")
                {
                    MessageBox.Show("Erreur dans la connexion à la base de donnée.");
                }
                else if (lblid.Text == "Please enter the Player ID :")
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

        private void menuStrip1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            dataGridViewID.Visible = false;
            labelnbpseudo.Visible = false;
            nbpseudo.Visible = false;
            nbpseudo.Text = "";

            if (textBoxID.Text != "")
            {
                try
                {
                    charger(DA0, DT0, "SELECT COUNT(id_player) FROM player WHERE id_player= " + Convert.ToInt32(textBoxID.Text).ToString() + ";");
                    //charger(DA0, DT0, "SELECT COUNT(id_player) FROM player WHERE id_player= " + Convert.ToInt32(textBoxID.Text).ToString() + ";");

                    if (Convert.ToInt32(textBoxID.Text) > (Convert.ToInt32("99999999")))
                    {
                        if (lblid.Text == "Veuillez entrer l'ID du joueur :")
                        {
                            MessageBox.Show("L'identifiant d'un joueur ne peut pas contenir autant de chiffre.");
                        }
                        else if (lblid.Text == "Please enter the Player ID :")
                        {
                            MessageBox.Show("The identifier of a player can not contain as many digits.");
                        }
                        // textBoxID.Text = "1";
                        textBoxID.Clear();
                        listBoxID.Visible = false;
                        dataGridViewID.Visible = false;
                        labelnbpseudo.Visible = false;
                    }

                    if (DT0.Rows[0][0].ToString() != "0")
                    {
                        listBoxID.Visible = false;

                        charger(DA1, DT1, "select DISTINCT tag_player as 'Tag', pseudo_player as 'Pseudonyme', id_player as 'ID' from player WHERE id_player= " + Convert.ToInt32(textBoxID.Text).ToString() + " group by id DESC;");
                        //charger(DA1, DT1, "select nom_tag as 'Tag', nom_pseudo as 'Pseudonyme', p.id_player as 'Identifiant' from player as p inner join tag as t on p.id_player = t.id_player inner join pseudo as ps on t.id_player = ps.id_player WHERE p.id_player= " + Convert.ToInt32(textBoxID.Text).ToString() + " order by p.id_player;");

                        dataGridViewID.Visible = true;
                        labelnbpseudo.Visible = true;
                        nbpseudo.Visible = true;

                        dataGridViewID.DataSource = DT1;

                        DataGridViewColumn column = dataGridViewID.Columns[0];
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                        DataGridViewColumn column2 = dataGridViewID.Columns[1];
                        column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        DataGridViewColumn column3 = dataGridViewID.Columns[2];
                        column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                        charger(DA2, DT2, "SELECT id_player as 'nombre2' FROM player WHERE id_player= " + Convert.ToInt32(textBoxID.Text).ToString() + ";");
                        
                        nbpseudo.Text = DT2.Rows.Count.ToString();
                        dataGridViewID.Visible = true;
                        labelnbpseudo.Visible = true;
                        nbpseudo.Visible = true;

                        if (lblid.Text == "Veuillez entrer l'ID du joueur :")
                        {
                            dataGridViewID.Columns[0].HeaderText = "Tag";
                            dataGridViewID.Columns[1].HeaderText = "Pseudonyme";
                            dataGridViewID.Columns[2].HeaderText = "Identifiant";
                        }
                        else if (lblid.Text == "Please enter the Player ID :")
                        {
                            dataGridViewID.Columns[0].HeaderText = "Tag";
                            dataGridViewID.Columns[1].HeaderText = "Pseudonym";
                            dataGridViewID.Columns[2].HeaderText = "Login";
                        }
                    }
                    // listBoxID.Items.Clear();

                    if (DT0.Rows[0][0].ToString() == "0" && textBoxID.Text != "")
                    {
                        listBoxID.Visible = true;
                        dataGridViewID.Visible = false;
                        labelnbpseudo.Visible = false;
                        nbpseudo.Visible = false;
                        nbpseudo.Text = "";
                        listBoxID.Visible = true;
                        //listBoxID.Items.Add("ID inconnu.");
                    }
                    else
                    {
                        listBoxID.Visible = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Vous devez entrer des chiffres !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBoxID.Clear();
                }
            }
            else
            {
                listBoxID.Visible = false;
            }
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
                if (lblid.Text == "Veuillez entrer l'ID du joueur :")
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
                else if (lblid.Text == "Please enter the Player ID :")
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

        private void textBoxID_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
