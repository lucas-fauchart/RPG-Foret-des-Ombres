namespace RPG_Forêt_des_Ombres
{
    partial class FrmArmesPotions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArmesPotions));
            BtnRetour = new Button();
            BtnArme = new Button();
            BtnPotion = new Button();
            SuspendLayout();
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
            BtnRetour.TabIndex = 20;
            BtnRetour.UseVisualStyleBackColor = false;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // BtnArme
            // 
            BtnArme.BackColor = Color.Transparent;
            BtnArme.BackgroundImageLayout = ImageLayout.Zoom;
            BtnArme.FlatAppearance.BorderSize = 0;
            BtnArme.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnArme.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnArme.FlatStyle = FlatStyle.Flat;
            BtnArme.Location = new Point(285, 354);
            BtnArme.Name = "BtnArme";
            BtnArme.Size = new Size(160, 160);
            BtnArme.TabIndex = 21;
            BtnArme.UseVisualStyleBackColor = false;
            BtnArme.Click += BtnArme_Click;
            // 
            // BtnPotion
            // 
            BtnPotion.BackColor = Color.Transparent;
            BtnPotion.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPotion.FlatAppearance.BorderSize = 0;
            BtnPotion.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnPotion.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnPotion.FlatStyle = FlatStyle.Flat;
            BtnPotion.Location = new Point(545, 354);
            BtnPotion.Name = "BtnPotion";
            BtnPotion.Size = new Size(160, 160);
            BtnPotion.TabIndex = 22;
            BtnPotion.UseVisualStyleBackColor = false;
            BtnPotion.Click += BtnPotion_Click;
            // 
            // FrmArmesPotions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(BtnPotion);
            Controls.Add(BtnArme);
            Controls.Add(BtnRetour);
            DoubleBuffered = true;
            Name = "FrmArmesPotions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forêt des ombres - Armes et potions";
            Load += FrmArmesPotions_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button BtnRetour;
        private Button BtnArme;
        private Button BtnPotion;
    }
}