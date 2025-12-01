using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThermostat
{
    public class Thermostat
    {
        public const double TEMPÉRATURE_MINIMALE = 5.0;

        public const double TEMPÉRATURE_MAXIMALE = 35.0;

        private const double TEMPÉRATURE_INITIALE = 20.0;

        public double Température { get; private set; }

        public Thermostat()
        {
            Température = TEMPÉRATURE_INITIALE;
        }

        public Thermostat(int pTempérature)
        {
            if ((double)pTempérature < TEMPÉRATURE_MINIMALE || (double)pTempérature > TEMPÉRATURE_MAXIMALE)
            {
                throw new ArgumentOutOfRangeException("La température doit être entre : " + TEMPÉRATURE_MINIMALE + " et " + TEMPÉRATURE_MAXIMALE);
            }

            Température = pTempérature;
        }

        public void AugmenterTemperature()
        {
            Température++;
            if (Température > TEMPÉRATURE_MAXIMALE)
            {
                throw new ArgumentOutOfRangeException("La température dépasse le MAXIMUM autorisé");
            }
        }

        public void DiminuerTemperature()
        {
            Température--;
            if (Température < TEMPÉRATURE_MINIMALE)
            {
                throw new ArgumentOutOfRangeException("La température est inférieure au MINIMUM autorisé");
            }
        }
    }
}
