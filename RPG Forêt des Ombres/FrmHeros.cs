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
    public partial class FrmHeros : Form
    {
        private List<Heros> lesHeros;

        internal FrmHeros(List<Heros> lesHeros)
        {
            InitializeComponent();
            this.lesHeros = lesHeros;
        }

        private void FrmHeros_Load(object sender, EventArgs e)
        {
            foreach (Heros unHeros in lesHeros)
            {
                CbNomHeros.Items.Add(unHeros.GetNomPersonnage());
            }

            CbNomHeros.SelectedIndex = -1;
        }

        private void CbNomHeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Heros herosSelectionner = lesHeros[CbNomHeros.SelectedIndex];
            PbImageHeros.Image = herosSelectionner.GetImagePersonnage();
            LbNomHeros.Text = herosSelectionner.GetNomPersonnage();
            LbDescriptionHeros.Text = herosSelectionner.GetDescriptionPersonnage();
            LbPointVieHeros.Text = herosSelectionner.GetPointsViePersonnage().ToString();
            LbDegatHeros.Text = herosSelectionner.GetDegatPersonnage().ToString();
            LbNiveauHeros.Text = herosSelectionner.GetNiveau().ToString();        
        }

        private void BtnChoisirHeros_Click(object sender, EventArgs e)
        {
            Heros choixHeros = lesHeros[CbNomHeros.SelectedIndex];
        }
    }
}
