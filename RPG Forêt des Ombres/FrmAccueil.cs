namespace RPG_Forêt_des_Ombres
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {

        }

        private void BtnChargerPartie_Click(object sender, EventArgs e)
        {
            //Permet d'ouvrir la fenêtre
            FrmExploration frmExploration = new FrmExploration();
            frmExploration.Show();
            this.Hide();
        }
    }
}