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
        private string nomObjet;
        private string descriptionObjet;

        //Constructeur
        public Objet(string leNomObjet, string laDescriptionObjet)
        {
            this.nomObjet = leNomObjet;
            this.descriptionObjet = laDescriptionObjet;
        }

        //Getters
        public string GetNomObjet()
        {
            return this.nomObjet;
        }
        public string GetDescriptionOBJET()
        {
            return this.descriptionObjet;
        }

        // Méthode virtuelle pour permettre une redéfinition
        public virtual void Utiliser(Heros heros)
        {
            Console.WriteLine($"{this.nomObjet} utilisé !");
        }
    }
}
