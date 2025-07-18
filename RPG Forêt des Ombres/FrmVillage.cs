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
    public partial class FrmVillage : Form
    {
        internal FrmVillage()
        {
            InitializeComponent();
        }

        private void FrmVillage_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Images/Fond/FondVillage.png");
            BtnRetour.BackgroundImage = Image.FromFile("Images/Bouton/BoutonRetour.png");
            BtnHeros.BackgroundImage = Image.FromFile("Images/Bouton/BoutonHeros.png");
            BtnArmesPotions.BackgroundImage = Image.FromFile("Images/Bouton/BoutonArmePotion.png");
            BtnParametres.BackgroundImage = Image.FromFile("Images/Bouton/BoutonParametre.png");
        }

        private void BtnHeros_Click(object sender, EventArgs e)
        {
            FrmHeros frmHeros = new FrmHeros();
            frmHeros.Show();
            this.Hide();
        }

        private void BtnArmesPotions_Click(object sender, EventArgs e)
        {
            FrmArmesPotions frmArmesPotions = new FrmArmesPotions();
            frmArmesPotions.Show();
            this.Hide();
        }

        private void BtnParametres_Click(object sender, EventArgs e)
        {
            FrmParametres frmParametres = new FrmParametres();
            frmParametres.Show();
            this.Hide();
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmExploration frmExploration = new FrmExploration();
            frmExploration.Show();
            this.Hide();
        }
    }
}
