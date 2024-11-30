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
        //private Dictionary<string, List<Objet>> inventaire = new Dictionary<string, List<Objet>>();
        private int experiencePourNiveauSuivant;

        //Constructeur
        public Heros(string nomPersonnage, string descriptionPersonnage, int lesPointsViePersonnage, int lesPointsVieParDefault, int lesDegatsPersonnage, Image uneImagePersonnage, int uneExperience, int niveau /*Dictionary<string, int> unInventaire*/) :
            base(nomPersonnage, descriptionPersonnage, lesPointsViePersonnage, lesPointsVieParDefault, lesDegatsPersonnage, uneImagePersonnage)
        {
            this.experience = uneExperience;
            this.niveau = niveau;
            //this.inventaire = unInventaire;
            this.experiencePourNiveauSuivant = 100;
        }
        //Getters
        public int GetExperience()
        {
            return experience;
        }
        public int GetNiveau()
        {
            return niveau;
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
    }
}
