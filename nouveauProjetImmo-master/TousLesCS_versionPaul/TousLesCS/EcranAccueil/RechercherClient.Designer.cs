namespace EcranAccueil
{
    partial class RechercherClient
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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxFixe = new System.Windows.Forms.TextBox();
            this.textBoxCommercial = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.CritèreRecherche = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.CodePostal = new System.Windows.Forms.Label();
            this.TelephoneFixe = new System.Windows.Forms.Label();
            this.TelephoneMobile = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.DateAjout = new System.Windows.Forms.Label();
            this.Commercial = new System.Windows.Forms.Label();
            this.dateTimeAjout = new System.Windows.Forms.DateTimePicker();
            this.buttonVendeur = new System.Windows.Forms.Button();
            this.buttonAcheteur = new System.Windows.Forms.Button();
            this.listView_resultat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(19, 48);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(76, 20);
            this.textBoxNom.TabIndex = 0;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(19, 96);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrenom.TabIndex = 1;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged);
            // 
            // textBoxFixe
            // 
            this.textBoxFixe.Location = new System.Drawing.Point(19, 177);
            this.textBoxFixe.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFixe.Name = "textBoxFixe";
            this.textBoxFixe.Size = new System.Drawing.Size(76, 20);
            this.textBoxFixe.TabIndex = 2;
            this.textBoxFixe.TextChanged += new System.EventHandler(this.textBoxFixe_TextChanged);
            // 
            // textBoxCommercial
            // 
            this.textBoxCommercial.Location = new System.Drawing.Point(19, 331);
            this.textBoxCommercial.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCommercial.Name = "textBoxCommercial";
            this.textBoxCommercial.Size = new System.Drawing.Size(76, 20);
            this.textBoxCommercial.TabIndex = 3;
            this.textBoxCommercial.TextChanged += new System.EventHandler(this.textBoxCommercial_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(19, 250);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(76, 20);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(19, 214);
            this.textBoxMobile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(76, 20);
            this.textBoxMobile.TabIndex = 6;
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(19, 141);
            this.textBoxCodePostal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(76, 20);
            this.textBoxCodePostal.TabIndex = 7;
            // 
            // CritèreRecherche
            // 
            this.CritèreRecherche.AutoSize = true;
            this.CritèreRecherche.Location = new System.Drawing.Point(16, 7);
            this.CritèreRecherche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CritèreRecherche.Name = "CritèreRecherche";
            this.CritèreRecherche.Size = new System.Drawing.Size(103, 13);
            this.CritèreRecherche.TabIndex = 8;
            this.CritèreRecherche.Text = "Critère de recherche";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(36, 32);
            this.Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(32, 13);
            this.Nom.TabIndex = 9;
            this.Nom.Text = "Nom:";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(36, 80);
            this.Prenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(49, 13);
            this.Prenom.TabIndex = 10;
            this.Prenom.Text = "Prenom :";
            // 
            // CodePostal
            // 
            this.CodePostal.AutoSize = true;
            this.CodePostal.Location = new System.Drawing.Point(24, 124);
            this.CodePostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(67, 13);
            this.CodePostal.TabIndex = 11;
            this.CodePostal.Text = "Code Postal:";
            // 
            // TelephoneFixe
            // 
            this.TelephoneFixe.AutoSize = true;
            this.TelephoneFixe.Location = new System.Drawing.Point(16, 161);
            this.TelephoneFixe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TelephoneFixe.Name = "TelephoneFixe";
            this.TelephoneFixe.Size = new System.Drawing.Size(83, 13);
            this.TelephoneFixe.TabIndex = 12;
            this.TelephoneFixe.Text = "Telephone Fixe:";
            // 
            // TelephoneMobile
            // 
            this.TelephoneMobile.AutoSize = true;
            this.TelephoneMobile.Location = new System.Drawing.Point(9, 197);
            this.TelephoneMobile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TelephoneMobile.Name = "TelephoneMobile";
            this.TelephoneMobile.Size = new System.Drawing.Size(95, 13);
            this.TelephoneMobile.TabIndex = 13;
            this.TelephoneMobile.Text = "Telephone Mobile:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(36, 234);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email";
            // 
            // DateAjout
            // 
            this.DateAjout.AutoSize = true;
            this.DateAjout.Location = new System.Drawing.Point(22, 278);
            this.DateAjout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateAjout.Name = "DateAjout";
            this.DateAjout.Size = new System.Drawing.Size(67, 13);
            this.DateAjout.TabIndex = 15;
            this.DateAjout.Text = "Date d\'ajout:";
            // 
            // Commercial
            // 
            this.Commercial.AutoSize = true;
            this.Commercial.Location = new System.Drawing.Point(16, 314);
            this.Commercial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Commercial.Name = "Commercial";
            this.Commercial.Size = new System.Drawing.Size(88, 13);
            this.Commercial.TabIndex = 16;
            this.Commercial.Text = "Commercial affilié";
            // 
            // dateTimeAjout
            // 
            this.dateTimeAjout.Location = new System.Drawing.Point(19, 294);
            this.dateTimeAjout.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeAjout.Name = "dateTimeAjout";
            this.dateTimeAjout.Size = new System.Drawing.Size(151, 20);
            this.dateTimeAjout.TabIndex = 17;
            // 
            // buttonVendeur
            // 
            this.buttonVendeur.Location = new System.Drawing.Point(249, 32);
            this.buttonVendeur.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVendeur.Name = "buttonVendeur";
            this.buttonVendeur.Size = new System.Drawing.Size(205, 21);
            this.buttonVendeur.TabIndex = 18;
            this.buttonVendeur.Text = "Vendeur";
            this.buttonVendeur.UseVisualStyleBackColor = true;
            this.buttonVendeur.Click += new System.EventHandler(this.button_vendeur_Click);
            // 
            // buttonAcheteur
            // 
            this.buttonAcheteur.Location = new System.Drawing.Point(452, 32);
            this.buttonAcheteur.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAcheteur.Name = "buttonAcheteur";
            this.buttonAcheteur.Size = new System.Drawing.Size(237, 21);
            this.buttonAcheteur.TabIndex = 19;
            this.buttonAcheteur.Text = "Acheteur";
            this.buttonAcheteur.UseVisualStyleBackColor = true;
            this.buttonAcheteur.Click += new System.EventHandler(this.buttonAcheteur_Click);
            // 
            // listView_resultat
            // 
            this.listView_resultat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_resultat.Location = new System.Drawing.Point(249, 83);
            this.listView_resultat.Name = "listView_resultat";
            this.listView_resultat.Size = new System.Drawing.Size(440, 231);
            this.listView_resultat.TabIndex = 20;
            this.listView_resultat.UseCompatibleStateImageBehavior = false;
            this.listView_resultat.View = System.Windows.Forms.View.Details;
            this.listView_resultat.SelectedIndexChanged += new System.EventHandler(this.listView_resultat_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prénom";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 186;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID Client";
            // 
            // RechercherClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 452);
            this.Controls.Add(this.listView_resultat);
            this.Controls.Add(this.buttonAcheteur);
            this.Controls.Add(this.buttonVendeur);
            this.Controls.Add(this.dateTimeAjout);
            this.Controls.Add(this.Commercial);
            this.Controls.Add(this.DateAjout);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.TelephoneMobile);
            this.Controls.Add(this.TelephoneFixe);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.CritèreRecherche);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxCommercial);
            this.Controls.Add(this.textBoxFixe);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RechercherClient";
            this.Text = "RechercherClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxFixe;
        private System.Windows.Forms.TextBox textBoxCommercial;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.Label CritèreRecherche;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label CodePostal;
        private System.Windows.Forms.Label TelephoneFixe;
        private System.Windows.Forms.Label TelephoneMobile;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label DateAjout;
        private System.Windows.Forms.Label Commercial;
        private System.Windows.Forms.DateTimePicker dateTimeAjout;
        private System.Windows.Forms.Button buttonVendeur;
        private System.Windows.Forms.Button buttonAcheteur;
        private System.Windows.Forms.ListView listView_resultat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}