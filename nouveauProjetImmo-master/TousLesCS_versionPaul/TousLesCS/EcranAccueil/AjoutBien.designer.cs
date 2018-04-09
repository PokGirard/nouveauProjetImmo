namespace EcranAccueil
{
    partial class AjoutBien
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prénomVendeur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adresseVendeur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codePostalVendeur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fixeVendeur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mobileVendeur = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.emailVendeur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1_surfHab = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown2_surfParc = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown3_nbPieces = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown4_nbChambres = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown5_nbSdb = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown6_prix = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox9_adresse = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox10_codePostal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimePicker1_miseEnVente = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox12_commentaires = new System.Windows.Forms.TextBox();
            this.button1_ajouterBien = new System.Windows.Forms.Button();
            this.button3_supprimer = new System.Windows.Forms.Button();
            this.button5_annuler = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.checkBox1_garage = new System.Windows.Forms.CheckBox();
            this.checkBox2_cave = new System.Windows.Forms.CheckBox();
            this.titreFenetreAjoutBien = new System.Windows.Forms.Label();
            this.dateTimePicker1_créationClient = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox1_villesClient = new System.Windows.Forms.ComboBox();
            this.comboBox2_villesBien = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button_voir_visites = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_surfHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_surfParc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3_nbPieces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4_nbChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5_nbSdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6_prix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "STATUT";
            // 
            // comboBox1_status
            // 
            this.comboBox1_status.FormattingEnabled = true;
            this.comboBox1_status.Items.AddRange(new object[] {
            "DISPONIBLE",
            "RETIRE",
            "VENDU",
            "SOUS-SEING"});
            this.comboBox1_status.Location = new System.Drawing.Point(604, 351);
            this.comboBox1_status.Name = "comboBox1_status";
            this.comboBox1_status.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_status.TabIndex = 1;
            this.comboBox1_status.Text = "DISPONIBLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLIENT";
            // 
            // nomClient
            // 
            this.nomClient.Location = new System.Drawing.Point(101, 122);
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(137, 20);
            this.nomClient.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prénom";
            // 
            // prénomVendeur
            // 
            this.prénomVendeur.Location = new System.Drawing.Point(293, 122);
            this.prénomVendeur.Name = "prénomVendeur";
            this.prénomVendeur.Size = new System.Drawing.Size(162, 20);
            this.prénomVendeur.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adresse";
            // 
            // adresseVendeur
            // 
            this.adresseVendeur.Location = new System.Drawing.Point(101, 156);
            this.adresseVendeur.Name = "adresseVendeur";
            this.adresseVendeur.Size = new System.Drawing.Size(354, 20);
            this.adresseVendeur.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Code Postal";
            // 
            // codePostalVendeur
            // 
            this.codePostalVendeur.Location = new System.Drawing.Point(101, 193);
            this.codePostalVendeur.Name = "codePostalVendeur";
            this.codePostalVendeur.Size = new System.Drawing.Size(118, 20);
            this.codePostalVendeur.TabIndex = 10;
            this.codePostalVendeur.TextChanged += new System.EventHandler(this.codePostalVendeur_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(508, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Téléphone fixe";
            // 
            // fixeVendeur
            // 
            this.fixeVendeur.Location = new System.Drawing.Point(603, 156);
            this.fixeVendeur.Name = "fixeVendeur";
            this.fixeVendeur.Size = new System.Drawing.Size(100, 20);
            this.fixeVendeur.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Téléphone mobile";
            // 
            // mobileVendeur
            // 
            this.mobileVendeur.Location = new System.Drawing.Point(603, 193);
            this.mobileVendeur.Name = "mobileVendeur";
            this.mobileVendeur.Size = new System.Drawing.Size(100, 20);
            this.mobileVendeur.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Email";
            // 
            // emailVendeur
            // 
            this.emailVendeur.Location = new System.Drawing.Point(101, 233);
            this.emailVendeur.Name = "emailVendeur";
            this.emailVendeur.Size = new System.Drawing.Size(354, 20);
            this.emailVendeur.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "BIEN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Surface habitable";
            // 
            // numericUpDown1_surfHab
            // 
            this.numericUpDown1_surfHab.Location = new System.Drawing.Point(138, 336);
            this.numericUpDown1_surfHab.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1_surfHab.Name = "numericUpDown1_surfHab";
            this.numericUpDown1_surfHab.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1_surfHab.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Surface parcelle";
            // 
            // numericUpDown2_surfParc
            // 
            this.numericUpDown2_surfParc.Location = new System.Drawing.Point(138, 372);
            this.numericUpDown2_surfParc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2_surfParc.Name = "numericUpDown2_surfParc";
            this.numericUpDown2_surfParc.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown2_surfParc.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 417);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Pièces";
            // 
            // numericUpDown3_nbPieces
            // 
            this.numericUpDown3_nbPieces.Location = new System.Drawing.Point(138, 410);
            this.numericUpDown3_nbPieces.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown3_nbPieces.Name = "numericUpDown3_nbPieces";
            this.numericUpDown3_nbPieces.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown3_nbPieces.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 458);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Chambres";
            // 
            // numericUpDown4_nbChambres
            // 
            this.numericUpDown4_nbChambres.Location = new System.Drawing.Point(138, 451);
            this.numericUpDown4_nbChambres.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown4_nbChambres.Name = "numericUpDown4_nbChambres";
            this.numericUpDown4_nbChambres.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown4_nbChambres.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(30, 495);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Salles de bain";
            // 
            // numericUpDown5_nbSdb
            // 
            this.numericUpDown5_nbSdb.Location = new System.Drawing.Point(138, 488);
            this.numericUpDown5_nbSdb.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown5_nbSdb.Name = "numericUpDown5_nbSdb";
            this.numericUpDown5_nbSdb.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown5_nbSdb.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(290, 374);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Prix de vente";
            // 
            // numericUpDown6_prix
            // 
            this.numericUpDown6_prix.Location = new System.Drawing.Point(383, 367);
            this.numericUpDown6_prix.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown6_prix.Name = "numericUpDown6_prix";
            this.numericUpDown6_prix.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown6_prix.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(290, 410);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Adresse";
            // 
            // textBox9_adresse
            // 
            this.textBox9_adresse.Location = new System.Drawing.Point(383, 403);
            this.textBox9_adresse.Name = "textBox9_adresse";
            this.textBox9_adresse.Size = new System.Drawing.Size(372, 20);
            this.textBox9_adresse.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(290, 448);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Code Postal";
            // 
            // textBox10_codePostal
            // 
            this.textBox10_codePostal.Location = new System.Drawing.Point(383, 446);
            this.textBox10_codePostal.Name = "textBox10_codePostal";
            this.textBox10_codePostal.Size = new System.Drawing.Size(100, 20);
            this.textBox10_codePostal.TabIndex = 35;
            this.textBox10_codePostal.TextChanged += new System.EventHandler(this.textBox10_codePostal_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(537, 449);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "Ville";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(290, 489);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "Date de mise en vente";
            // 
            // dateTimePicker1_miseEnVente
            // 
            this.dateTimePicker1_miseEnVente.Enabled = false;
            this.dateTimePicker1_miseEnVente.Location = new System.Drawing.Point(421, 483);
            this.dateTimePicker1_miseEnVente.Name = "dateTimePicker1_miseEnVente";
            this.dateTimePicker1_miseEnVente.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1_miseEnVente.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 539);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(106, 13);
            this.label22.TabIndex = 40;
            this.label22.Text = "COMMENTAIRES";
            // 
            // textBox12_commentaires
            // 
            this.textBox12_commentaires.Location = new System.Drawing.Point(16, 555);
            this.textBox12_commentaires.Multiline = true;
            this.textBox12_commentaires.Name = "textBox12_commentaires";
            this.textBox12_commentaires.Size = new System.Drawing.Size(734, 107);
            this.textBox12_commentaires.TabIndex = 41;
            this.textBox12_commentaires.TextChanged += new System.EventHandler(this.textBox12_commentaires_TextChanged);
            // 
            // button1_ajouterBien
            // 
            this.button1_ajouterBien.Location = new System.Drawing.Point(212, 706);
            this.button1_ajouterBien.Name = "button1_ajouterBien";
            this.button1_ajouterBien.Size = new System.Drawing.Size(156, 47);
            this.button1_ajouterBien.TabIndex = 42;
            this.button1_ajouterBien.Text = "AJOUTER LE BIEN";
            this.button1_ajouterBien.UseVisualStyleBackColor = true;
            this.button1_ajouterBien.Click += new System.EventHandler(this.button1_ajouterBien_Click);
            // 
            // button3_supprimer
            // 
            this.button3_supprimer.Enabled = false;
            this.button3_supprimer.Location = new System.Drawing.Point(594, 706);
            this.button3_supprimer.Name = "button3_supprimer";
            this.button3_supprimer.Size = new System.Drawing.Size(156, 47);
            this.button3_supprimer.TabIndex = 44;
            this.button3_supprimer.Text = "SUPPRIMER LE BIEN";
            this.button3_supprimer.UseVisualStyleBackColor = true;
            this.button3_supprimer.Click += new System.EventHandler(this.button3_supprimer_Click);
            // 
            // button5_annuler
            // 
            this.button5_annuler.Location = new System.Drawing.Point(16, 706);
            this.button5_annuler.Name = "button5_annuler";
            this.button5_annuler.Size = new System.Drawing.Size(156, 47);
            this.button5_annuler.TabIndex = 48;
            this.button5_annuler.Text = "RETOUR MENU";
            this.button5_annuler.UseVisualStyleBackColor = true;
            this.button5_annuler.Click += new System.EventHandler(this.button5_annuler_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(290, 335);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 49;
            this.label24.Text = "Garage";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(415, 336);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "Cave";
            // 
            // checkBox1_garage
            // 
            this.checkBox1_garage.AutoSize = true;
            this.checkBox1_garage.Location = new System.Drawing.Point(344, 335);
            this.checkBox1_garage.Name = "checkBox1_garage";
            this.checkBox1_garage.Size = new System.Drawing.Size(15, 14);
            this.checkBox1_garage.TabIndex = 51;
            this.checkBox1_garage.UseVisualStyleBackColor = true;
            // 
            // checkBox2_cave
            // 
            this.checkBox2_cave.AutoSize = true;
            this.checkBox2_cave.Location = new System.Drawing.Point(453, 335);
            this.checkBox2_cave.Name = "checkBox2_cave";
            this.checkBox2_cave.Size = new System.Drawing.Size(15, 14);
            this.checkBox2_cave.TabIndex = 52;
            this.checkBox2_cave.UseVisualStyleBackColor = true;
            // 
            // titreFenetreAjoutBien
            // 
            this.titreFenetreAjoutBien.AutoSize = true;
            this.titreFenetreAjoutBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreFenetreAjoutBien.Location = new System.Drawing.Point(299, 21);
            this.titreFenetreAjoutBien.Name = "titreFenetreAjoutBien";
            this.titreFenetreAjoutBien.Size = new System.Drawing.Size(196, 25);
            this.titreFenetreAjoutBien.TabIndex = 54;
            this.titreFenetreAjoutBien.Text = "AJOUT D\'UN BIEN";
            // 
            // dateTimePicker1_créationClient
            // 
            this.dateTimePicker1_créationClient.Enabled = false;
            this.dateTimePicker1_créationClient.Location = new System.Drawing.Point(101, 265);
            this.dateTimePicker1_créationClient.Name = "dateTimePicker1_créationClient";
            this.dateTimePicker1_créationClient.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1_créationClient.TabIndex = 57;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(24, 272);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "Date création";
            // 
            // comboBox1_villesClient
            // 
            this.comboBox1_villesClient.FormattingEnabled = true;
            this.comboBox1_villesClient.Location = new System.Drawing.Point(293, 192);
            this.comboBox1_villesClient.Name = "comboBox1_villesClient";
            this.comboBox1_villesClient.Size = new System.Drawing.Size(162, 21);
            this.comboBox1_villesClient.TabIndex = 58;
            // 
            // comboBox2_villesBien
            // 
            this.comboBox2_villesBien.FormattingEnabled = true;
            this.comboBox2_villesBien.Location = new System.Drawing.Point(593, 440);
            this.comboBox2_villesBien.Name = "comboBox2_villesBien";
            this.comboBox2_villesBien.Size = new System.Drawing.Size(162, 21);
            this.comboBox2_villesBien.TabIndex = 59;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(15, 665);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(141, 13);
            this.label26.TabIndex = 60;
            this.label26.Text = "150 caractères restants";
            // 
            // button_voir_visites
            // 
            this.button_voir_visites.Location = new System.Drawing.Point(407, 706);
            this.button_voir_visites.Name = "button_voir_visites";
            this.button_voir_visites.Size = new System.Drawing.Size(156, 47);
            this.button_voir_visites.TabIndex = 61;
            this.button_voir_visites.Text = "VISITES DU BIEN";
            this.button_voir_visites.UseVisualStyleBackColor = true;
            this.button_voir_visites.Click += new System.EventHandler(this.button_voir_visites_Click);
            // 
            // AjoutBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 758);
            this.Controls.Add(this.button_voir_visites);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.comboBox2_villesBien);
            this.Controls.Add(this.comboBox1_villesClient);
            this.Controls.Add(this.dateTimePicker1_créationClient);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.titreFenetreAjoutBien);
            this.Controls.Add(this.checkBox2_cave);
            this.Controls.Add(this.checkBox1_garage);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.button5_annuler);
            this.Controls.Add(this.button3_supprimer);
            this.Controls.Add(this.button1_ajouterBien);
            this.Controls.Add(this.textBox12_commentaires);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dateTimePicker1_miseEnVente);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox10_codePostal);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox9_adresse);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numericUpDown6_prix);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numericUpDown5_nbSdb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numericUpDown4_nbChambres);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numericUpDown3_nbPieces);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDown2_surfParc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericUpDown1_surfHab);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.emailVendeur);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mobileVendeur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fixeVendeur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.codePostalVendeur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adresseVendeur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prénomVendeur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1_status);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "AjoutBien";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_surfHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_surfParc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3_nbPieces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4_nbChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5_nbSdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6_prix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1_surfHab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown2_surfParc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown3_nbPieces;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown4_nbChambres;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown5_nbSdb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown6_prix;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox9_adresse;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox10_codePostal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_miseEnVente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox12_commentaires;
        private System.Windows.Forms.Button button1_ajouterBien;
        private System.Windows.Forms.Button button3_supprimer;
        private System.Windows.Forms.Button button5_annuler;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox checkBox1_garage;
        private System.Windows.Forms.CheckBox checkBox2_cave;
        internal System.Windows.Forms.TextBox prénomVendeur;
        internal System.Windows.Forms.TextBox adresseVendeur;
        internal System.Windows.Forms.TextBox codePostalVendeur;
        internal System.Windows.Forms.TextBox fixeVendeur;
        internal System.Windows.Forms.TextBox mobileVendeur;
        internal System.Windows.Forms.TextBox emailVendeur;
        public System.Windows.Forms.TextBox nomClient;
        private System.Windows.Forms.Label titreFenetreAjoutBien;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_créationClient;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox1_villesClient;
        private System.Windows.Forms.ComboBox comboBox2_villesBien;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button_voir_visites;
    }
}

