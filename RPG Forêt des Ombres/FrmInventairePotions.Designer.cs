namespace RPG_Forêt_des_Ombres
{
    partial class FrmInventairePotions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FlpInventaireJoueur = new FlowLayoutPanel();
            BtnRetour = new Button();
            SuspendLayout();
            // 
            // FlpInventaireJoueur
            // 
            FlpInventaireJoueur.BackColor = Color.Transparent;
            FlpInventaireJoueur.Location = new Point(21, 12);
            FlpInventaireJoueur.Name = "FlpInventaireJoueur";
            FlpInventaireJoueur.Size = new Size(187, 88);
            FlpInventaireJoueur.TabIndex = 11;
            FlpInventaireJoueur.Paint += FlpInventaireJoueur_Paint;
            // 
            // BtnRetour
            // 
            BtnRetour.BackColor = Color.Transparent;
            BtnRetour.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRetour.FlatAppearance.BorderSize = 0;
            BtnRetour.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnRetour.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnRetour.FlatStyle = FlatStyle.Flat;
            BtnRetour.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRetour.ForeColor = Color.White;
            BtnRetour.Location = new Point(83, 120);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(62, 60);
            BtnRetour.TabIndex = 12;
            BtnRetour.UseVisualStyleBackColor = false;
            BtnRetour.Click += BtnRevenirAuCombat_Click;
            // 
            // FrmInventairePotions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(216, 203);
            Controls.Add(BtnRetour);
            Controls.Add(FlpInventaireJoueur);
            Location = new Point(100, 100);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInventairePotions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventaire";
            Load += FrmInventairePotions_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlpInventaireJoueur;
        private Button BtnRetour;
    }
}