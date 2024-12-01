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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCombat));
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
            PbHeros.BackColor = Color.Transparent;
            PbHeros.BorderStyle = BorderStyle.FixedSingle;
            PbHeros.Location = new Point(276, 249);
            PbHeros.Name = "PbHeros";
            PbHeros.Size = new Size(129, 175);
            PbHeros.SizeMode = PictureBoxSizeMode.Zoom;
            PbHeros.TabIndex = 0;
            PbHeros.TabStop = false;
            // 
            // PbEnnemi
            // 
            PbEnnemi.BackColor = Color.Transparent;
            PbEnnemi.BorderStyle = BorderStyle.FixedSingle;
            PbEnnemi.Location = new Point(548, 97);
            PbEnnemi.Name = "PbEnnemi";
            PbEnnemi.Size = new Size(129, 175);
            PbEnnemi.SizeMode = PictureBoxSizeMode.Zoom;
            PbEnnemi.TabIndex = 1;
            PbEnnemi.TabStop = false;
            // 
            // BtnAttaque
            // 
            BtnAttaque.Location = new Point(653, 451);
            BtnAttaque.Name = "BtnAttaque";
            BtnAttaque.Size = new Size(90, 90);
            BtnAttaque.TabIndex = 4;
            BtnAttaque.Text = "Attaque";
            BtnAttaque.UseVisualStyleBackColor = true;
            BtnAttaque.Click += BtnAttaque_Click;
            // 
            // BtnRegeneration
            // 
            BtnRegeneration.Location = new Point(749, 451);
            BtnRegeneration.Name = "BtnRegeneration";
            BtnRegeneration.Size = new Size(90, 90);
            BtnRegeneration.TabIndex = 5;
            BtnRegeneration.Text = "Regeneration";
            BtnRegeneration.UseVisualStyleBackColor = true;
            // 
            // BtnFuite
            // 
            BtnFuite.Location = new Point(845, 451);
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
            LbPointsVieHeros.BackColor = Color.Transparent;
            LbPointsVieHeros.Location = new Point(321, 427);
            LbPointsVieHeros.Name = "LbPointsVieHeros";
            LbPointsVieHeros.Size = new Size(39, 20);
            LbPointsVieHeros.TabIndex = 7;
            LbPointsVieHeros.Text = "0 / 0";
            // 
            // LbPointsVieEnnemi
            // 
            LbPointsVieEnnemi.AutoSize = true;
            LbPointsVieEnnemi.BackColor = Color.Transparent;
            LbPointsVieEnnemi.Location = new Point(599, 275);
            LbPointsVieEnnemi.Name = "LbPointsVieEnnemi";
            LbPointsVieEnnemi.Size = new Size(39, 20);
            LbPointsVieEnnemi.TabIndex = 8;
            LbPointsVieEnnemi.Text = "0 / 0";
            // 
            // FrmCombat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(LbPointsVieEnnemi);
            Controls.Add(LbPointsVieHeros);
            Controls.Add(BtnFuite);
            Controls.Add(BtnRegeneration);
            Controls.Add(BtnAttaque);
            Controls.Add(PbEnnemi);
            Controls.Add(PbHeros);
            DoubleBuffered = true;
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