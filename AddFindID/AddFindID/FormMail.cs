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
using System.Text.RegularExpressions;

namespace AddFindID
{
    public partial class FormMail : Form
    {
        public MySqlDataAdapter DA1 = new MySqlDataAdapter();
        public MySqlCommandBuilder CB1;
        public DataTable DT1 = new DataTable();
        public DataTable DT2 = new DataTable();

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

        public FormMail(string prenom, string mail, string btnenvoyer, string infoenvoiemail, string infosup, string btnhome)
        {
            InitializeComponent();
            this.lblprenom.Text = prenom;
            this.labelmail.Text = mail;
            this.btnenvoyermail.Text = btnenvoyer;
            this.boutonmodifier.Text = btnhome;
            this.labelconfirmationmail.Text = infoenvoiemail;
            this.labelinfomail.Text = infosup;
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            ClassMySQL.sedeconnecter();
            this.Close();
        }

        private void FormMail_Load(object sender, EventArgs e)
        {
            ClassMySQL.seconnecter();

            if (ClassMySQL.connopen == false)
            {
                if (lblprenom.Text == "Entrez votre prénom :")
                {
                    MessageBox.Show("Erreur dans la connexion à la base de donnée.");
                }
                else if (lblprenom.Text == "Enter your first name :")
                {
                    MessageBox.Show("Error in the connection to the database.");
                }
                this.Close();
            }


            textBoxprenom.Enabled = true;
            textBoxmail.Enabled = true;
            btnenvoyermail.Visible = true;
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

        private void btnenvoyermail_Click(object sender, EventArgs e)
        {
            charger(DA1, DT1, "select * from mail");

            if (textBoxprenom.Text != "") // Prenom
            {
                btnenvoyermail.Enabled = false;
                btnenvoyermail.Visible = false;
                boutonmodifier.Enabled = false;

                if (Regex.IsMatch(textBoxmail.Text, @"^(\w{1,12})@([a-z]{1,7})\.([a-z]{1,3})$", RegexOptions.None))
                {
                    MailAddress from = new MailAddress("dimy@hotmail.fr");
                    MailAddress to = new MailAddress(textBoxmail.Text);

                    MailMessage email = new MailMessage(from, to);
                    email.Subject = "Mot de passe Ajout/Modification de joueur AddFindPlayer";
                    email.Body = "Bonjour " + textBoxprenom.Text + ".\r\n\r\nAvant de vous communiquez un mot de passe, j'aimerai obtenir les informations suivantes :\r\n\r\n   - Quel est votre pseudo dans seafight ?\r\n   - Dans quelle guilde jouez-vous ? (TAG)\r\n\r\nMerci.\r\n\r\nCordialement ♪.·тιгđﺕιмραcт·.♪ЯĞC - Dimy.";
                    SmtpClient client = new SmtpClient("smtp.live.com");
                    client.Port = 587;
                    #region Confidentiel
                    client.Credentials = new System.Net.NetworkCredential("dimy@hotmail.fr", "Dimtchek12");
                    #endregion
                    client.EnableSsl = true;


                    progressBarAgent.Visible = true;
                    progressBarAgent.Minimum = 0;
                    progressBarAgent.Maximum = 8;
                    progressBarAgent.Value = progressBarAgent.Minimum;

                    while (progressBarAgent.Value < progressBarAgent.Maximum)
                    {
                        progressBarAgent.Value += 1;
                        System.Threading.Thread.Sleep(1000); //Cette ligne ne sert qu'a stopper l'exécution 1 seconde entre chaque changement de la progressBar.
                    }


                    try
                    {
                        client.Send(email);

                        DataRow NouvLigne = DT1.NewRow();
                        NouvLigne["prenom_mail"] = textBoxprenom.Text;

                        if (textBoxmail.Text != "") // mail
                        {
                            NouvLigne["adresse_mail"] = textBoxmail.Text;
                        }
                        else
                        {
                            NouvLigne["adresse_mail"] = Convert.DBNull; // mettre NULL dans la BD
                        }
                        DT1.Rows.Add(NouvLigne);
                        DA1.Update(DT1);

                        labelconfirmationmail.Visible = true;
                        labelinfomail.Visible = true;
                        progressBarAgent.Visible = false;
                    }

                    catch (SmtpException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    textBoxprenom.Clear();
                    textBoxmail.Clear();
                    textBoxprenom.Enabled = false;
                    textBoxmail.Enabled = false;
                    boutonmodifier.Enabled = true;
                }
                else
                {

                    MessageBox.Show("Email NON valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBoxmail.Clear();
                    FormMail_Load(sender, e);
                }
            }
        }

        private void textBoxprenom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxprenom.Text != "" && textBoxmail.Text != "")
                {
                    btnenvoyermail.Enabled = true;
                }
                else if (textBoxprenom.Text != "" || textBoxmail.Text != "")
                {
                    btnenvoyermail.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Vous devez entrer des lettres !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxprenom.Clear();
            }
        }

        private void textBoxmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxprenom.Text != "" && textBoxmail.Text != "")
                {
                    btnenvoyermail.Enabled = true;
                }
                else if (textBoxprenom.Text != "" || textBoxmail.Text != "")
                {
                    btnenvoyermail.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Vous devez entrer des lettres !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxprenom.Clear();
            }
        }
    }
}
