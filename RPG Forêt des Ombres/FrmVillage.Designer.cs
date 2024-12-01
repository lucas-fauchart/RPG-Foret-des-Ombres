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
            Lb1 = new Label();
            Lb3 = new Label();
            BtnRetour = new Button();
            SuspendLayout();
            // 
            // BtnHeros
            // 
            BtnHeros.BackColor = Color.Transparent;
            BtnHeros.BackgroundImage = (Image)resources.GetObject("BtnHeros.BackgroundImage");
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
            BtnArmesPotions.BackColor = Color.DimGray;
            BtnArmesPotions.FlatAppearance.BorderSize = 0;
            BtnArmesPotions.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnArmesPotions.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnArmesPotions.FlatStyle = FlatStyle.Flat;
            BtnArmesPotions.Location = new Point(143, 345);
            BtnArmesPotions.Name = "BtnArmesPotions";
            BtnArmesPotions.Size = new Size(148, 137);
            BtnArmesPotions.TabIndex = 1;
            BtnArmesPotions.UseVisualStyleBackColor = false;
            BtnArmesPotions.Click += BtnArmesPotions_Click;
            // 
            // BtnParametres
            // 
            BtnParametres.Location = new Point(725, 345);
            BtnParametres.Name = "BtnParametres";
            BtnParametres.Size = new Size(148, 137);
            BtnParametres.TabIndex = 2;
            BtnParametres.Text = "button3";
            BtnParametres.UseVisualStyleBackColor = true;
            BtnParametres.Click += BtnParametres_Click;
            // 
            // Lb1
            // 
            Lb1.AutoSize = true;
            Lb1.Location = new Point(157, 497);
            Lb1.Name = "Lb1";
            Lb1.Size = new Size(122, 20);
            Lb1.TabIndex = 3;
            Lb1.Text = "Armes et potions";
            // 
            // Lb3
            // 
            Lb3.AutoSize = true;
            Lb3.Location = new Point(760, 485);
            Lb3.Name = "Lb3";
            Lb3.Size = new Size(82, 20);
            Lb3.TabIndex = 4;
            Lb3.Text = "Paramétres";
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(12, 12);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(60, 60);
            BtnRetour.TabIndex = 21;
            BtnRetour.Text = "<-";
            BtnRetour.UseVisualStyleBackColor = true;
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
            Controls.Add(Lb3);
            Controls.Add(Lb1);
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
            PerformLayout();
        }

        #endregion

        private Button BtnHeros;
        private Button BtnArmesPotions;
        private Button BtnParametres;
        private Label Lb1;
        private Label Lb3;
        private Button BtnRetour;
    }
}