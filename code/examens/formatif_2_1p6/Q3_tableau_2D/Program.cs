namespace Q3_tableau_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Question 3 - Tableau 2D (10 pts) - Temps suggéré : 25 minutes

                Le stationnement du cégep a 3 rangées de 4 places. Une place occupée vaut 1 et une place libre vaut 0 :

                    Rangée Nord   : 1 0 1 1
                    Rangée Centre : 0 0 1 0
                    Rangée Sud    : 1 1 1 0

                Le tableau 1D du nom des rangées est déjà fourni ci-dessous.

                Écrivez un programme qui :
                    - Déclare et initialise un tableau 2D d'entiers (int) contenant les places.
                    - Affiche le plan du stationnement : X pour une place occupée et un point pour une place libre.
                    - Affiche le nombre de places libres de chaque rangée.
                    - Affiche le nombre total de places libres.

                Utilisez des boucles for imbriquées et GetLength pour parcourir le tableau.

                --- Affichage attendu ---
                Plan du stationnement :
                X . X X
                . . X .
                X X X .

                Rangée Nord : 1 place(s) libre(s)
                Rangée Centre : 3 place(s) libre(s)
                Rangée Sud : 1 place(s) libre(s)
                Total : 5 place(s) libre(s)
                =====================================================================================================================

                Grille de pointage :

                1. Déclaration et initialisation du tableau 2D .......................... /2

                2. Affichage du plan .................................................... /3
                    → Boucles imbriquées avec GetLength, une ligne de la console par rangée

                3. Nombre de places libres par rangée ................................... /3
                    → Compteur remis à zéro pour chaque rangée, nom de la rangée affiché

                4. Total des places libres .............................................. /1

                5. Affichage du résultat final .......................................... /1
                =====================================================================================================================
            */

            string[] rangees = { "Nord", "Centre", "Sud" };



        }
    }
}
