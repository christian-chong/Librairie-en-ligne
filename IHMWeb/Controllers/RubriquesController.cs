using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using DAL;
using DAL.Models;

public enum Rub
{
    Catalog,
    CoupDeCoeur,
    MeilVentes,
    Nouveau,
    Actu,
    Promo
}

namespace IHMWeb.Controllers
{
    public class RubriquesController : Controller
    {
        // GET: Rubriques
        private Dao dao;
        private LibrairieContext context= new LibrairieContext();

        public RubriquesController() : base()
        {
            dao = new Dao();
            
        }

        public ActionResult List(Rub rub)
        {
            Rubrique rubrique;
            var  exemplaires = context.Exemplaires;
            switch (rub)
            {
                case Rub.Catalog :
                    ViewBag.Title = "Liste de tous les livres";
                    return View(exemplaires.ToList());

                case Rub.CoupDeCoeur :
                    ViewBag.Title = "Liste des livres : coup de coeur";
                     rubrique = dao.FindRubrique("Coup de coeur");
                    return View(dao.FindExemplaires(rubrique));
                
                case Rub.MeilVentes :
                    ViewBag.Title = "Liste des meilleurs ventes";
                     rubrique = dao.FindRubrique("Meilleurs ventes");
                    return View(dao.FindExemplaires(rubrique));

                case Rub.Nouveau :
                    ViewBag.Title = "Liste des nouveautés";
                     rubrique = dao.FindRubrique("Nouveautés");
                 
                    return View(dao.FindExemplaires(rubrique));
                
                case Rub.Actu :
                    ViewBag.Title = "Liste des livres d'actualités";
                      rubrique = dao.FindRubrique("Actualités");
                     return View(dao.FindExemplaires(rubrique));
                
                case Rub.Promo :
                     ViewBag.Title = "Liste des livres en promotion";
                      rubrique = dao.FindRubrique("Promotions");
                     return View(dao.FindExemplaires(rubrique));
                
                default :
                    ViewBag.Title = "Liste de tous les livres";
                   return View(exemplaires.ToList());
            }
        }


      
        
    }
}