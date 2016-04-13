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
    public partial class FormChiffre : Form
    {
        public MySqlDataAdapter DA0 = new MySqlDataAdapter();
        public MySqlDataAdapter DA1 = new MySqlDataAdapter();
        public MySqlCommandBuilder CB1;
        public DataTable DT0 = new DataTable();
        public DataTable DT1 = new DataTable();

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

        public FormChiffre(string lb1, string lb2, string lb3, string lb4, string lb5, string lb6)
        {
            InitializeComponent();

            lblchiffre1.Text = lb1;
            lblchiffre2.Text = lb2;
            lblchiffre3.Text = lb3;
            lblchiffres4.Text = lb4;
            lblchiffres5.Text = lb5;
            btnaccueil.Text = lb6;
        }

        private void btnaccueil_Click(object sender, EventArgs e)
        {
            ClassMySQL.sedeconnecter();
            FormMenu form = (FormMenu)this.MdiParent;
            form.MyMenu.Items[0].Enabled = true;
            form.MyMenu.Items[1].Enabled = true;
            form.MyMenu.Items[2].Enabled = true;
            this.Close();
        }

        private void FormChiffre_Load(object sender, EventArgs e)
        {
            ClassMySQL.seconnecter();

            if (ClassMySQL.connopen == false)
            {
                if (lblchiffre1.Text == "Des chiffres ?")
                {
                    MessageBox.Show("Erreur dans la connexion à la base de donnée.");
                }
                else if (lblchiffre1.Text == "Numbers ?")
                {
                    MessageBox.Show("Error in the connection to the database.");
                }
                this.Close();
            }

            FormMenu form = (FormMenu)this.MdiParent;
            //MyMenu.Enabled = false;
            form.MyMenu.Items[0].Enabled = false;
            form.MyMenu.Items[1].Enabled = false;
            form.MyMenu.Items[2].Enabled = false;

            charger(DA1, DT1, "SELECT DISTINCT id_player as 'nombre2' FROM player;");

            nbjoueur.Text = DT1.Rows.Count.ToString();

            charger(DA0, DT0, "SELECT id as 'nombre1' FROM player;");

            nbpseudo.Text = DT0.Rows.Count.ToString();
        }
    }
}
