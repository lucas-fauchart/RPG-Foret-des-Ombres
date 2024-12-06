using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace RPG_Forêt_des_Ombres
{
    internal class Heros : Personnage
    {
        //Varible
        private int experience;
        private int niveau;
        //private Dictionary<string, List<Objet>> inventaire = new Dictionary<string, List<Objet>>();
        private int experiencePourNiveauSuivant;
        private int degatsParDefault;
        private Image fondVillageHeros;
        public string ImagePersonnageBase64 { get; set; }

        //Constructeur
        public Heros(string nomPersonnage, string descriptionPersonnage, int lesPointsViePersonnage, int lesPointsVieParDefault, int lesDegatsPersonnage, Image uneImagePersonnage, int uneExperience, int niveau, int lesDegatsParDefault, Image unFondVillageHeros /*Dictionary<string, int> unInventaire*/) :
            base(nomPersonnage, descriptionPersonnage, lesPointsViePersonnage, lesPointsVieParDefault, lesDegatsPersonnage, uneImagePersonnage)
        {
            this.experience = uneExperience;
            this.niveau = niveau;
            //this.inventaire = unInventaire;
            this.experiencePourNiveauSuivant = 100;
            this.degatsParDefault = lesDegatsParDefault;
            this.fondVillageHeros = unFondVillageHeros;
            ImagePersonnageBase64 = ImageToBase64(fondVillageHeros);  // Convertir l'image en base64
        }
        //Getters
        public int GetExperience()
        {
            return this.experience;
        }
        public int GetNiveau()
        {
            return this.niveau;
        }
        public int GetDegatsParDefault()
        {
            return this.degatsParDefault;
        }
        public Image GetImageFondVillage()
        {
            return this.fondVillageHeros;
        }
        //Setters
        public void AjouterExperience(int bonusExperience)
        {
            this.experience += bonusExperience;
            if (experience >= experiencePourNiveauSuivant)
            {
                MonterNiveau();
            }
        }
        public void MonterNiveau()
        {
            niveau++;
            experiencePourNiveauSuivant = niveau * 100;
            experience = 0;
        }
        public int GetExperiencePourNiveauSuivant()
        {
            return experiencePourNiveauSuivant;
        }
        public void RetirerExperience(int malusExperience)
        {
            this.experience -= malusExperience;
            if (this.experience < 0)
            {
                this.experience = 0;
            }
        }
        public void MettreDegatsParDefault(int lesDegatsParDefault)
        {
            ReinisialiserDegats(lesDegatsParDefault);
        }
        /*public Dictionary<string, int> GetInventaire()
        {
            return inventaire;
        }
        
        public void UtiliserObjet(string nomObjet)
        {
            // Exemple de logique pour une potion
            if (this.inventaire.ContainsKey(nomObjet) && this.inventaire[nomObjet] > 0)
            {
                if (nomObjet == "Potion")
                {
                    AjouterPointVie(10);
                    this.inventaire[nomObjet]--;
                }
            }
        }

        public void AjouterObjet(Objet objet)
        {
            if (this.inventaire.ContainsKey(objet.GetNomObjet()))
            {
                this.inventaire[objet.GetNomObjet()]++;
            }
            else
            {
                this.inventaire.Add(objet.GetNomObjet(), 1);
            }
        }*/

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
