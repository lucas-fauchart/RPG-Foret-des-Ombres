using System;
using System.Media;

namespace RPG_Forêt_des_Ombres
{
    public partial class FrmAccueil : Form
    {
        Random random = new Random();

        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {
            GestionMusique.StartBackgroundMusic();

            this.BackgroundImage = Image.FromFile("Images/Fond/FondAccueil.png");
        }

        private void BtnChargerPartie_Click(object sender, EventArgs e)
        {
            // Appel à la méthode de chargement
            string cheminFichier = @"C:\Users\lucas\OneDrive\Documents\RPG Foret des Ombres\RPG Forêt des Ombres\bin\Debug\net6.0-windows\sauvegarde.json";
            List<Heros> listeHeros = GestionSauvegarde.Charger();

            if (listeHeros.Count > 0)
            {
                // Afficher ou manipuler les héros chargés
                Globale.lesHeros = listeHeros;
                MessageBox.Show("Héros chargés avec succès !");
            }
            else
            {
                MessageBox.Show("Aucun héros à charger.");
            }

            Globale.choixHeros = Globale.lesHeros[0];
            //Permet d'ouvrir la fenêtre
            FrmExploration frmExploration = new FrmExploration();
            frmExploration.Show();
            this.Hide();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            GestionMusique.StopBackgroundMusic();
            Application.Exit();
        }

        private void BtnNouvellePartie_Click(object sender, EventArgs e)
        {
            //Génére les héros
            Globale.lesHeros.Add(new Heros("Arthur", "Un jeune héros déterminé à prouver sa valeur.", 100, 100, 10, Image.FromFile("Images/arthur.png"), 0, 0, 10, Image.FromFile("Images/Fond/FondVillageArthur.png")));
            Globale.lesHeros.Add(new Heros("Edgar", "Un combattant musclé qui ne connaît pas la peur.", 120, 120, 5, Image.FromFile("Images/edgar.png"), 0, 0, 5, Image.FromFile("Images/Fond/FondVillageEdgar.png")));
            Globale.lesHeros.Add(new Heros("Gabriel", "Un grand au cœur tendre, mais redoutable au combat.", 105, 105, 7, Image.FromFile("Images/gabriel.png"), 0, 0, 7, Image.FromFile("Images/Fond/FondVillageGabriel.png")));
            Globale.lesHeros.Add(new Heros("Lina", "Rapide et forte, elle ne recule devant rien.", 90, 90, 13, Image.FromFile("Images/lina.png"), 0, 0, 13, Image.FromFile("Images/Fond/FondVillageLina.png")));
            Globale.lesHeros.Add(new Heros("Sofia", "Toujours prête à explorer de nouveaux horizons.", 100, 100, 10, Image.FromFile("Images/sofia.png"), 0, 0, 10, Image.FromFile("Images/Fond/FondVillageSofia.png")));

            //Génére les ennemis
            Globale.lesEnnemis.Add(new Ennemi("Ennemi1", "", 90, 90, 0, Image.FromFile("Images/ennemi1.png"), "ombre", 10));
            Globale.lesEnnemis.Add(new Ennemi("Ennemi2", "", 100, 100, 0, Image.FromFile("Images/ennemi2.png"), "ombre", 11));
            Globale.lesEnnemis.Add(new Ennemi("Ennemi3", "", 125, 125, 0, Image.FromFile("Images/ennemi3.png"), "ombre", 15));
            Globale.lesEnnemis.Add(new Ennemi("Ennemi4", "", 140, 140, 0, Image.FromFile("Images/ennemi4.png"), "ombre", 18));
            Globale.lesEnnemis.Add(new Ennemi("Ennemi5", "", 165, 165, 0, Image.FromFile("Images/ennemi5.png"), "ombre", 23));
            Globale.lesEnnemis.Add(new Ennemi("Ennemi6", "", 180, 180, 0, Image.FromFile("Images/ennemi6.png"), "ombre", 28));
            Globale.lesEnnemis.Add(new Ennemi("Ennemi7", "", 200, 200, 0, Image.FromFile("Images/ennemi7.png"), "ombre", 33));

            //Génére les armes
            int nombreAleatoireDegatMarteau = random.Next(2, 7);
            int nombreAleatoireDegatPioche = random.Next(5, 10);
            int nombreAleatoireDegatHache = random.Next(7, 12);
            int nombreAleatoireDegatBatteBaseball = random.Next(10, 15);
            int nombreAleatoireDegatEpee = random.Next(12, 17);
            Globale.lesArmes.Add(new Arme("Arme", "Marteau", "Un outil lourd et puissant, conçu pour écraser.", Image.FromFile("Images/marteau.png"), "2 - 7", nombreAleatoireDegatMarteau));
            Globale.lesArmes.Add(new Arme("Arme", "Pioche", "Un outil robuste, capable de percer les ennemis.", Image.FromFile("Images/pioche.png"), "5 - 10", nombreAleatoireDegatPioche));
            Globale.lesArmes.Add(new Arme("Arme", "Hache", "Une lame affûtée, parfaite pour des coups rapides et puissants.", Image.FromFile("Images/hache.png"), "7 - 12", nombreAleatoireDegatHache));
            Globale.lesArmes.Add(new Arme("Arme", "Batte de baseball", "Simple mais efficace, elle repousse et assomme les ennemis.", Image.FromFile("Images/batteBaseball.png"), "10 - 15", nombreAleatoireDegatBatteBaseball));
            Globale.lesArmes.Add(new Arme("Arme", "Epée", "Une arme équilibrée, symbole classique de maîtrise et de combat.", Image.FromFile("Images/epee.png"), "12 - 17", nombreAleatoireDegatEpee));

            //Génére les potions
            Globale.lesPotions.Add(new Potion("Potion", "Potion de guérison faible", "Un breuvage simple, parfait pour des blessures légères.", Image.FromFile("Images/potionGuerisonFaible.png"), 30));
            Globale.lesPotions.Add(new Potion("Potion", "Elixir de régénération", "Un élixir puissant qui accélère la guérison et restaure l'énergie perdue.", Image.FromFile("Images/elixirRegeneration.png"), 40));
            Globale.lesPotions.Add(new Potion("Potion", "Nectar de vie", "Un nectar rare et précieux, capable de soigner les blessures graves en un instant.", Image.FromFile("Images/nectarVie.png"), 50));

            Globale.choixHeros = Globale.lesHeros[0];

            //Permet d'ouvrir la fenêtre
            FrmExploration frmExploration = new FrmExploration();
            frmExploration.Show();
            this.Hide();
        }
    }
}