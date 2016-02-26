using DMS_120_Web_Exercice_MVC5_EcoleMondor.Abstraction;
using DMS_120_Web_Exercice_MVC5_EcoleMondor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMS_120_Web_Exercice_MVC5_EcoleMondor.Models;

namespace DMS_120_Web_Exercice_MVC5_EcoleMondor.Repositories
{
    public class EtudiantRepositoryRAMImpl : MainRepository<Etudiant>, IEtudiantRepository
    {
        static List<Etudiant> listeEtudiants = new List<Etudiant>();

        public override bool Creer(Etudiant a)
        {
            Random rand = new Random();
            a.Id = (int) (rand.NextDouble() * 1000000);
            listeEtudiants.Add(a);
            return true;
        }

        public override bool Modifier(Etudiant a)
        {
            listeEtudiants.RemoveAll(new Predicate<Etudiant>(target => target.Id == a.Id));
            listeEtudiants.Add(a);
            return true;
        }

        public override Etudiant Recuperer(int id)
        {
            return listeEtudiants.Find(new Predicate<Etudiant>(target => target.Id == id));
        }

        public override bool Supprimer(int id)
        {
            listeEtudiants.RemoveAll(new Predicate<Etudiant>(target => target.Id == id));
            return true;
        }


        public List<Etudiant> ListeEtudiant()
        {
            return listeEtudiants;
        }


        public EtudiantRepositoryRAMImpl()
        {
            if (listeEtudiants.Count <= 0)
            {
                listeEtudiants = new List<Etudiant>()
                {
                    new Etudiant(1, "Cena", "John", "5 impasse des tilleuls", "joncena@gmail.com", "0642154575"),
                    new Etudiant(2, "Undertaker", "The", "5 voie du romarin", "undertake@hotmail.com", "0643105105")
                };
            }
        }
    }
}