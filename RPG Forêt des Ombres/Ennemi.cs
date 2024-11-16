using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Forêt_des_Ombres
{
    internal class Ennemi : Personnage
    {
        //Variable
        private string typeEnnemi;
        private int degatsSupplementaires;

        // Constructeur
        public Ennemi(string leNomPersonnage, string laDescriptionPersonnage, int lesPointsViePersonnage, int lesDegatsPersonnage, string unTypeEnnemi, int lesDegatsSupplementaires) :
            base(leNomPersonnage, laDescriptionPersonnage, lesPointsViePersonnage, lesDegatsPersonnage)
        {
            this.typeEnnemi = unTypeEnnemi;
            this.degatsSupplementaires = lesDegatsSupplementaires;
        }

        //Getters
        public string GetTypeEnnemi()
        {
            return this.typeEnnemi;
        }
        public int GetDegatsSupplementaire()
        {
            return this.degatsSupplementaires;
        }

        //Methode
        public void AttaqueSpeciale(Personnage cible)
        {
            int degats = this.GetDegatPersonnage() + this.degatsSupplementaires;
            cible.RecevoirDesDegats(degats);
        }
        public override void Attaquer(Personnage cible)
        {
            base.Attaquer(cible);
        }
    }
}
