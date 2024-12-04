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
            BtnRevenirAuCombat = new Button();
            SuspendLayout();
            // 
            // FlpInventaireJoueur
            // 
            FlpInventaireJoueur.Location = new Point(12, 16);
            FlpInventaireJoueur.Name = "FlpInventaireJoueur";
            FlpInventaireJoueur.Size = new Size(235, 88);
            FlpInventaireJoueur.TabIndex = 11;
            // 
            // BtnRevenirAuCombat
            // 
            BtnRevenirAuCombat.Location = new Point(55, 126);
            BtnRevenirAuCombat.Name = "BtnRevenirAuCombat";
            BtnRevenirAuCombat.Size = new Size(150, 29);
            BtnRevenirAuCombat.TabIndex = 12;
            BtnRevenirAuCombat.Text = "Revenir au combat";
            BtnRevenirAuCombat.UseVisualStyleBackColor = true;
            BtnRevenirAuCombat.Click += BtnRevenirAuCombat_Click;
            // 
            // FrmInventairePotions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(262, 167);
            Controls.Add(BtnRevenirAuCombat);
            Controls.Add(FlpInventaireJoueur);
            Location = new Point(100, 100);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInventairePotions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInventairePotions";
            Load += FrmInventairePotions_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlpInventaireJoueur;
        private Button BtnRevenirAuCombat;
    }
}