﻿using DMS_120_Web_Exercice_MVC5_EcoleMondor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_120_Web_Exercice_MVC5_EcoleMondor.Abstraction
{
    interface IEtudiantRepository
    {
        List<Etudiant> ListeEtudiant();

        bool Creer(Etudiant a);

        bool Modifier(Etudiant a);

        bool Supprimer(int id);

        Etudiant Recuperer(int id);
    }
}
