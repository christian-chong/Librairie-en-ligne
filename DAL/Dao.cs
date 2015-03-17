using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using System.Windows.Forms;

namespace DAL
{
    public class Dao
    {

        public List<Exemplaire> RechercheExemplaireMotCle(string motCle)
        {
            using (LibrairieContext context = new LibrairieContext())
            {
                try
                {
                    List<Livre> livres = RechercheLivres(motCle);
                    var exemplaires = new List<Exemplaire>();
                    foreach (var livre in livres)
                    {
                        exemplaires.AddRange(context.Exemplaires.Include("Editeur").Include("Livre").Where(e => e.LivreId == livre.Id)); 
                    }
                    return exemplaires;
                }
                catch (Exception ex)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + ex.Message);
                }
            }
        }

        public Prix FindPrix(Exemplaire exemplaire)
        {
            using (var context = new LibrairieContext())
            {
                var requete = (from r in context.Couters.Include("Prixes")
                    .Where(l => l.ExemplaireId == exemplaire.Id)
                    select r);

                var date = (from re in requete
                    select re.Prixes
                    ).Max(p1 => p1.Date);

                var query = (from ex in context.Exemplaires
                    where ex.Id == exemplaire.Id
                    join cou in context.Couters on ex.Id equals cou.ExemplaireId
                    join pri in context.Prixes on cou.PrixId equals pri.Id
                    where pri.Date == date
                    select pri
                    ).Single();
                return query;
            }
        }


        public List<Exemplaire> FindExemplaires(string theme)
        {
            using (LibrairieContext context = new LibrairieContext())
            {
                try
                {
                    var exemplaire = new List<Exemplaire>();

                    var requete = (from liv in context.Livres
                        where (Equals(liv.Theme.ToUpper().Trim(), theme.ToUpper().Trim()))
                                   select liv);
                    exemplaire = new List<Exemplaire>();
                    foreach (var livre in requete)
                    {
                        exemplaire.AddRange(context.Exemplaires.Include("Editeur").Where(e => e.LivreId == livre.Id));
                    }
                    return exemplaire;
                }
                catch (Exception ex)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + ex.Message);
                }
            }
        }

        public List<Exemplaire> FindExemplaires(Rubrique rubrique)
        {
            using (LibrairieContext context = new LibrairieContext())
            {
                try
                {
                    List<Exemplaire> exemplaire = new List<Exemplaire>();
                    // List<Livre> listeLivres = FindLivre(rubrique); 
                    var requete = from r in context.Appartenir1s.Include("Livre")
                        .Where(l => l.RubriqueId == rubrique.Id)
                        select r;
                    var livreResult = requete.Select(p => p.Livre);

                    exemplaire = new List<Exemplaire>();

                    foreach (var livre in livreResult)
                    {
                        exemplaire.AddRange(context.Exemplaires.Include("Editeur").Where(e => e.LivreId == livre.Id));
                    }
                    return exemplaire;
                }
                catch (Exception ex)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + ex.Message);
                }
            }
        }


          public Livre FindLivre(Exemplaire exemplaire)
        {
            using (LibrairieContext context = new LibrairieContext())
            {
                var query = (from ex in context.Exemplaires.Include("Livre")
                    where ex.LivreId == exemplaire.LivreId 
                    select ex);
                return query.Select(l=> l.Livre).Distinct().Single();
            }
            
        }
       

        public List<Rubrique> FindRubrique(Livre livre)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        from r in context.Appartenir1s.Include("Rubrique")
                            .Where(l => l.LivreId == livre.Id)
                        select r;

                    var Appartenir1s = requete.ToList();
                    return Appartenir1s.Select(e => e.Rubrique).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public Exemplaire FindExemplaireId(int exemplaireId)
        {
            using (LibrairieContext context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        (from e in
                            context.Exemplaires.Include("Editeur").Include("Livre")
                            where e.Id == exemplaireId
                            select e).ToList();

                    return requete.Single();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }



        public LigneDeCommande FindLignesDeCommandeSuppression(Commande commande, Exemplaire exemplaire)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var r = from e in context.LigneDeCommandes
                        where e.CommandeId == commande.Id && e.ExemplaireId == exemplaire.Id
                        select e;
                    return r.Single();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void CreateLigneDeCommande(LigneDeCommande ldc)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(ldc).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void DeleteLigneDeCommande(LigneDeCommande ldc)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(ldc).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }


        public List<Commande> FindCommandes(Utilisateur utilisateur)
        {

            using (var context = new LibrairieContext())
            {
                try // rubrique
                {
                    var requete =
                        from r in context.Commandes
                            .Where(l => l.UtilisateurId == utilisateur.Id)
                        select r;

                    var req = requete.ToList();
                    return req;
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }


        public List<LigneDeCommande> FindLignesDeCommande(Commande commande)
        {

            using (var context = new LibrairieContext())
            {
                try // rubrique
                {
                    var requete =
                        from r in context.LigneDeCommandes
                            .Where(l => l.CommandeId == commande.Id)
                        select r;

                    var req = requete.ToList();
                    return req;
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }



public List<Panier> PanierSelect(List<LigneDeCommande> mesLignesDeCommandes)
{
  using (LibrairieContext context = new LibrairieContext())
       { 
            try
            {

                List<Panier> listePaniers = new List<Panier>();

                foreach (var ligneDeCommande in mesLignesDeCommandes)
                {


                    var requete = (from r in context.Couters.Include("Prixes")
                        .Where(l => l.ExemplaireId == ligneDeCommande.ExemplaireId)
                        select r);

                    var date = (from re in requete
                        select re.Prixes
                        ).Max(p1 => p1.Date);

                    var query = (from li in context.LigneDeCommandes
                        where li.CommandeId == ligneDeCommande.CommandeId

                        join ex in context.Exemplaires on li.ExemplaireId equals ex.Id
                        where ex.Id == ligneDeCommande.ExemplaireId

                        join cou in context.Couters on ex.Id equals cou.ExemplaireId
                        join pri in context.Prixes on cou.PrixId equals pri.Id

                        where pri.Date == date

                        join liv in context.Livres on ex.LivreId equals liv.Id
                        //join aut in context.Auteurs on 

                        select new 
                        {
                            ExemplaireId = ex.Id,
                            Quantite = li.Quantite,
                            ISBN = ex.ISBN,
                            Titre = liv.Titre,
                            PrixHT = pri.PrixHT,
                            TVA = pri.TVA,
                            PrixTTC = pri.PrixHT*((decimal) 1 + pri.TVA/(decimal) 100)
                        })
                        .ToList()
                        .Select(x=>new Panier
                        {
                            ExemplaireId = x.ExemplaireId,
                            Quantite = x.Quantite,
                            ISBN = x.ISBN,
                            Titre = x.Titre,
                            PrixHT = x.PrixHT,
                            TVA = x.TVA,
                            PrixTTC = x.PrixHT * ((decimal)1 + x.TVA / (decimal)100)
                        }
                        ).Single();
                    listePaniers.Add(query);
                } 
                return listePaniers.ToList();

            } 


            catch (Exception ex)
            {
                //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                throw new Exception("Un problème est survenu pour la raison suivante \n" + ex.Message);
            }
                }
    }

    public void UpdateLigneDeCommandeDataSource(List<LigneDeCommande> mesLignesDeCommandes, DataGridView panierGridView)
        {
            using (LibrairieContext context = new LibrairieContext())
            {
                try
                {
                    List<Panier> listePaniers = new List<Panier>();
 
                    foreach (var ligneDeCommande in mesLignesDeCommandes)
                    {
                        //var truc = context.Prixes; 
                        /*var query = (from li in context.LigneDeCommandes
                                     where li.CommandeId == ligneDeCommande.CommandeId 
                                    
                                     join ex in context.Exemplaires on li.ExemplaireId equals ex.Id
                                     where ex.Id == ligneDeCommande.ExemplaireId
                                    
                                     join cou in context.Couters on ex.Id equals cou.ExemplaireId
                                     join pri in context.Prixes on cou.PrixId equals pri.Id
                                     
                                     let maxDate = //context.Prixes
                                     (
                                     (
                                     from r in context.Couters.Include("Prixes")
                                        .Where(l => l.ExemplaireId == ligneDeCommande.ExemplaireId)
                                            select r
                                     ).ToList().Select(p => p.Prixes)
                                     ).ToList()
                                     
                                     .Max(p1 => p1.Date)
                                     where pri.Date == maxDate
                                     join liv in context.Livres on ex.LivreId equals liv.Id
                                   select new Panier
                                   {
                                       Quantite = li.Quantite,
                                       ISBN = ex.ISBN,
                                       Titre = liv.Titre,
                                       Prix = pri.PrixHT
                                   }).Single();*/

                        /***********************************************************************/
/*
                        var query = (from li in context.LigneDeCommandes
                                     where li.CommandeId == ligneDeCommande.CommandeId 
                                    
                                     join ex in context.Exemplaires on li.ExemplaireId equals ex.Id
                                     where ex.Id == ligneDeCommande.ExemplaireId
                                    
                                     join cou in context.Couters on ex.Id equals cou.ExemplaireId
                                     join pri in context.Prixes on cou.PrixId equals pri.Id
                                     
                                     let req = (from r in context.Couters.Include("Prixes")
                                                .Where(l => l.ExemplaireId == ligneDeCommande.ExemplaireId)
                                                select r)
                                     let maxDate = (from re in req 
                                                    select re.Prixes
                                                    ).Max(p1 => p1.Date)
                                     where pri.Date == maxDate
                                     join liv in context.Livres on ex.LivreId equals liv.Id
                                    select new Panier
                                   {
                                       Quantite = li.Quantite,
                                       ISBN = ex.ISBN,
                                       Titre = liv.Titre,
                                       Prix = pri.PrixHT
                                   }).Single();
                        */

                       var  requete = (from r in context.Couters.Include("Prixes")
                            .Where(l => l.ExemplaireId == ligneDeCommande.ExemplaireId)
                            select r);

                       var  date = (from re in requete
                            select re.Prixes
                            ).Max(p1 => p1.Date);

                       var query = (from li in context.LigneDeCommandes
                                    where li.CommandeId == ligneDeCommande.CommandeId

                                    join ex in context.Exemplaires on li.ExemplaireId equals ex.Id
                                    where ex.Id == ligneDeCommande.ExemplaireId

                                    join cou in context.Couters on ex.Id equals cou.ExemplaireId
                                    join pri in context.Prixes on cou.PrixId equals pri.Id

                                    where pri.Date == date

                                    join liv in context.Livres on ex.LivreId equals liv.Id

                                    select new
                                    {
                                        ExemplaireId = ex.Id,
                                        Quantite = li.Quantite,
                                        ISBN = ex.ISBN,
                                        Titre = liv.Titre,
                                        PrixHT = pri.PrixHT,
                                        TVA = pri.TVA,
                                        PrixTTC = pri.PrixHT * ((decimal)1 + pri.TVA / (decimal)100)
                                    })
                        .ToList()
                        .Select(x => new Panier
                        {
                            ExemplaireId = x.ExemplaireId,
                            Quantite = x.Quantite,
                            ISBN = x.ISBN,
                            Titre = x.Titre,
                            PrixHT = x.PrixHT,
                            TVA = x.TVA,
                            PrixTTC = x.PrixHT * ((decimal)1 + x.TVA / (decimal)100)
                        }
                        ).Single();



                        listePaniers.Add(query);

                    }
                   

                    panierGridView.DataSource = listePaniers;

                    panierGridView.Columns[0].DataPropertyName = "Quantite";
                    panierGridView.Columns[1].DataPropertyName = "ISBN";
                    panierGridView.Columns[2].DataPropertyName = "Titre";
                    panierGridView.Columns[3].DataPropertyName = "PrixHT";
                    panierGridView.Columns[4].DataPropertyName = "TVA";
                    panierGridView.Columns[5].DataPropertyName = "PrixTTC";
                 /*   int i = 0; 
                    foreach (var item in listePaniers)
                    {
                        MessageBox.Show(string.Format("Commande id {0}, Exemplaire id {1}", mesLignesDeCommandes[i].CommandeId, mesLignesDeCommandes[i].ExemplaireId));
                        i++;

                    }
                       var query1  = from p in context.Prixes
                              let maxDate = context.Prixes.Max(p1 => p1.Date)
                    where p.Date == maxDate
                    select p;
                var q1 = query1.ToList(); 
                
                var query2 = from u in context.Prixes
                    where u.Date == (context.Prixes.Max(p1 => p1.Date))
                    select u;
                var q2 = query2.ToList();
                     */
                }
                catch (Exception ex)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + ex.Message);
                }
            }
        }


        public List<Commande> AllCommandes()
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var r = context.Commandes.ToList();
                    return r ;
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public List<Rubrique> AllRubriques()
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Rubriques.ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public List<StatusDeCommande> AllStatusDeCommandes()
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.StatutDeCommandes.ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

       



        public void CreateCommande(Commande commande)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(commande).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void CreatePrix(Prix prix)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(prix).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void CreateCouter(Couter couter)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(couter).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        
        
        public void CreateRubrique(Rubrique rubrique)
        {
            using (var context = new LibrairieContext())
            {
                try
                {

                    var requete =
                        context.Rubriques.Where(a => a.Nom == rubrique.Nom).ToList();
                    // Teste si le mot clé existe déjà, s'il existe déjà on n'ajoute pas de nouveau mot clé
                    if (requete.Count != 0)
                        return;

                    context.Entry(rubrique).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void DeleteAppartenir1(Appartenir1 appartenir1)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(appartenir1).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }


        public void CreateAppartenir1(Appartenir1 appartenir1)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(appartenir1).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }


        public StatusDeCommande FindStatusDeCommande(int sId)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var r = from e in context.StatutDeCommandes
                            where e.Id == sId
                            select e;
                    return r.Single();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public ModeDePaiement FindModeDePaiement(int mId)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var r = from e in context.ModeDePaiements
                            where e.Id == mId
                            select e;
                    return r.Single();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public Utilisateur FindUtilisateur(int uId)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var r = from e in context.Utilisateurs
                            where e.Id == uId
                            select e;
                    return r.Single();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public Appartenir1 FindAppartenir1(int rId, int lId)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var r = from e in context.Appartenir1s
                            where e.RubriqueId == rId && e.LivreId == lId
                            select e;
                    return r.First();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        

        // *********************************************************** // 
        public List<Utilisateur> AllUtilisateurs()
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Utilisateurs.ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        
        public List<MotCle> AllMotCles()
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.MotCles.ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public List<MotCle> FindMotCles(Livre livre)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        from i in context.Taggers.Include("MotCle")
                            .Where(l => l.LivreId == livre.Id)
                        select i;

                    var taggers = requete.ToList();
                    return taggers.Select(e => e.MotCle).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void CreateMotCle(MotCle motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {

                    var requete =
                        context.MotCles.Where(a => a.Nom == motCle.Nom).ToList();
                    // Teste si le mot clé existe déjà, s'il existe déjà on n'ajoute pas de nouveau mot clé
                    if (requete.Count != 0)
                        return;

                    context.Entry(motCle).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void DeleteTagger(Tagger tagger)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(tagger).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }


        public void CreateTagger(Tagger tagger)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(tagger).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }



        public Tagger FindTagger(int mId, int lId)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var r = from e in context.Taggers
                            where e.MotCleId == mId && e.LivreId == lId
                            select e;
                    return r.First();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des mots clés
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }


        /**************************************/
 
        public Rubrique FindRubrique(string motCle)
        {
           using (var context = new LibrairieContext())
            {
                try
                {
                    Rubrique rubrique = context.Rubriques.SingleOrDefault(e => e.Nom.ToString().Trim().ToUpper().Contains(motCle.ToString().Trim().ToUpper()));
                    return rubrique;
                }
                catch (Exception ex)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + ex.Message);
                }
            }
        }

        /**************************************/
        public List<Utilisateur> RechercheUtilisateurs(string motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Utilisateurs
                        .Where(
                            e =>
                                e.Nom.ToUpper().Contains(motCle.ToUpper())
                                ||
                                e.Prenom.ToUpper().Contains(motCle.ToUpper())
                                ).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }


        public List<Commande> RechercheCommande(string motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Commandes
                        .Where(
                            e =>
                                e.Id.ToString().ToUpper().Contains(motCle.ToUpper())
                                ).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public List<StatusDeCommande> RechercheStatusDeCommandes(string motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.StatutDeCommandes
                        .Where(
                            e =>
                                e.Nom.ToUpper().Contains(motCle.ToUpper())
                                ).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public List<ModeDePaiement> RechercheModeDePaiements(string motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.ModeDePaiements
                        .Where(
                            e =>
                                e.Type.ToUpper().Contains(motCle.ToUpper())
                                ).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public List<Rubrique> RechercheRubriques(string motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Rubriques
                        .Where(
                            e =>
                                e.Nom.ToUpper().Contains(motCle.ToUpper())
                                ).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public List<Exemplaire> RechercheExemplaires(string motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Exemplaires
                        .Where(
                            e =>
                                e.ISBN.ToUpper().Contains(motCle.ToUpper()) ||
                                e.Type.ToUpper().Contains(motCle.ToUpper())  
                                ).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public List<Livre> RechercheLivres(string motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Livres
                        .Where(
                            e =>
                                e.Titre.ToUpper().Contains(motCle.ToUpper())
                                ||
                                e.SousTitre.ToUpper().Contains(motCle.ToUpper())
                                ||
                                e.Theme.ToUpper().Contains(motCle.ToUpper())
                                ).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public List<MotCle> RechercheMotCle(string motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.MotCles
                        .Where(
                            e =>e.Nom.ToUpper().Contains(motCle.ToUpper())
                                ).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }



        public List<Auteur> RechercheAuteurs(string motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Auteurs
                        .Where(
                            e =>
                                e.Nom.ToUpper().Contains(motCle.ToUpper())
                                 ||
                                e.Prenom.ToUpper().Contains(motCle.ToUpper())                               
                                ).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public List<Exemplaire> AllExemplaires()
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Exemplaires.ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public List<ModeDePaiement> AllModeDePaiements()
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.ModeDePaiements.ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public List<Livre> AllLivres()
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Livres.ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public List<Auteur> AllAuteurs()
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Auteurs.ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public List<Editeur> AllEditeurs()
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    return context.Editeurs.ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }


        public List<Editeur> FindEditeurs(Livre livre)
        {
            using (var context = new LibrairieContext())
            {
                try
                {

                    var r =
                        from i in context.Exemplaires.Include("Editeur")
                            .Where(e => e.LivreId == livre.Id)
                        select i;

                    var exemplaires = r.ToList();


                   /* var requete =
                        from i in context.Exemplaires.Include("Editeur")
                            .Where(e => e.EditeurId == exemplaire.Id)
                        select i;

                    var exemplaires = requete.ToList();*/
                    return exemplaires.Select(e => e.Editeur).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public List<Auteur> FindAuteurs(Livre livre)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        from i in context.Ecrires.Include("Auteur")
                            .Where(l => l.LivreId == livre.Id)
                        select i;

                    var ecrires = requete.ToList();
                    return ecrires.Select(e => e.Auteur).ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiche si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public List<Exemplaire> FindExemplaire(int livreId)
        {
            using (LibrairieContext context = new LibrairieContext())
            {
                try
                {
                    var requete = (from e in context.Exemplaires
                        where e.LivreId == livreId
                        select e).ToList();

                    return requete;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        

        
        public List<Prix> FindPrixes(int eId)
        {
            using (LibrairieContext context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        from i in context.Couters.Include("Prixes")
                            .Where(l => l.ExemplaireId == eId)
                        select i;

                    var couters = requete.ToList();
                    return couters.Select(e => e.Prixes).ToList();

                   /* var requete =
                        from i in context.Ecrires.Include("Auteur")
                            .Where(l => l.LivreId == livre.Id)
                    select i;

                    var ecrires = requete.ToList();
                    return ecrires.Select(e => e.Auteur).ToList();*/

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public void CreateStatusDeCommande(StatusDeCommande statusDeCommande)
        {
            using (var context = new LibrairieContext())
            {
                try
                {

                    var requete =
                        context.StatutDeCommandes.Where(e => e.Nom == statusDeCommande.Nom).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on n'ajoute pas de nouveau livre
                    if (requete.Count != 0)
                        return;

                    context.Entry(statusDeCommande).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        
        public void CreateModeDePaiement(ModeDePaiement modeDePaiement)
        {
            using (var context = new LibrairieContext())
            {
                try
                {

                    var requete =
                        context.ModeDePaiements.Where(e => e.Type == modeDePaiement.Type).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on n'ajoute pas de nouveau livre
                    if (requete.Count != 0)
                        return;

                    context.Entry(modeDePaiement).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        
        public void CreateEditeur(Editeur editeur)
        {
            using (var context = new LibrairieContext())
            {
                try
                {

                    var requete =
                        context.Editeurs.Where(e=> e.Nom == editeur.Nom).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on n'ajoute pas de nouveau livre
                    if (requete.Count != 0)
                        return;

                    context.Entry(editeur).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void CreateLivre(Livre livre)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    
                    var requete =
                        context.Livres.Where(l => l.Titre == livre.Titre && l.SousTitre == livre.SousTitre).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on n'ajoute pas de nouveau livre
                    if (requete.Count != 0)
                        return;

                    context.Entry(livre).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void CreateAuteur(Auteur auteur)
        {
            using (var context = new LibrairieContext())
            {
                try
                {

                    var requete =
                        context.Auteurs.Where(a => a.Nom == auteur.Nom && a.Prenom == auteur.Prenom).ToList();
                    // Teste si l'auteur existe déjà, s'il existe déjà on n'ajoute pas de nouveau auteur
                    if (requete.Count != 0)
                        return;

                    context.Entry(auteur).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void CreateExemplaire(Exemplaire exemplaire)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(exemplaire).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void UpdateStatusDeCommande(StatusDeCommande statusDeCommande)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        context.StatutDeCommandes.Where(l => l.Nom == statusDeCommande.Nom).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on ne peut pas faire la modification
                    if (requete.Count != 0)
                        return;
                    context.Entry(statusDeCommande).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void UpdateModeDePaiement(ModeDePaiement modeDePaiement)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        context.ModeDePaiements.Where(l => l.Type == modeDePaiement.Type).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on ne peut pas faire la modification
                    if (requete.Count != 0)
                        return;
                    context.Entry(modeDePaiement).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void UpdateRubrique(Rubrique rubrique)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        context.Rubriques.Where(l => l.Nom == rubrique.Nom).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on ne peut pas faire la modification
                    if (requete.Count != 0)
                        return;
                    context.Entry(rubrique).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        
        public void UpdateLivre(Livre livre)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        context.Livres.Where(l => l.Titre == livre.SousTitre && livre.Titre == livre.SousTitre).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on ne peut pas faire la modification
                    if (requete.Count != 0)
                        return;
                    context.Entry(livre).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void UpdateMotCle(MotCle motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        context.MotCles.Where(l => l.Nom == motCle.Nom).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on ne peut pas faire la modification
                    if (requete.Count != 0)
                        return;
                    context.Entry(motCle).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void UpdateAuteur(Auteur auteur)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var requete =
                        context.Auteurs.Where(l => l.Nom == auteur.Nom && l.Prenom == auteur.Prenom).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on ne peut pas faire la modification
                    if (requete.Count != 0)
                        return;
                    context.Entry(auteur).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void UpdatePrix(Prix prix)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    /*var requete =
                        context.Exemplaires.Where(e => e.ISBN == exemplaire.ISBN && e.Type == exemplaire.Type).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on ne peut pas faire la modification
                    if (requete.Count != 0)
                        return;*/
                    context.Entry(prix).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void UpdateCouter(Couter couter)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(couter).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void UpdateExemplaire(Exemplaire exemplaire)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    /*var requete =
                        context.Exemplaires.Where(e => e.ISBN == exemplaire.ISBN && e.Type == exemplaire.Type).ToList();
                    // Teste si le livre existe déjà, s'il existe déjà on ne peut pas faire la modification
                    if (requete.Count != 0)
                        return;*/
                    context.Entry(exemplaire).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void DeleteStatusDeCommande(StatusDeCommande statusDeCommande)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(statusDeCommande).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void DeleteModeDePaiement(ModeDePaiement modeDePaiement)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(modeDePaiement).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void DeleteRubrique(Rubrique rubrique)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(rubrique).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void DeleteMotCle(MotCle motCle)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(motCle).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void DeleteLivre(Livre livre)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(livre).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void DeleteAuteur(Auteur auteur)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(auteur).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public List<Ecrire> AllEcrire()
        {
            using (var context = new LibrairieContext())
            {
                try
                {   
                    // retourne la table de jointure complète entre Livre et Auteur
                    return context.Ecrires.Include("Livre").Include("Auteur").ToList();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }



        public void CreateEcrire(Ecrire ecrire)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(ecrire).State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }


        public Couter FindCouter(int eId, int pId)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var r = from c in context.Couters
                            where c.PrixId == pId && c.ExemplaireId == eId
                            select c;
                    return r.First();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public Ecrire FindEcrire(int aId, int lId)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                   var r = from e in context.Ecrires 
                       where e.AuteurId == aId && e.LivreId == lId
                    select e;
                    return r.First();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
       public Exemplaire FindExemplaireSuppression(int editeurId, int livreId)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    var r = from e in context.Exemplaires
                        where e.EditeurId == editeurId && e.LivreId == livreId 
                    select e;
                    return r.Single(); // Single instead of first
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }

        public void DeleteEcrire(Ecrire ecrire)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(ecrire).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }
        public void DeleteExemplaire(Exemplaire exemplaire)
        {
            using (var context = new LibrairieContext())
            {
                try
                {
                    context.Entry(exemplaire).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    //Ce message sera affiché si un probleme survient lors du chargement de la liste des etudiants
                    throw new Exception("Un problème est survenu pour la raison suivante \n" + e.Message);
                }
            }
        }



    }
}
