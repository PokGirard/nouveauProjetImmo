namespace EcranAccueil
{
    partial class VisitesBien
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
            this.listViewbiens = new System.Windows.Forms.ListView();
            this.nomAcheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenomAcheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateVisite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sous_seing_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewbiens
            // 
            this.listViewbiens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomAcheteur,
            this.prenomAcheteur,
            this.dateVisite});
            this.listViewbiens.FullRowSelect = true;
            this.listViewbiens.GridLines = true;
            this.listViewbiens.Location = new System.Drawing.Point(12, 12);
            this.listViewbiens.MultiSelect = false;
            this.listViewbiens.Name = "listViewbiens";
            this.listViewbiens.Size = new System.Drawing.Size(298, 347);
            this.listViewbiens.TabIndex = 59;
            this.listViewbiens.UseCompatibleStateImageBehavior = false;
            this.listViewbiens.View = System.Windows.Forms.View.Details;
            // 
            // nomAcheteur
            // 
            this.nomAcheteur.Text = "Nom Acheteur";
            this.nomAcheteur.Width = 96;
            // 
            // prenomAcheteur
            // 
            this.prenomAcheteur.Text = "Prénom Acheteur";
            this.prenomAcheteur.Width = 102;
            // 
            // dateVisite
            // 
            this.dateVisite.Text = "Date de visite";
            this.dateVisite.Width = 94;
            // 
            // sous_seing_button
            // 
            this.sous_seing_button.Location = new System.Drawing.Point(64, 365);
            this.sous_seing_button.Name = "sous_seing_button";
            this.sous_seing_button.Size = new System.Drawing.Size(179, 39);
            this.sous_seing_button.TabIndex = 60;
            this.sous_seing_button.Text = "FERMER";
            this.sous_seing_button.UseVisualStyleBackColor = true;
            this.sous_seing_button.Click += new System.EventHandler(this.sous_seing_button_Click);
            // 
            // VisitesBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 408);
            this.Controls.Add(this.sous_seing_button);
            this.Controls.Add(this.listViewbiens);
            this.Name = "VisitesBien";
            this.Text = "VisitesBien";
            this.Load += new System.EventHandler(this.VisitesBien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewbiens;
        private System.Windows.Forms.ColumnHeader nomAcheteur;
        private System.Windows.Forms.ColumnHeader prenomAcheteur;
        private System.Windows.Forms.ColumnHeader dateVisite;
        private System.Windows.Forms.Button sous_seing_button;
    }
}