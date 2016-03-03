using System;
using System.Web;
using System.ComponentModel;
using System.Data.SqlClient;


namespace ServiceGeographie.Repository
{
    public class ParametresBD
    {

        //  ====================
        //  Attributs
        //  ====================
        private const string nomServeurSQL = "S13poste24\\SQLEXPRESS_SIMON";
        private const string nomBD = "DBGeographie";
        private static string chaineConnexionSQL;
        //  ====================
        //  propriétés
        //  ====================

        private static string ChaineConnexionSQL
        {
            get
            {
                chaineConnexionSQL = "Data Source=";
                chaineConnexionSQL += nomServeurSQL;
                chaineConnexionSQL += ";Initial Catalog=";
                chaineConnexionSQL += nomBD;
                chaineConnexionSQL += ";Integrated Security=True";
                return chaineConnexionSQL;
            }
        }
        //  ==========================================================
        //  méthode :   ouvrir une connexion sur SQL server 
        //              et renvoyer un objet connexion à l'appelant
        //  ==========================================================
        public static SqlConnection ouvrirConnexionSQL()
        {
            // déclarer les objets pour accès à une BD
            SqlConnection Uneconnex;
            Uneconnex = new SqlConnection();
            // chaîne de connexion
            Uneconnex.ConnectionString = ChaineConnexionSQL;
            try
            {   // ouvrir la connexion
                Uneconnex.Open();
                return Uneconnex;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //  ===============================================
        //  méthode :   fermer la connexion sur SQL server
        //  ===============================================
        public static bool fermerConnexionSQL(SqlConnection c)
        {
            try
            {   // fermer la connexion
                c.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
