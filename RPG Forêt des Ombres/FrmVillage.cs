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

        internal FrmVillage(List<Heros> lesHeros)
        {
            InitializeComponent();
            this.lesHeros = lesHeros;
        }

        private void FrmVillage_Load(object sender, EventArgs e)
        {

        }

        private void BtnHeros_Click(object sender, EventArgs e)
        {
            FrmHeros frmHeros = new FrmHeros(lesHeros);
            frmHeros.Show();
            this.Hide();
        }

        private void BtnArmesPotions_Click(object sender, EventArgs e)
        {

        }

        private void BtnParametres_Click(object sender, EventArgs e)
        {

        }
    }
}
