using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_AchatPokemon
{
    public class CartePokemon
    {
        public string Nom { get; set; }
        public string Rarete { get; set; }
        public string Image { get; set; }
        public double Prix { get; set; }

        public CartePokemon(string nom, string rarete, string image, double prix)
        {
            Nom = nom;
            Rarete = rarete;
            Image = image;
            Prix = prix;
        }

        public override string ToString()
        {
            return $"{Nom} - {Prix:F2}$ ({Rarete})";
        }
    }
}
