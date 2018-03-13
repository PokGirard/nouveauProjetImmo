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
            this.label_titre_immobily.Location = new System.Drawing.Point(76, 42);
            this.label_titre_immobily.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_titre_immobily.Name = "label_titre_immobily";
            this.label_titre_immobily.Size = new System.Drawing.Size(154, 31);
            this.label_titre_immobily.TabIndex = 0;
            this.label_titre_immobily.Text = "IMMOBILY";
            // 
            // button_catalogue
            // 
            this.button_catalogue.Location = new System.Drawing.Point(83, 199);
            this.button_catalogue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_catalogue.Name = "button_catalogue";
            this.button_catalogue.Size = new System.Drawing.Size(100, 68);
            this.button_catalogue.TabIndex = 1;
            this.button_catalogue.Text = "Catalogue des biens";
            this.button_catalogue.UseVisualStyleBackColor = true;
            // 
            // button_ajouter_bien_catalogue
            // 
            this.button_ajouter_bien_catalogue.Location = new System.Drawing.Point(260, 199);
            this.button_ajouter_bien_catalogue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ajouter_bien_catalogue.Name = "button_ajouter_bien_catalogue";
            this.button_ajouter_bien_catalogue.Size = new System.Drawing.Size(100, 68);
            this.button_ajouter_bien_catalogue.TabIndex = 2;
            this.button_ajouter_bien_catalogue.Text = "Ajouter un bien";
            this.button_ajouter_bien_catalogue.UseVisualStyleBackColor = true;
            this.button_ajouter_bien_catalogue.Click += new System.EventHandler(this.button_ajouter_bien_catalogue_Click);
            // 
            // button_gestion_des_clients
            // 
            this.button_gestion_des_clients.Location = new System.Drawing.Point(452, 196);
            this.button_gestion_des_clients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_gestion_des_clients.Name = "button_gestion_des_clients";
            this.button_gestion_des_clients.Size = new System.Drawing.Size(100, 74);
            this.button_gestion_des_clients.TabIndex = 3;
            this.button_gestion_des_clients.Text = "Gestion des clients";
            this.button_gestion_des_clients.UseVisualStyleBackColor = true;
            this.button_gestion_des_clients.Click += new System.EventHandler(this.button_gestion_des_clients_Click);
            // 
            // button_gestion_des_commerciaux
            // 
            this.button_gestion_des_commerciaux.Image = global::EcranAccueil.Properties.Resources.unnamed;
            this.button_gestion_des_commerciaux.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_gestion_des_commerciaux.Location = new System.Drawing.Point(433, 42);
            this.button_gestion_des_commerciaux.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_gestion_des_commerciaux.Name = "button_gestion_des_commerciaux";
            this.button_gestion_des_commerciaux.Size = new System.Drawing.Size(119, 101);
            this.button_gestion_des_commerciaux.TabIndex = 4;
            this.button_gestion_des_commerciaux.Text = "Gestion des commerciaux";
            this.button_gestion_des_commerciaux.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_gestion_des_commerciaux.UseVisualStyleBackColor = true;
            this.button_gestion_des_commerciaux.Click += new System.EventHandler(this.button_gestion_des_commerciaux_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 313);
            this.Controls.Add(this.button_gestion_des_commerciaux);
            this.Controls.Add(this.button_gestion_des_clients);
            this.Controls.Add(this.button_ajouter_bien_catalogue);
            this.Controls.Add(this.button_catalogue);
            this.Controls.Add(this.label_titre_immobily);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

