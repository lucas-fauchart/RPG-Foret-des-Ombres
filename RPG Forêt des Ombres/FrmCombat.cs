using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forêt_des_Ombres
{
    public partial class FrmCombat : Form
    {
        //Variable
        private Random random = new Random();
        private int ennemiChoisie;
        private int herosChoisie;


        internal FrmCombat()
        {
            InitializeComponent();
        }

        private void FrmCombat_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Images/Fond/FondCombat.png");
            for (herosChoisie = 0; herosChoisie < Globale.lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == Globale.lesHeros[herosChoisie].GetNomPersonnage())
                {
                    Globale.choixHeros.NouveauPointsVie(Globale.choixHeros.GetPointsViePaeDefautl());
                    PbHeros.Image = Globale.lesHeros[herosChoisie].GetImagePersonnage();
                    LbPointsVieHeros.Text = $"{Globale.lesHeros[herosChoisie].GetPointsViePersonnage()} / {Globale.lesHeros[herosChoisie].GetPointsViePaeDefautl()}";
                    Arme arme = Globale.unInventaire.OfType<Arme>().FirstOrDefault();
                    Globale.lesHeros[herosChoisie].AjouterDegat(arme.GetBonusDegat());
                    MessageBox.Show(Globale.lesHeros[herosChoisie].GetDegatPersonnage().ToString());
                }
            }
            ennemiChoisie = GenererEnnemiAleatoire();
            PbEnnemi.Image = Globale.lesEnnemis[ennemiChoisie].GetImagePersonnage();
            LbDegatHeros.Text = "0";
            LbDegatEnnemi.Text = "0";
            LbPhrase.Text = "A VOUS D'ATTAQUER L'ENNEMI";
        }

        private void PbHeros_Click(object sender, EventArgs e)
        {
            FrmInventairePotions frmInventairePotions = new FrmInventairePotions(Globale.unInventaire, this);
            frmInventairePotions.Show();
        }

        private async void PbEnnemi_Click(object sender, EventArgs e)
        {
            for (herosChoisie = 0; herosChoisie < Globale.lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == Globale.lesHeros[herosChoisie].GetNomPersonnage())
                {
                    Globale.lesHeros[herosChoisie].Degats(Globale.choixHeros.GetDegatPersonnage());
                    // Le héros attaque l'ennemi choisi
                    Globale.lesHeros[herosChoisie].Attaquer(Globale.lesEnnemis[ennemiChoisie]);

                    // Mettre à jour l'affichage des points de vie de l'ennemi
                    LbPointsVieEnnemi.Text = $"{Globale.lesEnnemis[ennemiChoisie].GetPointsViePersonnage()} / {Globale.lesEnnemis[ennemiChoisie].GetPointsViePaeDefautl()}";
                    LbDegatHeros.Text = "- " + Globale.lesHeros[herosChoisie].GetDegatPersonnage() + " PV";

                    // Vérifier si l'ennemi est battu
                    if (Globale.lesEnnemis[ennemiChoisie].GetPointsViePersonnage() <= 0)
                    {
                        Random random = new Random();
                        int nombreExperienceGagne = random.Next(15, 31);
                        MessageBox.Show("L'ennemi a été battu ! Tu as gagné " + nombreExperienceGagne + " expériences !");
                        Globale.lesHeros[herosChoisie].AjouterExperience(nombreExperienceGagne);
                        FrmExploration frmExploration = new FrmExploration();
                        frmExploration.Show();
                        this.Close();
                        return;
                    }

                    // L'ennemi riposte
                    if (Globale.lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi1")
                    {
                        int nombreAleatoireDegatEnnemi1 = random.Next(3, 7);
                        Globale.lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi1);
                    }
                    else if (Globale.lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi2")
                    {
                        int nombreAleatoireDegatEnnemi2 = random.Next(4, 8);
                        Globale.lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi2);
                    }
                    else if (Globale.lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi3")
                    {
                        int nombreAleatoireDegatEnnemi3 = random.Next(6, 12);
                        Globale.lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi3);
                    }
                    else if (Globale.lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi4")
                    {
                        int nombreAleatoireDegatEnnemi4 = random.Next(8, 15);
                        Globale.lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi4);
                    }
                    else if (Globale.lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi5")
                    {
                        int nombreAleatoireDegatEnnemi5 = random.Next(10, 20);
                        Globale.lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi5);
                    }
                    else if (Globale.lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi6")
                    {
                        int nombreAleatoireDegatEnnemi6 = random.Next(12, 25);
                        Globale.lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi6);
                    }
                    else if (Globale.lesEnnemis[ennemiChoisie].GetNomPersonnage() == "Ennemi7")
                    {
                        int nombreAleatoireDegatEnnemi7 = random.Next(15, 30);
                        Globale.lesEnnemis[ennemiChoisie].Degats(nombreAleatoireDegatEnnemi7);
                    }

                    PbEnnemi.Enabled = false;
                    LbPhrase.Text = "L'ENNEMI VA VOUS ATTAQUER";
                    await Task.Delay(2000);

                    Globale.lesEnnemis[ennemiChoisie].Attaquer(Globale.lesHeros[herosChoisie]);
                    LbPointsVieHeros.Text = $"{Globale.lesHeros[herosChoisie].GetPointsViePersonnage()} / {Globale.lesHeros[herosChoisie].GetPointsViePaeDefautl()}";
                    LbDegatEnnemi.Text = "- " + Globale.lesEnnemis[ennemiChoisie].GetDegatPersonnage() + " PV";
                    LbPhrase.Text = "A VOTRE TOUR D'ATTAQUER L'ENNEMI";
                    PbEnnemi.Enabled = true;

                    if (Globale.lesHeros[herosChoisie].GetPointsViePersonnage() <= 0)
                    {
                        Random random = new Random();
                        int nombreExperiencePerdu = random.Next(10, 16);
                        MessageBox.Show("Vous avez été battu ! Tu as perdu " + nombreExperiencePerdu + " expériences.");
                        Globale.lesHeros[herosChoisie].RetirerExperience(nombreExperiencePerdu);
                        FrmExploration frmExploration = new FrmExploration();
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
            int ennemi = random.Next(Globale.lesEnnemis.Count);
            return ennemi;
        }

        private void BtnFuite_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veux-tu vraiment prendre la fuite ?", "Prendre la fuite ?", MessageBoxButtons.YesNo);
            Globale.unInventaire.Clear();
            for (herosChoisie = 0; herosChoisie < Globale.lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == Globale.lesHeros[herosChoisie].GetNomPersonnage())
                {
                    Globale.lesHeros[herosChoisie].RetirerExperience(50);
                }
            }
            FrmExploration frmExploration = new FrmExploration();
            frmExploration.Show();
            this.Hide();
        }

        public void MettreAJourPointsVieHeros()
        {
            LbPointsVieHeros.Text = $"{Globale.lesHeros[herosChoisie].GetPointsViePersonnage()} / {Globale.lesHeros[herosChoisie].GetPointsViePaeDefautl()}";
        }

        private void BtnFuite2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veux-tu vraiment prendre la fuite ?", "Prendre la fuite ?", MessageBoxButtons.YesNo);
            Globale.unInventaire.Clear();
            for (herosChoisie = 0; herosChoisie < Globale.lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == Globale.lesHeros[herosChoisie].GetNomPersonnage())
                {
                    Globale.lesHeros[herosChoisie].RetirerExperience(50);
                }
            }
            FrmExploration frmExploration = new FrmExploration();
            frmExploration.Show();
            this.Hide();
        }

        private void BtnFuite3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veux-tu vraiment prendre la fuite ?", "Prendre la fuite ?", MessageBoxButtons.YesNo);
            Globale.unInventaire.Clear();
            for (herosChoisie = 0; herosChoisie < Globale.lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == Globale.lesHeros[herosChoisie].GetNomPersonnage())
                {
                    Globale.lesHeros[herosChoisie].RetirerExperience(50);
                }
            }
            FrmExploration frmExploration = new FrmExploration();
            frmExploration.Show();
            this.Hide();
        }

        private void BtnFuite12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veux-tu vraiment prendre la fuite ?", "Prendre la fuite ?", MessageBoxButtons.YesNo);
            Globale.unInventaire.Clear();
            for (herosChoisie = 0; herosChoisie < Globale.lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == Globale.lesHeros[herosChoisie].GetNomPersonnage())
                {
                    Globale.lesHeros[herosChoisie].RetirerExperience(50);
                }
            }
            FrmExploration frmExploration = new FrmExploration();
            frmExploration.Show();
            this.Hide();
        }

        private void BtnFuite5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veux-tu vraiment prendre la fuite ?", "Prendre la fuite ?", MessageBoxButtons.YesNo);
            Globale.unInventaire.Clear();
            for (herosChoisie = 0; herosChoisie < Globale.lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == Globale.lesHeros[herosChoisie].GetNomPersonnage())
                {
                    Globale.lesHeros[herosChoisie].RetirerExperience(50);
                }
            }
            FrmExploration frmExploration = new FrmExploration();
            frmExploration.Show();
            this.Hide();
        }
    }
}
