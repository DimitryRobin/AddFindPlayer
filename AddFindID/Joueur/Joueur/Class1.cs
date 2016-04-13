using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joueur
{
    public class ClassJoueur
    {
         #region Propriété de la classe

        private int id;
        private string tag;
        private string pseudo;

        #endregion

        #region Accesseur

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }
        

        #endregion

        #region Constructeur

        public ClassJoueur()
        {

        }

        /// <summary>
        /// ClassJoueur
        /// </summary>
        /// <param name="unid"></param>
        /// <param name="untag"></param>
        /// <param name="unpseudo"></param>
        
        public ClassJoueur(int unid, string untag, string unpseudo)
        {
            id=unid;
            tag=untag;
            pseudo=unpseudo;

        }

        #endregion

        #region Méthodes


        #endregion
    }
}
