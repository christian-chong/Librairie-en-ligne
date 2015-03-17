using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DAL;
using DAL.Models;
public enum Theme
{ 
    Roman,
    Informatique,
    Histoire,
    Geographie,
    Litterature,
    BD,
    Science,
    Scolaire,
    Polar,
    Poesie,
    Theatre,
    SciFi,
    Sante,
    Cuisine,
    Nature,
    Recherche
}

namespace IHMWeb.Controllers
{
    public class ThemesController : Controller
    {
        private LibrairieContext context = new LibrairieContext();
        private Dao dao;

        public ThemesController() : base()
        {
            dao = new Dao();
        }

        public ActionResult List(Theme theme)
        {
            switch (theme)
            {
                case Theme.Roman:
                    ViewBag.Title = "Liste des romans";
                    return View(dao.FindExemplaires("Roman"));

                case Theme.Informatique:
                    ViewBag.Title = "Liste des livres d'informatique";
                    return View(dao.FindExemplaires("Informatique"));

                case Theme.Histoire:
                    ViewBag.Title = "Liste des livres d'histoire";
                    return View(dao.FindExemplaires("Histoire"));

                case Theme.Geographie:
                    ViewBag.Title = "Liste des livres de géographie";
                    return View(dao.FindExemplaires("Géographie"));

                case Theme.Litterature:
                    ViewBag.Title = "Liste des oeuvres littéraires";
                    return View(dao.FindExemplaires("Littérature"));

                case Theme.BD:
                    ViewBag.Title = "Liste des bandes déssinés";
                    return View(dao.FindExemplaires("BD"));

                case Theme.Science:
                    ViewBag.Title = "Liste des livres scientifiques";
                    return View(dao.FindExemplaires("Science"));

                case Theme.Scolaire:
                    ViewBag.Title = "Liste des livres scolaires";
                    return View(dao.FindExemplaires("Scolaire"));

                case Theme.Polar:
                    ViewBag.Title = "Liste des polars";
                    return View(dao.FindExemplaires("Polar"));

                case Theme.Poesie:
                    ViewBag.Title = "Liste des livres de poésie";
                    return View(dao.FindExemplaires("Poésie"));

                case Theme.Theatre:
                    ViewBag.Title = "Liste des pièces de théatre";
                    return View(dao.FindExemplaires("Théatre"));

                case Theme.SciFi:
                    ViewBag.Title = "Liste des livres de science-fiction";
                    return View(dao.FindExemplaires("Science-fiction"));

                case Theme.Sante:
                    ViewBag.Title = "Liste des livres de santé";
                    return View(dao.FindExemplaires("Santé"));

                case Theme.Cuisine:
                    ViewBag.Title = "Liste des livres de cuisine";
                    return View(dao.FindExemplaires("Cuisine"));

                case Theme.Nature:
                    ViewBag.Title = "Liste des livres sur la nature";
                    return View(dao.FindExemplaires("Nature"));
                
                case Theme.Recherche:
                    ViewBag.Title = "Liste de livres issue de la recherche";
                    return View(SessionCommande.maRechercheMotCle.MaListExemplaires);
                default : return null;
            }
        }

        // GET: Themes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exemplaire exemplaire = context.Exemplaires.Find(id);
            if (exemplaire == null)
            {
                return HttpNotFound();
            }
            return View(exemplaire);
        }


    }
}
