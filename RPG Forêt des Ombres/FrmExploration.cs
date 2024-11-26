using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Forêt_des_Ombres
{
    public partial class FrmExploration : Form
    {
        private List<Objet> unInventaire = new List<Objet>();
        private List<Ennemi> lesEnnemis = new List<Ennemi>();
        private List<Potion> lesPotions = new List<Potion>();
        private List<Arme> lesArmes = new List<Arme>();
        private List<Heros> lesHeros = new List<Heros>();

        public FrmExploration()
        {
            InitializeComponent();
        }

        private void FrmExploration_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            //Génére les héros
            lesHeros.Add(new Heros("Arthur", "Un jeune héros déterminé à prouver sa valeur.", 100, 15, Image.FromFile("Images/arthur.png"), 0, 0));
            lesHeros.Add(new Heros("Edgar", "Un combattant musclé qui ne connaît pas la peur.", 120, 10, Image.FromFile("Images/edgar.png"), 0, 0));
            lesHeros.Add(new Heros("Gabriel", "Un grand au cœur tendre, mais redoutable au combat.", 105, 12, Image.FromFile("Images/gabriel.png"), 0, 0));
            lesHeros.Add(new Heros("Lina", "Rapide et forte, elle ne recule devant rien.", 90, 18, Image.FromFile("Images/lina.png"), 0, 0));
            lesHeros.Add(new Heros("Sofia", "Toujours prête à explorer de nouveaux horizons.", 100, 15, Image.FromFile("Images/sofia.png"), 0, 0));

            //Génére les ennemis
            int nombreAleatoireDegatEnnemi1 = random.Next(3, 7);
            int nombreAleatoireDegatEnnemi2 = random.Next(4, 8);
            int nombreAleatoireDegatEnnemi3 = random.Next(6, 12);
            int nombreAleatoireDegatEnnemi4 = random.Next(8, 15);
            int nombreAleatoireDegatEnnemi5 = random.Next(10, 20);
            int nombreAleatoireDegatEnnemi6 = random.Next(12, 25);
            int nombreAleatoireDegatEnnemi7 = random.Next(15, 30);
            lesEnnemis.Add(new Ennemi("ennemi1", "", 30, nombreAleatoireDegatEnnemi1, Image.FromFile("Images/ennemi1.png"), "ombre", 10));
            lesEnnemis.Add(new Ennemi("ennemi2", "", 40, nombreAleatoireDegatEnnemi1, Image.FromFile("Images/ennemi2.png"), "ombre", 11));
            lesEnnemis.Add(new Ennemi("ennemi3", "", 60, nombreAleatoireDegatEnnemi1, Image.FromFile("Images/ennemi3.png"), "ombre", 15));
            lesEnnemis.Add(new Ennemi("ennemi4", "", 80, nombreAleatoireDegatEnnemi1, Image.FromFile("Images/ennemi4.png"), "ombre", 18));
            lesEnnemis.Add(new Ennemi("ennemi5", "", 120, nombreAleatoireDegatEnnemi1, Image.FromFile("Images/ennemi5.png"), "ombre", 23));
            lesEnnemis.Add(new Ennemi("ennemi6", "", 150, nombreAleatoireDegatEnnemi1, Image.FromFile("Images/ennemi6.png"), "ombre", 28));
            lesEnnemis.Add(new Ennemi("ennemi7", "", 200, nombreAleatoireDegatEnnemi1, Image.FromFile("Images/ennemi7.png"), "ombre", 33));

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

        private void BtnForet1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int nombreAleatoire = random.Next(0, 100);
            int nombreArmeInventaire = unInventaire.OfType<Arme>().Count();
            int nombrePotionInventaire = unInventaire.OfType<Potion>().Count();

            if (nombreAleatoire > 0 && nombreAleatoire < 60 && nombreArmeInventaire < 1 && nombrePotionInventaire < 2)
            {
                TbListeEvenement.AppendText("Au combat ! Vous venez de rencontrer un ennemi. \r\n");
                //Ouvre interface combat
            }
            else if (nombreAleatoire > 60 && nombreAleatoire < 90)
            {
                if (unInventaire.Count < 5)
                {
                    GenererObjetAleatoire();
                    AfficherInventaire();
                    TbListeEvenement.AppendText("Oh. Vous avez trouvé un objet ! \r\n");
                }
                else
                {
                    MessageBox.Show("Votre inventaire est plein !");
                }
            }
            else if (nombreAleatoire > 90 && nombreAleatoire < 101)
            {
                TbListeEvenement.AppendText("Mince ! Vous n'avez rien trouvez. \r\n");
            }
        }

        private void BtnForet2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int nombreAleatoire = random.Next(0, 100);
            int nombreArmeInventaire = unInventaire.OfType<Arme>().Count();
            int nombrePotionInventaire = unInventaire.OfType<Potion>().Count();

            if (nombreAleatoire > 0 && nombreAleatoire < 60 && nombreArmeInventaire < 1 && nombrePotionInventaire < 2)
            {
                TbListeEvenement.AppendText("Au combat ! Vous venez de rencontrer un ennemi. \r\n");
                //Ouvre interface combat
            }
            else if (nombreAleatoire > 60 && nombreAleatoire < 90)
            {
                if (unInventaire.Count < 5)
                {
                    GenererObjetAleatoire();
                    AfficherInventaire();
                    TbListeEvenement.AppendText("Oh. Vous avez trouvé un objet ! \r\n");
                }
                else
                {
                    MessageBox.Show("Votre inventaire est plein !");
                }
            }
            else if (nombreAleatoire > 90 && nombreAleatoire < 101)
            {
                TbListeEvenement.AppendText("Mince ! Vous n'avez rien trouvez. \r\n");
            }
        }

        private void BtnForet3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int nombreAleatoire = random.Next(0, 100);
            int nombreArmeInventaire = unInventaire.OfType<Arme>().Count();
            int nombrePotionInventaire = unInventaire.OfType<Potion>().Count();

            if (nombreAleatoire > 0 && nombreAleatoire < 60 && nombreArmeInventaire < 1 && nombrePotionInventaire < 2)
            {
                TbListeEvenement.AppendText("Au combat ! Vous venez de rencontrer un ennemi. \r\n");
                //Ouvre interface combat
            }
            else if (nombreAleatoire > 60 && nombreAleatoire < 90)
            {
                if (unInventaire.Count < 5)
                {
                    GenererObjetAleatoire();
                    AfficherInventaire();
                    TbListeEvenement.AppendText("Oh. Vous avez trouvé un objet ! \r\n");
                }
                else
                {
                    MessageBox.Show("Votre inventaire est plein !");
                }
            }
            else if (nombreAleatoire > 90 && nombreAleatoire < 101)
            {
                TbListeEvenement.AppendText("Mince ! Vous n'avez rien trouvez. \r\n");
            }
        }

        private void BtnVillage_Click(object sender, EventArgs e)
        {
            FrmVillage frmVillage = new FrmVillage(lesHeros, lesArmes, lesPotions);
            frmVillage.Show();
            this.Hide();
        }

        public void GenererObjetAleatoire()
        {
            Random random = new Random();
            int choix = random.Next(0, 2);
            int nombreArmeInventaire = unInventaire.OfType<Arme>().Count();
            int nombrePotionInventaire = unInventaire.OfType<Potion>().Count();
            if (choix == 0 && nombreArmeInventaire < 2)
            {
                int armeChoisie = random.Next(lesArmes.Count);
                Arme arme = lesArmes[armeChoisie];
                unInventaire.Add(arme);
            }
            else if (choix == 1 && nombrePotionInventaire < 3)
            {
                int potionChoisie = random.Next(lesPotions.Count);
                Potion potion = lesPotions[potionChoisie];
                unInventaire.Add(potion);
            }
        }

        public void AfficherInventaire()
        {
            FlpInventaireJoueur.Controls.Clear();

            foreach (Objet unObjet in unInventaire)
            {
                Panel panelObjet = new Panel() { Width = 80, Height = 80, BorderStyle = BorderStyle.FixedSingle };

                PictureBox PbItem = new PictureBox() { Width = 75, Height = 75, Image = unObjet.GetImageObjet(), SizeMode = PictureBoxSizeMode.Zoom, Dock = DockStyle.Top };

                panelObjet.Controls.Add(PbItem);

                FlpInventaireJoueur.Controls.Add(panelObjet);
            }
        }
    }
}
