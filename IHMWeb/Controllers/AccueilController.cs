using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Models;
using DAL;


namespace IHMWeb.Controllers
{
    public class AccueilController : Controller
    {
        private List<Rubrique> _rubriques;


        public List<Rubrique> AllRubriques()
        {
            List<Rubrique> rubriques = new List<Rubrique>();
            using (LibrairieContext context = new LibrairieContext())
            {
                foreach (var item in context.Rubriques)
                {
                    rubriques.Add(item);
                }
            }
            return rubriques;
    
        }
        
        public ActionResult Rubrique()
        {
            ViewBag.Message = "Rubrique thématique";
            _rubriques = AllRubriques();

            return View(_rubriques);
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nouvellement arrivé sur le net Book Store est une librairie en ligne.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Fiche de contact";

            return View();
        }
    }
}