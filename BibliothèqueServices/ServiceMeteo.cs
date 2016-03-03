using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace BibliothèqueServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class ServiceMeteo : IServiceMeteo
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string ConversionTemperature(int temp, char sensConversion)
        {
            switch (sensConversion)
            {
                case 'f':
                    return ((temp * 9) / 5 + 32).ToString();
                case 'c':
                    return (((temp - 32) * 5) / 9).ToString();
                default:
                    return (0).ToString();
            }
        }

        public int PrevisionMeteo(string pays, string ville, string date, string heure)
        {
            SqlConnection connexion;
            SqlCommand command;
            SqlDataReader dataReader;
            int temperature = 0;

            try
            {
                connexion = ParametresBD.ouvrirConnexionSQL();
                if (connexion.State == System.Data.ConnectionState.Open)
                {
                    string request = "" +
                        "SELECT temperatureCelsuis " +
                        "FROM meteo " +
                        "WHERE" +
                        " codePays = '" + pays + "' AND " +
                        " codeVille = '" + ville + "' AND" +
                        " date LIKE '" + date + "' AND" +
                        " heure LIKE '" + heure + "'";
                    command = new SqlCommand(request, connexion);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        temperature = int.Parse(dataReader["temperatureCelsuis"].ToString());
                    }
                }
                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Impossible de se connecter à la base de données with error message: \n" + e.Message);
            }
            return temperature;
        }
    }
}
