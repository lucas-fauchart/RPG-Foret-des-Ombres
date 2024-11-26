using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forêt_des_Ombres
{
    internal class Potion : Objet
    {
        //Variable
        private int bonusPointsVie;

        //Construction
        public Potion(string leNomObjet, string laDescriptionObjet, Image uneImageObjet, int unBonusPointsVie) :
             base(leNomObjet, laDescriptionObjet, uneImageObjet)
        {
            this.bonusPointsVie = unBonusPointsVie;
        }

        //Getters
        public int GetBonusPointsVie()
        {
            return bonusPointsVie;
        }

        //Méthode
        public override void Utiliser(Heros heros)
        {
            heros.AjouterPointVie(this.bonusPointsVie);
        }
    }
}
