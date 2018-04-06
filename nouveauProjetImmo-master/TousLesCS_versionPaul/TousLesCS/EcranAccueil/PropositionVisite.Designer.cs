namespace EcranAccueil
{
    partial class PropositionVisite
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
            this.LabelTitre = new System.Windows.Forms.Label();
            this.buttonCréer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelPrenomClient = new System.Windows.Forms.Label();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.textBoxNomClient = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxPrenomClient = new System.Windows.Forms.TextBox();
            this.textBoxCommercial = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelBien = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelCommercial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTitre
            // 
            this.LabelTitre.AutoSize = true;
            this.LabelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitre.Location = new System.Drawing.Point(66, 9);
            this.LabelTitre.Name = "LabelTitre";
            this.LabelTitre.Size = new System.Drawing.Size(266, 13);
            this.LabelTitre.TabIndex = 0;
            this.LabelTitre.Text = "CREATION D\'UNE PROPOSITION DE VISITE";
            // 
            // buttonCréer
            // 
            this.buttonCréer.Location = new System.Drawing.Point(79, 335);
            this.buttonCréer.Name = "buttonCréer";
            this.buttonCréer.Size = new System.Drawing.Size(75, 23);
            this.buttonCréer.TabIndex = 19;
            this.buttonCréer.Text = "Créer";
            this.buttonCréer.UseVisualStyleBackColor = true;
            this.buttonCréer.Click += new System.EventHandler(this.buttonCréer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(218, 335);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 20;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 291);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(11, 238);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 46;
            this.labelAdresse.Text = "Adresse";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(141, 238);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.ReadOnly = true;
            this.textBoxAdresse.Size = new System.Drawing.Size(233, 20);
            this.textBoxAdresse.TabIndex = 45;
            // 
            // labelPrenomClient
            // 
            this.labelPrenomClient.AutoSize = true;
            this.labelPrenomClient.Location = new System.Drawing.Point(11, 165);
            this.labelPrenomClient.Name = "labelPrenomClient";
            this.labelPrenomClient.Size = new System.Drawing.Size(43, 13);
            this.labelPrenomClient.TabIndex = 44;
            this.labelPrenomClient.Text = "Prénom";
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Location = new System.Drawing.Point(14, 139);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(29, 13);
            this.labelNomClient.TabIndex = 43;
            this.labelNomClient.Text = "Nom";
            // 
            // textBoxNomClient
            // 
            this.textBoxNomClient.Location = new System.Drawing.Point(141, 132);
            this.textBoxNomClient.Name = "textBoxNomClient";
            this.textBoxNomClient.ReadOnly = true;
            this.textBoxNomClient.Size = new System.Drawing.Size(136, 20);
            this.textBoxNomClient.TabIndex = 42;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(141, 201);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.ReadOnly = true;
            this.textBoxDesignation.Size = new System.Drawing.Size(233, 20);
            this.textBoxDesignation.TabIndex = 41;
            // 
            // textBoxPrenomClient
            // 
            this.textBoxPrenomClient.Location = new System.Drawing.Point(141, 162);
            this.textBoxPrenomClient.Name = "textBoxPrenomClient";
            this.textBoxPrenomClient.ReadOnly = true;
            this.textBoxPrenomClient.Size = new System.Drawing.Size(136, 20);
            this.textBoxPrenomClient.TabIndex = 40;
            // 
            // textBoxCommercial
            // 
            this.textBoxCommercial.Location = new System.Drawing.Point(141, 69);
            this.textBoxCommercial.Name = "textBoxCommercial";
            this.textBoxCommercial.ReadOnly = true;
            this.textBoxCommercial.Size = new System.Drawing.Size(136, 20);
            this.textBoxCommercial.TabIndex = 39;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(11, 291);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 13);
            this.labelDate.TabIndex = 38;
            this.labelDate.Text = "DATE";
            // 
            // labelBien
            // 
            this.labelBien.AutoSize = true;
            this.labelBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBien.Location = new System.Drawing.Point(11, 204);
            this.labelBien.Name = "labelBien";
            this.labelBien.Size = new System.Drawing.Size(36, 13);
            this.labelBien.TabIndex = 37;
            this.labelBien.Text = "BIEN";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(11, 110);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(51, 13);
            this.labelClient.TabIndex = 36;
            this.labelClient.Text = "CLIENT";
            // 
            // labelCommercial
            // 
            this.labelCommercial.AutoSize = true;
            this.labelCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommercial.Location = new System.Drawing.Point(11, 72);
            this.labelCommercial.Name = "labelCommercial";
            this.labelCommercial.Size = new System.Drawing.Size(88, 13);
            this.labelCommercial.TabIndex = 35;
            this.labelCommercial.Text = "COMMERCIAL";
            // 
            // PropositionVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 380);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelPrenomClient);
            this.Controls.Add(this.labelNomClient);
            this.Controls.Add(this.textBoxNomClient);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.textBoxPrenomClient);
            this.Controls.Add(this.textBoxCommercial);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelBien);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelCommercial);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonCréer);
            this.Controls.Add(this.LabelTitre);
            this.Name = "PropositionVisite";
            this.Text = "PropositionVisite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitre;
        private System.Windows.Forms.Button buttonCréer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelPrenomClient;
        private System.Windows.Forms.Label labelNomClient;
        private System.Windows.Forms.TextBox textBoxNomClient;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxPrenomClient;
        private System.Windows.Forms.TextBox textBoxCommercial;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelBien;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelCommercial;
    }
}