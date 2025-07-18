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

        private void FrmArmesPotions_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Images/Fond/FondVillage.png");
            BtnRetour.BackgroundImage = Image.FromFile("Images/Bouton/BoutonRetour.png");
            BtnArme.BackgroundImage = Image.FromFile("Images/Bouton/BoutonArme.png");
            BtnPotion.BackgroundImage = Image.FromFile("Images/Bouton/BoutonPotion.png");
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmVillage frmVillage = new FrmVillage();
            frmVillage.Show();
            this.Hide();
        }

        private void BtnArme_Click(object sender, EventArgs e)
        {
            FrmArme frmArme = new FrmArme();
            frmArme.Show();
            this.Hide();
        }

        private void BtnPotion_Click(object sender, EventArgs e)
        {
            FrmPotions frmPotions = new FrmPotions();
            frmPotions.Show();
            this.Hide();
        }
    }
}
