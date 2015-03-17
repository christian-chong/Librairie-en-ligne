using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.Win32;

namespace DAL
{
    public class LibrairieInitializer :  DropCreateDatabaseAlways <LibrairieContext>
        //DropCreateDatabaseIfModelChanges<LibrairieContext>
    //  
    {
        protected override void Seed(LibrairieContext context)
        {


            List<StatusDeCommande> statusDeCommandes = new List<StatusDeCommande>
            {
                new StatusDeCommande {Nom = "En cours de validation"},
                new StatusDeCommande {Nom = "Validée"},
                new StatusDeCommande {Nom = "En cours de préparation"},
                new StatusDeCommande {Nom = "Expédié : En cours de livraison"},
                new StatusDeCommande {Nom = "Receptionner"}
            };
            statusDeCommandes.ForEach(u => context.StatutDeCommandes.Add(u));
            context.SaveChanges();
            List<ModeDePaiement> modeDePaiements = new List<ModeDePaiement>
            {
                new ModeDePaiement {Type = "Carte bleue"},
                new ModeDePaiement {Type = "Chèque"},
                new ModeDePaiement {Type = "Paypal"},
                new ModeDePaiement {Type = "Espèce"},
                new ModeDePaiement {Type = "Virement"}
            };
            modeDePaiements.ForEach(u => context.ModeDePaiements.Add(u));
            context.SaveChanges();



            List<Utilisateur> utilisateurs = new List<Utilisateur>
            {
                new Utilisateur
                {
                    Nom = "Chong",
                    Prenom = "Christian",
                    Telephone = "0123456789",
                    Email = "christian.chong@mail.com",
                    DateAdhesion = new DateTime(2010, 04, 13),
                    MotDePasse = "xxxx",
                    Activite = true
                },
                new Utilisateur
                {
                    Nom = "Deiva",
                    Prenom = "Alain",
                    Telephone = "2340156789",
                    Email = "deiva@mail.com",
                    DateAdhesion = new DateTime(2012, 08, 10),
                    MotDePasse = "motdepasse",
                    Activite = true
                },
                new Utilisateur
                {
                    Nom = "Degueldre",
                    Prenom = "Michèle",
                    Telephone = "2154576789",
                    Email = "m.de@mail.com",
                    DateAdhesion = new DateTime(2010, 01, 18),
                    MotDePasse = "mdp",
                    Activite = true
                },
                new Utilisateur
                {
                    Nom = "Kabamba",
                    Prenom = "Jean-Claude",
                    Telephone = "2340156478",
                    Email = "KabambaJC@mail.com",
                    DateAdhesion = new DateTime(2011, 04, 21),
                    MotDePasse = "mmmm",
                    Activite = true
                }
            };
            utilisateurs.ForEach(u => context.Utilisateurs.Add(u));
            context.SaveChanges();


            List<Livre> livres = new List<Livre>
            {
                new Livre
                {
                    Titre = "Nutshell : C sharp",
                    SousTitre = "C#",
                    Theme = "Informatique",
                    Resume = "Livre de référence pour la programmation C# ..."
                },
                new Livre
                {
                    Titre = "JAVA",
                    SousTitre = "Par la pratique",
                    Theme = "Informatique",
                    Resume = "Livre d'apprentissage de la programmation JAVA par la pratique ..."
                },
                new Livre
                {
                    Titre = "L'histoire de france",
                    SousTitre = "XVIII - XIX ème siècle",
                    Theme = "Histoire",
                    Resume = "On n'y trouve l'histoire de france détaillé ..."
                },
                new Livre
                {
                    Titre = "Bienvenue a Gattaca",
                    SousTitre = "Hello there",
                    Theme = "Roman",
                    Resume = "Histoire irréaliste au coeur d'une ville mouvante ..."
                },
                new Livre
                {
                    Titre = "La valée des loups",
                    SousTitre = "Lassie",
                    Theme = "Roman",
                    Resume = "Histoire en campagne d'un terrible drame ..."
                }
            };
            livres.ForEach(l => context.Livres.Add(l));
            context.SaveChanges();

            List<Auteur> auteurs = new List<Auteur>
            {
                new Auteur
                {
                    Nom = "Hugo",
                    Prenom = "Victor"
                },
                new Auteur
                {
                    Nom = "Balzac",
                    Prenom = "Honoré"
                },
                new Auteur
                {
                    Nom = "Poquelin",
                    Prenom = "Jean-Baptiste"
                },
                new Auteur
                {
                    Nom = "King",
                    Prenom = "Stephen"
                },
                new Auteur
                {
                    Nom = "Dumas",
                    Prenom = "Alexandre"
                }
            };
            auteurs.ForEach(a => context.Auteurs.Add(a));
            context.SaveChanges();

            List<Ecrire> ecrires = new List<Ecrire>
            {
                new Ecrire
                {
                    LivreId = 1,
                    AuteurId = 1
                },
                new Ecrire
                {
                    LivreId = 2,
                    AuteurId = 2
                },
                new Ecrire
                {
                    LivreId = 2,
                    AuteurId = 1
                },
                new Ecrire
                {
                    LivreId = 3,
                    AuteurId = 3
                },
                new Ecrire
                {
                    LivreId = 4,
                    AuteurId = 4
                },
                new Ecrire
                {
                    LivreId = 5,
                    AuteurId = 5
                }
            };
            ecrires.ForEach(e => context.Ecrires.Add(e));
            context.SaveChanges();

            List<Editeur> editeurs = new List<Editeur>
            {
                new Editeur {Nom = "DUNOD"},
                new Editeur {Nom = "EYROLLES"},
                new Editeur {Nom = "POCHE"},
                new Editeur {Nom = "FLAMMARION"},
                new Editeur {Nom = "LAROUSSE"}
            };

            editeurs.ForEach(e => context.Editeurs.Add(e));
            context.SaveChanges();

            List<Exemplaire> exemplaires = new List<Exemplaire>
            {
                new Exemplaire
                {
                    LivreId = 1,
                    EditeurId = 1,
                    ISBN = "100",
                    Type = "poche",
                    Stock = 10,
                    Pages = 200,
                    URLimage = "../../Images/livre1.jpg",
                    DateEdition = new DateTime(2005, 10, 10)
                },
                new Exemplaire
                {
                    LivreId = 1,
                    EditeurId = 2,
                    ISBN = "123",
                    Type = "broché",
                    Stock = 1,
                    Pages = 214,
                    URLimage = "../../Images/livre1.jpg",
                    DateEdition = new DateTime(2005, 12, 10)
                },
                new Exemplaire
                {
                    LivreId = 2,
                    EditeurId = 3,
                    ISBN = "110",
                    Type = "Broché",
                    Stock = 20,
                    Pages = 250,
                    URLimage = "../../Images/livre2.jpg",
                    DateEdition = new DateTime(2003, 10, 5)
                },
                new Exemplaire
                {
                    LivreId = 2,
                    EditeurId = 4,
                    ISBN = "10",
                    Type = "Numérique",
                    Stock = 54,
                    Pages = 120,
                    URLimage = "../../Images/livre2.jpg",
                    DateEdition = new DateTime(2003, 5, 5)
                },
                new Exemplaire
                {
                    LivreId = 3,
                    EditeurId = 5,
                    ISBN = "120",
                    Type = "numérique",
                    Stock = 25,
                    Pages = 150,
                    URLimage = "../../Images/livre3.jpg",
                    DateEdition = new DateTime(2004, 12, 31)
                },
                new Exemplaire
                {
                    LivreId = 3,
                    EditeurId = 1,
                    ISBN = "145",
                    Type = "numérique",
                    Stock = 10,
                    Pages = 132,
                    URLimage = "../../Images/livre3.jpg",
                    DateEdition = new DateTime(2004, 7, 27)
                },
                new Exemplaire
                {
                    LivreId = 4,
                    EditeurId = 2,
                    ISBN = "130",
                    Type = "poche",
                    Stock = 5,
                    Pages = 100,
                    URLimage = "../../Images/livre4.jpg",
                    DateEdition = new DateTime(2010, 05, 03)
                },
                new Exemplaire
                {
                    LivreId = 4,
                    EditeurId =3,
                    ISBN = "84",
                    Type = "broché",
                    Stock = 7,
                    Pages = 74,
                    URLimage = "../../Images/livre4.jpg",
                    DateEdition = new DateTime(2010, 04, 07)
                },
                new Exemplaire
                {
                    LivreId = 5,
                    EditeurId =4,
                    ISBN = "140",
                    Type = "poche",
                    Stock = 2,
                    Pages = 20,
                    URLimage = "../../Images/livre5.jpg",
                    DateEdition = new DateTime(2015, 02, 03)
                },
                new Exemplaire
                {
                    LivreId = 5,
                    EditeurId = 5,
                    ISBN = "63",
                    Type = "poche",
                    Stock = 6,
                    Pages = 15,
                    URLimage = "../../Images/livre5.jpg",
                    DateEdition = new DateTime(2014, 02, 03)
                } /*****/

            };
            exemplaires.ForEach(e => context.Exemplaires.Add(e));
            context.SaveChanges();

            List<Prix> prixes = new List<Prix>
            {
                new Prix
                {
                    Date = new DateTime(2010, 01, 01),
                    PrixHT = 10,
                    TVA = 5
                },
                new Prix
                {
                    Date = new DateTime(2010, 01, 02),
                    PrixHT = (decimal) 12.3,
                    TVA = 5
                },
                new Prix
                {
                    Date = new DateTime(2010, 01, 03),
                    PrixHT = (decimal) 14.4,
                    TVA = 5
                },
                new Prix
                {
                    Date = new DateTime(2010, 01, 04),
                    PrixHT = (decimal) 15.5,
                    TVA = 5
                },
                new Prix
                {
                    Date = new DateTime(2010, 01, 05),
                    PrixHT = (decimal) 16.6,
                    TVA = 5
                },
                new Prix
                {
                    Date = new DateTime(2010, 01, 06),
                    PrixHT = (decimal) 17.5,
                    TVA = 5
                },
                new Prix
                {
                    Date = new DateTime(2010, 01, 07),
                    PrixHT = (decimal) 18.9,
                    TVA = 5
                },
                new Prix
                {
                    Date = new DateTime(2010, 01, 08),
                    PrixHT = (decimal) 19.21,
                    TVA = 6
                },
                new Prix
                {
                    Date = new DateTime(2010, 01, 09),
                    PrixHT = (decimal) 21.21,
                    TVA = 6
                },
                new Prix
                {
                    Date = new DateTime(2010, 01, 10),
                    PrixHT = (decimal) 26.21,
                    TVA = 6
                }
            };
            prixes.ForEach(u => context.Prixes.Add(u));
            context.SaveChanges();

            List<Couter> couters = new List<Couter>
            {
                new Couter
                {
                    ExemplaireId = 1,
                    PrixId = 1
                },
                new Couter
                {
                    ExemplaireId = 1,
                    PrixId = 3,
                },
                new Couter
                {
                    ExemplaireId = 2,
                    PrixId = 2
                },
                new Couter
                {
                    ExemplaireId = 3,
                    PrixId = 3
                },
                new Couter
                {
                    ExemplaireId = 4,
                    PrixId = 4
                },
                new Couter
                {
                    ExemplaireId = 5,
                    PrixId = 5
                },
                new Couter
                {
                    ExemplaireId = 6,
                    PrixId = 6
                },
                new Couter
                {
                    ExemplaireId = 7,
                    PrixId = 7
                },
                new Couter
                {
                    ExemplaireId = 8,
                    PrixId = 8
                },
                new Couter
                {
                    ExemplaireId = 9,
                    PrixId = 9
                },
                new Couter
                {
                    ExemplaireId = 10,
                    PrixId = 10
                }
            };
            couters.ForEach(e => context.Couters.Add(e));
            context.SaveChanges();


            List<Rubrique> rubriques = new List<Rubrique>
            {
                new Rubrique {Nom = "Coup de coeur"},
                new Rubrique {Nom = "Nouveautés"},
                new Rubrique {Nom = "Promotion"}
            };
            rubriques.ForEach(u => context.Rubriques.Add(u));
            context.SaveChanges();

            List<Appartenir1> appartenir1s = new List<Appartenir1>
            {
                new Appartenir1()
                {
                    LivreId = 1,
                    RubriqueId = 1
                },
                new Appartenir1()
                {
                    LivreId = 2,
                    RubriqueId = 1
                },
                new Appartenir1()
                {
                    LivreId = 3,
                    RubriqueId = 2
                },
                new Appartenir1()
                {
                    LivreId = 4,
                    RubriqueId = 3
                },
                new Appartenir1()
                {
                    LivreId = 5,
                    RubriqueId = 2
                },
                new Appartenir1()
                {
                    LivreId = 1,
                    RubriqueId = 2
                },
                new Appartenir1()
                {
                    LivreId = 2,
                    RubriqueId = 2
                },
            };
            appartenir1s.ForEach(e => context.Appartenir1s.Add(e));
            context.SaveChanges();


            List<Commande> commandes = new List<Commande>
            {
                new Commande()
                {
                    ModeDePaiementId = 1,
                    StatutDeCommandeId = 1,
                    UtilisateurId = 1,
                    Date = new DateTime(2015, 01, 01)
                },
                new Commande()
                {
                    ModeDePaiementId = 2,
                    StatutDeCommandeId = 2,
                    UtilisateurId = 2,
                    Date = new DateTime(2015, 01, 02)
                },
                new Commande()
                {
                    ModeDePaiementId = 3,
                    StatutDeCommandeId = 3,
                    UtilisateurId = 3,
                    Date = new DateTime(2015, 01, 03)
                },
                new Commande()
                {
                    ModeDePaiementId = 4,
                    StatutDeCommandeId = 4,
                    UtilisateurId = 4,
                    Date = new DateTime(2015, 01, 04)
                },
                new Commande()
                {
                    ModeDePaiementId = 5,
                    StatutDeCommandeId = 5,
                    UtilisateurId = 1,
                    Date = new DateTime(2015, 01, 05)
                }
            };
            commandes.ForEach(e => context.Commandes.Add(e));
            context.SaveChanges();


            List<LigneDeCommande> ligneDeCommandes = new List<LigneDeCommande>
            {
                new LigneDeCommande()
                {
                    CommandeId = 1,
                    ExemplaireId = 1,
                    Quantite = 1
                },
                new LigneDeCommande()
                {
                    CommandeId = 1,
                    ExemplaireId = 6,
                    Quantite = 1
                },
                new LigneDeCommande()
                {
                    CommandeId = 2,
                    ExemplaireId = 10,
                    Quantite = 1
                },
                new LigneDeCommande()
                {
                    CommandeId = 2,
                    ExemplaireId = 5,
                    Quantite = 1
                },
                new LigneDeCommande()
                {
                    CommandeId = 3,
                    ExemplaireId = 3,
                    Quantite = 1
                },
                new LigneDeCommande()
                {
                    CommandeId = 3,
                    ExemplaireId = 8,
                    Quantite = 1
                },
                new LigneDeCommande()
                {
                    CommandeId = 4,
                    ExemplaireId = 7,
                    Quantite = 1
                },
                new LigneDeCommande()
                {
                    CommandeId = 4,
                    ExemplaireId = 3,
                    Quantite = 1
                },
                new LigneDeCommande()
                {
                    CommandeId = 5,
                    ExemplaireId = 4,
                    Quantite = 1
                },
                new LigneDeCommande()
                {
                    CommandeId = 5,
                    ExemplaireId = 5,
                    Quantite = 1
                }

            };
            ligneDeCommandes.ForEach(e => context.LigneDeCommandes.Add(e));
            context.SaveChanges();
        }
    }
}
