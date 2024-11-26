using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forêt_des_Ombres
{
    internal class Arme : Objet
    {
        //Variable
        private string degatsPossible;
        private int bonusDegat;

        //Constructeur
        public Arme(string leNomObjet, string laDescriptionObjet, Image uneImageObjet, string lesDegatsPossible, int unBonusDegat) :
             base(leNomObjet, laDescriptionObjet, uneImageObjet)
        {
            this.degatsPossible = lesDegatsPossible;
            this.bonusDegat = unBonusDegat;
        }
        
        //Getters
        public string GetDegatsPossible()
        {
            return degatsPossible;
        }
        public int GetBonusDegat()
        {
            return this.bonusDegat;
        }

        //Méthode
        public override void Utiliser(Heros heros)
        {
            heros.AjouterDegat(this.bonusDegat);
        }
    }
}
