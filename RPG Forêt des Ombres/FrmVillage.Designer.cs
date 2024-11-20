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
            BtnPotion = new Button();
            BtnArme = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtnHeros
            // 
            BtnHeros.Location = new Point(387, 251);
            BtnHeros.Name = "BtnHeros";
            BtnHeros.Size = new Size(194, 173);
            BtnHeros.TabIndex = 0;
            BtnHeros.Text = "button1";
            BtnHeros.UseVisualStyleBackColor = true;
            BtnHeros.Click += BtnHeros_Click;
            // 
            // BtnPotion
            // 
            BtnPotion.Location = new Point(134, 287);
            BtnPotion.Name = "BtnPotion";
            BtnPotion.Size = new Size(148, 137);
            BtnPotion.TabIndex = 1;
            BtnPotion.Text = "button2";
            BtnPotion.UseVisualStyleBackColor = true;
            BtnPotion.Click += BtnPotion_Click;
            // 
            // BtnArme
            // 
            BtnArme.Location = new Point(712, 287);
            BtnArme.Name = "BtnArme";
            BtnArme.Size = new Size(148, 137);
            BtnArme.TabIndex = 2;
            BtnArme.Text = "button3";
            BtnArme.UseVisualStyleBackColor = true;
            BtnArme.Click += BtnArme_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 439);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 3;
            label1.Text = "Armes et potions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(747, 439);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Paramétres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 439);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 5;
            label3.Text = "Héros";
            // 
            // FrmVillage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnArme);
            Controls.Add(BtnPotion);
            Controls.Add(BtnHeros);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVillage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forêt des ombres - Village";
            WindowState = FormWindowState.Minimized;
            Load += FrmVillage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHeros;
        private Button BtnPotion;
        private Button BtnArme;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}