using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DMS_120_Web_Exercice_MVC5_EcoleMondor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "DeleteStudent",
                url: "Etudiant/Supprimer/{id}",
                defaults: new { controller = "Etudiant", action = "Supprimer", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CreateFormStudent",
                url: "Etudiant/CreerEtudiant",
                defaults: new { controller = "Etudiant", action = "CreerEtudiant", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ModifyStudent",
                url: "Etudiant/Modifier/{model}",
                defaults: new { controller = "Etudiant", action = "Modifier", model = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "CreateStudent",
                url: "Etudiant/Creer/{etudiant}",
                defaults: new { controller = "Etudiant", action = "Creer", etudiant = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SupprimerConfirmation",
                url: "Etudiant/SupprimerConfirmation/{id}",
                defaults: new { controller = "Etudiant", action = "SupprimerConfirmation", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ModifierConfirmation",
                url: "Etudiant/ModifierConfirmation/{id}",
                defaults: new { controller = "Etudiant", action = "ModifierConfirmation", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ListStudent",
                url: "Etudiant/List",
                defaults: new { controller = "Etudiant", action = "List" }
            );
        }
    }
}
