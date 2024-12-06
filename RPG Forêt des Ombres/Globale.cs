using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forêt_des_Ombres
{
    internal class Globale
    {
        public static List<Heros> lesHeros = new List<Heros>();
        public static List<Ennemi> lesEnnemis = new List<Ennemi>();
        public static List<Potion> lesPotions = new List<Potion>();
        public static List<Arme> lesArmes = new List<Arme>();
        public static List<Objet> unInventaire = new List<Objet>();
        public static Heros? choixHeros;
        public static int nouvellesDonnees;

    }
}
