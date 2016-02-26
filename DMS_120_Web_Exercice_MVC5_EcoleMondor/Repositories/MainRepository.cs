using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMS_120_Web_Exercice_MVC5_EcoleMondor.Repositories
{
    public abstract class MainRepository<A>
    {
        abstract public bool Creer(A a);

        abstract public bool Modifier(A a);

        abstract public bool Supprimer(int id);

        abstract public A Recuperer(int id);
    }
}