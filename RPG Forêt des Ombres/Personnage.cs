using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        public string ImagePersonnageBase64 { get; set; }

        //Constructeur
        public Personnage(string leNomPersonnage, string laDescriptionPersonnage, int lesPointsViePersonnage, int lesPointsVieParDefaultPersonnage, int lesDegatsPersonnage, Image uneImagePersonnage)
        {
            this.nomPersonnage = leNomPersonnage;
            this.descriptionPersonnage = laDescriptionPersonnage;
            this.pointsViePersonnage = lesPointsViePersonnage;
            this.pointsVieParDefaultPersonnage = lesPointsVieParDefaultPersonnage;
            this.degatsPersonnage = lesDegatsPersonnage;
            this.imagePersonnage = uneImagePersonnage;
            ImagePersonnageBase64 = ImageToBase64(imagePersonnage);  // Convertir l'image en base64
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

        public virtual void Attaquer(Personnage cible)
        {
            cible.pointsViePersonnage = Math.Max(0, cible.pointsViePersonnage - this.degatsPersonnage);
        }

        // Méthode pour convertir une image en une chaîne base64
        private string ImageToBase64(Image image)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);  // Sauvegarder l'image dans un MemoryStream
                    byte[] imageBytes = ms.ToArray();
                    return Convert.ToBase64String(imageBytes);  // Convertir les octets en chaîne base64
                }
            }
            return null;  // Retourner null si l'image est absente
        }

        // Méthode pour convertir une chaîne base64 en une image
        public Image Base64ToImage(string base64String)
        {
            if (string.IsNullOrEmpty(base64String))
                return null;

            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);  // Convertir en Image
            }
        }
    }
}
