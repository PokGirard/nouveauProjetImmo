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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.button_catalogue = new System.Windows.Forms.Button();
            this.button_ajouter_bien_catalogue = new System.Windows.Forms.Button();
            this.button_gestion_des_clients = new System.Windows.Forms.Button();
            this.button_gestion_des_commerciaux = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_catalogue
            // 
            this.button_catalogue.Location = new System.Drawing.Point(200, 159);
            this.button_catalogue.Name = "button_catalogue";
            this.button_catalogue.Size = new System.Drawing.Size(89, 60);
            this.button_catalogue.TabIndex = 1;
            this.button_catalogue.Text = "Catalogue des biens";
            this.button_catalogue.UseVisualStyleBackColor = true;
            this.button_catalogue.Click += new System.EventHandler(this.button_catalogue_Click);
            // 
            // button_ajouter_bien_catalogue
            // 
            this.button_ajouter_bien_catalogue.Location = new System.Drawing.Point(62, 159);
            this.button_ajouter_bien_catalogue.Name = "button_ajouter_bien_catalogue";
            this.button_ajouter_bien_catalogue.Size = new System.Drawing.Size(89, 60);
            this.button_ajouter_bien_catalogue.TabIndex = 2;
            this.button_ajouter_bien_catalogue.Text = "Ajouter un bien";
            this.button_ajouter_bien_catalogue.UseVisualStyleBackColor = true;
            this.button_ajouter_bien_catalogue.Click += new System.EventHandler(this.button_ajouter_bien_catalogue_Click);
            // 
            // button_gestion_des_clients
            // 
            this.button_gestion_des_clients.Location = new System.Drawing.Point(358, 159);
            this.button_gestion_des_clients.Name = "button_gestion_des_clients";
            this.button_gestion_des_clients.Size = new System.Drawing.Size(89, 60);
            this.button_gestion_des_clients.TabIndex = 3;
            this.button_gestion_des_clients.Text = "Gestion des clients";
            this.button_gestion_des_clients.UseVisualStyleBackColor = true;
            this.button_gestion_des_clients.Click += new System.EventHandler(this.button_gestion_des_clients_Click);
            // 
            // button_gestion_des_commerciaux
            // 
            this.button_gestion_des_commerciaux.Image = global::EcranAccueil.Properties.Resources.logo_commerciaux_gimp;
            this.button_gestion_des_commerciaux.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_gestion_des_commerciaux.Location = new System.Drawing.Point(367, 37);
            this.button_gestion_des_commerciaux.Name = "button_gestion_des_commerciaux";
            this.button_gestion_des_commerciaux.Size = new System.Drawing.Size(80, 81);
            this.button_gestion_des_commerciaux.TabIndex = 4;
            this.button_gestion_des_commerciaux.Text = "Gestion des commerciaux";
            this.button_gestion_des_commerciaux.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_gestion_des_commerciaux.UseVisualStyleBackColor = true;
            this.button_gestion_des_commerciaux.Click += new System.EventHandler(this.button_gestion_des_commerciaux_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 122);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_gestion_des_commerciaux);
            this.Controls.Add(this.button_gestion_des_clients);
            this.Controls.Add(this.button_ajouter_bien_catalogue);
            this.Controls.Add(this.button_catalogue);
            this.Name = "Accueil";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_catalogue;
        private System.Windows.Forms.Button button_ajouter_bien_catalogue;
        private System.Windows.Forms.Button button_gestion_des_clients;
        private System.Windows.Forms.Button button_gestion_des_commerciaux;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

