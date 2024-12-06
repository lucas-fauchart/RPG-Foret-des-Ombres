namespace RPG_Forêt_des_Ombres
{
    partial class FrmParametres
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
            BtnDesactiveMusique = new Button();
            BtnActiveMusique = new Button();
            label1 = new Label();
            BtnRetour = new Button();
            SuspendLayout();
            // 
            // BtnDesactiveMusique
            // 
            BtnDesactiveMusique.Anchor = AnchorStyles.None;
            BtnDesactiveMusique.BackColor = Color.Transparent;
            BtnDesactiveMusique.FlatAppearance.BorderColor = Color.Silver;
            BtnDesactiveMusique.FlatAppearance.BorderSize = 2;
            BtnDesactiveMusique.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnDesactiveMusique.FlatAppearance.MouseOverBackColor = Color.Sienna;
            BtnDesactiveMusique.FlatStyle = FlatStyle.Flat;
            BtnDesactiveMusique.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDesactiveMusique.ForeColor = Color.Red;
            BtnDesactiveMusique.Location = new Point(311, 370);
            BtnDesactiveMusique.Name = "BtnDesactiveMusique";
            BtnDesactiveMusique.Size = new Size(364, 64);
            BtnDesactiveMusique.TabIndex = 4;
            BtnDesactiveMusique.Text = "DESACTIVER LA MUSIQUE";
            BtnDesactiveMusique.UseVisualStyleBackColor = false;
            BtnDesactiveMusique.Click += BtnDesactiveMusique_Click;
            // 
            // BtnActiveMusique
            // 
            BtnActiveMusique.Anchor = AnchorStyles.None;
            BtnActiveMusique.BackColor = Color.Transparent;
            BtnActiveMusique.FlatAppearance.BorderColor = Color.Silver;
            BtnActiveMusique.FlatAppearance.BorderSize = 2;
            BtnActiveMusique.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnActiveMusique.FlatAppearance.MouseOverBackColor = Color.Sienna;
            BtnActiveMusique.FlatStyle = FlatStyle.Flat;
            BtnActiveMusique.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtnActiveMusique.ForeColor = Color.FromArgb(0, 192, 0);
            BtnActiveMusique.Location = new Point(311, 271);
            BtnActiveMusique.Name = "BtnActiveMusique";
            BtnActiveMusique.Size = new Size(364, 64);
            BtnActiveMusique.TabIndex = 3;
            BtnActiveMusique.Text = "ACTIVER LA MUSIQUE";
            BtnActiveMusique.UseVisualStyleBackColor = false;
            BtnActiveMusique.Click += BtnActiveMusique_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(289, 75);
            label1.Name = "label1";
            label1.Size = new Size(412, 106);
            label1.TabIndex = 5;
            label1.Text = "MUSIQUE";
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
            BtnRetour.TabIndex = 22;
            BtnRetour.UseVisualStyleBackColor = false;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // FrmParametres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(982, 553);
            Controls.Add(BtnRetour);
            Controls.Add(label1);
            Controls.Add(BtnDesactiveMusique);
            Controls.Add(BtnActiveMusique);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmParametres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmParametres";
            Load += FrmParametres_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDesactiveMusique;
        private Button BtnActiveMusique;
        private Label label1;
        private Button BtnRetour;
    }
}