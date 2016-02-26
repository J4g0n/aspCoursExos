using DMS_120_Web_Exercice_MVC5_EcoleMondor.Models;
using DMS_120_Web_Exercice_MVC5_EcoleMondor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS_120_Web_Exercice_MVC5_EcoleMondor.Controllers
{
    public class EtudiantController : Controller
    {
        // GET: Etudiant
        public ActionResult List()
        {
            List<Etudiant> listeEtudiants = new EtudiantRepositoryRAMImpl().ListeEtudiant();
            return View(listeEtudiants);
        }
        public ActionResult ModifierConfirmation(int id)
        {
            Etudiant etudiant = new EtudiantRepositoryRAMImpl().Recuperer(id);
            return View(etudiant);
        }
        public ActionResult Modifier(Etudiant model)
        {
            new EtudiantRepositoryRAMImpl().Modifier(model);
            return RedirectToAction("List", "Etudiant");
        }
        public ActionResult SupprimerConfirmation(int id)
        {
            Etudiant etudiant = new EtudiantRepositoryRAMImpl().Recuperer(id);
            return View(etudiant);
        }
        public ActionResult Supprimer(int id)
        {
            new EtudiantRepositoryRAMImpl().Supprimer(id);
            return RedirectToAction("List", "Etudiant");
        }
        public ActionResult CreerEtudiant()
        {
            return View();
        }
        public ActionResult Creer(Etudiant etudiant)
        {
            new EtudiantRepositoryRAMImpl().Creer(etudiant);
            return RedirectToAction("List", "Etudiant");
        }
    }
}