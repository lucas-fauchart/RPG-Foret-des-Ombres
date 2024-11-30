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
        private List<Heros> lesHeros;
        private List<Ennemi> lesEnnemi;
        private List<Objet> unInventaire;
        private int ennemiChoisie;
        private int herosChoisie;

        internal FrmCombat(List<Heros> lesHeros, List<Ennemi> lesEnnemi, List<Objet> unInventaire)
        {
            InitializeComponent();
            this.lesHeros = lesHeros;
            this.lesEnnemi = lesEnnemi;
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
            PbEnnemi.Image = lesEnnemi[ennemiChoisie].GetImagePersonnage();
            LbPointsVieEnnemi.Text = $"{lesEnnemi[ennemiChoisie].GetPointsViePersonnage()} / {lesEnnemi[ennemiChoisie].GetPointsViePaeDefautl()}";
        }

        private void BtnAttaque_Click(object sender, EventArgs e)
        {
            for (herosChoisie = 0; herosChoisie < lesHeros.Count; herosChoisie++)
            {
                if (Globale.choixHeros.GetNomPersonnage() == lesHeros[herosChoisie].GetNomPersonnage())
                {
                    // Le héros attaque l'ennemi choisi
                    lesHeros[herosChoisie].Attaquer(lesEnnemi[ennemiChoisie]);

                    // Mettre à jour l'affichage des points de vie de l'ennemi
                    LbPointsVieEnnemi.Text = $"{lesEnnemi[ennemiChoisie].GetPointsViePersonnage()} / {lesEnnemi[ennemiChoisie].GetPointsViePaeDefautl()}";

                    // Vérifier si l'ennemi est battu
                    if (lesEnnemi[ennemiChoisie].GetPointsViePersonnage() <= 0)
                    {
                        Random random = new Random();
                        int nombreExperienceGagne = random.Next(15, 31);
                        MessageBox.Show("L'ennemi a été battu ! Tu as gagné " + nombreExperienceGagne + " expériences !");
                        lesHeros[herosChoisie].AjouterExperience(nombreExperienceGagne);
                        FrmExploration frmExploration = new FrmExploration(lesHeros);
                        frmExploration.Show();
                        this.Close();
                        return;
                    }

                    // L'ennemi riposte
                    lesEnnemi[ennemiChoisie].Attaquer(lesHeros[herosChoisie]);

                    // Mettre à jour l'affichage des points de vie du héros
                    LbPointsVieHeros.Text = $"{lesHeros[herosChoisie].GetPointsViePersonnage()} / {lesHeros[herosChoisie].GetPointsViePaeDefautl()}";

                    // Vérifier si le héros est battu
                    if (lesHeros[herosChoisie].GetPointsViePersonnage() <= 0)
                    {
                        Random random = new Random();
                        int nombreExperiencePerdu = random.Next(10, 16);
                        MessageBox.Show("Vous avez été battu ! Tu as perdu " + nombreExperiencePerdu + " expériences.");
                        lesHeros[herosChoisie].RetirerExperience(nombreExperiencePerdu);
                        FrmExploration frmExploration = (FrmExploration)this.Owner;
                        frmExploration.MettreAJourNiveauExperience();
                        this.Close();
                        return;
                    }
                }
            }
        }
        public int GenererEnnemiAleatoire()
        {
            Random random = new Random();
            int ennemi = random.Next(lesEnnemi.Count);
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
            FrmExploration frmExploration = new FrmExploration(lesHeros);
            frmExploration.Show();
            this.Hide();
        }


        private void LbPointsVieParDefault_Click(object sender, EventArgs e)
        {

        }
    }
}
