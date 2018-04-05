namespace EcranAccueil
{
    partial class RDV_Visite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDV_Visite));
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonCréer = new System.Windows.Forms.Button();
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
            this.LabelTitre = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(227, 350);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 36;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click_1);
            // 
            // buttonCréer
            // 
            this.buttonCréer.Location = new System.Drawing.Point(86, 350);
            this.buttonCréer.Name = "buttonCréer";
            this.buttonCréer.Size = new System.Drawing.Size(75, 23);
            this.buttonCréer.TabIndex = 35;
            this.buttonCréer.Text = "Créer";
            this.buttonCréer.UseVisualStyleBackColor = true;
            this.buttonCréer.Click += new System.EventHandler(this.buttonCréer_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 294);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(10, 241);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 33;
            this.labelAdresse.Text = "Adresse";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(140, 241);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.ReadOnly = true;
            this.textBoxAdresse.Size = new System.Drawing.Size(233, 20);
            this.textBoxAdresse.TabIndex = 32;
            // 
            // labelPrenomClient
            // 
            this.labelPrenomClient.AutoSize = true;
            this.labelPrenomClient.Location = new System.Drawing.Point(10, 168);
            this.labelPrenomClient.Name = "labelPrenomClient";
            this.labelPrenomClient.Size = new System.Drawing.Size(43, 13);
            this.labelPrenomClient.TabIndex = 31;
            this.labelPrenomClient.Text = "Prénom";
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Location = new System.Drawing.Point(13, 142);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(29, 13);
            this.labelNomClient.TabIndex = 30;
            this.labelNomClient.Text = "Nom";
            // 
            // textBoxNomClient
            // 
            this.textBoxNomClient.Location = new System.Drawing.Point(140, 135);
            this.textBoxNomClient.Name = "textBoxNomClient";
            this.textBoxNomClient.ReadOnly = true;
            this.textBoxNomClient.Size = new System.Drawing.Size(136, 20);
            this.textBoxNomClient.TabIndex = 29;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(140, 204);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.ReadOnly = true;
            this.textBoxDesignation.Size = new System.Drawing.Size(233, 20);
            this.textBoxDesignation.TabIndex = 28;
            // 
            // textBoxPrenomClient
            // 
            this.textBoxPrenomClient.Location = new System.Drawing.Point(140, 165);
            this.textBoxPrenomClient.Name = "textBoxPrenomClient";
            this.textBoxPrenomClient.ReadOnly = true;
            this.textBoxPrenomClient.Size = new System.Drawing.Size(136, 20);
            this.textBoxPrenomClient.TabIndex = 27;
            // 
            // textBoxCommercial
            // 
            this.textBoxCommercial.Location = new System.Drawing.Point(140, 72);
            this.textBoxCommercial.Name = "textBoxCommercial";
            this.textBoxCommercial.ReadOnly = true;
            this.textBoxCommercial.Size = new System.Drawing.Size(136, 20);
            this.textBoxCommercial.TabIndex = 26;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(10, 294);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 13);
            this.labelDate.TabIndex = 25;
            this.labelDate.Text = "DATE";
            // 
            // labelBien
            // 
            this.labelBien.AutoSize = true;
            this.labelBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBien.Location = new System.Drawing.Point(10, 207);
            this.labelBien.Name = "labelBien";
            this.labelBien.Size = new System.Drawing.Size(36, 13);
            this.labelBien.TabIndex = 24;
            this.labelBien.Text = "BIEN";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(10, 113);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(51, 13);
            this.labelClient.TabIndex = 23;
            this.labelClient.Text = "CLIENT";
            // 
            // labelCommercial
            // 
            this.labelCommercial.AutoSize = true;
            this.labelCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommercial.Location = new System.Drawing.Point(10, 75);
            this.labelCommercial.Name = "labelCommercial";
            this.labelCommercial.Size = new System.Drawing.Size(88, 13);
            this.labelCommercial.TabIndex = 22;
            this.labelCommercial.Text = "COMMERCIAL";
            // 
            // LabelTitre
            // 
            this.LabelTitre.AutoSize = true;
            this.LabelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitre.Location = new System.Drawing.Point(104, 9);
            this.LabelTitre.Name = "LabelTitre";
            this.LabelTitre.Size = new System.Drawing.Size(185, 13);
            this.LabelTitre.TabIndex = 21;
            this.LabelTitre.Text = "CREATION DU RENDEZ-VOUS";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // RDV_Visite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 402);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonCréer);
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
            this.Controls.Add(this.LabelTitre);
            this.Name = "RDV_Visite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDV_Visite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonCréer;
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
        private System.Windows.Forms.Label LabelTitre;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}