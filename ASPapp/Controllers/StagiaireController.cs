using ASPapp.Entites;
using ASPapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPapp.Controllers
{
    public class StagiaireController : Controller
    {
        // GET: Stagiaire
        public ActionResult Stagiaire()
        {
            List<Stagiaire> listStagiaires = new RepositoryStagiaireSQLServer().Stagiaires;
            return View(listStagiaires);
        }
    }
}