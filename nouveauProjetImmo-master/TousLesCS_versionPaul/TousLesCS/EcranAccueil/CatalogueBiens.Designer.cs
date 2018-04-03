namespace EcranAccueil
{
    partial class CatalogueBiens
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
            this.label15 = new System.Windows.Forms.Label();
            this.disponible_button = new System.Windows.Forms.Button();
            this.sous_seing_button = new System.Windows.Forms.Button();
            this.vendu_button = new System.Windows.Forms.Button();
            this.archive_button = new System.Windows.Forms.Button();
            this.listViewbiens = new System.Windows.Forms.ListView();
            this.ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surface_parcelle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surface_habitable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nb_pieces = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.garage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.voir_bien_button = new System.Windows.Forms.Button();
            this.idBien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(255, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(266, 25);
            this.label15.TabIndex = 53;
            this.label15.Text = "CATALOGUE DES BIENS";
            // 
            // disponible_button
            // 
            this.disponible_button.Location = new System.Drawing.Point(23, 100);
            this.disponible_button.Name = "disponible_button";
            this.disponible_button.Size = new System.Drawing.Size(179, 39);
            this.disponible_button.TabIndex = 54;
            this.disponible_button.Text = "DISPONIBLE";
            this.disponible_button.UseVisualStyleBackColor = true;
            this.disponible_button.Click += new System.EventHandler(this.disponible_Click);
            // 
            // sous_seing_button
            // 
            this.sous_seing_button.Location = new System.Drawing.Point(208, 100);
            this.sous_seing_button.Name = "sous_seing_button";
            this.sous_seing_button.Size = new System.Drawing.Size(179, 39);
            this.sous_seing_button.TabIndex = 55;
            this.sous_seing_button.Text = "SOUS-SEING";
            this.sous_seing_button.UseVisualStyleBackColor = true;
            this.sous_seing_button.Click += new System.EventHandler(this.sous_seing_button_Click);
            // 
            // vendu_button
            // 
            this.vendu_button.Location = new System.Drawing.Point(392, 100);
            this.vendu_button.Name = "vendu_button";
            this.vendu_button.Size = new System.Drawing.Size(179, 39);
            this.vendu_button.TabIndex = 56;
            this.vendu_button.Text = "VENDU";
            this.vendu_button.UseVisualStyleBackColor = true;
            this.vendu_button.Click += new System.EventHandler(this.vendu_button_Click);
            // 
            // archive_button
            // 
            this.archive_button.Location = new System.Drawing.Point(577, 100);
            this.archive_button.Name = "archive_button";
            this.archive_button.Size = new System.Drawing.Size(179, 39);
            this.archive_button.TabIndex = 57;
            this.archive_button.Text = "ARCHIVE";
            this.archive_button.UseVisualStyleBackColor = true;
            this.archive_button.Click += new System.EventHandler(this.archive_button_Click);
            // 
            // listViewbiens
            // 
            this.listViewbiens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idBien,
            this.ville,
            this.prix,
            this.surface_parcelle,
            this.surface_habitable,
            this.nb_pieces,
            this.garage,
            this.cave});
            this.listViewbiens.FullRowSelect = true;
            this.listViewbiens.Location = new System.Drawing.Point(23, 145);
            this.listViewbiens.MultiSelect = false;
            this.listViewbiens.Name = "listViewbiens";
            this.listViewbiens.Size = new System.Drawing.Size(733, 367);
            this.listViewbiens.TabIndex = 58;
            this.listViewbiens.UseCompatibleStateImageBehavior = false;
            this.listViewbiens.View = System.Windows.Forms.View.Details;
            this.listViewbiens.Click += new System.EventHandler(this.listViewbiens_Click);
            // 
            // ville
            // 
            this.ville.Text = "Ville";
            this.ville.Width = 177;
            // 
            // prix
            // 
            this.prix.Text = "Prix";
            this.prix.Width = 108;
            // 
            // surface_parcelle
            // 
            this.surface_parcelle.DisplayIndex = 2;
            this.surface_parcelle.Text = "Parcelle";
            this.surface_parcelle.Width = 75;
            // 
            // surface_habitable
            // 
            this.surface_habitable.DisplayIndex = 3;
            this.surface_habitable.Text = "Habitable";
            this.surface_habitable.Width = 71;
            // 
            // nb_pieces
            // 
            this.nb_pieces.DisplayIndex = 4;
            this.nb_pieces.Text = "Nombre de pièces";
            this.nb_pieces.Width = 106;
            // 
            // garage
            // 
            this.garage.DisplayIndex = 5;
            this.garage.Text = "Garage";
            this.garage.Width = 89;
            // 
            // cave
            // 
            this.cave.DisplayIndex = 6;
            this.cave.Text = "Cave";
            this.cave.Width = 86;
            // 
            // voir_bien_button
            // 
            this.voir_bien_button.Location = new System.Drawing.Point(303, 518);
            this.voir_bien_button.Name = "voir_bien_button";
            this.voir_bien_button.Size = new System.Drawing.Size(179, 39);
            this.voir_bien_button.TabIndex = 59;
            this.voir_bien_button.Text = "VOIR LE BIEN";
            this.voir_bien_button.UseVisualStyleBackColor = true;
            this.voir_bien_button.Click += new System.EventHandler(this.voir_bien_button_Click);
            // 
            // idBien
            // 
            this.idBien.Text = "IDBien";
            // 
            // CatalogueBiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.voir_bien_button);
            this.Controls.Add(this.listViewbiens);
            this.Controls.Add(this.archive_button);
            this.Controls.Add(this.vendu_button);
            this.Controls.Add(this.sous_seing_button);
            this.Controls.Add(this.disponible_button);
            this.Controls.Add(this.label15);
            this.Name = "CatalogueBiens";
            this.Text = "Catalogue des biens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button disponible_button;
        private System.Windows.Forms.Button sous_seing_button;
        private System.Windows.Forms.Button vendu_button;
        private System.Windows.Forms.Button archive_button;
        private System.Windows.Forms.ListView listViewbiens;
        private System.Windows.Forms.ColumnHeader ville;
        private System.Windows.Forms.ColumnHeader surface_parcelle;
        private System.Windows.Forms.ColumnHeader surface_habitable;
        private System.Windows.Forms.Button voir_bien_button;
        private System.Windows.Forms.ColumnHeader nb_pieces;
        private System.Windows.Forms.ColumnHeader garage;
        private System.Windows.Forms.ColumnHeader cave;
        private System.Windows.Forms.ColumnHeader idBien;
        private System.Windows.Forms.ColumnHeader prix;
    }
}