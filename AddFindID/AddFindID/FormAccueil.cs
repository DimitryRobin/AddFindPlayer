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
    public partial class FormAccueil : Form
    {
        public MySqlDataAdapter DA1 = new MySqlDataAdapter();
        public MySqlCommandBuilder CB1;
        public DataTable DT1 = new DataTable();
        public DataTable DT2 = new DataTable();

        public FormAccueil()
        {
            InitializeComponent();
        }

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

        private void btnajouter_Click(object sender, EventArgs e)
        {
            FormMenu FM = new FormMenu();
            //FFID.MdiParent = this;
            this.Hide();
            FM.Show();

            // menuStrip1.Enabled = false;
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            ClassMySQL.seconnecter();

            if (ClassMySQL.connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion à la base de donnée.");
                this.Close();
            }

            charger(DA1, DT1, "SELECT date_maj as 'DateMaj' FROM maj WHERE date_maj = (SELECT MAX(date_maj) FROM maj);");

            // labelmaj.Text = "DateMaj";
            labeldatemaj.Text = DT1.Rows[0]["DateMaj"].ToString();
        }

        private void FormAccueil_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassMySQL.sedeconnecter();
        }
    }
}
