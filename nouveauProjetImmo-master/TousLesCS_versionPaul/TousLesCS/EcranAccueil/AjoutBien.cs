﻿using EcranAccueil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcranAccueil
{
    public partial class AjoutBien : Form
    {

        public BIEN bien_en_cours { get; set; }
        #region propriétés

        public VENDEUR monVendeur { get; set; }
        public ACHETEUR monAcheteur { get; set; }
        #endregion

        public AjoutBien()
        {
            InitializeComponent();
                
        }

        public AjoutBien(VENDEUR monVendeur, bool nouveauClient)
        {
            if (!nouveauClient)
            {/*BUGGGGGGG*/
              //  titreFenetreAjoutBien.ResetText();
                titreFenetreAjoutBien.Text = "VOIR LE BIEN";

                blocageBox(nouveauClient);
            }
            this.monVendeur = monVendeur;
            InitializeComponent();
            this.comboBox1_status.Text = "DISPONIBLE";
            this.nomClient.Text = monVendeur.NOM_VENDEUR;
            this.prénomVendeur.Text = monVendeur.PRÉNOM_VENDEUR;
            this.adresseVendeur.Text = monVendeur.ADRESSE_VENDEUR;

            var maVille = (from v in Accueil.modeleBase.VILLE
                            where v.IDVILLE == monVendeur.IDVILLE
                            select v.NOM_VILLE).First();

            this.villeVendeur.Text = maVille;
            this.codePostalVendeur.Text = monVendeur.CODE_POSTAL.ToString();
            this.fixeVendeur.Text = monVendeur.TÉLÉPHONE_FIXE.ToString();
            this.mobileVendeur.Text = monVendeur.TÉLÉPHONE_MOBILE.ToString();
            this.emailVendeur.Text = monVendeur.EMAIL;
        }

        public AjoutBien(BIEN bien_en_cours, bool nouveauClient)
        {
            if (!nouveauClient)
            {
                // titreFenetreAjoutBien.ResetText();    
               titreFenetreAjoutBien.Text = "VOIR LE BIEN";
               blocageBox(nouveauClient);
            }

            this.bien_en_cours = bien_en_cours;
            InitializeComponent();
            this.comboBox1_status.Text = bien_en_cours.STATUT;
            this.nomClient.Text = bien_en_cours.VENDEUR.NOM_VENDEUR;
            this.prénomVendeur.Text = bien_en_cours.VENDEUR.PRÉNOM_VENDEUR;
            this.adresseVendeur.Text = bien_en_cours.VENDEUR.ADRESSE_VENDEUR;
            this.villeVendeur.Text = bien_en_cours.VENDEUR.VILLE.NOM_VILLE;
            this.codePostalVendeur.Text = bien_en_cours.VENDEUR.VILLE.CODE_POSTAL.ToString();
            this.fixeVendeur.Text = bien_en_cours.VENDEUR.TÉLÉPHONE_FIXE.ToString();
            this.mobileVendeur.Text = bien_en_cours.VENDEUR.TÉLÉPHONE_MOBILE.ToString();
            this.emailVendeur.Text = bien_en_cours.VENDEUR.EMAIL;


            this.numericUpDown1_surfHab.Value = bien_en_cours.SURFACE_HABITABLE;
            this.numericUpDown2_surfParc.Value = bien_en_cours.SURFACE_PARCELLE;
            this.numericUpDown3_nbPieces.Value = bien_en_cours.NB_PIÈCES;
            this.numericUpDown4_nbChambres.Value = bien_en_cours.NB_CHAMBRES;
            this.numericUpDown5_nbSdb.Value = bien_en_cours.NB_SALLEDEBAIN;

            if (bien_en_cours.GARAGE)
                this.checkBox1_garage.Checked = true;
            if (bien_en_cours.CAVE)
                this.checkBox2_cave.Checked = true;
            this.numericUpDown6_prix.Value = bien_en_cours.PRIX_SOUHAITÉ;
            this.textBox9_adresse.Text = bien_en_cours.ADRESSE_BIEN;
            this.textBox10_codePostal.Text = bien_en_cours.CODE_POSTAL.ToString();
            var ville = (from v in Accueil.modeleBase.VILLE
                         where v.IDVILLE == bien_en_cours.IDVILLE
                         select v.NOM_VILLE).FirstOrDefault();
            this.textBox11_ville.Text = ville;
            this.dateTimePicker1_miseEnVente.Value = bien_en_cours.DATE_MISEENVENTE;
            this.textBox12_commentaires.Text = bien_en_cours.ZONE_DE_SAISIE;

        }

        private void blocageBox(bool blocage)
        {
            nomClient.ReadOnly = !blocage;
            prénomVendeur.ReadOnly = !blocage;
            adresseVendeur.ReadOnly = !blocage;
            codePostalVendeur.ReadOnly = !blocage;
            fixeVendeur.ReadOnly = !blocage;
            mobileVendeur.ReadOnly = !blocage;
            emailVendeur.ReadOnly = !blocage;
            villeVendeur.ReadOnly = !blocage;
        }
        private void button5_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void nom_TextChanged(object sender, EventArgs e)
        {
            //var nomVendeur = (from v in modeleBase.VENDEUR
            //                  where v.NOM_VENDEUR.StartsWith(this.nomVendeur.Text)
            //                  select v.NOM_VENDEUR);
            //this.nomVendeur.Text = nomVendeur.First();
        }

        private void button1_ajouterBien_Click(object sender, EventArgs e)
        {
            if (bien_en_cours == null && verifier_champs())
            {
                creation_nouveau_bien();
            }

        }

        private bool verifier_champs()
        {
            bool valide = true;

            string message_erreur = "Informations manquantes : \nVeuillez renseigner les champs suivants :\n";

            if (numericUpDown1_surfHab.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer une surface habitable \n";
                valide = false;
            }

            if (numericUpDown2_surfParc.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer une surface de parcelle";
                valide = false;
            }


            if (numericUpDown3_nbPieces.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer un nombre de pièces. \n";
                valide = false;
            }

            if (numericUpDown4_nbChambres.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer un nombre de chambres";
                valide = false;
            }

            if (numericUpDown5_nbSdb.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer un nombre de salles de bain. \n";
                valide = false;
            }

            if (numericUpDown6_prix.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer un prix.";
                valide = false;
            }


            if (textBox9_adresse.Text == "" || textBox9_adresse.Text == null)
            {
                message_erreur += " --> Veuillez indiquer une adresse. \n";
                valide = false;
            }

            if (textBox10_codePostal.Text == "" || textBox10_codePostal.Text == null)
            {
                message_erreur += " --> Veuillez indiquer un code postal.";
                valide = false;
            }


            // vérifier si la ville est contenue dans la base
            var ville = (from v in Accueil.modeleBase.VILLE
                         where v.NOM_VILLE == textBox11_ville.Text.Replace(" ", string.Empty) &&
                         v.CODE_POSTAL == int.Parse(textBox10_codePostal.Text)
                         select v).FirstOrDefault();

            if (textBox11_ville.Text == "" || textBox11_ville.Text == null || ville == null)
            {


                message_erreur += " --> Veuillez indiquer une ville.";
                valide = false;

            }


            if (!valide)
            {
                MessageBox.Show(message_erreur);

            }

            return valide;
        }

        private void creation_nouveau_bien()
        {
            BIEN nouveauBien = new BIEN();

            var idville = (from v in Accueil.modeleBase.VILLE
                           where v.NOM_VILLE == textBox11_ville.Text
                           select v.IDVILLE);
            nouveauBien.IDVILLE = idville.First();

            var idvendeur = (from ve in Accueil.modeleBase.VENDEUR
                             where ve.EMAIL == emailVendeur.Text
                             select ve.IDVENDEUR).FirstOrDefault();

            nouveauBien.IDVENDEUR = idvendeur;

            nouveauBien.SURFACE_HABITABLE = (int)numericUpDown1_surfHab.Value;
            nouveauBien.SURFACE_PARCELLE = (int)numericUpDown2_surfParc.Value;
            nouveauBien.NB_PIÈCES = (int)numericUpDown3_nbPieces.Value;
            nouveauBien.NB_CHAMBRES = (int)numericUpDown4_nbChambres.Value;
            nouveauBien.NB_SALLEDEBAIN = (int)numericUpDown5_nbSdb.Value;
            nouveauBien.PRIX_SOUHAITÉ = (int)numericUpDown6_prix.Value;
            nouveauBien.ADRESSE_BIEN = textBox9_adresse.Text;
            nouveauBien.ZONE_DE_SAISIE = textBox12_commentaires.Text;
            nouveauBien.CODE_POSTAL = Int32.Parse(textBox10_codePostal.Text);
            nouveauBien.DATE_MISEENVENTE = dateTimePicker1_miseEnVente.Value;
            nouveauBien.STATUT = comboBox1_status.Text;
            nouveauBien.NB_VISITES = 0;

            if (checkBox1_garage.Checked)
            {
                nouveauBien.GARAGE = true;
            }
            if (checkBox2_cave.Checked)
            {
                nouveauBien.CAVE = true;
            }
            Accueil.modeleBase.BIEN.Add(nouveauBien);
            Accueil.modeleBase.SaveChanges();
        }
    }
}
