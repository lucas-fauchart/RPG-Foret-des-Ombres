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

        //Constructeur
        public Heros(string nomPersonnage, string descriptionPersonnage, int lesPointsViePersonnage, int lesDegatsPersonnage, Image uneImagePersonnage, int uneExperience, int niveau /*Dictionary<string, int> unInventaire*/) :
            base(nomPersonnage, descriptionPersonnage, lesPointsViePersonnage, lesDegatsPersonnage, uneImagePersonnage)
        {
            this.experience = uneExperience;
            this.niveau = niveau;
            //this.inventaire = unInventaire;
        }
        public int GetExperience()
        {
            return experience;
        }
        public int GetNiveau()
        {
            return niveau;
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
