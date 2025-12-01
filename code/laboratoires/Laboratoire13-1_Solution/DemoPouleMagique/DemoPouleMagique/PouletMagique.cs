using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPouleMagique
{
    public class PouletMagique
    {
        public const int TAILLE_MAX = 20;

        public static int NombrePoules { get; private set; }

        public int Taille { get; private set; } = 10;


        public int Rage { get; private set; } = 0;


        public int Oeufs { get; private set; } = 0;


        public bool EstDore { get; private set; } = false;


        public PouletMagique()
        {
            NombrePoules++;
        }

        public void MangerMais(int quantite)
        {
            Taille += quantite;
            if (Taille > 20)
            {
                Taille = 20;
            }
        }

        public void Danser()
        {
            EstDore = true;
        }

        public void Pondre()
        {
            Oeufs++;
            Taille--;
        }

        public void CrisDeGuerre()
        {
            Rage += 5;
            Taille++;
            EstDore = false;
        }

        public void ActionSpeciale()
        {
            Rage++;
            Oeufs += 2;
            Taille -= 3;
            EstDore = true;
        }
    }
}
