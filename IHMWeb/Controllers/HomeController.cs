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
    public class HomeController : Controller
    {
        private List<Rubrique> rubriques;
        private Dao dao;

        public HomeController() : base()
        {
            dao = new Dao();
        }

        /*
        public ActionResult Rubrique()
        {
            ViewBag.Message = "Rubrique thématique";
            rubriques = dao.AllRubriques();
            return View(rubriques);
        }*/
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cgv()
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