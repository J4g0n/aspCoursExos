using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPapp.Models
{
    public class Stagiaire
    {
        private int _identifiant;
        public int identifiant
        {
            get { return _identifiant; }
            set { _identifiant = value; }
        }
        private string _nom;
        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private string _prenom;
        public string prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }


        public Stagiaire(int id, string n, string p)
        {
            _identifiant = id;
            _nom = n;
            _prenom = p;
        }
    }
}