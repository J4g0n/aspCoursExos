using ServiceGeographie.Models;
using ServiceGeographie.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGeographie
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class ServiceGeographie : IServiceGeographie
    {
        static VilleRepository villeRepository = new VilleRepository();

        public Ville CapitalPays(string codePays)
        {
            List<Ville> villes = villeRepository.ListeVillesParPays(codePays);
            Ville capitale = villes.Find(new Predicate<Ville>(ville => ville.EstCapitale));
            return capitale;
        }

        public List<Ville> VillePays(string codePays)
        {
            return villeRepository.ListeVillesParPays(codePays);
        }

        public List<Ville> VillePaysSelonTaille(string codePays, int nbHabitantsMin)
        {
            return villeRepository.ListeVillesParPaysAvecMinNbHabitants(codePays, nbHabitantsMin);
        }
    }
}
