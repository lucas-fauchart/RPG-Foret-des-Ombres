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
    public partial class FrmPotions : Form
    {
        public FrmPotions()
        {
            InitializeComponent();
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmArmesPotions frmArmesPotions = new FrmArmesPotions();
            frmArmesPotions.Show();
            this.Hide();
        }

        private void FrmPotions_Load(object sender, EventArgs e)
        {
            BtnRetour.BackgroundImage = Image.FromFile("Images/Bouton/BoutonRetour.png");

            Potion unePotionPotionGuerisonFaible = Globale.lesPotions[0];
            PbPotionGuerisonFaible.Image = unePotionPotionGuerisonFaible.GetImageObjet();
            LbNomPotionGuerisionFaible.Text = unePotionPotionGuerisonFaible.GetNomObjet();
            LbDescriptionPotionGuerisonFaible.Text = unePotionPotionGuerisonFaible.GetDescriptionObjet();
            LbPointsVieSupplementaireElexirRegeneration.Text = "Vie : " + unePotionPotionGuerisonFaible.GetBonusPointsVie().ToString();

            Potion unePotionElexirRegeneration = Globale.lesPotions[1];
            PbElexirRegeneration.Image = unePotionElexirRegeneration.GetImageObjet();
            LbNomElexirRegeneration.Text = unePotionElexirRegeneration.GetNomObjet();
            LbDescriptionElexirRegeneration.Text = unePotionElexirRegeneration.GetDescriptionObjet();
            LbPointsVieSupplementaireElexirRegeneration.Text = "Vie : " + unePotionElexirRegeneration.GetBonusPointsVie().ToString();

            Potion unePotionNectarVie = Globale.lesPotions[2];
            PbNectarVie.Image = unePotionNectarVie.GetImageObjet();
            LbNomNectarVie.Text = unePotionNectarVie.GetNomObjet();
            LbDescriptionNectarVie.Text = unePotionNectarVie.GetDescriptionObjet();
            LbPointsVieSupplementaireNectarVie.Text = "Vie : " + unePotionNectarVie.GetBonusPointsVie().ToString();
        }
    }
}
