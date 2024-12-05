namespace RPG_Forêt_des_Ombres
{
    public partial class FrmExploration : Form
    {
        internal FrmExploration()
        {
            InitializeComponent();
        }

        private void FrmExploration_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Images/Fond/FondExploration.png");
            Globale.unInventaire.Clear();

            LbExperience.Text = (Globale.choixHeros.GetExperience().ToString() + "/100");
            LbNiveau.Text = Globale.choixHeros.GetNiveau().ToString();
        }

        private void BtnForet1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int nombreAleatoire = random.Next(0, 100);
            int nombreArmeInventaire = Globale.unInventaire.OfType<Arme>().Count();
            int nombrePotionInventaire = Globale.unInventaire.OfType<Potion>().Count();

            if (nombreArmeInventaire == 1 && nombrePotionInventaire == 2)
            {
                if (Globale.choixHeros.GetNomPersonnage() == "Arthur" || Globale.choixHeros.GetNomPersonnage() == "Edgar" || Globale.choixHeros.GetNomPersonnage() == "Gabriel" || Globale.choixHeros.GetNomPersonnage() == "Lina" || Globale.choixHeros.GetNomPersonnage() == "Sofia")
                {
                    TbListeEvenement.AppendText("Au combat ! Vous venez de rencontrer un ennemi. \r\n");
                    //Ouvre interface combat
                    FrmCombat frmCombat = new FrmCombat();
                    frmCombat.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tu n'as pas selectionné d'héros");
                }

            }
            else if (nombreAleatoire > 0 && nombreAleatoire < 98)
            {
                if (Globale.unInventaire.Count < 3)
                {
                    GenererObjetAleatoire();
                    AfficherInventaire();
                    TbListeEvenement.AppendText("Oh. Vous avez trouvé un objet ! \r\n");
                }
                else
                {
                    MessageBox.Show("Votre inventaire est plein !");
                }
            }
            else if (nombreAleatoire > 99 && nombreAleatoire < 101)
            {
                TbListeEvenement.AppendText("Mince ! Vous n'avez rien trouvez. \r\n");
            }
        }

        private void BtnForet2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int nombreAleatoire = random.Next(0, 100);
            int nombreArmeInventaire = Globale.unInventaire.OfType<Arme>().Count();
            int nombrePotionInventaire = Globale.unInventaire.OfType<Potion>().Count();

            if (nombreArmeInventaire == 1 && nombrePotionInventaire == 2)
            {
                if (Globale.choixHeros.GetNomPersonnage() == "Arthur" || Globale.choixHeros.GetNomPersonnage() == "Edgar" || Globale.choixHeros.GetNomPersonnage() == "Gabriel" || Globale.choixHeros.GetNomPersonnage() == "Lina" || Globale.choixHeros.GetNomPersonnage() == "Sofia")
                {
                    TbListeEvenement.AppendText("Au combat ! Vous venez de rencontrer un ennemi. \r\n");
                    //Ouvre interface combat
                    FrmCombat frmCombat = new FrmCombat();
                    frmCombat.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tu n'as pas selectionné d'héros");
                }

            }
            else if (nombreAleatoire > 0 && nombreAleatoire < 98)
            {
                if (Globale.unInventaire.Count < 3)
                {
                    GenererObjetAleatoire();
                    AfficherInventaire();
                    TbListeEvenement.AppendText("Oh. Vous avez trouvé un objet ! \r\n");
                }
                else
                {
                    MessageBox.Show("Votre inventaire est plein !");
                }
            }
            else if (nombreAleatoire > 99 && nombreAleatoire < 101)
            {
                TbListeEvenement.AppendText("Mince ! Vous n'avez rien trouvez. \r\n");
            }
        }

        private void BtnForet3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int nombreAleatoire = random.Next(0, 100);
            int nombreArmeInventaire = Globale.unInventaire.OfType<Arme>().Count();
            int nombrePotionInventaire = Globale.unInventaire.OfType<Potion>().Count();

            if (nombreArmeInventaire == 1 && nombrePotionInventaire == 2)
            {
                if (Globale.choixHeros.GetNomPersonnage() == "Arthur" || Globale.choixHeros.GetNomPersonnage() == "Edgar" || Globale.choixHeros.GetNomPersonnage() == "Gabriel" || Globale.choixHeros.GetNomPersonnage() == "Lina" || Globale.choixHeros.GetNomPersonnage() == "Sofia")
                {
                    TbListeEvenement.AppendText("Au combat ! Vous venez de rencontrer un ennemi. \r\n");
                    //Ouvre interface combat
                    FrmCombat frmCombat = new FrmCombat();
                    frmCombat.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tu n'as pas selectionné d'héros");
                }

            }
            else if (nombreAleatoire > 0 && nombreAleatoire < 98)
            {
                if (Globale.unInventaire.Count < 3)
                {
                    GenererObjetAleatoire();
                    AfficherInventaire();
                    TbListeEvenement.AppendText("Oh. Vous avez trouvé un objet ! \r\n");
                }
                else
                {
                    MessageBox.Show("Votre inventaire est plein !");
                }
            }
            else if (nombreAleatoire > 99 && nombreAleatoire < 101)
            {
                TbListeEvenement.AppendText("Mince ! Vous n'avez rien trouvez. \r\n");
            }
        }

        private void BtnVillage_Click(object sender, EventArgs e)
        {
            FrmVillage frmVillage = new FrmVillage();
            frmVillage.Show();
            this.Hide();
        }

        public void GenererObjetAleatoire()
        {
            Random random = new Random();
            int choix = random.Next(0, 2);
            int nombreArmeInventaire = Globale.unInventaire.OfType<Arme>().Count();
            int nombrePotionInventaire = Globale.unInventaire.OfType<Potion>().Count();
            if (nombreArmeInventaire < 1)
            {
                int armeChoisie = random.Next(Globale.lesArmes.Count);
                Arme arme = Globale.lesArmes[armeChoisie];
                Globale.unInventaire.Add(arme);
            }
            else if (nombrePotionInventaire < 2)
            {
                int potionChoisie = random.Next(Globale.lesPotions.Count);
                Potion potion = Globale.lesPotions[potionChoisie];
                Globale.unInventaire.Add(potion);
            }
        }

        public void AfficherInventaire()
        {
            FlpInventaireJoueur.Controls.Clear();

            foreach (Objet unObjet in Globale.unInventaire)
            {
                Panel panelObjet = new Panel() { Width = 80, Height = 80, BorderStyle = BorderStyle.FixedSingle };

                PictureBox PbItem = new PictureBox() { Width = 75, Height = 75, Image = unObjet.GetImageObjet(), SizeMode = PictureBoxSizeMode.Zoom, Dock = DockStyle.Top };

                panelObjet.Controls.Add(PbItem);

                FlpInventaireJoueur.Controls.Add(panelObjet);
            }
        }

        public void MettreAJourNiveauExperience()
        {
            // Mettre à jour l'affichage de l'expérience et du niveau
            LbExperience.Text = Globale.choixHeros.GetExperience().ToString();
            LbNiveau.Text = Globale.choixHeros.GetNiveau().ToString();
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {

        }
    }
}
