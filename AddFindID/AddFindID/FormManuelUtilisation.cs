using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddFindID
{
    public partial class FormManuelUtilisation : Form
    {

        string indice80;
        string indice81;
        string indice82;
        string indice83;
        string indice84;
        string indice85;

        public FormManuelUtilisation(string info1, string info2, string info3, string info5, string info6, string info7, string info8, string info9, string info10, string info11)
        {
            InitializeComponent();

            this.lblinfo1.Text = info1;
            this.lblinfo2.Text = info2;
            this.lblinfo3.Text = info3;
            this.lblinfo5.Text = info5;
            this.lblinfo6.Text = info6;
            this.lblinfo7.Text = info7;
            this.lblinfo8.Text = info8;
            this.lbldon1.Text = info9;
            this.labeldon2.Text = info10;
            this.label300.Text = info11;
        }

        private void FormManuelUtilisation_Load(object sender, EventArgs e)
        {
            if (lblinfo1.Text == "Manuel d'utilisation")
            {
                indice80 = "Des chiffres ?";
                indice81 = "AddFindPlayer, c'est :";
                indice82 = "joueurs.";
                indice83 = "pseudonymes.";
                indice84 = "☞ 90h de développement";
                indice85 = "Accueil ⇒";
            }
            else if (lblinfo1.Text == "User Manual")
            {
                indice80 = "Numbers ?";
                indice81 = "AddFindPlayer, it's :";
                indice82 = "players.";
                indice83 = "pseudonyms.";
                indice84 = "☞ 90h of development";
                indice85 = "Home ⇒";
            }
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            /*
            if (lblinfo1.Text == "Manuel d'utilisation")
            {
                MessageBox.Show("AddFindPlayer, c'est 80h de développement.\r\nProjet réalisé par ♪.·тιгđﺕιмραcт·.♪ЯĞC @Dimy.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lblinfo1.Text == "User Manual")
            {
                MessageBox.Show("AddFindPlayer, It is 80h of development.\r\nProject by ♪.·тιгđﺕιмραcт·.♪ЯĞC @Dimy.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             */


            FormChiffre FC = new FormChiffre(indice80, indice81, indice82, indice83, indice84, indice85);
            FC.MdiParent = (FormMenu)this.MdiParent;
            FC.Show();
            //FormMenu form = (FormMenu)this.MdiParent;
            //MyMenu.Enabled = false;
            //form.MyMenu.Items[0].Enabled = false;
            //form.MyMenu.Items[1].Enabled = false;
            //form.MyMenu.Items[2].Enabled = false;
        }

        private void boutondon_Click(object sender, EventArgs e)
        {
            
        }

        private void boutondon_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dimitryrobin.fr/FaireUnDon2.php");
        }
    }
}
