using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

namespace RPG_Forêt_des_Ombres
{
    internal class GestionSauvegarde
    {
        public static void Sauvegarder(List<Heros> listeHeros)
        {
            try
            {
                // Utiliser un chemin relatif ou un dossier AppData
                string cheminFichier = Path.Combine(Application.StartupPath, "sauvegarde.json");

                // Si vous souhaitez utiliser AppData à la place
                //string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                //string cheminFichier = Path.Combine(appDataFolder, "RPG_Forêt_des_Ombres", "sauvegarde.json");

                // Convertir la liste des héros en JSON
                string json = JsonConvert.SerializeObject(listeHeros, Newtonsoft.Json.Formatting.Indented);

                // Sauvegarder dans le fichier
                File.WriteAllText(cheminFichier, json);

                MessageBox.Show("Sauvegarde effectuée avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message);
            }
        }

        public static List<Heros> Charger()
        {
            try
            {
                // Utiliser le même chemin de fichier que pour la sauvegarde
                string cheminFichier = Path.Combine(Application.StartupPath, "sauvegarde.json");

                // Si vous souhaitez utiliser AppData à la place
                //string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                //string cheminFichier = Path.Combine(appDataFolder, "RPG_Forêt_des_Ombres", "sauvegarde.json");

                // Vérifier si le fichier existe
                if (!File.Exists(cheminFichier))
                    throw new FileNotFoundException("Le fichier de sauvegarde n'existe pas.");

                // Lire le contenu du fichier
                string json = File.ReadAllText(cheminFichier);

                // Désérialiser le contenu JSON dans une liste d'objets Heros
                List<Heros> listeHeros = JsonConvert.DeserializeObject<List<Heros>>(json);

                if (listeHeros == null) // Si le fichier est vide ou corrompu
                    throw new Exception("Le fichier de sauvegarde est vide ou mal formaté.");

                MessageBox.Show("Chargement de plusieurs héros effectué avec succès !");
                return listeHeros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message);
                return new List<Heros>(); // Retourner une liste vide en cas d'échec
            }
        }
    }
}
