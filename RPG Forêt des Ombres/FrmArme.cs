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
    public partial class FrmArme : Form
    {
        public FrmArme()
        {
            InitializeComponent();
        }

        private void PbEpee_Click(object sender, EventArgs e)
        {

        }

        private void LbDescriptionBatteBaseball_Click(object sender, EventArgs e)
        {

        }

        private void PbHache_Click(object sender, EventArgs e)
        {

        }

        private void FrmArme_Load(object sender, EventArgs e)
        {
            BtnRetour.BackgroundImage = Image.FromFile("Images/Bouton/BoutonRetour.png");

            Arme uneArmeMarteau = Globale.lesArmes[0];
            PbMarteau.Image = uneArmeMarteau.GetImageObjet();
            LbNomMarteau.Text = uneArmeMarteau.GetNomObjet();
            LbDescriptionMarteau.Text = uneArmeMarteau.GetDescriptionObjet();
            LbDegatSupplementaireMarteau.Text = "Dégât : " + uneArmeMarteau.GetDegatsPossible();

            Arme uneArmePioche = Globale.lesArmes[1];
            PbPioche.Image = uneArmePioche.GetImageObjet();
            LbNomPioche.Text = uneArmePioche.GetNomObjet();
            LbDescriptionPioche.Text = uneArmePioche.GetDescriptionObjet();
            LbDegatSupplementairePioche.Text = "Dégât : " + uneArmePioche.GetDegatsPossible();

            Arme uneArmeHache = Globale.lesArmes[2];
            PbHache.Image = uneArmeHache.GetImageObjet();
            LbNomHache.Text = uneArmeHache.GetNomObjet();
            LbDescriptionHache.Text = uneArmeHache.GetDescriptionObjet();
            LbDegatSupplementaireHache.Text = "Dégât : " + uneArmeHache.GetDegatsPossible();

            Arme uneArmeBatteBaseball = Globale.lesArmes[3];
            PbBatteBaseball.Image = uneArmeBatteBaseball.GetImageObjet();
            LbNomBatteBaseball.Text = uneArmeBatteBaseball.GetNomObjet();
            LbDescriptionBatteBaseball.Text = uneArmeBatteBaseball.GetDescriptionObjet();
            LbDegatSupplementaireBatteBaseball.Text = "Dégât : " + uneArmeBatteBaseball.GetDegatsPossible();

            Arme uneArmeEpee = Globale.lesArmes[4];
            PbEpee.Image = uneArmeEpee.GetImageObjet();
            LbNomEpee.Text = uneArmeEpee.GetNomObjet();
            LbDescriptionEpee.Text = uneArmeEpee.GetDescriptionObjet();
            LbDegatSupplementaireEpee.Text = "Dégât : " + uneArmeEpee.GetDegatsPossible();
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmArmesPotions frmArmesPotions = new FrmArmesPotions();
            frmArmesPotions.Show();
            this.Hide();
        }
    }
}
