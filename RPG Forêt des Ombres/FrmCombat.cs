using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Forêt_des_Ombres
{
    public partial class FrmCombat : Form
    {
        //Variable
        private Random random = new Random();
        private List<Heros> lesHeros;
        private List<Ennemi> lesEnnemis;
        private List<Potion> lesPotions;
        private List<Arme> lesArmes;
        private List<Objet> unInventaire;
        private int ennemiChoisie;
        private int herosChoisie;

        internal FrmCombat(List<Heros> lesHeros, List<Ennemi> lesEnnemi, List<Objet> unInventaire)
        {
            InitializeComponent();
            this.lesHeros = lesHeros;
            this.lesEnnemis = lesEnnemi;
            this.unInventaire = unInventaire;
        }

        private void FrmCombat_Load(object sender, EventArgs e)
        {
            for (herosChoisie = 0; herosChoisie < lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == lesHeros[herosChoisie].GetNomPersonnage())
                {
                    PbHeros.Image = lesHeros[herosChoisie].GetImagePersonnage();
                    Arme arme = unInventaire.OfType<Arme>().FirstOrDefault();
                    lesHeros[herosChoisie].AjouterDegat(arme.GetBonusDegat());
                }
            }


            ennemiChoisie = GenererEnnemiAleatoire();
            PbEnnemi.Image = lesEnnemis[ennemiChoisie].GetImagePersonnage();
            LbPointsVieEnnemi.Text = $"{lesEnnemis[ennemiChoisie].GetPointsViePersonnage()} / {lesEnnemis[ennemiChoisie].GetPointsViePaeDefautl()}";
        }

        private void BtnAttaque_Click(object sender, EventArgs e)
        {
            for (herosChoisie = 0; herosChoisie < lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == lesHeros[herosChoisie].GetNomPersonnage())
                {
                    // Le héros attaque l'ennemi choisi
                    lesHeros[herosChoisie].Attaquer(lesEnnemis[ennemiChoisie]);

                    // Mettre à jour l'affichage des points de vie de l'ennemi
                    LbPointsVieEnnemi.Text = $"{lesEnnemis[ennemiChoisie].GetPointsViePersonnage()} / {lesEnnemis[ennemiChoisie].GetPointsViePaeDefautl()}";

                    // Vérifier si l'ennemi est battu
                    if (lesEnnemis[ennemiChoisie].GetPointsViePersonnage() <= 0)
                    {
                        Random random = new Random();
                        int nombreExperienceGagne = random.Next(15, 31);
                        MessageBox.Show("L'ennemi a été battu ! Tu as gagné " + nombreExperienceGagne + " expériences !");
                        lesHeros[herosChoisie].AjouterExperience(nombreExperienceGagne);
                        FrmExploration frmExploration = new FrmExploration(lesHeros, lesEnnemis, lesArmes, lesPotions);
                        frmExploration.Show();
                        this.Close();
                        return;
                    }

                    // L'ennemi riposte
                    if (lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi1")
                    {
                        int nombreAleatoireDegatEnnemi1 = random.Next(3, 7);
                        lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi1);
                        lesEnnemis[ennemiChoisie].Attaquer(lesHeros[herosChoisie]);
                    }
                    if (lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi2")
                    {
                        int nombreAleatoireDegatEnnemi2 = random.Next(4, 8);
                        lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi2);
                        lesEnnemis[ennemiChoisie].Attaquer(lesHeros[herosChoisie]);
                    }
                    if (lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi3")
                    {
                        int nombreAleatoireDegatEnnemi3 = random.Next(6, 12);
                        lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi3);
                        lesEnnemis[ennemiChoisie].Attaquer(lesHeros[herosChoisie]);
                    }
                    if (lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi4")
                    {
                        int nombreAleatoireDegatEnnemi4 = random.Next(8, 15);
                        lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi4);
                        lesEnnemis[ennemiChoisie].Attaquer(lesHeros[herosChoisie]);
                    }
                    if (lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi5")
                    {
                        int nombreAleatoireDegatEnnemi5 = random.Next(10, 20);
                        lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi5);
                        lesEnnemis[ennemiChoisie].Attaquer(lesHeros[herosChoisie]);
                    }
                    if (lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi6")
                    {
                        int nombreAleatoireDegatEnnemi6 = random.Next(12, 25);
                        lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi6);
                        lesEnnemis[ennemiChoisie].Attaquer(lesHeros[herosChoisie]);
                    }
                    if (lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi7")
                    {
                        int nombreAleatoireDegatEnnemi7 = random.Next(15, 30);
                        lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi7);
                        lesEnnemis[ennemiChoisie].Attaquer(lesHeros[herosChoisie]);
                    }

                    LbPointsVieHeros.Text = $"{lesHeros[herosChoisie].GetPointsViePersonnage()} / {lesHeros[herosChoisie].GetPointsViePaeDefautl()}";

                    if (lesHeros[herosChoisie].GetPointsViePersonnage() <= 0)
                    {
                        Random random = new Random();
                        int nombreExperiencePerdu = random.Next(10, 16);
                        MessageBox.Show("Vous avez été battu ! Tu as perdu " + nombreExperiencePerdu + " expériences.");
                        lesHeros[herosChoisie].RetirerExperience(nombreExperiencePerdu);
                        FrmExploration frmExploration = new FrmExploration(lesHeros, lesEnnemis, lesArmes, lesPotions);
                        frmExploration.Show();
                        this.Close();
                        return;
                    }
                }
            }
        }
        public int GenererEnnemiAleatoire()
        {
            Random random = new Random();
            int ennemi = random.Next(lesEnnemis.Count);
            return ennemi;
        }

        private void BtnFuite_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veux-tu vraiment prendre la fuite ?", "Prendre la fuite ?", MessageBoxButtons.YesNo);
            unInventaire.Clear();
            for (herosChoisie = 0; herosChoisie < lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == lesHeros[herosChoisie].GetNomPersonnage())
                {
                    lesHeros[herosChoisie].RetirerExperience(50);
                }
            }
            FrmExploration frmExploration = new FrmExploration(lesHeros, lesEnnemis, lesArmes, lesPotions);
            frmExploration.Show();
            this.Hide();
        }


        private void LbPointsVieParDefault_Click(object sender, EventArgs e)
        {

        }
    }
}
