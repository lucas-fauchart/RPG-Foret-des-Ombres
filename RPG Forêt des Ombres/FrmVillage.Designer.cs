namespace RPG_Forêt_des_Ombres
{
    partial class FrmVillage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVillage));
            BtnHeros = new Button();
            BtnArmesPotions = new Button();
            BtnParametres = new Button();
            BtnRetour = new Button();
            SuspendLayout();
            // 
            // BtnHeros
            // 
            BtnHeros.BackColor = Color.Transparent;
            BtnHeros.BackgroundImageLayout = ImageLayout.Zoom;
            BtnHeros.FlatAppearance.BorderSize = 0;
            BtnHeros.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnHeros.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnHeros.FlatStyle = FlatStyle.Flat;
            BtnHeros.Location = new Point(382, 265);
            BtnHeros.Name = "BtnHeros";
            BtnHeros.Size = new Size(229, 263);
            BtnHeros.TabIndex = 0;
            BtnHeros.UseVisualStyleBackColor = false;
            BtnHeros.Click += BtnHeros_Click;
            // 
            // BtnArmesPotions
            // 
            BtnArmesPotions.BackColor = Color.Transparent;
            BtnArmesPotions.BackgroundImageLayout = ImageLayout.Zoom;
            BtnArmesPotions.FlatAppearance.BorderSize = 0;
            BtnArmesPotions.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnArmesPotions.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnArmesPotions.FlatStyle = FlatStyle.Flat;
            BtnArmesPotions.Location = new Point(143, 368);
            BtnArmesPotions.Name = "BtnArmesPotions";
            BtnArmesPotions.Size = new Size(148, 137);
            BtnArmesPotions.TabIndex = 1;
            BtnArmesPotions.UseVisualStyleBackColor = false;
            BtnArmesPotions.Click += BtnArmesPotions_Click;
            // 
            // BtnParametres
            // 
            BtnParametres.BackColor = Color.Transparent;
            BtnParametres.BackgroundImageLayout = ImageLayout.Zoom;
            BtnParametres.FlatAppearance.BorderSize = 0;
            BtnParametres.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnParametres.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnParametres.FlatStyle = FlatStyle.Flat;
            BtnParametres.Location = new Point(704, 368);
            BtnParametres.Name = "BtnParametres";
            BtnParametres.Size = new Size(148, 137);
            BtnParametres.TabIndex = 2;
            BtnParametres.UseVisualStyleBackColor = false;
            BtnParametres.Click += BtnParametres_Click;
            // 
            // BtnRetour
            // 
            BtnRetour.BackColor = Color.Transparent;
            BtnRetour.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRetour.FlatAppearance.BorderSize = 0;
            BtnRetour.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnRetour.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnRetour.FlatStyle = FlatStyle.Flat;
            BtnRetour.Location = new Point(12, 12);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(60, 60);
            BtnRetour.TabIndex = 21;
            BtnRetour.UseVisualStyleBackColor = false;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // FrmVillage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(BtnRetour);
            Controls.Add(BtnParametres);
            Controls.Add(BtnArmesPotions);
            Controls.Add(BtnHeros);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVillage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forêt des ombres - Village";
            TopMost = true;
            Load += FrmVillage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnHeros;
        private Button BtnArmesPotions;
        private Button BtnParametres;
        private Button BtnRetour;
    }
}