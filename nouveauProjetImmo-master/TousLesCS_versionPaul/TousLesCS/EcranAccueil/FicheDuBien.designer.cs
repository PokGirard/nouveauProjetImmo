namespace EcranAccueil
{
    partial class FicheDuBien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheDuBien));
            this.label_bien = new System.Windows.Forms.Label();
            this.desc_surface_habitable = new System.Windows.Forms.Label();
            this.label_desc_nb_pieces = new System.Windows.Forms.Label();
            this.label_desc_surf_parcelle = new System.Windows.Forms.Label();
            this.label_desc_nb_chambres = new System.Windows.Forms.Label();
            this.label_desc_salles_de_bain = new System.Windows.Forms.Label();
            this.label_desc_garage = new System.Windows.Forms.Label();
            this.label_desc_cave = new System.Windows.Forms.Label();
            this.label_adr_bien = new System.Windows.Forms.Label();
            this.label_desc_code_postal = new System.Windows.Forms.Label();
            this.label_desc_ville = new System.Windows.Forms.Label();
            this.label_desc_commentaires = new System.Windows.Forms.Label();
            this.surface_hab = new System.Windows.Forms.NumericUpDown();
            this.surface_parc = new System.Windows.Forms.NumericUpDown();
            this.nb_pieces = new System.Windows.Forms.NumericUpDown();
            this.nb_chambres = new System.Windows.Forms.NumericUpDown();
            this.nb_sdb = new System.Windows.Forms.NumericUpDown();
            this.comboBox_garage = new System.Windows.Forms.ComboBox();
            this.comboBox_cave = new System.Windows.Forms.ComboBox();
            this.textBox_descr_bien = new System.Windows.Forms.TextBox();
            this.code_postal = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.commentaires = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.titreFenetreFicheBien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.surface_hab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surface_parc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_pieces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_chambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_sdb)).BeginInit();
            this.SuspendLayout();
            // 
            // label_bien
            // 
            this.label_bien.AutoSize = true;
            this.label_bien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bien.Location = new System.Drawing.Point(29, 69);
            this.label_bien.Name = "label_bien";
            this.label_bien.Size = new System.Drawing.Size(36, 13);
            this.label_bien.TabIndex = 1;
            this.label_bien.Text = "BIEN";
            // 
            // desc_surface_habitable
            // 
            this.desc_surface_habitable.AutoSize = true;
            this.desc_surface_habitable.Location = new System.Drawing.Point(29, 97);
            this.desc_surface_habitable.Name = "desc_surface_habitable";
            this.desc_surface_habitable.Size = new System.Drawing.Size(90, 13);
            this.desc_surface_habitable.TabIndex = 2;
            this.desc_surface_habitable.Text = "Surface habitable";
            // 
            // label_desc_nb_pieces
            // 
            this.label_desc_nb_pieces.AutoSize = true;
            this.label_desc_nb_pieces.Location = new System.Drawing.Point(29, 154);
            this.label_desc_nb_pieces.Name = "label_desc_nb_pieces";
            this.label_desc_nb_pieces.Size = new System.Drawing.Size(93, 13);
            this.label_desc_nb_pieces.TabIndex = 3;
            this.label_desc_nb_pieces.Text = "Nombre de pièces";
            // 
            // label_desc_surf_parcelle
            // 
            this.label_desc_surf_parcelle.AutoSize = true;
            this.label_desc_surf_parcelle.Location = new System.Drawing.Point(29, 124);
            this.label_desc_surf_parcelle.Name = "label_desc_surf_parcelle";
            this.label_desc_surf_parcelle.Size = new System.Drawing.Size(110, 13);
            this.label_desc_surf_parcelle.TabIndex = 4;
            this.label_desc_surf_parcelle.Text = "Surface de la parcelle";
            // 
            // label_desc_nb_chambres
            // 
            this.label_desc_nb_chambres.AutoSize = true;
            this.label_desc_nb_chambres.Location = new System.Drawing.Point(29, 184);
            this.label_desc_nb_chambres.Name = "label_desc_nb_chambres";
            this.label_desc_nb_chambres.Size = new System.Drawing.Size(108, 13);
            this.label_desc_nb_chambres.TabIndex = 5;
            this.label_desc_nb_chambres.Text = "Nombre de chambres";
            // 
            // label_desc_salles_de_bain
            // 
            this.label_desc_salles_de_bain.AutoSize = true;
            this.label_desc_salles_de_bain.Location = new System.Drawing.Point(29, 214);
            this.label_desc_salles_de_bain.Name = "label_desc_salles_de_bain";
            this.label_desc_salles_de_bain.Size = new System.Drawing.Size(126, 13);
            this.label_desc_salles_de_bain.TabIndex = 6;
            this.label_desc_salles_de_bain.Text = "Nombre de salles de bain";
            // 
            // label_desc_garage
            // 
            this.label_desc_garage.AutoSize = true;
            this.label_desc_garage.Location = new System.Drawing.Point(29, 245);
            this.label_desc_garage.Name = "label_desc_garage";
            this.label_desc_garage.Size = new System.Drawing.Size(48, 13);
            this.label_desc_garage.TabIndex = 7;
            this.label_desc_garage.Text = "Garage :";
            // 
            // label_desc_cave
            // 
            this.label_desc_cave.AutoSize = true;
            this.label_desc_cave.Location = new System.Drawing.Point(29, 273);
            this.label_desc_cave.Name = "label_desc_cave";
            this.label_desc_cave.Size = new System.Drawing.Size(38, 13);
            this.label_desc_cave.TabIndex = 8;
            this.label_desc_cave.Text = "Cave :";
            // 
            // label_adr_bien
            // 
            this.label_adr_bien.AutoSize = true;
            this.label_adr_bien.Location = new System.Drawing.Point(29, 307);
            this.label_adr_bien.Name = "label_adr_bien";
            this.label_adr_bien.Size = new System.Drawing.Size(89, 13);
            this.label_adr_bien.TabIndex = 9;
            this.label_adr_bien.Text = "Adresse du bien :";
            // 
            // label_desc_code_postal
            // 
            this.label_desc_code_postal.AutoSize = true;
            this.label_desc_code_postal.Location = new System.Drawing.Point(29, 407);
            this.label_desc_code_postal.Name = "label_desc_code_postal";
            this.label_desc_code_postal.Size = new System.Drawing.Size(70, 13);
            this.label_desc_code_postal.TabIndex = 10;
            this.label_desc_code_postal.Text = "Code Postal :";
            // 
            // label_desc_ville
            // 
            this.label_desc_ville.AutoSize = true;
            this.label_desc_ville.Location = new System.Drawing.Point(29, 439);
            this.label_desc_ville.Name = "label_desc_ville";
            this.label_desc_ville.Size = new System.Drawing.Size(32, 13);
            this.label_desc_ville.TabIndex = 11;
            this.label_desc_ville.Text = "Ville :";
            // 
            // label_desc_commentaires
            // 
            this.label_desc_commentaires.AutoSize = true;
            this.label_desc_commentaires.Location = new System.Drawing.Point(29, 468);
            this.label_desc_commentaires.Name = "label_desc_commentaires";
            this.label_desc_commentaires.Size = new System.Drawing.Size(79, 13);
            this.label_desc_commentaires.TabIndex = 12;
            this.label_desc_commentaires.Text = "Commentaires :";
            // 
            // surface_hab
            // 
            this.surface_hab.Location = new System.Drawing.Point(194, 90);
            this.surface_hab.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.surface_hab.Name = "surface_hab";
            this.surface_hab.Size = new System.Drawing.Size(60, 20);
            this.surface_hab.TabIndex = 13;
            // 
            // surface_parc
            // 
            this.surface_parc.Location = new System.Drawing.Point(194, 117);
            this.surface_parc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.surface_parc.Name = "surface_parc";
            this.surface_parc.Size = new System.Drawing.Size(60, 20);
            this.surface_parc.TabIndex = 14;
            // 
            // nb_pieces
            // 
            this.nb_pieces.Location = new System.Drawing.Point(194, 147);
            this.nb_pieces.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nb_pieces.Name = "nb_pieces";
            this.nb_pieces.Size = new System.Drawing.Size(60, 20);
            this.nb_pieces.TabIndex = 15;
            // 
            // nb_chambres
            // 
            this.nb_chambres.Location = new System.Drawing.Point(194, 177);
            this.nb_chambres.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nb_chambres.Name = "nb_chambres";
            this.nb_chambres.Size = new System.Drawing.Size(60, 20);
            this.nb_chambres.TabIndex = 16;
            // 
            // nb_sdb
            // 
            this.nb_sdb.Location = new System.Drawing.Point(194, 207);
            this.nb_sdb.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nb_sdb.Name = "nb_sdb";
            this.nb_sdb.Size = new System.Drawing.Size(60, 20);
            this.nb_sdb.TabIndex = 17;
            // 
            // comboBox_garage
            // 
            this.comboBox_garage.FormattingEnabled = true;
            this.comboBox_garage.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.comboBox_garage.Location = new System.Drawing.Point(194, 237);
            this.comboBox_garage.Name = "comboBox_garage";
            this.comboBox_garage.Size = new System.Drawing.Size(60, 21);
            this.comboBox_garage.TabIndex = 18;
            // 
            // comboBox_cave
            // 
            this.comboBox_cave.FormattingEnabled = true;
            this.comboBox_cave.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.comboBox_cave.Location = new System.Drawing.Point(194, 273);
            this.comboBox_cave.Name = "comboBox_cave";
            this.comboBox_cave.Size = new System.Drawing.Size(60, 21);
            this.comboBox_cave.TabIndex = 19;
            // 
            // textBox_descr_bien
            // 
            this.textBox_descr_bien.Location = new System.Drawing.Point(32, 335);
            this.textBox_descr_bien.Multiline = true;
            this.textBox_descr_bien.Name = "textBox_descr_bien";
            this.textBox_descr_bien.Size = new System.Drawing.Size(403, 58);
            this.textBox_descr_bien.TabIndex = 20;
            // 
            // code_postal
            // 
            this.code_postal.Location = new System.Drawing.Point(105, 404);
            this.code_postal.Name = "code_postal";
            this.code_postal.Size = new System.Drawing.Size(124, 20);
            this.code_postal.TabIndex = 21;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(105, 432);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(124, 20);
            this.ville.TabIndex = 22;
            // 
            // commentaires
            // 
            this.commentaires.Location = new System.Drawing.Point(32, 497);
            this.commentaires.Multiline = true;
            this.commentaires.Name = "commentaires";
            this.commentaires.Size = new System.Drawing.Size(403, 58);
            this.commentaires.TabIndex = 23;
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
            // titreFenetreFicheBien
            // 
            this.titreFenetreFicheBien.AutoSize = true;
            this.titreFenetreFicheBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreFenetreFicheBien.Location = new System.Drawing.Point(131, 9);
            this.titreFenetreFicheBien.Name = "titreFenetreFicheBien";
            this.titreFenetreFicheBien.Size = new System.Drawing.Size(167, 25);
            this.titreFenetreFicheBien.TabIndex = 55;
            this.titreFenetreFicheBien.Text = "FICHE DU BIEN";
            // 
            // FicheDuBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(461, 598);
            this.Controls.Add(this.titreFenetreFicheBien);
            this.Controls.Add(this.commentaires);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.code_postal);
            this.Controls.Add(this.textBox_descr_bien);
            this.Controls.Add(this.comboBox_cave);
            this.Controls.Add(this.comboBox_garage);
            this.Controls.Add(this.nb_sdb);
            this.Controls.Add(this.nb_chambres);
            this.Controls.Add(this.nb_pieces);
            this.Controls.Add(this.surface_parc);
            this.Controls.Add(this.surface_hab);
            this.Controls.Add(this.label_desc_commentaires);
            this.Controls.Add(this.label_desc_ville);
            this.Controls.Add(this.label_desc_code_postal);
            this.Controls.Add(this.label_adr_bien);
            this.Controls.Add(this.label_desc_cave);
            this.Controls.Add(this.label_desc_garage);
            this.Controls.Add(this.label_desc_salles_de_bain);
            this.Controls.Add(this.label_desc_nb_chambres);
            this.Controls.Add(this.label_desc_surf_parcelle);
            this.Controls.Add(this.label_desc_nb_pieces);
            this.Controls.Add(this.desc_surface_habitable);
            this.Controls.Add(this.label_bien);
            this.Name = "FicheDuBien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impression fiche de bien";
            this.Click += new System.EventHandler(this.FicheDuBien_Click);
            ((System.ComponentModel.ISupportInitialize)(this.surface_hab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surface_parc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_pieces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_chambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_sdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_bien;
        private System.Windows.Forms.Label desc_surface_habitable;
        private System.Windows.Forms.Label label_desc_nb_pieces;
        private System.Windows.Forms.Label label_desc_surf_parcelle;
        private System.Windows.Forms.Label label_desc_nb_chambres;
        private System.Windows.Forms.Label label_desc_salles_de_bain;
        private System.Windows.Forms.Label label_desc_garage;
        private System.Windows.Forms.Label label_desc_cave;
        private System.Windows.Forms.Label label_adr_bien;
        private System.Windows.Forms.Label label_desc_code_postal;
        private System.Windows.Forms.Label label_desc_ville;
        private System.Windows.Forms.Label label_desc_commentaires;
        private System.Windows.Forms.NumericUpDown surface_hab;
        private System.Windows.Forms.NumericUpDown surface_parc;
        private System.Windows.Forms.NumericUpDown nb_pieces;
        private System.Windows.Forms.NumericUpDown nb_chambres;
        private System.Windows.Forms.NumericUpDown nb_sdb;
        private System.Windows.Forms.ComboBox comboBox_garage;
        private System.Windows.Forms.ComboBox comboBox_cave;
        private System.Windows.Forms.TextBox textBox_descr_bien;
        private System.Windows.Forms.TextBox code_postal;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.TextBox commentaires;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label titreFenetreFicheBien;
    }
}

