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
            BtnFuite4 = new Button();
            LbPointsVieHeros = new Label();
            LbPointsVieEnnemi = new Label();
            BtnFuite12 = new Button();
            BtnFuite2 = new Button();
            BtnFuite3 = new Button();
            BtnFuite5 = new Button();
            ((System.ComponentModel.ISupportInitialize)PbHeros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbEnnemi).BeginInit();
            SuspendLayout();
            // 
            // PbHeros
            // 
            PbHeros.BackColor = Color.Transparent;
            PbHeros.Location = new Point(277, 241);
            PbHeros.Name = "PbHeros";
            PbHeros.Size = new Size(129, 175);
            PbHeros.SizeMode = PictureBoxSizeMode.Zoom;
            PbHeros.TabIndex = 0;
            PbHeros.TabStop = false;
            PbHeros.Click += PbHeros_Click;
            // 
            // PbEnnemi
            // 
            PbEnnemi.BackColor = Color.Transparent;
            PbEnnemi.Location = new Point(548, 97);
            PbEnnemi.Name = "PbEnnemi";
            PbEnnemi.Size = new Size(129, 175);
            PbEnnemi.SizeMode = PictureBoxSizeMode.Zoom;
            PbEnnemi.TabIndex = 1;
            PbEnnemi.TabStop = false;
            PbEnnemi.Click += PbEnnemi_Click;
            // 
            // BtnAttaque
            // 
            BtnAttaque.BackColor = Color.Transparent;
            BtnAttaque.FlatAppearance.BorderSize = 0;
            BtnAttaque.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnAttaque.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnAttaque.FlatStyle = FlatStyle.Flat;
            BtnAttaque.Location = new Point(548, 97);
            BtnAttaque.Name = "BtnAttaque";
            BtnAttaque.Size = new Size(129, 175);
            BtnAttaque.TabIndex = 4;
            BtnAttaque.UseVisualStyleBackColor = false;
            // 
            // BtnRegeneration
            // 
            BtnRegeneration.BackColor = Color.Transparent;
            BtnRegeneration.FlatAppearance.BorderSize = 0;
            BtnRegeneration.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnRegeneration.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnRegeneration.FlatStyle = FlatStyle.Flat;
            BtnRegeneration.Location = new Point(277, 241);
            BtnRegeneration.Name = "BtnRegeneration";
            BtnRegeneration.Size = new Size(129, 175);
            BtnRegeneration.TabIndex = 5;
            BtnRegeneration.UseVisualStyleBackColor = false;
            // 
            // BtnFuite4
            // 
            BtnFuite4.BackColor = Color.Transparent;
            BtnFuite4.FlatAppearance.BorderSize = 0;
            BtnFuite4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnFuite4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnFuite4.FlatStyle = FlatStyle.Flat;
            BtnFuite4.Location = new Point(709, 1);
            BtnFuite4.Name = "BtnFuite4";
            BtnFuite4.Size = new Size(274, 551);
            BtnFuite4.TabIndex = 6;
            BtnFuite4.UseVisualStyleBackColor = false;
            BtnFuite4.Click += BtnFuite_Click;
            // 
            // LbPointsVieHeros
            // 
            LbPointsVieHeros.AutoSize = true;
            LbPointsVieHeros.BackColor = Color.Transparent;
            LbPointsVieHeros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbPointsVieHeros.ForeColor = SystemColors.ButtonHighlight;
            LbPointsVieHeros.Location = new Point(313, 419);
            LbPointsVieHeros.Name = "LbPointsVieHeros";
            LbPointsVieHeros.Size = new Size(57, 28);
            LbPointsVieHeros.TabIndex = 7;
            LbPointsVieHeros.Text = "0 / 0";
            LbPointsVieHeros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbPointsVieEnnemi
            // 
            LbPointsVieEnnemi.AutoSize = true;
            LbPointsVieEnnemi.BackColor = Color.Transparent;
            LbPointsVieEnnemi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbPointsVieEnnemi.ForeColor = SystemColors.ButtonHighlight;
            LbPointsVieEnnemi.Location = new Point(584, 275);
            LbPointsVieEnnemi.Name = "LbPointsVieEnnemi";
            LbPointsVieEnnemi.Size = new Size(57, 28);
            LbPointsVieEnnemi.TabIndex = 8;
            LbPointsVieEnnemi.Text = "0 / 0";
            LbPointsVieEnnemi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnFuite12
            // 
            BtnFuite12.BackColor = Color.Transparent;
            BtnFuite12.FlatAppearance.BorderSize = 0;
            BtnFuite12.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnFuite12.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnFuite12.FlatStyle = FlatStyle.Flat;
            BtnFuite12.Location = new Point(-10, -7);
            BtnFuite12.Name = "BtnFuite12";
            BtnFuite12.Size = new Size(180, 392);
            BtnFuite12.TabIndex = 9;
            BtnFuite12.UseVisualStyleBackColor = false;
            // 
            // BtnFuite2
            // 
            BtnFuite2.BackColor = Color.Transparent;
            BtnFuite2.FlatAppearance.BorderSize = 0;
            BtnFuite2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnFuite2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnFuite2.FlatStyle = FlatStyle.Flat;
            BtnFuite2.Location = new Point(166, -7);
            BtnFuite2.Name = "BtnFuite2";
            BtnFuite2.Size = new Size(360, 168);
            BtnFuite2.TabIndex = 10;
            BtnFuite2.UseVisualStyleBackColor = false;
            // 
            // BtnFuite3
            // 
            BtnFuite3.BackColor = Color.Transparent;
            BtnFuite3.FlatAppearance.BorderSize = 0;
            BtnFuite3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnFuite3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnFuite3.FlatStyle = FlatStyle.Flat;
            BtnFuite3.Location = new Point(166, 150);
            BtnFuite3.Name = "BtnFuite3";
            BtnFuite3.Size = new Size(240, 76);
            BtnFuite3.TabIndex = 11;
            BtnFuite3.UseVisualStyleBackColor = false;
            // 
            // BtnFuite5
            // 
            BtnFuite5.BackColor = Color.Transparent;
            BtnFuite5.FlatAppearance.BorderSize = 0;
            BtnFuite5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnFuite5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnFuite5.FlatStyle = FlatStyle.Flat;
            BtnFuite5.Location = new Point(584, 379);
            BtnFuite5.Name = "BtnFuite5";
            BtnFuite5.Size = new Size(131, 173);
            BtnFuite5.TabIndex = 12;
            BtnFuite5.UseVisualStyleBackColor = false;
            // 
            // FrmCombat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(BtnFuite5);
            Controls.Add(BtnFuite3);
            Controls.Add(BtnFuite2);
            Controls.Add(LbPointsVieEnnemi);
            Controls.Add(LbPointsVieHeros);
            Controls.Add(BtnFuite4);
            Controls.Add(PbEnnemi);
            Controls.Add(PbHeros);
            Controls.Add(BtnFuite12);
            Controls.Add(BtnRegeneration);
            Controls.Add(BtnAttaque);
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
        private Button BtnFuite4;
        private Label LbPointsVieHeros;
        private Label LbPointsVieEnnemi;
        private Button BtnFuite12;
        private Button BtnFuite2;
        private Button BtnFuite3;
        private Button BtnFuite5;
    }
}