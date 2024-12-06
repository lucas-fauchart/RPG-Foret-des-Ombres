namespace RPG_Forêt_des_Ombres
{
    partial class FrmExploration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExploration));
            BtnForet1 = new Button();
            BtnForet2 = new Button();
            BtnForet3 = new Button();
            BtnVillage = new Button();
            Lb2 = new Label();
            LbNiveau = new Label();
            LbExperience = new Label();
            TbListeEvenement = new TextBox();
            FlpInventaireJoueur = new FlowLayoutPanel();
            Lb1 = new Label();
            Lb3 = new Label();
            BtnSauvegarder = new Button();
            BtnSauvegarderQuitter = new Button();
            SuspendLayout();
            // 
            // BtnForet1
            // 
            BtnForet1.BackColor = Color.Transparent;
            BtnForet1.FlatAppearance.BorderSize = 0;
            BtnForet1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnForet1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnForet1.FlatStyle = FlatStyle.Flat;
            BtnForet1.ForeColor = Color.Transparent;
            BtnForet1.Location = new Point(0, 0);
            BtnForet1.Name = "BtnForet1";
            BtnForet1.Size = new Size(484, 553);
            BtnForet1.TabIndex = 0;
            BtnForet1.UseVisualStyleBackColor = false;
            BtnForet1.Click += BtnForet1_Click;
            // 
            // BtnForet2
            // 
            BtnForet2.BackColor = Color.Transparent;
            BtnForet2.FlatAppearance.BorderSize = 0;
            BtnForet2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnForet2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnForet2.FlatStyle = FlatStyle.Flat;
            BtnForet2.ForeColor = Color.Transparent;
            BtnForet2.Location = new Point(480, 0);
            BtnForet2.Name = "BtnForet2";
            BtnForet2.Size = new Size(502, 248);
            BtnForet2.TabIndex = 1;
            BtnForet2.UseVisualStyleBackColor = false;
            BtnForet2.Click += BtnForet2_Click;
            // 
            // BtnForet3
            // 
            BtnForet3.BackColor = Color.Transparent;
            BtnForet3.FlatAppearance.BorderSize = 0;
            BtnForet3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnForet3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnForet3.FlatStyle = FlatStyle.Flat;
            BtnForet3.ForeColor = Color.Transparent;
            BtnForet3.Location = new Point(480, 245);
            BtnForet3.Name = "BtnForet3";
            BtnForet3.Size = new Size(311, 38);
            BtnForet3.TabIndex = 2;
            BtnForet3.UseVisualStyleBackColor = false;
            BtnForet3.Click += BtnForet3_Click;
            // 
            // BtnVillage
            // 
            BtnVillage.BackColor = Color.Transparent;
            BtnVillage.FlatAppearance.BorderSize = 0;
            BtnVillage.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnVillage.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnVillage.FlatStyle = FlatStyle.Flat;
            BtnVillage.ForeColor = Color.Transparent;
            BtnVillage.Location = new Point(699, 326);
            BtnVillage.Name = "BtnVillage";
            BtnVillage.Size = new Size(230, 204);
            BtnVillage.TabIndex = 3;
            BtnVillage.UseVisualStyleBackColor = false;
            BtnVillage.Click += BtnVillage_Click;
            // 
            // Lb2
            // 
            Lb2.AutoSize = true;
            Lb2.BackColor = Color.Transparent;
            Lb2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lb2.ForeColor = Color.White;
            Lb2.Location = new Point(33, 71);
            Lb2.Name = "Lb2";
            Lb2.Size = new Size(174, 38);
            Lb2.TabIndex = 5;
            Lb2.Text = "Expérience :";
            // 
            // LbNiveau
            // 
            LbNiveau.AutoSize = true;
            LbNiveau.BackColor = Color.Transparent;
            LbNiveau.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LbNiveau.ForeColor = Color.White;
            LbNiveau.Location = new Point(155, 27);
            LbNiveau.Name = "LbNiveau";
            LbNiveau.Size = new Size(33, 38);
            LbNiveau.TabIndex = 6;
            LbNiveau.Text = "0";
            // 
            // LbExperience
            // 
            LbExperience.AutoSize = true;
            LbExperience.BackColor = Color.Transparent;
            LbExperience.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LbExperience.ForeColor = Color.White;
            LbExperience.Location = new Point(204, 71);
            LbExperience.Name = "LbExperience";
            LbExperience.Size = new Size(61, 38);
            LbExperience.TabIndex = 7;
            LbExperience.Text = "0/0";
            // 
            // TbListeEvenement
            // 
            TbListeEvenement.BackColor = Color.SandyBrown;
            TbListeEvenement.BorderStyle = BorderStyle.None;
            TbListeEvenement.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TbListeEvenement.ForeColor = Color.White;
            TbListeEvenement.Location = new Point(648, 27);
            TbListeEvenement.Multiline = true;
            TbListeEvenement.Name = "TbListeEvenement";
            TbListeEvenement.ReadOnly = true;
            TbListeEvenement.ScrollBars = ScrollBars.Vertical;
            TbListeEvenement.Size = new Size(310, 99);
            TbListeEvenement.TabIndex = 8;
            // 
            // FlpInventaireJoueur
            // 
            FlpInventaireJoueur.BackColor = Color.SandyBrown;
            FlpInventaireJoueur.Location = new Point(33, 442);
            FlpInventaireJoueur.Name = "FlpInventaireJoueur";
            FlpInventaireJoueur.Size = new Size(259, 88);
            FlpInventaireJoueur.TabIndex = 10;
            // 
            // Lb1
            // 
            Lb1.AutoSize = true;
            Lb1.BackColor = Color.Transparent;
            Lb1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lb1.ForeColor = Color.White;
            Lb1.Location = new Point(33, 27);
            Lb1.Name = "Lb1";
            Lb1.Size = new Size(125, 38);
            Lb1.TabIndex = 4;
            Lb1.Text = "Niveau :";
            // 
            // Lb3
            // 
            Lb3.AutoSize = true;
            Lb3.BackColor = Color.Transparent;
            Lb3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lb3.ForeColor = Color.Transparent;
            Lb3.ImageAlign = ContentAlignment.MiddleLeft;
            Lb3.Location = new Point(33, 401);
            Lb3.Name = "Lb3";
            Lb3.Size = new Size(150, 38);
            Lb3.TabIndex = 11;
            Lb3.Text = "Inventaire";
            Lb3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnSauvegarder
            // 
            BtnSauvegarder.BackColor = Color.SaddleBrown;
            BtnSauvegarder.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSauvegarder.FlatAppearance.BorderSize = 0;
            BtnSauvegarder.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnSauvegarder.FlatAppearance.MouseOverBackColor = Color.SandyBrown;
            BtnSauvegarder.FlatStyle = FlatStyle.Flat;
            BtnSauvegarder.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSauvegarder.ForeColor = Color.Transparent;
            BtnSauvegarder.Location = new Point(464, 468);
            BtnSauvegarder.Name = "BtnSauvegarder";
            BtnSauvegarder.Size = new Size(112, 28);
            BtnSauvegarder.TabIndex = 22;
            BtnSauvegarder.Text = "SAUVEGARDER";
            BtnSauvegarder.UseVisualStyleBackColor = false;
            BtnSauvegarder.Click += BtnSauvegarder_Click;
            // 
            // BtnSauvegarderQuitter
            // 
            BtnSauvegarderQuitter.BackColor = Color.SaddleBrown;
            BtnSauvegarderQuitter.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSauvegarderQuitter.FlatAppearance.BorderSize = 0;
            BtnSauvegarderQuitter.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnSauvegarderQuitter.FlatAppearance.MouseOverBackColor = Color.SandyBrown;
            BtnSauvegarderQuitter.FlatStyle = FlatStyle.Flat;
            BtnSauvegarderQuitter.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSauvegarderQuitter.ForeColor = Color.Transparent;
            BtnSauvegarderQuitter.Location = new Point(480, 502);
            BtnSauvegarderQuitter.Name = "BtnSauvegarderQuitter";
            BtnSauvegarderQuitter.Size = new Size(78, 28);
            BtnSauvegarderQuitter.TabIndex = 23;
            BtnSauvegarderQuitter.Text = "QUITTER";
            BtnSauvegarderQuitter.UseVisualStyleBackColor = false;
            BtnSauvegarderQuitter.Click += BtnSauvegarderQuitter_Click;
            // 
            // FrmExploration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(BtnSauvegarderQuitter);
            Controls.Add(BtnSauvegarder);
            Controls.Add(Lb3);
            Controls.Add(FlpInventaireJoueur);
            Controls.Add(TbListeEvenement);
            Controls.Add(LbExperience);
            Controls.Add(LbNiveau);
            Controls.Add(Lb2);
            Controls.Add(Lb1);
            Controls.Add(BtnVillage);
            Controls.Add(BtnForet3);
            Controls.Add(BtnForet1);
            Controls.Add(BtnForet2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmExploration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forêt des ombres - Exploration";
            TopMost = true;
            Load += FrmExploration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnForet1;
        private Button BtnForet2;
        private Button BtnForet3;
        private Button BtnVillage;
        private Label Lb2;
        private Label LbNiveau;
        private Label LbExperience;
        private TextBox TbListeEvenement;
        private FlowLayoutPanel FlpInventaireJoueur;
        private Label Lb1;
        private Label Lb3;
        private Button BtnSauvegarder;
        private Button BtnSauvegarderQuitter;
    }
}