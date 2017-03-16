namespace Droid_Geography
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.worldMapView1 = new Droid_Geography.WorldMapView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCapital = new System.Windows.Forms.Label();
            this.labelCoordonate = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.labelIso = new System.Windows.Forms.Label();
            this.labelTrigramme = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // worldMapView1
            // 
            this.worldMapView1.BackColor = System.Drawing.Color.DimGray;
            this.worldMapView1.CurrentWorldMap = null;
            this.worldMapView1.Location = new System.Drawing.Point(0, 33);
            this.worldMapView1.Name = "worldMapView1";
            this.worldMapView1.Size = new System.Drawing.Size(669, 442);
            this.worldMapView1.TabIndex = 0;
            this.worldMapView1.Zoom = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "focus on";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(716, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(716, 59);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(39, 13);
            this.labelCapital.TabIndex = 6;
            this.labelCapital.Text = "Capital";
            // 
            // labelCoordonate
            // 
            this.labelCoordonate.AutoSize = true;
            this.labelCoordonate.Location = new System.Drawing.Point(716, 86);
            this.labelCoordonate.Name = "labelCoordonate";
            this.labelCoordonate.Size = new System.Drawing.Size(62, 13);
            this.labelCoordonate.TabIndex = 7;
            this.labelCoordonate.Text = "Coordonate";
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(716, 114);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(57, 13);
            this.labelPopulation.TabIndex = 8;
            this.labelPopulation.Text = "Population";
            // 
            // labelIso
            // 
            this.labelIso.AutoSize = true;
            this.labelIso.Location = new System.Drawing.Point(716, 146);
            this.labelIso.Name = "labelIso";
            this.labelIso.Size = new System.Drawing.Size(21, 13);
            this.labelIso.TabIndex = 9;
            this.labelIso.Text = "Iso";
            // 
            // labelTrigramme
            // 
            this.labelTrigramme.AutoSize = true;
            this.labelTrigramme.Location = new System.Drawing.Point(716, 172);
            this.labelTrigramme.Name = "labelTrigramme";
            this.labelTrigramme.Size = new System.Drawing.Size(56, 13);
            this.labelTrigramme.TabIndex = 10;
            this.labelTrigramme.Text = "Trigramme";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(716, 199);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(54, 13);
            this.labelArea.TabIndex = 11;
            this.labelArea.Text = "Superficie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 488);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelTrigramme);
            this.Controls.Add(this.labelIso);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.labelCoordonate);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.worldMapView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WorldMapView worldMapView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.Label labelCoordonate;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.Label labelIso;
        private System.Windows.Forms.Label labelTrigramme;
        private System.Windows.Forms.Label labelArea;
    }
}

