using ASPapp.Abstraction;
using ASPapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPapp.Entites
{
    public class RepositoryStagiaire : IRepositoryStagiaire
    {
        private static List<Stagiaire> _listeStagiaires;
        public List<Stagiaire> Stagiaires
        {
            get
            {
                _listeStagiaires = new List<Stagiaire>()
                {
                    new Stagiaire(1, "Renaud", "Benoit"),
                    new Stagiaire(2, "Yann", "Yohan"),
                    new Stagiaire(3, "Baboulinet", "Steve")
                };
                return _listeStagiaires;
            }
        }

        public bool Creer()
        {
            return true;
        }
        public bool Modifier()
        {
            return true;
        }
        public bool Supprimer()
        {
            return true;
        }
        public Stagiaire Recuperer()
        {
            return null;
        }

        public RepositoryStagiaire()
        {

        }
    }
}