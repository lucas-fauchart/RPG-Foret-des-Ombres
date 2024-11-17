namespace RPG_Forêt_des_Ombres
{
    partial class FrmAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            pictureBox1 = new PictureBox();
            BtnNouvellePartie = new Button();
            BtnChargerPartie = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(757, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnNouvellePartie
            // 
            BtnNouvellePartie.Anchor = AnchorStyles.None;
            BtnNouvellePartie.BackColor = Color.Transparent;
            BtnNouvellePartie.FlatAppearance.BorderColor = Color.Silver;
            BtnNouvellePartie.FlatAppearance.BorderSize = 2;
            BtnNouvellePartie.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnNouvellePartie.FlatAppearance.MouseOverBackColor = Color.Sienna;
            BtnNouvellePartie.FlatStyle = FlatStyle.Flat;
            BtnNouvellePartie.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNouvellePartie.ForeColor = Color.Gold;
            BtnNouvellePartie.Location = new Point(137, 332);
            BtnNouvellePartie.Name = "BtnNouvellePartie";
            BtnNouvellePartie.Size = new Size(326, 91);
            BtnNouvellePartie.TabIndex = 1;
            BtnNouvellePartie.Text = "NOUVELLE PARTIE";
            BtnNouvellePartie.UseVisualStyleBackColor = false;
            // 
            // BtnChargerPartie
            // 
            BtnChargerPartie.Anchor = AnchorStyles.None;
            BtnChargerPartie.BackColor = Color.Transparent;
            BtnChargerPartie.FlatAppearance.BorderColor = Color.Silver;
            BtnChargerPartie.FlatAppearance.BorderSize = 2;
            BtnChargerPartie.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnChargerPartie.FlatAppearance.MouseOverBackColor = Color.Sienna;
            BtnChargerPartie.FlatStyle = FlatStyle.Flat;
            BtnChargerPartie.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtnChargerPartie.ForeColor = Color.Gold;
            BtnChargerPartie.Location = new Point(515, 332);
            BtnChargerPartie.Name = "BtnChargerPartie";
            BtnChargerPartie.Size = new Size(326, 91);
            BtnChargerPartie.TabIndex = 2;
            BtnChargerPartie.Text = "CHARGER LA PARTIE";
            BtnChargerPartie.UseVisualStyleBackColor = false;
            BtnChargerPartie.Click += BtnChargerPartie_Click;
            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(982, 553);
            Controls.Add(BtnChargerPartie);
            Controls.Add(BtnNouvellePartie);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAccueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fôret des ombres - Accueil";
            WindowState = FormWindowState.Minimized;
            Load += FrmAccueil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnNouvellePartie;
        private Button BtnChargerPartie;
    }
}