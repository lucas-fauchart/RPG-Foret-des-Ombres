using System;

namespace RPG_Forêt_des_Ombres
{
    public partial class FrmAccueil : Form
    {
        private Random random = new Random();
        private List<Heros> lesHeros = new List<Heros>();
        private List<Ennemi> lesEnnemis = new List<Ennemi>();
        private List<Potion> lesPotions = new List<Potion>();
        private List<Arme> lesArmes = new List<Arme>();

        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {
            //Génére les héros
            lesHeros.Add(new Heros("Arthur", "Un jeune héros déterminé à prouver sa valeur.", 100, 100, 15, Image.FromFile("Images/arthur.png"), 0, 0));
            lesHeros.Add(new Heros("Edgar", "Un combattant musclé qui ne connaît pas la peur.", 120, 120, 10, Image.FromFile("Images/edgar.png"), 0, 0));
            lesHeros.Add(new Heros("Gabriel", "Un grand au cœur tendre, mais redoutable au combat.", 105, 105, 12, Image.FromFile("Images/gabriel.png"), 0, 0));
            lesHeros.Add(new Heros("Lina", "Rapide et forte, elle ne recule devant rien.", 90, 90, 18, Image.FromFile("Images/lina.png"), 0, 0));
            lesHeros.Add(new Heros("Sofia", "Toujours prête à explorer de nouveaux horizons.", 100, 100, 15, Image.FromFile("Images/sofia.png"), 0, 0));

            //Génére les ennemis
            lesEnnemis.Add(new Ennemi("ennemi1", "", 30, 30, 0, Image.FromFile("Images/ennemi1.png"), "ombre", 10));
            lesEnnemis.Add(new Ennemi("ennemi2", "", 40, 40, 0, Image.FromFile("Images/ennemi2.png"), "ombre", 11));
            lesEnnemis.Add(new Ennemi("ennemi3", "", 60, 60, 0, Image.FromFile("Images/ennemi3.png"), "ombre", 15));
            lesEnnemis.Add(new Ennemi("ennemi4", "", 80, 80, 0, Image.FromFile("Images/ennemi4.png"), "ombre", 18));
            lesEnnemis.Add(new Ennemi("ennemi5", "", 120, 120, 0, Image.FromFile("Images/ennemi5.png"), "ombre", 23));
            lesEnnemis.Add(new Ennemi("ennemi6", "", 150, 150, 0, Image.FromFile("Images/ennemi6.png"), "ombre", 28));
            lesEnnemis.Add(new Ennemi("ennemi7", "", 200, 200, 0, Image.FromFile("Images/ennemi7.png"), "ombre", 33));

            //Génére les armes
            int nombreAleatoireDegatMarteau = random.Next(5, 10);
            int nombreAleatoireDegatPioche = random.Next(8, 13);
            int nombreAleatoireDegatHache = random.Next(10, 15);
            int nombreAleatoireDegatBatteBaseball = random.Next(13, 18);
            int nombreAleatoireDegatEpee = random.Next(15, 20);
            lesArmes.Add(new Arme("Marteau", "Un outil lourd et puissant, conçu pour écraser.", Image.FromFile("Images/marteau.png"), "5 - 10", nombreAleatoireDegatMarteau));
            lesArmes.Add(new Arme("Pioche", "Un outil robuste, capable de percer les ennemis.", Image.FromFile("Images/pioche.png"), "8 - 13", nombreAleatoireDegatPioche));
            lesArmes.Add(new Arme("Hache", "Une lame affûtée, parfaite pour des coups rapides et puissants..", Image.FromFile("Images/hache.png"), "10 - 15", nombreAleatoireDegatHache));
            lesArmes.Add(new Arme("Batte de baseball", "Simple mais efficace, elle repousse et assomme les ennemis.", Image.FromFile("Images/batteBaseball.png"), "13 - 18", nombreAleatoireDegatBatteBaseball));
            lesArmes.Add(new Arme("Epée", "Une arme équilibrée, symbole classique de maîtrise et de combat..", Image.FromFile("Images/epee.png"), "15 - 20", nombreAleatoireDegatEpee));

            //Génére les potions
            lesPotions.Add(new Potion("Potion de guérison faible", "Un breuvage simple, parfait pour des blessures légères.", Image.FromFile("Images/potionGuerisonFaible.png"), 20));
            lesPotions.Add(new Potion("Elixir de régénération", "Un élixir puissant qui accélère la guérison et restaure l'énergie perdue.", Image.FromFile("Images/elixirRegeneration.png"), 50));
            lesPotions.Add(new Potion("Nectar de vie", "Un nectar rare et précieux, capable de soigner les blessures graves en un instant.", Image.FromFile("Images/nectarVie.png"), 100));
        }

        private void BtnChargerPartie_Click(object sender, EventArgs e)
        {
            //Permet d'ouvrir la fenêtre
            FrmExploration frmExploration = new FrmExploration(lesHeros, lesEnnemis, lesArmes, lesPotions);
            frmExploration.Show();
            this.Hide();
        }
    }
}