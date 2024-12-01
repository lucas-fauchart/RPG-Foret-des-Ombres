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
        private List<Heros> lesHeros;
        private List<Arme> lesArmes;
        private List<Potion> lesPotions;
        private List<Ennemi> lesEnnemis;

        internal FrmVillage(List<Heros> lesHeros, List<Arme> lesArmes, List<Potion> lesPotions)
        {
            InitializeComponent();
            this.lesHeros = lesHeros;
            this.lesArmes = lesArmes;
            this.lesPotions = lesPotions;
        }

        private void FrmVillage_Load(object sender, EventArgs e)
        {

        }

        private void BtnHeros_Click(object sender, EventArgs e)
        {
            FrmHeros frmHeros = new FrmHeros(lesHeros, lesArmes, lesPotions);
            frmHeros.Show();
            this.Hide();
        }

        private void BtnArmesPotions_Click(object sender, EventArgs e)
        {
            FrmArmesPotions frmArmesPotions = new FrmArmesPotions(lesArmes, lesPotions);
            frmArmesPotions.Show();
            this.Hide();
        }

        private void BtnParametres_Click(object sender, EventArgs e)
        {

        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmExploration frmExploration = new FrmExploration(lesHeros, lesEnnemis, lesArmes, lesPotions);
            frmExploration.Show();
            this.Hide();
        }
    }
}
