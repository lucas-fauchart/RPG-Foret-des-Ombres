﻿namespace RPG_Forêt_des_Ombres
{
    partial class FrmHeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHeros));
            CbNomHeros = new ComboBox();
            Lb1 = new Label();
            PbImageHeros = new PictureBox();
            Pl1 = new Panel();
            LbNiveauHeros = new Label();
            LbDegatHeros = new Label();
            LbPointVieHeros = new Label();
            LbDescriptionHeros = new Label();
            LbNomHeros = new Label();
            Lb6 = new Label();
            Lb5 = new Label();
            Lb4 = new Label();
            Lb3 = new Label();
            Lb2 = new Label();
            Lb15 = new Label();
            BtnChoisirHeros = new Button();
            BtnRetour = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PbImageHeros).BeginInit();
            Pl1.SuspendLayout();
            SuspendLayout();
            // 
            // CbNomHeros
            // 
            CbNomHeros.BackColor = Color.Tan;
            CbNomHeros.DropDownStyle = ComboBoxStyle.DropDownList;
            CbNomHeros.FlatStyle = FlatStyle.Flat;
            CbNomHeros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CbNomHeros.ForeColor = Color.White;
            CbNomHeros.FormattingEnabled = true;
            CbNomHeros.Location = new Point(203, 101);
            CbNomHeros.Name = "CbNomHeros";
            CbNomHeros.Size = new Size(151, 28);
            CbNomHeros.TabIndex = 0;
            CbNomHeros.SelectedIndexChanged += CbNomHeros_SelectedIndexChanged;
            // 
            // Lb1
            // 
            Lb1.AutoSize = true;
            Lb1.BackColor = Color.Transparent;
            Lb1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lb1.ForeColor = Color.Transparent;
            Lb1.Location = new Point(243, 463);
            Lb1.Name = "Lb1";
            Lb1.Size = new Size(67, 28);
            Lb1.TabIndex = 1;
            Lb1.Text = "Héros";
            // 
            // PbImageHeros
            // 
            PbImageHeros.BackColor = Color.Transparent;
            PbImageHeros.Location = new Point(156, 195);
            PbImageHeros.Name = "PbImageHeros";
            PbImageHeros.Size = new Size(242, 265);
            PbImageHeros.SizeMode = PictureBoxSizeMode.Zoom;
            PbImageHeros.TabIndex = 2;
            PbImageHeros.TabStop = false;
            // 
            // Pl1
            // 
            Pl1.BackColor = Color.DarkGoldenrod;
            Pl1.Controls.Add(LbNiveauHeros);
            Pl1.Controls.Add(LbDegatHeros);
            Pl1.Controls.Add(LbPointVieHeros);
            Pl1.Controls.Add(LbDescriptionHeros);
            Pl1.Controls.Add(LbNomHeros);
            Pl1.Controls.Add(Lb6);
            Pl1.Controls.Add(Lb5);
            Pl1.Controls.Add(Lb4);
            Pl1.Controls.Add(Lb3);
            Pl1.Controls.Add(Lb2);
            Pl1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Pl1.ForeColor = SystemColors.ButtonFace;
            Pl1.Location = new Point(499, 151);
            Pl1.Name = "Pl1";
            Pl1.Size = new Size(270, 265);
            Pl1.TabIndex = 3;
            // 
            // LbNiveauHeros
            // 
            LbNiveauHeros.AutoSize = true;
            LbNiveauHeros.Location = new Point(132, 120);
            LbNiveauHeros.Name = "LbNiveauHeros";
            LbNiveauHeros.Size = new Size(20, 23);
            LbNiveauHeros.TabIndex = 9;
            LbNiveauHeros.Text = "0";
            // 
            // LbDegatHeros
            // 
            LbDegatHeros.AutoSize = true;
            LbDegatHeros.Location = new Point(14, 120);
            LbDegatHeros.Name = "LbDegatHeros";
            LbDegatHeros.Size = new Size(20, 23);
            LbDegatHeros.TabIndex = 8;
            LbDegatHeros.Text = "0";
            // 
            // LbPointVieHeros
            // 
            LbPointVieHeros.AutoSize = true;
            LbPointVieHeros.Location = new Point(132, 44);
            LbPointVieHeros.Name = "LbPointVieHeros";
            LbPointVieHeros.Size = new Size(20, 23);
            LbPointVieHeros.TabIndex = 7;
            LbPointVieHeros.Text = "0";
            // 
            // LbDescriptionHeros
            // 
            LbDescriptionHeros.Location = new Point(14, 195);
            LbDescriptionHeros.Name = "LbDescriptionHeros";
            LbDescriptionHeros.Size = new Size(242, 63);
            LbDescriptionHeros.TabIndex = 6;
            LbDescriptionHeros.Text = "0";
            // 
            // LbNomHeros
            // 
            LbNomHeros.AutoSize = true;
            LbNomHeros.Location = new Point(14, 44);
            LbNomHeros.Name = "LbNomHeros";
            LbNomHeros.Size = new Size(20, 23);
            LbNomHeros.TabIndex = 5;
            LbNomHeros.Text = "0";
            // 
            // Lb6
            // 
            Lb6.AutoSize = true;
            Lb6.Location = new Point(132, 100);
            Lb6.Name = "Lb6";
            Lb6.Size = new Size(75, 23);
            Lb6.TabIndex = 4;
            Lb6.Text = "Niveau :";
            // 
            // Lb5
            // 
            Lb5.AutoSize = true;
            Lb5.Location = new Point(14, 100);
            Lb5.Name = "Lb5";
            Lb5.Size = new Size(69, 23);
            Lb5.TabIndex = 3;
            Lb5.Text = "Dégât :";
            // 
            // Lb4
            // 
            Lb4.AutoSize = true;
            Lb4.Location = new Point(132, 24);
            Lb4.Name = "Lb4";
            Lb4.Size = new Size(114, 23);
            Lb4.TabIndex = 2;
            Lb4.Text = "Point de vie :";
            // 
            // Lb3
            // 
            Lb3.AutoSize = true;
            Lb3.Location = new Point(14, 175);
            Lb3.Name = "Lb3";
            Lb3.Size = new Size(112, 23);
            Lb3.TabIndex = 1;
            Lb3.Text = "Description :";
            // 
            // Lb2
            // 
            Lb2.AutoSize = true;
            Lb2.Location = new Point(14, 24);
            Lb2.Name = "Lb2";
            Lb2.Size = new Size(59, 23);
            Lb2.TabIndex = 0;
            Lb2.Text = "Nom :";
            // 
            // Lb15
            // 
            Lb15.AutoSize = true;
            Lb15.BackColor = Color.Transparent;
            Lb15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lb15.ForeColor = SystemColors.ButtonHighlight;
            Lb15.Location = new Point(553, 419);
            Lb15.Name = "Lb15";
            Lb15.Size = new Size(164, 28);
            Lb15.TabIndex = 5;
            Lb15.Text = "Caractèristiques";
            // 
            // BtnChoisirHeros
            // 
            BtnChoisirHeros.BackColor = Color.SaddleBrown;
            BtnChoisirHeros.FlatAppearance.BorderColor = Color.Silver;
            BtnChoisirHeros.FlatAppearance.BorderSize = 2;
            BtnChoisirHeros.FlatAppearance.MouseOverBackColor = Color.Sienna;
            BtnChoisirHeros.FlatStyle = FlatStyle.Flat;
            BtnChoisirHeros.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnChoisirHeros.ForeColor = Color.Transparent;
            BtnChoisirHeros.Location = new Point(377, 494);
            BtnChoisirHeros.Name = "BtnChoisirHeros";
            BtnChoisirHeros.Size = new Size(215, 47);
            BtnChoisirHeros.TabIndex = 6;
            BtnChoisirHeros.Text = "CHOISIR CETTE HEROS";
            BtnChoisirHeros.UseVisualStyleBackColor = false;
            BtnChoisirHeros.Click += BtnChoisirHeros_Click;
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
            BtnRetour.TabIndex = 7;
            BtnRetour.UseVisualStyleBackColor = false;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(147, 58);
            label1.Name = "label1";
            label1.Size = new Size(262, 28);
            label1.TabIndex = 8;
            label1.Text = "SELECTIONNE TON HEROS";
            // 
            // FrmHeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(label1);
            Controls.Add(BtnRetour);
            Controls.Add(BtnChoisirHeros);
            Controls.Add(Lb15);
            Controls.Add(Pl1);
            Controls.Add(PbImageHeros);
            Controls.Add(Lb1);
            Controls.Add(CbNomHeros);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHeros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forêt des ombres - Héros";
            TopMost = true;
            Load += FrmHeros_Load;
            ((System.ComponentModel.ISupportInitialize)PbImageHeros).EndInit();
            Pl1.ResumeLayout(false);
            Pl1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CbNomHeros;
        private Label Lb1;
        private PictureBox PbImageHeros;
        private Panel Pl1;
        private Label Lb4;
        private Label Lb3;
        private Label Lb2;
        private Label Lb5;
        private Label Lb6;
        private Label LbNiveauHeros;
        private Label LbDegatHeros;
        private Label LbPointVieHeros;
        private Label LbDescriptionHeros;
        private Label LbNomHeros;
        private Label Lb15;
        private Button BtnChoisirHeros;
        private Button BtnRetour;
        private Label label1;
    }
}