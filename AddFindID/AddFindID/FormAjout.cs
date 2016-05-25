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
using System.Web;
using System.Net.Mail;

namespace AddFindID
{
    public partial class FormAjout : Form
    {
        public MySqlDataAdapter DA1 = new MySqlDataAdapter();
        public MySqlDataAdapter DA2 = new MySqlDataAdapter();
        public MySqlDataAdapter DA3 = new MySqlDataAdapter();
        public MySqlDataAdapter DA4 = new MySqlDataAdapter();
        public MySqlDataAdapter DA5 = new MySqlDataAdapter();
        public MySqlCommandBuilder CB1;
        public DataTable DT8 = new DataTable();
        public DataTable DT9 = new DataTable();
        public DataTable DT10 = new DataTable();
        public DataTable DT11 = new DataTable();
        public DataTable DT12 = new DataTable();

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

        public FormAjout(string ajoutid, string ajoutpseudo, string ajouttag, string confirmation, string infotag, string btnajouter, string btnmodifier4)
        {
            InitializeComponent();
            this.lblajoutid.Text = ajoutid;
            this.labelajoutpseudo.Text = ajoutpseudo;
            this.labelajouttag.Text = ajouttag;
            this.labelconfirmation.Text = confirmation;
            this.labelinfotag.Text = infotag;
            this.btnajouterjoueur.Text = btnajouter;
            this.boutonmodifier.Text = btnmodifier4;
        }

        private void btnajouterjoueur_Click(object sender, EventArgs e)
        {
            //charger(DA3, DT10, "select id from player where tag_player=" + textBoxajouttag.Text + " and id_player = " + textBoxajoutid.Text + " and pseudo_player =" + textBoxajoutpseudo.Text);

            //String test = DT10.Rows[0]["id"].ToString().Trim();
                charger(DA1, DT8, "select * from player");


                //1- solution
                //byte[] utf16Bytes = Encoding.Unicode.GetBytes(textBoxajouttag.Text);
                //byte[] utf8Bytes = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf16Bytes);
                //string guilde =  Encoding.UTF8.GetString(utf8Bytes);


                /*2- solution
                Encoding iso = Encoding.GetEncoding("ISO-8859-1");
                Encoding utf8 = Encoding.UTF8;
                byte[] utfBytes = utf8.GetBytes(textBoxajouttag.Text);
                byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);
                string guilde = iso.GetString(isoBytes);
                */


                textboxmaj.Text = DateTime.Now.ToString();

                if (textBoxajoutid.Text != "")
                {
                    DataRow NouvLigne = DT8.NewRow();
                    NouvLigne["id_Player"] = Convert.ToInt32(textBoxajoutid.Text);

                    if (textBoxajoutpseudo.Text != "")
                    {
                        NouvLigne["pseudo_Player"] = textBoxajoutpseudo.Text;

                        if (textBoxajouttag.Text != "")
                        {
                            NouvLigne["tag_Player"] = textBoxajouttag.Text;
                        }
                        else
                        {
                            NouvLigne["tag_player"] = "-"; // mettre NULL dans la BD
                        }
                    }
                    else
                    {
                        NouvLigne["pseudo_Player"] = Convert.DBNull; // mettre NULL dans la BD
                    }

                    DT8.Rows.Add(NouvLigne);
                    DA1.Update(DT8);
                }

                charger(DA2, DT9, "select date_maj from maj");

                if (textboxmaj.Text != "")
                {
                    DataRow NouvLigne2 = DT9.NewRow();
                    NouvLigne2["date_maj"] = textboxmaj.Text;

                    DT9.Rows.Add(NouvLigne2);
                    DA2.Update(DT9);
                }

                textboxmaj.Clear();

                textBoxajoutid.Clear();
                textBoxajoutpseudo.Clear();
                textBoxajouttag.Clear();

                FormAjout_Load(sender, e);

                labelconfirmation.Visible = true;

            /*
                if (lblajoutid.Text == "Ajout/Modification du joueur ID :")
                {
                    MessageBox.Show("Ce joueur est déjà inscrit dans la base de donnée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (lblajoutid.Text == "Add / Change Player ID :")
                {
                    MessageBox.Show("This player is already registered in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                textBoxajoutid.Clear();
                textBoxajoutpseudo.Clear();
                textBoxajouttag.Clear();

                FormAjout_Load(sender, e);
             */
        }

        private void boutonmodifier_Click(object sender, EventArgs e)
        {
            ClassMySQL.sedeconnecter();
            FormMenu form = (FormMenu)this.MdiParent;
            form.MyMenu.Items[0].Enabled = true;
            form.MyMenu.Items[1].Enabled = true;
            form.MyMenu.Items[2].Enabled = true;
            this.Close();
        }

