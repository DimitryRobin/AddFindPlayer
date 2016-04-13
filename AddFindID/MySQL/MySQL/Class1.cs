using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySQL
{
    public class ClassMySQL
    {
        public static MySqlConnection myConnection; // variable de connexion
        public static bool connopen = false; // pour tester si la connexion est ouverte
        public static bool errgrave = false; // pour tester si des erreurs se sont produites


        public static void seconnecter()
        {
            //string myConnectionString = "Database=addfindplayer;Data Source=localhost;User Id=root;CharSet=utf8"; // local
            string myConnectionString = "Database=addfindplayer;Data Source=db4free.net;User Id=dimitry;password=Dimtchek12;CharSet=utf8"; // online
            //string myConnectionString = "Database=gyqwl431;Data Source=sql2.olympe.in;User Id=gyqwl431;password=Dimtchek12;CharSet=utf8"; // olympe
            //string myConnectionString = "Database=u164988437_afp;Data Source=mysql.hostinger.fr;User Id=u164988437_dim;password=8w4qbsLdoe;CharSet=utf8"; // hostinger




            myConnection = new MySqlConnection(myConnectionString);
            connopen = true;
            try // tentative
            {
                myConnection.Open(); // ouverture de la connexion
            }
            catch (Exception err)// gestion des erreurs
            {
                connopen = false; errgrave = true;
            }
        }
        public static void sedeconnecter()
        {
            if (!connopen) return; // pour tester si la connexion est bien ouverte
            try
            {
                myConnection.Close(); // fermeture de la connexion
                myConnection.Dispose(); // libération de la connexion
            }
            catch (Exception err)
            {
                errgrave = true;
            }
        }
    }
}
