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
    public partial class FrmHeros : Form
    {
        internal FrmHeros()
        {
            InitializeComponent();
        }

        private void FrmHeros_Load(object sender, EventArgs e)
        {
            BtnRetour.BackgroundImage = Image.FromFile("Images/Bouton/BoutonRetour.png");

            foreach (Heros unHeros in Globale.lesHeros)
            {
                CbNomHeros.Items.Add(unHeros.GetNomPersonnage());
            }

            CbNomHeros.SelectedIndex = 0;

        }

        private void CbNomHeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Heros herosSelectionner = Globale.lesHeros[CbNomHeros.SelectedIndex];
            PbImageHeros.Image = herosSelectionner.GetImagePersonnage();
            LbNomHeros.Text = herosSelectionner.GetNomPersonnage();
            LbDescriptionHeros.Text = herosSelectionner.GetDescriptionPersonnage();
            LbPointVieHeros.Text = herosSelectionner.GetPointsViePersonnage().ToString();
            LbDegatHeros.Text = herosSelectionner.GetDegatPersonnage().ToString();
            LbNiveauHeros.Text = herosSelectionner.GetNiveau().ToString();
            this.BackgroundImage = herosSelectionner.GetImageFondVillage();

        }

        private void BtnChoisirHeros_Click(object sender, EventArgs e)
        {
            Globale.choixHeros = Globale.lesHeros[CbNomHeros.SelectedIndex];
            MessageBox.Show("L'héros " + Globale.lesHeros[CbNomHeros.SelectedIndex].GetNomPersonnage() + " a était selectionné");
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmVillage frmVillage = new FrmVillage();
            frmVillage.Show();
            this.Hide();
        }
    }
}
