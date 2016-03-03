using ServiceGeographie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGeographie
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceGeographie
    {
        [OperationContract]
        Ville CapitalPays(string codePays);

        [OperationContract]
        List<Ville> VillePays(string codePays);

        [OperationContract]
        List<Ville> VillePaysSelonTaille(string codePays, int nbHabitantsMin);

    }
}
