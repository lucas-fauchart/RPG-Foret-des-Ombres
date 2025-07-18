using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forêt_des_Ombres
{
    internal class Objet
    {
        //Variable
        private string type;
        private string nomObjet;
        private string descriptionObjet;
        private Image imageObjet;

        //Constructeur
        public Objet(string leType, string leNomObjet, string laDescriptionObjet, Image uneImageObjet)
        {
            this.type = leType;
            this.nomObjet = leNomObjet;
            this.descriptionObjet = laDescriptionObjet;
            this.imageObjet = uneImageObjet;
        }

        //Getters
        public string GetTypeObjet()
        {
            return type;
        }
        public string GetNomObjet()
        {
            return this.nomObjet;
        }
        public string GetDescriptionObjet()
        {
            return this.descriptionObjet;
        }
        public Image GetImageObjet()
        {
            return this.imageObjet;
        }

        // Méthode virtuelle pour permettre une redéfinition
        public virtual void Utiliser(Heros heros)
        {
            Console.WriteLine($"{this.nomObjet} utilisé !");
        }
    }
}
