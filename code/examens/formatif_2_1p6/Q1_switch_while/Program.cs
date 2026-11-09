namespace Q1_switch_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Question 1 - Switch et boucle (10 pts) - Temps suggéré : 20 minutes

                Le café étudiant veut une petite caisse. L'employé entre les articles un à la fois
                et le programme calcule le total de la commande.

                Écrivez un programme qui :
                    - Demande un choix à répétition avec une boucle while ou do... while, jusqu'à ce que l'employé entre 4.
                    - Utilise un switch case pour ajouter le prix de l'article au total.
                    - Affiche "Choix invalide." pour tout autre choix.
                    - Utilise int.TryParse pour lire le choix : le programme ne doit pas planter si on entre du texte.
                    - Affiche le total à payer à la fin.

                Rappel : si la conversion échoue, TryParse donne la valeur 0 à la variable.

                --- Affichage attendu ---
                1. Café (2,50 $)
                2. Muffin (3,25 $)
                3. Biscuit (1,75 $)
                4. Terminer la commande
                Votre choix : 1
                Votre choix : 2
                Votre choix : abc
                Choix invalide.
                Votre choix : 7
                Choix invalide.
                Votre choix : 1
                Votre choix : 4
                Total à payer : 8,25 $
                =====================================================================================================================

                Grille de pointage :

                1. Boucle ............................................................... /3
                    → Structure adéquate, le programme s'arrête quand le choix vaut 4

                2. Switch case .......................................................... /3
                    → Un cas par article, cas par défaut pour les choix invalides

                3. Lecture du choix avec int.TryParse ................................... /2

                4. Calcul du total ...................................................... /2
                =====================================================================================================================
            */

            Console.WriteLine("1. Café (2,50 $)");
            Console.WriteLine("2. Muffin (3,25 $)");
            Console.WriteLine("3. Biscuit (1,75 $)");
            Console.WriteLine("4. Terminer la commande");

            double total = 0;



        }
    }
}
