namespace EcranAccueil
{
    partial class Accueil
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
            this.label_titre_immobily = new System.Windows.Forms.Label();
            this.button_catalogue = new System.Windows.Forms.Button();
            this.button_ajouter_bien_catalogue = new System.Windows.Forms.Button();
            this.button_gestion_des_clients = new System.Windows.Forms.Button();
            this.button_gestion_des_commerciaux = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titre_immobily
            // 
            this.label_titre_immobily.AutoSize = true;
            this.label_titre_immobily.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titre_immobily.Location = new System.Drawing.Point(57, 34);
            this.label_titre_immobily.Name = "label_titre_immobily";
            this.label_titre_immobily.Size = new System.Drawing.Size(123, 25);
            this.label_titre_immobily.TabIndex = 0;
            this.label_titre_immobily.Text = "IMMOBILY";
            // 
            // button_catalogue
            // 
            this.button_catalogue.Location = new System.Drawing.Point(62, 162);
            this.button_catalogue.Name = "button_catalogue";
            this.button_catalogue.Size = new System.Drawing.Size(75, 55);
            this.button_catalogue.TabIndex = 1;
            this.button_catalogue.Text = "Catalogue des biens";
            this.button_catalogue.UseVisualStyleBackColor = true;
            this.button_catalogue.Click += new System.EventHandler(this.button_catalogue_Click);
            // 
            // button_ajouter_bien_catalogue
            // 
            this.button_ajouter_bien_catalogue.Location = new System.Drawing.Point(195, 162);
            this.button_ajouter_bien_catalogue.Name = "button_ajouter_bien_catalogue";
            this.button_ajouter_bien_catalogue.Size = new System.Drawing.Size(75, 55);
            this.button_ajouter_bien_catalogue.TabIndex = 2;
            this.button_ajouter_bien_catalogue.Text = "Ajouter un bien";
            this.button_ajouter_bien_catalogue.UseVisualStyleBackColor = true;
            this.button_ajouter_bien_catalogue.Click += new System.EventHandler(this.button_ajouter_bien_catalogue_Click);
            // 
            // button_gestion_des_clients
            // 
            this.button_gestion_des_clients.Location = new System.Drawing.Point(339, 159);
            this.button_gestion_des_clients.Name = "button_gestion_des_clients";
            this.button_gestion_des_clients.Size = new System.Drawing.Size(75, 60);
            this.button_gestion_des_clients.TabIndex = 3;
            this.button_gestion_des_clients.Text = "Gestion des clients";
            this.button_gestion_des_clients.UseVisualStyleBackColor = true;
            this.button_gestion_des_clients.Click += new System.EventHandler(this.button_gestion_des_clients_Click);
            // 
            // button_gestion_des_commerciaux
            // 
            this.button_gestion_des_commerciaux.Image = global::EcranAccueil.Properties.Resources.unnamed;
            this.button_gestion_des_commerciaux.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_gestion_des_commerciaux.Location = new System.Drawing.Point(325, 34);
            this.button_gestion_des_commerciaux.Name = "button_gestion_des_commerciaux";
            this.button_gestion_des_commerciaux.Size = new System.Drawing.Size(89, 82);
            this.button_gestion_des_commerciaux.TabIndex = 4;
            this.button_gestion_des_commerciaux.Text = "Gestion des commerciaux";
            this.button_gestion_des_commerciaux.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_gestion_des_commerciaux.UseVisualStyleBackColor = true;
            this.button_gestion_des_commerciaux.Click += new System.EventHandler(this.button_gestion_des_commerciaux_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 254);
            this.Controls.Add(this.button_gestion_des_commerciaux);
            this.Controls.Add(this.button_gestion_des_clients);
            this.Controls.Add(this.button_ajouter_bien_catalogue);
            this.Controls.Add(this.button_catalogue);
            this.Controls.Add(this.label_titre_immobily);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titre_immobily;
        private System.Windows.Forms.Button button_catalogue;
        private System.Windows.Forms.Button button_ajouter_bien_catalogue;
        private System.Windows.Forms.Button button_gestion_des_clients;
        private System.Windows.Forms.Button button_gestion_des_commerciaux;
    }
}

