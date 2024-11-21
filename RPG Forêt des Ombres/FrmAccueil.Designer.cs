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
            BtnNouvellePartie = new Button();
            BtnChargerPartie = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
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
            BtnNouvellePartie.Location = new Point(130, 332);
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
            BtnChargerPartie.Location = new Point(508, 332);
            BtnChargerPartie.Name = "BtnChargerPartie";
            BtnChargerPartie.Size = new Size(326, 91);
            BtnChargerPartie.TabIndex = 2;
            BtnChargerPartie.Text = "CHARGER LA PARTIE";
            BtnChargerPartie.UseVisualStyleBackColor = false;
            BtnChargerPartie.Click += BtnChargerPartie_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(33, 136);
            label1.Name = "label1";
            label1.Size = new Size(368, 124);
            label1.TabIndex = 3;
            label1.Text = "Forêt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(369, 178);
            label2.Name = "label2";
            label2.Size = new Size(139, 74);
            label2.TabIndex = 4;
            label2.Text = "DES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(492, 136);
            label3.Name = "label3";
            label3.Size = new Size(451, 124);
            label3.TabIndex = 5;
            label3.Text = "Ombres";
            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(982, 553);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnChargerPartie);
            Controls.Add(BtnNouvellePartie);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAccueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fôret des ombres - Accueil";
            WindowState = FormWindowState.Minimized;
            Load += FrmAccueil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnNouvellePartie;
        private Button BtnChargerPartie;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}