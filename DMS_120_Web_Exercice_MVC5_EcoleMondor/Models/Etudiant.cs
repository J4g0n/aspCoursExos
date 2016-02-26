using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMS_120_Web_Exercice_MVC5_EcoleMondor.Models
{
    //id, nom, prénom, adresse postale(en minimum 3 champs), téléphone(avec indicatif du pays), email, photo
    public class Etudiant
    {
        int id;
        public int Id
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

        string nom;
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        string prenom;
        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        string addresse;
        public string Addresse
        {
            get
            {
                return addresse;
            }

            set
            {
                addresse = value;
            }
        }

        string email;
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        string telephone;
        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public Etudiant(int id, string nom, string prenom, string addresse, string email, string telephone)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.addresse = addresse;
            this.email = email;
            this.telephone = telephone;
        }


        public Etudiant()
        {
            
        }
    }
}