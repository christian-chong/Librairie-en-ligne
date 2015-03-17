using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DAL.Models;


namespace IHMWeb.Controllers
{
    public class PanierController : Controller
    {
        Dao dao = new Dao();
        // GET: Panier
        [HttpGet]
        public ActionResult Quantite(){
            return View();
        }

        [HttpPost]
        public ActionResult Quantite(LigneDeCommande uneLigneDeCommande)
        {
            SessionCommande.maLigneDeCommande = new LigneDeCommande();
            //uneLigneDeCommande.CommandeId = SessionCommande.maCommande.Id;
            SessionCommande.maLigneDeCommande.CommandeId = SessionCommande.maCommande.Id;
            //uneLigneDeCommande.ExemplaireId = SessionCommande.currentExemplaire.Id;
            SessionCommande.maLigneDeCommande.ExemplaireId = SessionCommande.currentExemplaire.Id;

            SessionCommande.maLigneDeCommande.Quantite = uneLigneDeCommande.Quantite; 
            dao.CreateLigneDeCommande(SessionCommande.maLigneDeCommande);

        
            
            return RedirectToAction("List", "Panier");
        }


        public ActionResult List( )
        {

            List<Panier> monPaniers;           
            SessionCommande.mesLignesDeCommandes = dao.FindLignesDeCommande(SessionCommande.maCommande);

            monPaniers = dao.PanierSelect(SessionCommande.mesLignesDeCommandes);

            return View(monPaniers);
        }

        public ActionResult Delete(int id)
        {
            Dao dao = new Dao();

            SessionCommande.currentExemplaire = dao.FindExemplaireId(id);
            SessionCommande.maLigneDeCommande = dao.FindLignesDeCommandeSuppression(SessionCommande.maCommande, SessionCommande.currentExemplaire);
            // MessageBox.Show(string.Format("Commande id {0}, Exemplaire id {1}", ldc.CommandeId, ldc.ExemplaireId));
            dao.DeleteLigneDeCommande(SessionCommande.maLigneDeCommande);
            return RedirectToAction("List", "Panier");

        }
        [Authorize]
        public ActionResult Commande(int id)
        {

            return View();

        }

    }
}