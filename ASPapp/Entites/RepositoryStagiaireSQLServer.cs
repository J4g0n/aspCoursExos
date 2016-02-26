using ASPapp.Models;
using ASPapp.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ASPapp.Entites
{
    public class RepositoryStagiaireSQLServer : IRepositoryStagiaire
    {
        private static List<Stagiaire> _listeStagiaires;
        public List<Stagiaire> Stagiaires
        {
            get
            {
                _listeStagiaires = new List<Stagiaire>();
                SqlConnection connexion;
                SqlCommand command;
                SqlDataReader dataReader;
                Stagiaire stagiaire;
                string nomStagiaire, prenomStagiaire;
                int idStagiaire;

                try
                {
                    connexion = ParametresBD.ouvrirConnexionSQL();
                    if (connexion.State == System.Data.ConnectionState.Open)
                    {
                        string request = "SELECT * FROM Stagiaire";
                        command = new SqlCommand(request, connexion);
                        dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            idStagiaire = dataReader.GetInt32(0);
                            nomStagiaire = dataReader["nom"].ToString();
                            prenomStagiaire = dataReader.GetString(2);
                            stagiaire = new Stagiaire(idStagiaire, nomStagiaire, prenomStagiaire);
                            _listeStagiaires.Add(stagiaire);
                        }
                    }
                    connexion.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Impossible de se connecter à la base de données with error message: \n" + e.Message);
                }

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

        public RepositoryStagiaireSQLServer()
        {

        }
    }
}