        private void FormAjout_Load(object sender, EventArgs e)
        {

            ClassMySQL.seconnecter();

            if (ClassMySQL.connopen == false)
            {
                if (lblajoutid.Text == "Ajout/Modification du joueur ID :")
                {
                    MessageBox.Show("Erreur dans la connexion à la base de donnée.");
                }
                else if (lblajoutid.Text == "Add / Change Player ID :")
                {
                    MessageBox.Show("Error in the connection to the database.");
                }
                this.Close();
            }
            if (lblajoutid.Text == "Ajout/Modification du joueur ID :")
            {
                labelerreur.Text = "En cas d'erreur dans l'ajout, cochez la case :";
            }
            else if (lblajoutid.Text == "Add / Change Player ID :")
            {
                labelerreur.Text = "In case of error in the addition, check the box :";
            }

            buttonenvoyer.Enabled = false;
        }

        private void textBoxajoutid_TextChanged(object sender, EventArgs e)
        {
            labelconfirmation.Visible = false;

            try
            {
                if (textBoxajoutid.Text != "" && textBoxajoutpseudo.Text != "")
                {
                    btnajouterjoueur.Enabled = true;

                    if (Convert.ToInt32(textBoxajoutid.Text) > (Convert.ToInt32("99999999")))
                    {
                        if (lblajoutid.Text == "Ajout/Modification du joueur ID :")
                        {
                            MessageBox.Show("L'identifiant d'un joueur ne peut pas contenir autant de chiffre.");
                        }
                        else if (lblajoutid.Text == "Add / Change Player ID :")
                        {
                            MessageBox.Show("The identifier of a player can not contain as many digits.");
                        }
                        textBoxajoutid.Clear();
                    }
                }
                else if (textBoxajoutid.Text != "" || textBoxajoutpseudo.Text != "")
                {
                    btnajouterjoueur.Enabled = false;
                }

                if (textBoxajoutid.Text != "" && textBoxajouttag.Text != "")
                {

                    if (Convert.ToInt32(textBoxajoutid.Text) > (Convert.ToInt32("99999999")))
                    {
                        if (lblajoutid.Text == "Ajout/Modification du joueur ID :")
                        {
                            MessageBox.Show("L'identifiant d'un joueur ne peut pas contenir autant de chiffre.");
                        }
                        else if (lblajoutid.Text == "Add / Change Player ID :")
                        {
                            MessageBox.Show("The identifier of a player can not contain as many digits.");
                        }
                        textBoxajoutid.Clear();
                    }
                }

                if (textBoxajoutid.Text != "")
                {

                    if (Convert.ToInt32(textBoxajoutid.Text) > (Convert.ToInt32("99999999")))
                    {
                        if (lblajoutid.Text == "Ajout/Modification du joueur ID :")
                        {
                            MessageBox.Show("L'identifiant d'un joueur ne peut pas contenir autant de chiffre.");
                        }
                        else if (lblajoutid.Text == "Add / Change Player ID :")
                        {
                            MessageBox.Show("The identifier of a player can not contain as many digits.");
                        }
                        textBoxajoutid.Clear();
                    }
                }

                if (textBoxajoutid.Text != "" && textBoxajouttag.Text != "" && textBoxajoutpseudo.Text != "")
                {

                    if (Convert.ToInt32(textBoxajoutid.Text) > (Convert.ToInt32("99999999")))
                    {
                        if (lblajoutid.Text == "Ajout/Modification du joueur ID :")
                        {
                            MessageBox.Show("L'identifiant d'un joueur ne peut pas contenir autant de chiffre.");
                        }
                        else if (lblajoutid.Text == "Add / Change Player ID :")
                        {
                            MessageBox.Show("The identifier of a player can not contain as many digits.");
                        }
                        textBoxajoutid.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vous devez entrer des chiffres !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxajoutid.Clear();
            }
        }

        private void textBoxajoutpseudo_TextChanged(object sender, EventArgs e)
        {
            labelconfirmation.Visible = false;

            if (textBoxajoutid.Text != "" && textBoxajoutpseudo.Text != "")
            {
                btnajouterjoueur.Enabled = true;
            }
            else if (textBoxajoutid.Text != "" || textBoxajoutpseudo.Text != "")
            {
                btnajouterjoueur.Enabled = false;
            }
        }

        private void textBoxajouttag_TextChanged(object sender, EventArgs e)
        {
            labelconfirmation.Visible = false;

            if (textBoxajoutid.Text != "" && textBoxajoutpseudo.Text != "")
            {
                btnajouterjoueur.Enabled = true;
            }
            else if (textBoxajoutid.Text != "" || textBoxajoutpseudo.Text != "")
            {
                btnajouterjoueur.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (lblajoutid.Text == "Ajout/Modification du joueur ID :")
            {
                labelinfoerreur1.Text = "Vous avez fait une erreur dans le";
                labelinfoerreur2.Text = "pseudonyme, le tag ou l'ID ?";
                labelinfoerreur3.Text = "Faite-le moi savoir pour que je corrige cet";
                labelinfoerreur4.Text = "incident :";
                labelerreur2.Text = "Donnez-moi le plus d'informations";
                labelerreur3.Text = "concernant l'incident.";
                buttonenvoyer.Text = "Envoyer ⇒";

            }
            else if (lblajoutid.Text == "Add / Change Player ID :")
            {
                labelinfoerreur1.Text = "You made a mistake in the";
                labelinfoerreur2.Text = "nickname, the tag or ID ?";
                labelinfoerreur3.Text = "Called me know so I can correct this";
                labelinfoerreur4.Text = "incident :";
                labelerreur2.Text = "Give me more information";
                labelerreur3.Text = "concerning the incident.";
                buttonenvoyer.Text = "Send ⇒";
            }

            if (checkBox1.Checked == true)
            {
                labelajoutpseudo.Visible = false;
                labelajouttag.Visible = false;
                lblajoutid.Visible = false;
                labelconfirmation.Visible = false;
                labelinfotag.Visible = false;
                textBoxajoutid.Visible = false;
                textBoxajoutpseudo.Visible = false;
                textBoxajouttag.Visible = false;
                btnajouterjoueur.Visible = false;

                labelinfoerreur1.Visible = true;
                labelinfoerreur2.Visible = true;
                labelinfoerreur3.Visible = true;
                labelinfoerreur4.Visible = true;
                labelerreur2.Visible = true;
                labelerreur3.Visible = true;
                richTextBoxerreur.Visible = true;
                buttonenvoyer.Visible = true;
            }
            else
            {

                labelerreur.Visible = true;
                labelajoutpseudo.Visible = true;
                labelajouttag.Visible = true;
                lblajoutid.Visible = true;
                labelinfotag.Visible = true;
                textBoxajoutid.Visible = true;
                textBoxajoutpseudo.Visible = true;
                textBoxajouttag.Visible = true;
                btnajouterjoueur.Visible = true;

                labelinfoerreur1.Visible = false;
                labelinfoerreur2.Visible = false;
                labelinfoerreur3.Visible = false;
                labelinfoerreur4.Visible = false;
                labelerreur2.Visible = false;
                labelerreur3.Visible = false;
                richTextBoxerreur.Visible = false;
                buttonenvoyer.Visible = false;
            }
        }

        private void richTextBoxerreur_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxerreur.Text != "")
            {
                buttonenvoyer.Enabled = true;
            }
            else
            {
                buttonenvoyer.Enabled = false;
            }
        }

        private void buttonenvoyer_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;

            MailAddress from = new MailAddress("dimy@hotmail.fr");
            MailAddress to = new MailAddress("dimy@hotmail.fr");

            MailMessage email = new MailMessage(from, to);
            email.Subject = "Erreur dans l'Ajout/Modification de joueur AddFindPlayer";
            email.Body = "Voici l'erreur :\r\n\r\n" + richTextBoxerreur.Text;
            SmtpClient client = new SmtpClient("smtp.live.com");
            client.Port = 587;
            #region Confidentiel
            client.Credentials = new System.Net.NetworkCredential("dimy@hotmail.fr", "maeva200914");
            #endregion
            client.EnableSsl = true;

            labelerreur2.Visible = false;
            labelerreur3.Visible = false;

            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 8;
            progressBar1.Value = progressBar1.Minimum;

            while (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                System.Threading.Thread.Sleep(1000); //Cette ligne ne sert qu'a stopper l'exécution 1 seconde entre chaque changement de la progressBar.
            }


            try
            {
                client.Send(email);


                if (lblajoutid.Text == "Ajout/Modification du joueur ID :")
                {
                    MessageBox.Show("Votre message a bien été envoyé.");
                }
                else if (lblajoutid.Text == "Add / Change Player ID :")
                {
                    MessageBox.Show("Your message has been sent.");
                }

                checkBox1.Enabled = true;
                buttonenvoyer.Enabled = false;
                richTextBoxerreur.Clear();
                progressBar1.Visible = false;
                checkBox1.Checked = false;
                FormAjout_Load(sender, e);
            }

            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message);
                checkBox1.Enabled = true;
            }
        }
    }
}
