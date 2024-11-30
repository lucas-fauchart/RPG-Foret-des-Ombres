namespace RPG_Forêt_des_Ombres
{
    public partial class FrmAccueil : Form
    {
        private List<Heros> lesHeros = new List<Heros>();

        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {
            //Génére les héros
            lesHeros.Add(new Heros("Arthur", "Un jeune héros déterminé à prouver sa valeur.", 100, 100, 15, Image.FromFile("Images/arthur.png"), 0, 0));
            lesHeros.Add(new Heros("Edgar", "Un combattant musclé qui ne connaît pas la peur.", 120, 120, 10, Image.FromFile("Images/edgar.png"), 0, 0));
            lesHeros.Add(new Heros("Gabriel", "Un grand au cœur tendre, mais redoutable au combat.", 105, 105, 12, Image.FromFile("Images/gabriel.png"), 0, 0));
            lesHeros.Add(new Heros("Lina", "Rapide et forte, elle ne recule devant rien.", 90, 90, 18, Image.FromFile("Images/lina.png"), 0, 0));
            lesHeros.Add(new Heros("Sofia", "Toujours prête à explorer de nouveaux horizons.", 100, 100, 15, Image.FromFile("Images/sofia.png"), 0, 0));
        }

        private void BtnChargerPartie_Click(object sender, EventArgs e)
        {
            //Permet d'ouvrir la fenêtre
            FrmExploration frmExploration = new FrmExploration(lesHeros);
            frmExploration.Show();
            this.Hide();
        }
    }
}