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
    public partial class FrmParametres : Form
    {
        public FrmParametres()
        {
            InitializeComponent();
        }



        private void BtnDesactiveMusique_Click(object sender, EventArgs e)
        {
            GestionMusique.StopBackgroundMusic();
        }

        private void BtnActiveMusique_Click(object sender, EventArgs e)
        {
            GestionMusique.StartBackgroundMusic();
        }

        private void FrmParametres_Load(object sender, EventArgs e)
        {
            BtnRetour.BackgroundImage = Image.FromFile("Images/Bouton/BoutonRetour.png");
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmVillage frmVillage = new FrmVillage();
            frmVillage.Show();
            this.Hide();
        }
    }
}
