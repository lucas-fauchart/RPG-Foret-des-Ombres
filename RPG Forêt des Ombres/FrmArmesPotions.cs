using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPG_Forêt_des_Ombres
{
    public partial class FrmArmesPotions : Form
    {
        internal FrmArmesPotions()
        {
            InitializeComponent();
        }

        private void PbHache_Click(object sender, EventArgs e)
        {

        }

        private void FrmArmesPotions_Load(object sender, EventArgs e)
        {
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
