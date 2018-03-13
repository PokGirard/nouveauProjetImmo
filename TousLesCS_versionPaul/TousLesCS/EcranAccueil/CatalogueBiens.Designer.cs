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
            this.listView1 = new System.Windows.Forms.ListView();
            this.designation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nb_visites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(301, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 25);
            this.label15.TabIndex = 53;
            this.label15.Text = "COMMERCIAUX";
            // 
            // disponible_button
            // 
            this.disponible_button.Location = new System.Drawing.Point(23, 97);
            this.disponible_button.Name = "disponible_button";
            this.disponible_button.Size = new System.Drawing.Size(150, 39);
            this.disponible_button.TabIndex = 54;
            this.disponible_button.Text = "DISPONIBLE";
            this.disponible_button.UseVisualStyleBackColor = true;
            this.disponible_button.Click += new System.EventHandler(this.disponible_Click);
            // 
            // sous_seing_button
            // 
            this.sous_seing_button.Location = new System.Drawing.Point(226, 97);
            this.sous_seing_button.Name = "sous_seing_button";
            this.sous_seing_button.Size = new System.Drawing.Size(150, 39);
            this.sous_seing_button.TabIndex = 55;
            this.sous_seing_button.Text = "SOUS-SEING";
            this.sous_seing_button.UseVisualStyleBackColor = true;
            this.sous_seing_button.Click += new System.EventHandler(this.sous_seing_button_Click);
            // 
            // vendu_button
            // 
            this.vendu_button.Location = new System.Drawing.Point(418, 97);
            this.vendu_button.Name = "vendu_button";
            this.vendu_button.Size = new System.Drawing.Size(150, 39);
            this.vendu_button.TabIndex = 56;
            this.vendu_button.Text = "VENDU";
            this.vendu_button.UseVisualStyleBackColor = true;
            this.vendu_button.Click += new System.EventHandler(this.vendu_button_Click);
            // 
            // archive_button
            // 
            this.archive_button.Location = new System.Drawing.Point(606, 97);
            this.archive_button.Name = "archive_button";
            this.archive_button.Size = new System.Drawing.Size(150, 39);
            this.archive_button.TabIndex = 57;
            this.archive_button.Text = "ARCHIVE";
            this.archive_button.UseVisualStyleBackColor = true;
            this.archive_button.Click += new System.EventHandler(this.archive_button_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.designation,
            this.adresse,
            this.ville,
            this.nb_visites});
            this.listView1.Location = new System.Drawing.Point(23, 168);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(733, 372);
            this.listView1.TabIndex = 58;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // designation
            // 
            this.designation.Text = "Designation";
            this.designation.Width = 109;
            // 
            // adresse
            // 
            this.adresse.Text = "Adresse";
            this.adresse.Width = 365;
            // 
            // ville
            // 
            this.ville.Text = "Ville";
            this.ville.Width = 118;
            // 
            // nb_visites
            // 
            this.nb_visites.Text = "Nombre de visites";
            this.nb_visites.Width = 136;
            // 
            // CatalogueBiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader designation;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader ville;
        private System.Windows.Forms.ColumnHeader nb_visites;
    }
}