using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    public class Compte
    {
        public double Solde { get; private set; }

        public string Proprietaire { get; set; }

        public Compte()
        {
            Solde = 0.0;
            Proprietaire = "Inconnu";
        }

        public Compte(string proprietaire)
        {
            Solde = 0.0;
            Proprietaire = proprietaire;
        }

        public void Deposer(double montant)
        {
            if (montant > 0.0)
            {
                Solde += montant;
            }
        }

        public bool Retirer(double montant)
        {
            if (montant > 0.0 && montant <= Solde)
            {
                Solde -= montant;
                return true;
            }

            return false;
        }

        public void Reinitialiser()
        {
            Solde = 0.0;
        }
    }
}
