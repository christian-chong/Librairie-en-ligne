using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DAL;
using DAL.Models;

namespace IHMWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static bool DejaPasser;
        protected void Application_Start()
        {
            DbInitializer.Init();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            Dao dao = new Dao();

            SessionCommande.maRechercheMotCle = new RechercheMotCle();
            SessionCommande.currentUtilisateur = dao.FindUtilisateur(1); // Utilisateur avec Id = 1 ;
            SessionCommande.currentModeDePaiement = dao.FindModeDePaiement(1); // Mode de Paiement avec carte bleue Id = 1 ;
            SessionCommande.currentStatusDeCommande = dao.FindStatusDeCommande(1); // Status de Commande avec Id = 1 : En cours de validation;
            SessionCommande.maCommande = new Commande
            {
                UtilisateurId = SessionCommande.currentUtilisateur.Id,
                ModeDePaiementId = SessionCommande.currentModeDePaiement.Id,
                StatutDeCommandeId = SessionCommande.currentStatusDeCommande.Id,
                Date = DateTime.Now
            };
            dao.CreateCommande(SessionCommande.maCommande);


        }
    }
}
