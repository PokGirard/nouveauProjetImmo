namespace EcranAccueil
{
    partial class Visites_bien
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.nom_client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom_client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_visite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nom_client,
            this.prenom_client,
            this.date_visite});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 408);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nom_client
            // 
            this.nom_client.Text = "Nom client";
            this.nom_client.Width = 107;
            // 
            // prenom_client
            // 
            this.prenom_client.Text = "Prénom client";
            this.prenom_client.Width = 105;
            // 
            // date_visite
            // 
            this.date_visite.Text = "Date de visite";
            this.date_visite.Width = 94;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(247, 426);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 23);
            this.retour.TabIndex = 1;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // Visites_bien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.listView1);
            this.Name = "Visites_bien";
            this.Text = "Visites du bien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nom_client;
        private System.Windows.Forms.ColumnHeader prenom_client;
        private System.Windows.Forms.ColumnHeader date_visite;
        private System.Windows.Forms.Button retour;
    }
}