namespace Droid.Geography
{
    partial class Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCapital = new System.Windows.Forms.Label();
            this.labelCoordonate = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.labelIso = new System.Windows.Forms.Label();
            this.labelTrigramme = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelContinent = new System.Windows.Forms.Label();
            this.worldMapView1 = new Droid.Geography.WorldMapView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPop = new System.Windows.Forms.RadioButton();
            this.radioButtonArea = new System.Windows.Forms.RadioButton();
            this.radioButtonCountry = new System.Windows.Forms.RadioButton();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "focus on";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(669, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(6, 43);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(39, 13);
            this.labelCapital.TabIndex = 6;
            this.labelCapital.Text = "Capital";
            // 
            // labelCoordonate
            // 
            this.labelCoordonate.AutoSize = true;
            this.labelCoordonate.Location = new System.Drawing.Point(6, 59);
            this.labelCoordonate.Name = "labelCoordonate";
            this.labelCoordonate.Size = new System.Drawing.Size(62, 13);
            this.labelCoordonate.TabIndex = 7;
            this.labelCoordonate.Text = "Coordonate";
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(6, 75);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(57, 13);
            this.labelPopulation.TabIndex = 8;
            this.labelPopulation.Text = "Population";
            // 
            // labelIso
            // 
            this.labelIso.AutoSize = true;
            this.labelIso.Location = new System.Drawing.Point(6, 91);
            this.labelIso.Name = "labelIso";
            this.labelIso.Size = new System.Drawing.Size(21, 13);
            this.labelIso.TabIndex = 9;
            this.labelIso.Text = "Iso";
            // 
            // labelTrigramme
            // 
            this.labelTrigramme.AutoSize = true;
            this.labelTrigramme.Location = new System.Drawing.Point(6, 107);
            this.labelTrigramme.Name = "labelTrigramme";
            this.labelTrigramme.Size = new System.Drawing.Size(56, 13);
            this.labelTrigramme.TabIndex = 10;
            this.labelTrigramme.Text = "Trigramme";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(6, 123);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(54, 13);
            this.labelArea.TabIndex = 11;
            this.labelArea.Text = "Superficie";
            // 
            // labelContinent
            // 
            this.labelContinent.AutoSize = true;
            this.labelContinent.Location = new System.Drawing.Point(6, 139);
            this.labelContinent.Name = "labelContinent";
            this.labelContinent.Size = new System.Drawing.Size(52, 13);
            this.labelContinent.TabIndex = 12;
            this.labelContinent.Text = "Continent";
            // 
            // worldMapView1
            // 
            this.worldMapView1.BackColor = System.Drawing.Color.DimGray;
            this.worldMapView1.CurrentWorldMap = null;
            this.worldMapView1.Location = new System.Drawing.Point(-1, 0);
            this.worldMapView1.Name = "worldMapView1";
            this.worldMapView1.Size = new System.Drawing.Size(600, 400);
            this.worldMapView1.TabIndex = 0;
            this.worldMapView1.Zoom = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelContinent);
            this.groupBox1.Controls.Add(this.labelCapital);
            this.groupBox1.Controls.Add(this.labelArea);
            this.groupBox1.Controls.Add(this.labelCoordonate);
            this.groupBox1.Controls.Add(this.labelTrigramme);
            this.groupBox1.Controls.Add(this.labelPopulation);
            this.groupBox1.Controls.Add(this.labelIso);
            this.groupBox1.Location = new System.Drawing.Point(605, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 165);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            // 
            // radioButtonPop
            // 
            this.radioButtonPop.AutoSize = true;
            this.radioButtonPop.Checked = true;
            this.radioButtonPop.Location = new System.Drawing.Point(605, 12);
            this.radioButtonPop.Name = "radioButtonPop";
            this.radioButtonPop.Size = new System.Drawing.Size(75, 17);
            this.radioButtonPop.TabIndex = 14;
            this.radioButtonPop.TabStop = true;
            this.radioButtonPop.Text = "Population";
            this.radioButtonPop.UseVisualStyleBackColor = true;
            this.radioButtonPop.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonArea
            // 
            this.radioButtonArea.AutoSize = true;
            this.radioButtonArea.Location = new System.Drawing.Point(605, 35);
            this.radioButtonArea.Name = "radioButtonArea";
            this.radioButtonArea.Size = new System.Drawing.Size(47, 17);
            this.radioButtonArea.TabIndex = 15;
            this.radioButtonArea.TabStop = true;
            this.radioButtonArea.Text = "Area";
            this.radioButtonArea.UseVisualStyleBackColor = true;
            this.radioButtonArea.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonCountry
            // 
            this.radioButtonCountry.AutoSize = true;
            this.radioButtonCountry.Location = new System.Drawing.Point(605, 81);
            this.radioButtonCountry.Name = "radioButtonCountry";
            this.radioButtonCountry.Size = new System.Drawing.Size(105, 17);
            this.radioButtonCountry.TabIndex = 16;
            this.radioButtonCountry.TabStop = true;
            this.radioButtonCountry.Text = "Selected country";
            this.radioButtonCountry.UseVisualStyleBackColor = true;
            this.radioButtonCountry.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(605, 58);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(60, 17);
            this.radioButtonCustom.TabIndex = 17;
            this.radioButtonCustom.TabStop = true;
            this.radioButtonCustom.Text = "Custom";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            this.radioButtonCustom.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 408);
            this.Controls.Add(this.radioButtonCustom);
            this.Controls.Add(this.radioButtonCountry);
            this.Controls.Add(this.radioButtonArea);
            this.Controls.Add(this.radioButtonPop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.worldMapView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "World map";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label labelContinent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPop;
        private System.Windows.Forms.RadioButton radioButtonArea;
        private System.Windows.Forms.RadioButton radioButtonCountry;
        private System.Windows.Forms.RadioButton radioButtonCustom;
    }
}

