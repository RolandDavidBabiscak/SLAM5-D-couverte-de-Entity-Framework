using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Entities; // Remplace par le namespace correct

namespace WinFormsApp1
{
    public static class Modele
    {
        private static BabicsakRolandPartitionContext monModel;  // Contexte de la base de données

        // Initialisation du contexte
        public static void Init()
        {
            monModel = new BabicsakRolandPartitionContext();
        }

        // Méthode pour obtenir la liste des clients
        public static List<Client> ListeClients()
        {
            return monModel.Clients.ToList();
        }

        // Méthode pour obtenir la liste des commandes
        public static List<Commande> ListeCommandes()
        {
            return monModel.Commandes.Include(c => c.NumcliNavigation).ToList();
        }

        // Méthode pour obtenir les commandes d'un client spécifique
        public static List<Commande> ListeCommandesParClient(int idClient)
        {
            return monModel.Commandes
                .Where(p => p.Numcli == idClient)
                .Include(p => p.NumcliNavigation)
                .ToList();
        }

        // Méthode pour obtenir la liste des partitions
        public static List<Partition> ListePartitions()
        {
            return monModel.Partitions.Include(p => p.Style).ToList();
        }

        // Méthode pour ajouter une nouvelle commande
        public static bool AjoutCommande(decimal montant, DateTime dateC, int idClient)
        {
            try
            {
                Commande maCommande = new Commande
                {
                    Montantcde = montant,
                    Datecde = dateC, // Assurez-vous que la date est en DateTime
                    Numcli = idClient
                };
                monModel.Commandes.Add(maCommande); // Ajout de l'objet à la base de données
                monModel.SaveChanges(); // Sauvegarde les changements
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false; // Retourne false en cas d'erreur
            }
        }

        // Méthode pour récupérer une commande par son ID
        public static Commande RecupererCommande(int idCommande)
        {
            try
            {
                return monModel.Commandes
                    .Include(c => c.Numparts)
                    .FirstOrDefault(x => x.Numcde == idCommande);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; // Retourne null en cas d'erreur
            }
        }

        // Méthode pour modifier une commande existante
        public static bool ModifierCommande(int idCde, decimal montant, DateTime dateC, int idClient)
        {
            try
            {
                var maCommande = RecupererCommande(idCde); // Récupération de la commande existante
                if (maCommande != null)
                {
                    maCommande.Montantcde = montant; // Mise à jour des propriétés
                    maCommande.Datecde = dateC;
                    maCommande.Numcli = idClient;

                    monModel.Commandes.Update(maCommande); // Met à jour l'objet dans le contexte
                    monModel.SaveChanges(); // Sauvegarde les changements
                    return true;
                }
                return false; // Commande non trouvée
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false; // Retourne false en cas d'erreur
            }
        }
    }
}
