using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceGeographie.Models
{
    [DataContract]
    public class Ville
    {
        private string id;
        private string nomAnglais;
        private string nomFrancais;
        private string pays;
        private int nbHabitants;
        private Boolean estCapitale;

        [DataMember]
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [DataMember]
        public string NomAnglais
        {
            get
            {
                return nomAnglais;
            }

            set
            {
                nomAnglais = value;
            }
        }

        [DataMember]
        public string NomFrancais
        {
            get
            {
                return nomFrancais;
            }

            set
            {
                nomFrancais = value;
            }
        }

        [DataMember]
        public string Pays
        {
            get
            {
                return pays;
            }

            set
            {
                pays = value;
            }
        }

        [DataMember]
        public int NbHabitants
        {
            get
            {
                return nbHabitants;
            }

            set
            {
                nbHabitants = value;
            }
        }

        [DataMember]
        public bool EstCapitale
        {
            get
            {
                return estCapitale;
            }

            set
            {
                estCapitale = value;
            }
        }

        public Ville(string id, string nomAnglais, string nomFrancais, string pays, int nbHabitants, Boolean estCapitale)
        {
            this.Id = id;
            this.NomAnglais = nomAnglais;
            this.NomFrancais = nomFrancais;
            this.Pays = pays;
            this.NbHabitants = nbHabitants;
            this.EstCapitale = estCapitale;
        }
    }
}
