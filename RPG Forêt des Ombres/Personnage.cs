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
        private readonly int pointsVieParDefaultPersonnage;
        private int degatsPersonnage;
        private Image imagePersonnage;

        //Constructeur
        public Personnage(string leNomPersonnage, string laDescriptionPersonnage, int lesPointsViePersonnage, int lesPointsVieParDefaultPersonnage, int lesDegatsPersonnage, Image uneImagePersonnage)
        {
            this.nomPersonnage = leNomPersonnage;
            this.descriptionPersonnage = laDescriptionPersonnage;
            this.pointsViePersonnage = lesPointsViePersonnage;
            this.pointsVieParDefaultPersonnage = lesPointsVieParDefaultPersonnage;
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
        public int GetPointsViePaeDefautl()
        {
            return this.pointsVieParDefaultPersonnage;
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
        public void Degats(int lesDegats)
        {
            this.degatsPersonnage = lesDegats;
        }
        public void NouveauPointsVie(int nouveauPointVie)
        {
            this.pointsViePersonnage = nouveauPointVie;
        }
        public void AjouterPointVie(int pointVieSuplementaire)
        {
            this.pointsViePersonnage = this.pointsViePersonnage + pointVieSuplementaire;
        }
        public void AjouterDegat(int degatSuplementaire)
        {
            this.degatsPersonnage = this.degatsPersonnage + degatSuplementaire;
        }
        public void ReinisialiserDegats(int lesDegatsParDefault)
        {
            this.degatsPersonnage = lesDegatsParDefault;
        }

        //Methode
        public void RecevoirDesDegats(int degats)
        {
            pointsViePersonnage = Math.Max(0, pointsViePersonnage - degats);
        }
        public virtual void Attaquer(Personnage cible)
        {
            cible.RecevoirDesDegats(this.degatsPersonnage);
        }
    }
}
