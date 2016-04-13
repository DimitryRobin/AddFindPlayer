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
    public partial class FormMenu : Form
    {
        public MySqlDataAdapter DA1 = new MySqlDataAdapter();
        public MySqlCommandBuilder CB1;
        public DataTable DT1 = new DataTable();

        string indice1 = "Veuillez entrer l'ID du joueur :";
        string indice2 = "ID inconnu";
        string indice3 = "↶ Retour";
        string indice4 = "Modifier ↻";
        string indice90 = "Nombre de pseudo :";

        string indice5 = "Veuillez entrer le Pseudonyme du joueur :";
        string indice6 = "Pseudonyme inconnu";
        string indice7 = "↶ Retour";
        string indice8 = "Modifier ↻";

        string indice9 = "Veuillez séléctionner le Tag de guilde :";
        string indice10 = "Tag inconnu";
        string indice11 = "↶ Retour";
        string indice12 = "Modifier ↻";

        string indice13 = "Ajout/Modification du joueur ID :";
        string indice14 = "Pseudonyme :";
        string indice15 = "Tag :";
        string indice16 = "Ajouté avec succès √";
        string indice17 = "Sans guilde : laisser vide";
        string indice18 = "Ajouter";
        string indice19 = "Accueil ⇒";

        string indice20 = "Manuel d'utilisation";
        string indice21 = "1°) Trouver un joueur par :";
        string indice22 = "- Son Identifiant";
        string indice24 = "- Son Pseudo       - Son Tag";
        string indice25 = "2°) Ajouter un joueur : (Tag) + Pseudo + ID";
        string indice26 = "OU";
        string indice27 = "Modifier un joueur si son dernier pseudo a changé";
        string indice28 = "N'hesitez pas à faire un don si vous avez apprécié";
        string indice40 = "la qualité du travail fournis :";
        string indice300 = "Des chiffres ?";

        string indice29 = "Entrez votre prénom :";
        string indice30 = "Votre adresse mail :";
        string indice31 = "Envoyer";
        string indice32 = "Envoyé avec succès √";
        string indice33 = "Vérifiez votre boîte de récéption.";
        string indice34 = "Accueil ⇒";

        public MenuStrip MyMenu
        {
            get { return menuStrip1; }
        }

        /*public int nb8
        {
            set { nb8 = 0; }
            get { return nb8; }
        }
         */

        public int nb8 = 0;


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

        public FormMenu()
        {
            InitializeComponent();
        }

        private void unIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrouverID FTID = new FormTrouverID(indice1, indice2, indice3, indice4, indice90);
            FTID.MdiParent = this;
            FTID.Show();
            //MyMenu.Enabled = false;
            MyMenu.Items[0].Enabled = false;
            MyMenu.Items[1].Enabled = false;
            MyMenu.Items[2].Enabled = false;
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult lol;

            if (quitterToolStripMenuItem1.Text == "Quitter")
            {
                lol = MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (lol == DialogResult.Yes)
                {
                    // ecrire_xml();
                    ClassMySQL.sedeconnecter();
                    this.Close();
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            else if (quitterToolStripMenuItem1.Text == "Leave")
            {
                lol = MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (lol == DialogResult.Yes)
                {
                    // ecrire_xml();
                    ClassMySQL.sedeconnecter();
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void françaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menu
            toolStripMenuItem1.Text = "Ajouter";
            gestionDesAgentsToolStripMenuItem.Text = "Trouver par ↓";
            toolStripMenuItem2.Text = "Langue ↓";
            quitterToolStripMenuItem1.Text = "Quitter";
            unIDToolStripMenuItem.Text = "Identifiant";
            unPseudonymeToolStripMenuItem.Text = "Pseudonyme";
            tagToolStripMenuItem.Text = "Tag";
            françaisToolStripMenuItem.Text = "Français";
            anglaisToolStripMenuItem.Text = "Anglais";

            //form trouver id
            indice1 = "Veuillez entrer l'ID du joueur :";
            indice2 = "ID inconnu";
            indice3 = "↶ Retour";
            indice4 = "Modifier ↻";
            indice90 = "Nombre de pseudo :";

            //form trouver pseudo
            indice5 = "Veuillez entrer le Pseudonyme du joueur :";
            indice6 = "Pseudonyme inconnu";
            indice7 = "↶ Retour";
            indice8 = "Modifier ↻";

            //form trouver tag
            indice9 = "Veuillez séléctionner le Tag de guilde :";
            indice10 = "Tag inconnu";
            indice11 = "↶ Retour";
            indice12 = "Modifier ↻";

            //form ajouter
            indice13 = "Ajout/Modification du joueur ID :";
            indice14 = "Pseudonyme :";
            indice15 = "Tag :";
            indice16 = "Ajouté avec succès √";
            indice17 = "Sans guilde : laisser vide";
            indice18 = "Ajouter";
            indice19 = "Accueil ⇒";

            //form manuel
            indice20 = "Manuel d'utilisation";
            indice21 = "1°) Trouver un joueur par :";
            indice22 = "- Son Identifiant";
            indice24 = "- Son Pseudo       - Son Tag";
            indice25 = "2°) Ajouter un joueur : (Tag) + Pseudo + ID";
            indice26 = "OU";
            indice27 = "Modifier un joueur si son dernier pseudo a changé";
            indice28 = "N'hesitez pas à faire un don si vous avez apprécié";
            indice40 = "la qualité du travail fournis :";
            indice300 = "Des chiffres ?";

            //form mail
            indice29 = "Entrez votre prénom :";
            indice30 = "Votre adresse mail :";
            indice31 = "Envoyer";
            indice32 = "Envoyé avec succès √";
            indice33 = "Vérifiez votre boîte de récéption.";
            indice34 = "Accueil ⇒";

            FormMenu_Load(sender, e);
        }

        private void anglaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Text = "anglais";

            //menu
            toolStripMenuItem1.Text =  "Add";
            gestionDesAgentsToolStripMenuItem.Text = "Find by ↓";
            toolStripMenuItem2.Text = "Language ↓";
            quitterToolStripMenuItem1.Text = "Leave";
            unIDToolStripMenuItem.Text = "Login";
            unPseudonymeToolStripMenuItem.Text = "Pseudonym";
            tagToolStripMenuItem.Text = "Tag";
            françaisToolStripMenuItem.Text = "French";
            anglaisToolStripMenuItem.Text = "English";

            //form trouver id
            indice1 = "Please enter the Player ID :";
            indice2 = "Unknown ID";
            indice3 = "↶ Return";
            indice4 = "Edit ↻";
            indice90 = "Total Username :";

            //form trouver pseudo
            indice5 = "Please enter the Username of the player :";
            indice6 = "Username unknown";
            indice7 = "↶ Return";
            indice8 = "Edit ↻";

            //form trouver tag
            indice9 = "Please enter the Player Tag :";
            indice10 = "Unknown tag";
            indice11 = "↶ Return";
            indice12 = "Edit ↻";

            //form ajouter
            indice13 = "Add / Change Player ID :";
            indice14 = "Pseudonym :";
            indice15 = "Tag :";
            indice16 = "Added successfully √";
            indice17 = "Without Guild : leave empty";
            indice18 = "Add";
            indice19 = "Home ⇒";

            //form manuel
            indice20 = "User Manual";
            indice21 = "1°) Find a user by:";
            indice22 = "- His Name";
            indice24 = "- His Nickname       - His Tag";
            indice25 = "2°) Add a player (Tag) + Username + ID";
            indice26 = "OR";
            indice27 = "Edit a player if his latest nickname changed to";
            indice28 = "Feel free to donate if you enjoyed";
            indice40 = "the quality of work provided :";
            indice300 = "Numbers ?";

            //form mail
            indice29 = "Enter your first name :";
            indice30 = "Your email address :";
            indice31 = "Send";
            indice32 = "Successfully sent √";
            indice33 = "Check your mailbox.";
            indice34 = "Home ⇒";

            FormMenu_Load(sender, e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region Mot de passe Admin
            string value = "";
            string mdp = "8g78HyETNq2g";
            #endregion

            if (nb8 != 0)
            {
                FormAjout FA = new FormAjout(indice13, indice14, indice15, indice16, indice17, indice18, indice19);
                FA.MdiParent = this;
                FA.Show();
                //MyMenu.Enabled = false;
                MyMenu.Items[0].Enabled = false;
                MyMenu.Items[1].Enabled = false;
                MyMenu.Items[2].Enabled = false;
            }
            else
            {
                if (toolStripMenuItem1.Text == "Ajouter")
                {
                    DialogResult test = InputBox("Vérification", "Entrez le mot de passe :", ref value);

                    if (test == DialogResult.Abort)
                    {
                        FormMail FM = new FormMail(indice29, indice30, indice31, indice32, indice33, indice34);
                        FM.MdiParent = this;
                        FM.Show();
                        //MyMenu.Enabled = false;
                        MyMenu.Items[0].Enabled = false;
                        MyMenu.Items[1].Enabled = false;
                        MyMenu.Items[2].Enabled = false;
                    }
                    else if (test == DialogResult.OK)
                    {
                        if (value == mdp)
                        {
                            FormAjout FA = new FormAjout(indice13, indice14, indice15, indice16, indice17, indice18, indice19);
                            FA.MdiParent = this;
                            FA.Show();
                            //MyMenu.Enabled = false;
                            MyMenu.Items[0].Enabled = false;
                            MyMenu.Items[1].Enabled = false;
                            MyMenu.Items[2].Enabled = false;

                            nb8 = nb8 + 1;

                            MessageBox.Show("Pour les joueurs ayant plusieurs pseudonymes et/ou tag, veuillez les ajouter du plus ancien au plus récent svp, merci.\n\n/!/ Utilisez les bons caractères spéciaux des tags de guilde et joueurs svp. /!/", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Vous n'avez pas la permission d'ajouter ou de modifier un joueur. \r\nSi vous souhaitez acquérir cette permission : \r\n\r\nDemander directement le mot de passe, si vous me connaissez. \r\n\r\nOU\r\n\r\nDemander par mail, je vous enverrai votre mot de passe.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else if (toolStripMenuItem1.Text == "Add")
                {
                    DialogResult test = InputBox2("Checking", "Enter password :", ref value);

                    if (test == DialogResult.Abort)
                    {
                        FormMail FM = new FormMail(indice29, indice30, indice31, indice32, indice33, indice34);
                        FM.MdiParent = this;
                        FM.Show();
                        //MyMenu.Enabled = false;
                        MyMenu.Items[0].Enabled = false;
                        MyMenu.Items[1].Enabled = false;
                        MyMenu.Items[2].Enabled = false;
                    }
                    else if (test == DialogResult.OK)
                    {
                        if (value == mdp)
                        {
                            FormAjout FA = new FormAjout(indice13, indice14, indice15, indice16, indice17, indice18, indice19);
                            FA.MdiParent = this;
                            FA.Show();
                            //MyMenu.Enabled = false;
                            MyMenu.Items[0].Enabled = false;
                            MyMenu.Items[1].Enabled = false;
                            MyMenu.Items[2].Enabled = false;

                            nb8 = nb8 + 1;

                            MessageBox.Show("For players with many pseudonyms and / or tag, please add them from oldest to most recent please, thank you.\n\n/!/ Use the right special characters guild tags and players please. /!/", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void unPseudonymeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrouverPseudo FTP = new FormTrouverPseudo(indice5, indice6, indice7, indice8);
            FTP.MdiParent = this;
            FTP.Show();
            //MyMenu.Enabled = false;
            MyMenu.Items[0].Enabled = false;
            MyMenu.Items[1].Enabled = false;
            MyMenu.Items[2].Enabled = false;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            FormManuelUtilisation FMU = new FormManuelUtilisation(indice20, indice21, indice22, indice24, indice25, indice26, indice27, indice28, indice40, indice300);
            FMU.MdiParent = this;
            FMU.Show();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void tagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrouverTag FTT = new FormTrouverTag(indice9, indice10, indice11, indice12);
            FTT.MdiParent = this;
            FTT.Show();
            //MyMenu.Enabled = false;
            MyMenu.Items[0].Enabled = false;
            MyMenu.Items[1].Enabled = false;
            MyMenu.Items[2].Enabled = false;
        }

        private void gestionDesAgentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
