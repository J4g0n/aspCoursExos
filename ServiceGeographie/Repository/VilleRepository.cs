using ServiceGeographie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ServiceGeographie.Repository
{
    class VilleRepository
    {
        List<Ville> ExecuteRequest(string request)
        {
            List<Ville> listeVille = new List<Ville>();
            SqlConnection connexion;
            SqlCommand command;
            SqlDataReader dataReader;
            Ville ville;
            string idVille, nomAnglais, nomFrancais, pays;
            Boolean estCapitale;
            int nbHabitants;

            try
            {
                connexion = ParametresBD.ouvrirConnexionSQL();
                if (connexion.State == System.Data.ConnectionState.Open)
                {
                    command = new SqlCommand(request, connexion);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        idVille = dataReader["id"].ToString();
                        nomAnglais = dataReader["nomAnglais"].ToString();
                        nomFrancais = dataReader["nomFrancais"].ToString();
                        pays = dataReader["pays"].ToString();
                        nbHabitants = int.Parse(dataReader["nbHabitants"].ToString());
                        estCapitale = dataReader["estCapitale"].ToString() == "True";
                        ville = new Ville(idVille, nomAnglais, nomFrancais, pays, nbHabitants, estCapitale);
                        listeVille.Add(ville);
                    }
                }
                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Impossible de se connecter à la base de données with error message: \n" + e.Message);
            }

            return listeVille;
        }


        public List<Ville> ListeVillesParPays(string codePays)
        {
            string request = "SELECT * FROM Ville " +
                            "WHERE pays = '" + codePays + "'";
            return ExecuteRequest(request);
        }

        public List<Ville> ListeVillesParPaysAvecMinNbHabitants(string codePays, int minHabitants)
        {
            string request = "SELECT * FROM Ville " +
                            "WHERE pays = '" + codePays + "' " +
                            "nbHabitants > " + minHabitants;
            return ExecuteRequest(request);
        }
    }
}
