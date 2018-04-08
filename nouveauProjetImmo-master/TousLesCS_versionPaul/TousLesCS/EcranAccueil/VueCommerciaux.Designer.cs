using System;

namespace EcranAccueil
{
    partial class VueCommerciaux
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
            System.Windows.Forms.ColumnHeader portablesPro;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.portablePro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.supprimerCommercial = new System.Windows.Forms.Button();
            this.ajoutCommercial = new System.Windows.Forms.Button();
            this.editerCommercial = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.fixePro = new System.Windows.Forms.TextBox();
            this.telPerso = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.actif = new System.Windows.Forms.CheckBox();
            this.inactif = new System.Windows.Forms.CheckBox();
            this.actifView = new System.Windows.Forms.Button();
            this.inactifView = new System.Windows.Forms.Button();
            this.tousView = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fixesPro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telephonesPerso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.nomacheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenomacheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailacheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telephoneClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresseacheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.villeacheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1_voirFicheClient = new System.Windows.Forms.Button();
            portablesPro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // portablesPro
            // 
            portablesPro.Text = "Portable pro";
            portablesPro.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des commerciaux";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portefeuille client du commercial sélectionné";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "COMMERCIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nom";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(85, 511);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(145, 20);
            this.nom.TabIndex = 6;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(300, 511);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(159, 20);
            this.prenom.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prénom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(85, 537);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(374, 20);
            this.email.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Téléphone professionnel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 580);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Portable";
            // 
            // portablePro
            // 
            this.portablePro.Location = new System.Drawing.Point(85, 576);
            this.portablePro.Name = "portablePro";
            this.portablePro.Size = new System.Drawing.Size(145, 20);
            this.portablePro.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(248, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Fixe";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 604);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Téléphone personnel";
            // 
            // supprimerCommercial
            // 
            this.supprimerCommercial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.supprimerCommercial.Location = new System.Drawing.Point(624, 387);
            this.supprimerCommercial.Name = "supprimerCommercial";
            this.supprimerCommercial.Size = new System.Drawing.Size(166, 29);
            this.supprimerCommercial.TabIndex = 45;
            this.supprimerCommercial.Text = "Supprimer le commercial";
            this.supprimerCommercial.UseVisualStyleBackColor = true;
            this.supprimerCommercial.Click += new System.EventHandler(this.supprimerCommercial_Click);
            // 
            // ajoutCommercial
            // 
            this.ajoutCommercial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ajoutCommercial.Location = new System.Drawing.Point(624, 317);
            this.ajoutCommercial.Name = "ajoutCommercial";
            this.ajoutCommercial.Size = new System.Drawing.Size(166, 29);
            this.ajoutCommercial.TabIndex = 46;
            this.ajoutCommercial.Text = "Ajouter/Modifier un commercial";
            this.ajoutCommercial.UseVisualStyleBackColor = true;
            this.ajoutCommercial.Click += new System.EventHandler(this.ajoutCommercial_Click);
            // 
            // editerCommercial
            // 
            this.editerCommercial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editerCommercial.Location = new System.Drawing.Point(624, 352);
            this.editerCommercial.Name = "editerCommercial";
            this.editerCommercial.Size = new System.Drawing.Size(166, 29);
            this.editerCommercial.TabIndex = 47;
            this.editerCommercial.Text = "Rechercher le commercial";
            this.editerCommercial.UseVisualStyleBackColor = true;
            this.editerCommercial.Click += new System.EventHandler(this.rechercherCommercial_Click_1);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(624, 585);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 55);
            this.button4.TabIndex = 51;
            this.button4.Text = "RETOUR MENU";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(295, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 25);
            this.label15.TabIndex = 52;
            this.label15.Text = "COMMERCIAUX";
            // 
            // fixePro
            // 
            this.fixePro.Location = new System.Drawing.Point(300, 576);
            this.fixePro.Name = "fixePro";
            this.fixePro.Size = new System.Drawing.Size(159, 20);
            this.fixePro.TabIndex = 55;
            // 
            // telPerso
            // 
            this.telPerso.Location = new System.Drawing.Point(85, 620);
            this.telPerso.Name = "telPerso";
            this.telPerso.Size = new System.Drawing.Size(145, 20);
            this.telPerso.TabIndex = 57;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(624, 421);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(166, 29);
            this.clear.TabIndex = 58;
            this.clear.Text = "Effacer";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // actif
            // 
            this.actif.AutoSize = true;
            this.actif.Location = new System.Drawing.Point(327, 623);
            this.actif.Margin = new System.Windows.Forms.Padding(2);
            this.actif.Name = "actif";
            this.actif.Size = new System.Drawing.Size(46, 17);
            this.actif.TabIndex = 59;
            this.actif.Text = "actif";
            this.actif.UseVisualStyleBackColor = true;
            this.actif.CheckedChanged += new System.EventHandler(this.actif_CheckedChanged);
            // 
            // inactif
            // 
            this.inactif.AutoSize = true;
            this.inactif.Location = new System.Drawing.Point(405, 623);
            this.inactif.Margin = new System.Windows.Forms.Padding(2);
            this.inactif.Name = "inactif";
            this.inactif.Size = new System.Drawing.Size(54, 17);
            this.inactif.TabIndex = 60;
            this.inactif.Text = "inactif";
            this.inactif.UseVisualStyleBackColor = true;
            this.inactif.CheckedChanged += new System.EventHandler(this.inactif_CheckedChanged);
            // 
            // actifView
            // 
            this.actifView.Location = new System.Drawing.Point(660, 169);
            this.actifView.Margin = new System.Windows.Forms.Padding(2);
            this.actifView.Name = "actifView";
            this.actifView.Size = new System.Drawing.Size(106, 39);
            this.actifView.TabIndex = 61;
            this.actifView.Text = "Actif";
            this.actifView.UseVisualStyleBackColor = true;
            this.actifView.Click += new System.EventHandler(this.actifView_Click);
            // 
            // inactifView
            // 
            this.inactifView.Location = new System.Drawing.Point(660, 231);
            this.inactifView.Margin = new System.Windows.Forms.Padding(2);
            this.inactifView.Name = "inactifView";
            this.inactifView.Size = new System.Drawing.Size(106, 39);
            this.inactifView.TabIndex = 62;
            this.inactifView.Text = "Ancien Employé";
            this.inactifView.UseVisualStyleBackColor = true;
            this.inactifView.Click += new System.EventHandler(this.inactifView_Click);
            // 
            // tousView
            // 
            this.tousView.Location = new System.Drawing.Point(660, 106);
            this.tousView.Margin = new System.Windows.Forms.Padding(2);
            this.tousView.Name = "tousView";
            this.tousView.Size = new System.Drawing.Size(106, 39);
            this.tousView.TabIndex = 63;
            this.tousView.Text = "Tous";
            this.tousView.UseVisualStyleBackColor = true;
            this.tousView.Click += new System.EventHandler(this.tousView_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnNom,
            this.columnPrenom,
            this.Emails,
            portablesPro,
            this.fixesPro,
            this.telephonesPerso,
            this.columnStatut,
            this.columnID});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 106);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(592, 164);
            this.listView1.TabIndex = 64;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ColumnNom
            // 
            this.ColumnNom.Text = "Nom";
            // 
            // columnPrenom
            // 
            this.columnPrenom.Text = "Prénom";
            this.columnPrenom.Width = 78;
            // 
            // Emails
            // 
            this.Emails.Text = "Email";
            this.Emails.Width = 67;
            // 
            // fixesPro
            // 
            this.fixesPro.Text = "Fixe pro";
            this.fixesPro.Width = 81;
            // 
            // telephonesPerso
            // 
            this.telephonesPerso.Text = "Tel. perso";
            // 
            // columnStatut
            // 
            this.columnStatut.Text = "Statut";
            this.columnStatut.Width = 85;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 67;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomacheteur,
            this.prenomacheteur,
            this.emailacheteur,
            this.telephoneClient,
            this.adresseacheteur,
            this.villeacheteur,
            this.ID});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(27, 317);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(592, 158);
            this.listView2.TabIndex = 65;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_Click);
            // 
            // nomacheteur
            // 
            this.nomacheteur.Text = "nom";
            // 
            // prenomacheteur
            // 
            this.prenomacheteur.Text = "prenom";
            this.prenomacheteur.Width = 70;
            // 
            // emailacheteur
            // 
            this.emailacheteur.Text = "email";
            this.emailacheteur.Width = 118;
            // 
            // telephoneClient
            // 
            this.telephoneClient.Text = "telephone";
            this.telephoneClient.Width = 81;
            // 
            // adresseacheteur
            // 
            this.adresseacheteur.Text = "adresse";
            this.adresseacheteur.Width = 99;
            // 
            // villeacheteur
            // 
            this.villeacheteur.Text = "ville";
            this.villeacheteur.Width = 90;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // button1_voirFicheClient
            // 
            this.button1_voirFicheClient.Enabled = false;
            this.button1_voirFicheClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1_voirFicheClient.Location = new System.Drawing.Point(624, 511);
            this.button1_voirFicheClient.Name = "button1_voirFicheClient";
            this.button1_voirFicheClient.Size = new System.Drawing.Size(166, 55);
            this.button1_voirFicheClient.TabIndex = 66;
            this.button1_voirFicheClient.Text = "Voir la fiche Client";
            this.button1_voirFicheClient.UseVisualStyleBackColor = true;
            this.button1_voirFicheClient.Click += new System.EventHandler(this.button1_voirFicheClient_Click);
            // 
            // VueCommerciaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 738);
            this.Controls.Add(this.button1_voirFicheClient);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tousView);
            this.Controls.Add(this.inactifView);
            this.Controls.Add(this.actifView);
            this.Controls.Add(this.inactif);
            this.Controls.Add(this.actif);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.telPerso);
            this.Controls.Add(this.fixePro);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.editerCommercial);
            this.Controls.Add(this.ajoutCommercial);
            this.Controls.Add(this.supprimerCommercial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.portablePro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VueCommerciaux";
            this.Text = "VueCommerciaux";
            this.Load += new System.EventHandler(this.VueCommerciaux_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void inactif_CheckedChanged(object sender, EventArgs e)
        {
            actif.Checked = !inactif.Checked;
        }

        private void actif_CheckedChanged(object sender, EventArgs e)
        {
            inactif.Checked = !actif.Checked;
            


        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox portablePro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button supprimerCommercial;
        private System.Windows.Forms.Button ajoutCommercial;
        private System.Windows.Forms.Button editerCommercial;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox fixePro;
        private System.Windows.Forms.TextBox telPerso;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.CheckBox actif;
        private System.Windows.Forms.CheckBox inactif;
        private System.Windows.Forms.Button actifView;
        private System.Windows.Forms.Button inactifView;
        private System.Windows.Forms.Button tousView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnNom;
        private System.Windows.Forms.ColumnHeader columnPrenom;
        private System.Windows.Forms.ColumnHeader Emails;
        private System.Windows.Forms.ColumnHeader fixesPro;
        private System.Windows.Forms.ColumnHeader telephonesPerso;
        private System.Windows.Forms.ColumnHeader columnStatut;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader nomacheteur;
        private System.Windows.Forms.ColumnHeader prenomacheteur;
        private System.Windows.Forms.ColumnHeader emailacheteur;
        private System.Windows.Forms.ColumnHeader adresseacheteur;
        private System.Windows.Forms.ColumnHeader villeacheteur;
        private System.Windows.Forms.ColumnHeader telephoneClient;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button button1_voirFicheClient;
    }
}