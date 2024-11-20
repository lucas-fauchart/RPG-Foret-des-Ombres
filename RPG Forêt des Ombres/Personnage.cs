using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forêt_des_Ombres
{
    internal class Personnage
    {
        //Variable
        private string nomPersonnage;
        private string descriptionPersonnage;
        private int pointsViePersonnage;
        private int degatsPersonnage;
        private Image imagePersonnage;

        //Constructeur
        public Personnage(string leNomPersonnage, string laDescriptionPersonnage, int lesPointsViePersonnage, int lesDegatsPersonnage, Image uneImagePersonnage)
        {
            this.nomPersonnage = leNomPersonnage;
            this.descriptionPersonnage = laDescriptionPersonnage;
            this.pointsViePersonnage = lesPointsViePersonnage;
            this.degatsPersonnage = lesDegatsPersonnage;
            this.imagePersonnage = uneImagePersonnage;
        }

        //Getters
        public string GetNomPersonnage()
        {
            return this.nomPersonnage;
        }
        public string GetDescriptionPersonnage()
        {
            return this.descriptionPersonnage;
        }
        public int GetPointsViePersonnage()
        {
            return this.pointsViePersonnage;
        }
        public int GetDegatPersonnage()
        {
            return this.degatsPersonnage;
        }
        public Image GetImagePersonnage()
        {
            return this.imagePersonnage;
        }

        //Setters
        public void AjouterPointVie(int pointVieSuplementaire)
        {
            this.pointsViePersonnage = this.pointsViePersonnage + pointVieSuplementaire;
        }
        public void AjouterDegat(int degatSuplementaire)
        {
            this.degatsPersonnage = this.degatsPersonnage + degatSuplementaire;
        }

        //Methode
        public void RecevoirDesDegats(int degats)
        {
            pointsViePersonnage -= degats;
        }
        public virtual void Attaquer(Personnage cible)
        {
            cible.RecevoirDesDegats(this.degatsPersonnage);
        }
    }
}
