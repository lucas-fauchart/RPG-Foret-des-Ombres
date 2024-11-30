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
            BtnHeros = new Button();
            BtnArmesPotions = new Button();
            BtnParametres = new Button();
            Lb1 = new Label();
            Lb3 = new Label();
            Lb2 = new Label();
            BtnRetour = new Button();
            SuspendLayout();
            // 
            // BtnHeros
            // 
            BtnHeros.Location = new Point(392, 251);
            BtnHeros.Name = "BtnHeros";
            BtnHeros.Size = new Size(194, 173);
            BtnHeros.TabIndex = 0;
            BtnHeros.Text = "button1";
            BtnHeros.UseVisualStyleBackColor = true;
            BtnHeros.Click += BtnHeros_Click;
            // 
            // BtnArmesPotions
            // 
            BtnArmesPotions.Location = new Point(127, 287);
            BtnArmesPotions.Name = "BtnArmesPotions";
            BtnArmesPotions.Size = new Size(148, 137);
            BtnArmesPotions.TabIndex = 1;
            BtnArmesPotions.Text = "button2";
            BtnArmesPotions.UseVisualStyleBackColor = true;
            BtnArmesPotions.Click += BtnArmesPotions_Click;
            // 
            // BtnParametres
            // 
            BtnParametres.Location = new Point(705, 287);
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
            Lb1.Location = new Point(141, 439);
            Lb1.Name = "Lb1";
            Lb1.Size = new Size(122, 20);
            Lb1.TabIndex = 3;
            Lb1.Text = "Armes et potions";
            // 
            // Lb3
            // 
            Lb3.AutoSize = true;
            Lb3.Location = new Point(740, 439);
            Lb3.Name = "Lb3";
            Lb3.Size = new Size(82, 20);
            Lb3.TabIndex = 4;
            Lb3.Text = "Paramétres";
            // 
            // Lb2
            // 
            Lb2.AutoSize = true;
            Lb2.Location = new Point(464, 439);
            Lb2.Name = "Lb2";
            Lb2.Size = new Size(48, 20);
            Lb2.TabIndex = 5;
            Lb2.Text = "Héros";
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
            ClientSize = new Size(982, 553);
            Controls.Add(BtnRetour);
            Controls.Add(Lb2);
            Controls.Add(Lb3);
            Controls.Add(Lb1);
            Controls.Add(BtnParametres);
            Controls.Add(BtnArmesPotions);
            Controls.Add(BtnHeros);
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
        private Label Lb2;
        private Button BtnRetour;
    }
}