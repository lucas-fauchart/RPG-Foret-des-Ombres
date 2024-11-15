using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forêt_des_Ombres
{
    internal class Heros : Personnage
    {
        //Varible
        private int experience;
        private int niveau;
        private Dictionary<string, int> inventaire = new Dictionary<string, int>();

        //Constructeur
        public Heros(string nomPersonnage, string descriptionPersonnage, int lesPointsViePersonnage, int lesDegatsPersonnage, int uneExperience, int niveau, Dictionary<string, int> unInventaire) :
            base(nomPersonnage, descriptionPersonnage, lesPointsViePersonnage, lesDegatsPersonnage)
        {
            this.experience = uneExperience;
            this.niveau = niveau;
            this.inventaire = unInventaire;
        }

        public void UtiliserObjet(string nomObjet)
        {
            // Exemple de logique pour une potion
            if (inventaire.ContainsKey(nomObjet) && inventaire[nomObjet] > 0)
            {
                if (nomObjet == "Potion")
                {
                    AjouterPointVie(10);
                    inventaire[nomObjet]--;
                }
            }
        } 
    }
}
