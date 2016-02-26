using ASPapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPapp.Abstraction
{
    interface IRepositoryStagiaire
    {
        List<Stagiaire> Stagiaires
        {
            get;
        }

        bool Creer();
        bool Modifier();
        bool Supprimer();
        Stagiaire Recuperer();
    }
}
