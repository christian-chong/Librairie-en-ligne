using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL;
using DAL.Models;

namespace IHMWeb.Controllers
{
    public class CommandesController : Controller
    {
        private LibrairieContext db = new LibrairieContext();

        // GET: Commandes
        public ActionResult Index()
        {
            var commandes = db.Commandes.Include(c => c.ModeDePaiement).Include(c => c.StatutDeCommande).Include(c => c.Utilisateur);
            return View(commandes.ToList());
        }

        // GET: Commandes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Commande commande = db.Commandes.Find(id);
            if (commande == null)
            {
                return HttpNotFound();
            }
            return View(commande);
        }

        // GET: Commandes/Create
        public ActionResult Create()
        {
            ViewBag.ModeDePaiementId = new SelectList(db.ModeDePaiements, "Id", "Type");
            ViewBag.StatutDeCommandeId = new SelectList(db.StatutDeCommandes, "Id", "Nom");
            ViewBag.UtilisateurId = new SelectList(db.Utilisateurs, "Id", "Nom");
            return View();
        }

        // POST: Commandes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UtilisateurId,ModeDePaiementId,StatutDeCommandeId,Date")] Commande commande)
        {
            if (ModelState.IsValid)
            {
                db.Commandes.Add(commande);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ModeDePaiementId = new SelectList(db.ModeDePaiements, "Id", "Type", commande.ModeDePaiementId);
            ViewBag.StatutDeCommandeId = new SelectList(db.StatutDeCommandes, "Id", "Nom", commande.StatutDeCommandeId);
            ViewBag.UtilisateurId = new SelectList(db.Utilisateurs, "Id", "Nom", commande.UtilisateurId);
            return View(commande);
        }

        // GET: Commandes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Commande commande = db.Commandes.Find(id);
            if (commande == null)
            {
                return HttpNotFound();
            }
            ViewBag.ModeDePaiementId = new SelectList(db.ModeDePaiements, "Id", "Type", commande.ModeDePaiementId);
            ViewBag.StatutDeCommandeId = new SelectList(db.StatutDeCommandes, "Id", "Nom", commande.StatutDeCommandeId);
            ViewBag.UtilisateurId = new SelectList(db.Utilisateurs, "Id", "Nom", commande.UtilisateurId);
            return View(commande);
        }

        // POST: Commandes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UtilisateurId,ModeDePaiementId,StatutDeCommandeId,Date")] Commande commande)
        {
            if (ModelState.IsValid)
            {
                db.Entry(commande).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ModeDePaiementId = new SelectList(db.ModeDePaiements, "Id", "Type", commande.ModeDePaiementId);
            ViewBag.StatutDeCommandeId = new SelectList(db.StatutDeCommandes, "Id", "Nom", commande.StatutDeCommandeId);
            ViewBag.UtilisateurId = new SelectList(db.Utilisateurs, "Id", "Nom", commande.UtilisateurId);
            return View(commande);
        }

        // GET: Commandes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Commande commande = db.Commandes.Find(id);
            if (commande == null)
            {
                return HttpNotFound();
            }
            return View(commande);
        }

        // POST: Commandes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Commande commande = db.Commandes.Find(id);
            db.Commandes.Remove(commande);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
