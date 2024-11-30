namespace RPG_Forêt_des_Ombres
{
    partial class FrmCombat
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
            PbHeros = new PictureBox();
            PbEnnemi = new PictureBox();
            BtnAttaque = new Button();
            BtnRegeneration = new Button();
            BtnFuite = new Button();
            LbPointsVieHeros = new Label();
            LbPointsVieEnnemi = new Label();
            ((System.ComponentModel.ISupportInitialize)PbHeros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbEnnemi).BeginInit();
            SuspendLayout();
            // 
            // PbHeros
            // 
            PbHeros.BorderStyle = BorderStyle.FixedSingle;
            PbHeros.Location = new Point(233, 249);
            PbHeros.Name = "PbHeros";
            PbHeros.Size = new Size(141, 197);
            PbHeros.SizeMode = PictureBoxSizeMode.Zoom;
            PbHeros.TabIndex = 0;
            PbHeros.TabStop = false;
            // 
            // PbEnnemi
            // 
            PbEnnemi.BorderStyle = BorderStyle.FixedSingle;
            PbEnnemi.Location = new Point(633, 118);
            PbEnnemi.Name = "PbEnnemi";
            PbEnnemi.Size = new Size(141, 197);
            PbEnnemi.SizeMode = PictureBoxSizeMode.Zoom;
            PbEnnemi.TabIndex = 1;
            PbEnnemi.TabStop = false;
            // 
            // BtnAttaque
            // 
            BtnAttaque.Location = new Point(558, 449);
            BtnAttaque.Name = "BtnAttaque";
            BtnAttaque.Size = new Size(90, 90);
            BtnAttaque.TabIndex = 4;
            BtnAttaque.Text = "Attaque";
            BtnAttaque.UseVisualStyleBackColor = true;
            BtnAttaque.Click += BtnAttaque_Click;
            // 
            // BtnRegeneration
            // 
            BtnRegeneration.Location = new Point(654, 449);
            BtnRegeneration.Name = "BtnRegeneration";
            BtnRegeneration.Size = new Size(90, 90);
            BtnRegeneration.TabIndex = 5;
            BtnRegeneration.Text = "Regeneration";
            BtnRegeneration.UseVisualStyleBackColor = true;
            // 
            // BtnFuite
            // 
            BtnFuite.Location = new Point(750, 449);
            BtnFuite.Name = "BtnFuite";
            BtnFuite.Size = new Size(90, 90);
            BtnFuite.TabIndex = 6;
            BtnFuite.Text = "Fuite";
            BtnFuite.UseVisualStyleBackColor = true;
            BtnFuite.Click += BtnFuite_Click;
            // 
            // LbPointsVieHeros
            // 
            LbPointsVieHeros.AutoSize = true;
            LbPointsVieHeros.Location = new Point(276, 449);
            LbPointsVieHeros.Name = "LbPointsVieHeros";
            LbPointsVieHeros.Size = new Size(39, 20);
            LbPointsVieHeros.TabIndex = 7;
            LbPointsVieHeros.Text = "0 / 0";
            // 
            // LbPointsVieEnnemi
            // 
            LbPointsVieEnnemi.AutoSize = true;
            LbPointsVieEnnemi.Location = new Point(685, 318);
            LbPointsVieEnnemi.Name = "LbPointsVieEnnemi";
            LbPointsVieEnnemi.Size = new Size(39, 20);
            LbPointsVieEnnemi.TabIndex = 8;
            LbPointsVieEnnemi.Text = "0 / 0";
            // 
            // FrmCombat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(LbPointsVieEnnemi);
            Controls.Add(LbPointsVieHeros);
            Controls.Add(BtnFuite);
            Controls.Add(BtnRegeneration);
            Controls.Add(BtnAttaque);
            Controls.Add(PbEnnemi);
            Controls.Add(PbHeros);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCombat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fôret des ombres - Combat";
            Load += FrmCombat_Load;
            ((System.ComponentModel.ISupportInitialize)PbHeros).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbEnnemi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbHeros;
        private PictureBox PbEnnemi;
        private Button BtnAttaque;
        private Button BtnRegeneration;
        private Button BtnFuite;
        private Label LbPointsVieHeros;
        private Label LbPointsVieEnnemi;
    }
}