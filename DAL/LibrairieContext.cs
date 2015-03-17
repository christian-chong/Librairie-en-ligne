using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class LibrairieContext : DbContext
    {
        public LibrairieContext() : base("LibrairieContext") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        } 

        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Appartenir1> Appartenir1s { get; set; }
        public DbSet<Appartenir2> Appartenir2s { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Aviser> Avisers { get; set; }
        public DbSet<CategorieUtilisateur> CategorieUtilisateurs { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Couter> Couters { get; set; }
        public DbSet<Ecrire> Ecrires { get; set; }
        public DbSet<Editeur> Editeurs { get; set; }
        public DbSet<Exemplaire> Exemplaires { get; set; }
        public DbSet<LigneDeCommande> LigneDeCommandes  { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<ModeDePaiement> ModeDePaiements { get; set; }
        public DbSet<Modification> Modifications { get; set; }
        public DbSet<MotCle> MotCles { get; set; }
        public DbSet<Posseder1> Posseder1s  { get; set; }
        public DbSet<Prix> Prixes  { get; set; }
        public DbSet<Rubrique> Rubriques  { get; set; }
        public DbSet<StatusDeCommande> StatutDeCommandes  { get; set; }
        public DbSet<Tagger> Taggers  { get; set; }
        public DbSet<Utilisateur> Utilisateurs  { get; set; }

        public System.Data.Entity.DbSet<DAL.Models.Panier> Paniers { get; set; }

        //public System.Data.Entity.DbSet<DAL.Models.Panier> Paniers { get; set; }

        //public System.Data.Entity.DbSet<DAL.Models.ExemplairePrix> ExemplairePrixes { get; set; }

        //public System.Data.Entity.DbSet<DAL.Models.SessionCommande> SessionCommandes { get; set; }
       
    }
}
