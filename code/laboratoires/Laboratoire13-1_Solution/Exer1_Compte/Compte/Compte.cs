using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    public class Compte
    {
        // --- Propriétés ---

        // Solde du compte (lecture seule à l’extérieur)
        public double Solde { get; private set; }

        // Nom du propriétaire du compte
        public string Proprietaire { get; set; }


        // --- Constructeurs ---

        // Constructeur par défaut
        public Compte()
        {
            Solde = 0;
            Proprietaire = "Inconnu";
        }

        // Constructeur avec propriétaire défini
        public Compte(string proprietaire)
        {
            Solde = 0;
            Proprietaire = proprietaire;
        }


        // --- Méthodes publiques ---

        // Déposer un montant positif
        public void Deposer(double montant)
        {
            if (montant > 0)
            {
                Solde += montant;
            }
        }

        // Retirer un montant si le solde est suffisant
        public bool Retirer(double montant)
        {
            if (montant > 0 && montant <= Solde)
            {
                Solde -= montant;
                return true;
            }
            return false;
        }

        // Réinitialiser le compte
        public void Reinitialiser()
        {
            Solde = 0;
        }
    }
}
