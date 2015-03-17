using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DAL.Models;

namespace IHMWeb.Controllers
{
    public class ExemplairesController : Controller
    {
        private Dao dao;

        public ExemplairesController()
        {
            dao = new Dao();
        }
        // GET: Exemplaires
        [HttpGet]
        public ActionResult Details(int id)
        {

            var exemplaire = dao.FindExemplaireId(id);
            SessionCommande.currentExemplaire = exemplaire;
            SessionCommande.currentPrix = dao.FindPrix(exemplaire);
            SessionCommande.currentLivre = dao.FindLivre(exemplaire);

            ViewBag.Title = SessionCommande.currentLivre.Titre;

            return View();
        }
        public ActionResult Edit(int id)
        {
            Exemplaire exemplaire = dao.FindExemplaireId(id);

            return View(exemplaire);
        }
  
    }
}