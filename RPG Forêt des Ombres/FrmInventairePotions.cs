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
    public partial class FrmInventairePotions : Form
    {
        private List<Objet> unInventaire;
        PictureBox PbItem = new PictureBox() { };
        private FrmCombat frmCombat;

        internal FrmInventairePotions(List<Objet> unInventaire, FrmCombat frmCombat)
        {
            InitializeComponent();
            this.unInventaire = unInventaire;
            this.frmCombat = frmCombat;
        }

        private void FrmInventairePotions_Load(object sender, EventArgs e)
        {
            BtnRetour.BackgroundImage = Image.FromFile("Images/Bouton/BoutonRetour.png");
            this.BackgroundImage = Image.FromFile("Images/Fond/FondInventaire.png");
            foreach (Objet unObjet in unInventaire)
            {
                if (unObjet.GetTypeObjet() == "Potion")
                {
                    // Vérifier que l'objet est bien une potion
                    if (unObjet is Potion unePotion)
                    {
                        // Créer un panel pour l'objet
                        Panel panelObjet = new Panel()
                        {
                            Width = 80,
                            Height = 80,
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        // Créer une PictureBox spécifique pour cet objet
                        PictureBox PbItem = new PictureBox()
                        {
                            Width = 75,
                            Height = 75,
                            Image = unObjet.GetImageObjet(),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Dock = DockStyle.Top,
                            BorderStyle = BorderStyle.None
                        };

                        // Ajouter la PictureBox au panel
                        panelObjet.Controls.Add(PbItem);

                        // Ajouter le panel au FlowLayoutPanel
                        FlpInventaireJoueur.Controls.Add(panelObjet);

                        // Ajouter un gestionnaire d'événement click à cette PictureBox
                        PbItem.Click += (s, ev) =>
                        {
                            if (Globale.choixHeros.GetPointsViePersonnage() < Globale.choixHeros.GetPointsViePaeDefautl())
                            {
                                int pointsVieActuels = Globale.choixHeros.GetPointsViePersonnage();
                                int pointsVieMax = Globale.choixHeros.GetPointsViePaeDefautl();
                                int bonusPotion = unePotion.GetBonusPointsVie();

                                if (pointsVieActuels + bonusPotion <= pointsVieMax)
                                {
                                    Globale.choixHeros.AjouterPointVie(unePotion.GetBonusPointsVie());
                                    MessageBox.Show($"Tu as utilisé une potion ! Points de vie ajoutés : {unePotion.GetBonusPointsVie()}");
                                    unInventaire.Remove(unObjet);
                                    RafraichirInventaire();
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Tu ne peux pas utiliser cette potion car tu as trop de points de vie.");
                                }
                            }
                        };
                    }
                }
            }
        }

        private void BtnRevenirAuCombat_Click(object sender, EventArgs e)
        {
            frmCombat.MettreAJourPointsVieHeros();
            this.Close();
        }

        private void RafraichirInventaire()
        {
            // Nettoyer le FlowLayoutPanel
            FlpInventaireJoueur.Controls.Clear();

            // Recharger les potions restantes
            foreach (Objet unObjet in unInventaire)
            {
                if (unObjet.GetTypeObjet() == "Potion" && unObjet is Potion unePotion)
                {
                    // Créer un panel pour l'objet
                    Panel panelObjet = new Panel()
                    {
                        Width = 80,
                        Height = 80,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Créer une PictureBox spécifique pour cet objet
                    PictureBox PbItem = new PictureBox()
                    {
                        Width = 75,
                        Height = 75,
                        Image = unePotion.GetImageObjet(),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Top
                    };

                    // Ajouter la PictureBox au panel
                    panelObjet.Controls.Add(PbItem);

                    // Ajouter le panel au FlowLayoutPanel
                    FlpInventaireJoueur.Controls.Add(panelObjet);

                    // Ajouter un gestionnaire d'événement click à cette PictureBox
                    PbItem.Click += (s, ev) =>
                    {
                        Globale.choixHeros.AjouterPointVie(unePotion.GetBonusPointsVie());
                        MessageBox.Show($"Vous avez utilisé une potion ! Points de vie ajoutés : {unePotion.GetBonusPointsVie()}");
                        unInventaire.Remove(unePotion);
                        RafraichirInventaire();
                        frmCombat.MettreAJourPointsVieHeros();
                    };
                }
            }
        }

        private void FlpInventaireJoueur_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
