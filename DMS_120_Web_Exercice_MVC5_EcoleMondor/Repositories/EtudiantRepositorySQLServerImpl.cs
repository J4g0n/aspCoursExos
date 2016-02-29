using DMS_120_Web_Exercice_MVC5_EcoleMondor.Abstraction;
using DMS_120_Web_Exercice_MVC5_EcoleMondor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMS_120_Web_Exercice_MVC5_EcoleMondor.Models;
using System.Data.SqlClient;

namespace DMS_120_Web_Exercice_MVC5_EcoleMondor.Repositories
{
    public class EtudiantRepositorySQLServerImpl : MainRepository<Etudiant>, IEtudiantRepository
    {
        public override bool Creer(Etudiant etudiant)
        {
            List<Etudiant> listeEtudiant = new List<Etudiant>();
            SqlConnection connexion;
            SqlCommand command;
            SqlDataReader dataReader;
            int nbCreate = 0;

            try
            {
                connexion = ParametresBD.ouvrirConnexionSQL();
                if (connexion.State == System.Data.ConnectionState.Open)
                {
                    string request = "" +
                        "INSERT INTO etudiant ( nom, prenom, addresse, email, telephone ) VALUES ( " +
                        "'" + etudiant.Nom + "', " +
                        "'" + etudiant.Prenom + "', " +
                        "'" + etudiant.Addresse + "', " +
                        "'" + etudiant.Email + "', " +
                        "'" + etudiant.Telephone + "'" +
                        " )";
                    command = new SqlCommand(request, connexion);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nbCreate += 1;
                    }
                }
                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Impossible de se connecter à la base de données with error message: \n" + e.Message);
            }

            return nbCreate > 0;
        }

        public override bool Modifier(Etudiant etudiant)
        {
            List<Etudiant> listeEtudiant = new List<Etudiant>();
            SqlConnection connexion;
            SqlCommand command;
            SqlDataReader dataReader;
            int nbModify = 0;

            try
            {
                connexion = ParametresBD.ouvrirConnexionSQL();
                if (connexion.State == System.Data.ConnectionState.Open)
                {
                    string request = "" +
                        "UPDATE etudiant SET " +
                        "nom = '" + etudiant.Nom + "', " +
                        "prenom = '" + etudiant.Prenom + "', " +
                        "addresse = '" + etudiant.Addresse + "', " +
                        "email = '" + etudiant.Email + "', " +
                        "telephone = '" + etudiant.Telephone + "' " +
                        "WHERE id = " + etudiant.Id;
                    command = new SqlCommand(request, connexion);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nbModify += 1;
                    }
                }
                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Impossible de se connecter à la base de données with error message: \n" + e.Message);
            }

            return nbModify > 0;
        }

        public override Etudiant Recuperer(int id)
        {
            return ListeEtudiant().Find(new Predicate<Etudiant>(etudiant => id == etudiant.Id));
        }

        public override bool Supprimer(int id)
        {
            List<Etudiant> listeEtudiant = new List<Etudiant>();
            SqlConnection connexion;
            SqlCommand command;
            SqlDataReader dataReader;
            int nbDelete = 0;

            try
            {
                connexion = ParametresBD.ouvrirConnexionSQL();
                if (connexion.State == System.Data.ConnectionState.Open)
                {
                    string request = "" +
                        "DELETE FROM etudiant " +
                        "WHERE id = " + id;
                    command = new SqlCommand(request, connexion);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nbDelete += 1;
                    }
                }
                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Impossible de se connecter à la base de données with error message: \n" + e.Message);
            }

            return nbDelete > 0;
        }


        public List<Etudiant> ListeEtudiant()
        {
            List<Etudiant> listeEtudiant = new List<Etudiant>();
            SqlConnection connexion;
            SqlCommand command;
            SqlDataReader dataReader;
            Etudiant etudiant;
            string nomEtudiant, prenomEtudiant, addresseEtudiant, telEtudiant;
            int idEtudiant;

            try
            {
                connexion = ParametresBD.ouvrirConnexionSQL();
                if (connexion.State == System.Data.ConnectionState.Open)
                {
                    string request = "SELECT * FROM etudiant";
                    command = new SqlCommand(request, connexion);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        idEtudiant = dataReader.GetInt32(0);
                        nomEtudiant = dataReader["nom"].ToString();
                        prenomEtudiant = dataReader["prenom"].ToString();
                        addresseEtudiant = dataReader["addresse"].ToString();
                        telEtudiant = dataReader["telephone"].ToString();
                        etudiant = new Etudiant(idEtudiant, nomEtudiant, prenomEtudiant, addresseEtudiant, "", telEtudiant);
                        listeEtudiant.Add(etudiant);
                    }
                }
                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Impossible de se connecter à la base de données with error message: \n" + e.Message);
            }

            return listeEtudiant;
        }


        public EtudiantRepositorySQLServerImpl()
        {
           
        }
    }
}