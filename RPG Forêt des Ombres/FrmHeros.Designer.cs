namespace RPG_Forêt_des_Ombres
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
            label1 = new Label();
            BtnChoisirHeros = new Button();
            BtnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)PbImageHeros).BeginInit();
            Pl1.SuspendLayout();
            SuspendLayout();
            // 
            // CbNomHeros
            // 
            CbNomHeros.FormattingEnabled = true;
            CbNomHeros.Location = new Point(236, 90);
            CbNomHeros.Name = "CbNomHeros";
            CbNomHeros.Size = new Size(151, 28);
            CbNomHeros.TabIndex = 0;
            CbNomHeros.SelectedIndexChanged += CbNomHeros_SelectedIndexChanged;
            // 
            // Lb1
            // 
            Lb1.AutoSize = true;
            Lb1.Location = new Point(292, 54);
            Lb1.Name = "Lb1";
            Lb1.Size = new Size(48, 20);
            Lb1.TabIndex = 1;
            Lb1.Text = "Héros";
            // 
            // PbImageHeros
            // 
            PbImageHeros.Location = new Point(213, 152);
            PbImageHeros.Name = "PbImageHeros";
            PbImageHeros.Size = new Size(199, 231);
            PbImageHeros.SizeMode = PictureBoxSizeMode.Zoom;
            PbImageHeros.TabIndex = 2;
            PbImageHeros.TabStop = false;
            // 
            // Pl1
            // 
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
            Pl1.Location = new Point(536, 118);
            Pl1.Name = "Pl1";
            Pl1.Size = new Size(242, 265);
            Pl1.TabIndex = 3;
            // 
            // LbNiveauHeros
            // 
            LbNiveauHeros.AutoSize = true;
            LbNiveauHeros.Location = new Point(122, 120);
            LbNiveauHeros.Name = "LbNiveauHeros";
            LbNiveauHeros.Size = new Size(17, 20);
            LbNiveauHeros.TabIndex = 9;
            LbNiveauHeros.Text = "0";
            // 
            // LbDegatHeros
            // 
            LbDegatHeros.AutoSize = true;
            LbDegatHeros.Location = new Point(27, 120);
            LbDegatHeros.Name = "LbDegatHeros";
            LbDegatHeros.Size = new Size(17, 20);
            LbDegatHeros.TabIndex = 8;
            LbDegatHeros.Text = "0";
            // 
            // LbPointVieHeros
            // 
            LbPointVieHeros.AutoSize = true;
            LbPointVieHeros.Location = new Point(122, 44);
            LbPointVieHeros.Name = "LbPointVieHeros";
            LbPointVieHeros.Size = new Size(17, 20);
            LbPointVieHeros.TabIndex = 7;
            LbPointVieHeros.Text = "0";
            // 
            // LbDescriptionHeros
            // 
            LbDescriptionHeros.Location = new Point(27, 195);
            LbDescriptionHeros.Name = "LbDescriptionHeros";
            LbDescriptionHeros.Size = new Size(188, 46);
            LbDescriptionHeros.TabIndex = 6;
            LbDescriptionHeros.Text = "0";
            // 
            // LbNomHeros
            // 
            LbNomHeros.AutoSize = true;
            LbNomHeros.Location = new Point(27, 44);
            LbNomHeros.Name = "LbNomHeros";
            LbNomHeros.Size = new Size(17, 20);
            LbNomHeros.TabIndex = 5;
            LbNomHeros.Text = "0";
            // 
            // Lb6
            // 
            Lb6.AutoSize = true;
            Lb6.Location = new Point(122, 100);
            Lb6.Name = "Lb6";
            Lb6.Size = new Size(62, 20);
            Lb6.TabIndex = 4;
            Lb6.Text = "Niveau :";
            // 
            // Lb5
            // 
            Lb5.AutoSize = true;
            Lb5.Location = new Point(27, 100);
            Lb5.Name = "Lb5";
            Lb5.Size = new Size(57, 20);
            Lb5.TabIndex = 3;
            Lb5.Text = "Dégât :";
            // 
            // Lb4
            // 
            Lb4.AutoSize = true;
            Lb4.Location = new Point(122, 24);
            Lb4.Name = "Lb4";
            Lb4.Size = new Size(93, 20);
            Lb4.TabIndex = 2;
            Lb4.Text = "Point de vie :";
            // 
            // Lb3
            // 
            Lb3.AutoSize = true;
            Lb3.Location = new Point(27, 175);
            Lb3.Name = "Lb3";
            Lb3.Size = new Size(92, 20);
            Lb3.TabIndex = 1;
            Lb3.Text = "Description :";
            // 
            // Lb2
            // 
            Lb2.AutoSize = true;
            Lb2.Location = new Point(27, 24);
            Lb2.Name = "Lb2";
            Lb2.Size = new Size(49, 20);
            Lb2.TabIndex = 0;
            Lb2.Text = "Nom :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(602, 74);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 5;
            label1.Text = "Caractèristiques";
            // 
            // BtnChoisirHeros
            // 
            BtnChoisirHeros.Location = new Point(381, 432);
            BtnChoisirHeros.Name = "BtnChoisirHeros";
            BtnChoisirHeros.Size = new Size(188, 58);
            BtnChoisirHeros.TabIndex = 6;
            BtnChoisirHeros.Text = "Choisir cette héros";
            BtnChoisirHeros.UseVisualStyleBackColor = true;
            BtnChoisirHeros.Click += BtnChoisirHeros_Click;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(12, 12);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(60, 60);
            BtnRetour.TabIndex = 7;
            BtnRetour.Text = "<-";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // FrmHeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(BtnRetour);
            Controls.Add(BtnChoisirHeros);
            Controls.Add(label1);
            Controls.Add(Pl1);
            Controls.Add(PbImageHeros);
            Controls.Add(Lb1);
            Controls.Add(CbNomHeros);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHeros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forêt des ombres - Héros";
            TopMost = true;
            WindowState = FormWindowState.Minimized;
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
        private Label label1;
        private Button BtnChoisirHeros;
        private Button BtnRetour;
    }
}