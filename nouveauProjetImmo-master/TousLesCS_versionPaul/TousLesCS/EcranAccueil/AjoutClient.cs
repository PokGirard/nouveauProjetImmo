using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcranAccueil
{
   
    public partial class AjoutClient : Form
    {
        
        AjoutBien maFenetreBien;
        FicheDeSouhaits maFiche;
        private VENDEUR vendeur_en_cours_fc;


        public ACHETEUR monAcheteur { get; set; }
        //public VENDEUR vendeur_en_cours_fc { get; set; }

        public AjoutClient()
        {
            InitializeComponent();
        }

        public AjoutClient(ACHETEUR monACheteur)
        {
            InitializeComponent();
            this.checkBox_Acheteur.Checked = true;
            this.nom.Text = monACheteur.NOM_ACHETEUR;
            this.prénom.Text = monACheteur.PRENOM_ACHETEUR;
            this.adresse.Text = monACheteur.ADRESSE;
            this.codePostal.Text = monACheteur.CODE_POSTAL.ToString();
            this.dateTimePicker1_créationClient.Value = monACheteur.DATE_CREATION;
            this.fixe.Text = monACheteur.TÉLÉPHONE.ToString();
            this.mobile.Text = monACheteur.TÉLÉPHONE_MOBILE.ToString();
            this.email.Text = monACheteur.EMAIL;

        }

        public AjoutClient(VENDEUR vendeur_en_cours_fc)
        {
            this.vendeur_en_cours_fc = vendeur_en_cours_fc;
        }


        private void créer_Click(object sender, EventArgs e)
        {
            if (checkBox_Vendeur.Checked)
            {

                VENDEUR vendeur = new VENDEUR();

                var idville = (from v in Accueil.modeleBase.VILLE
                               where v.CODE_POSTAL.ToString() == codePostal.Text
                               select v.IDVILLE);

                vendeur.IDVILLE = idville.First();
                vendeur.CODE_POSTAL = Int32.Parse(codePostal.Text);
                vendeur.NOM_VENDEUR = nom.Text;
                vendeur.PRÉNOM_VENDEUR = prénom.Text;
                vendeur.ADRESSE_VENDEUR = adresse.Text;
                vendeur.EMAIL = email.Text;

                string a = fixe.Text.Replace(" ", string.Empty);
                string b = mobile.Text.Replace(" ", string.Empty);
                vendeur.TÉLÉPHONE_FIXE = Int32.Parse(a);
                vendeur.TÉLÉPHONE_MOBILE = Int32.Parse(b);
                vendeur.DATE_CREATION = dateTimePicker1_créationClient.Value;

                Accueil.modeleBase.VENDEUR.Add(vendeur);
                Accueil.modeleBase.SaveChanges();

            }


            if (checkBox_Acheteur.Checked)
            {


                Refresh();

                ACHETEUR acheteur = new ACHETEUR();
                var idville = (from v in Accueil.modeleBase.VILLE
                               where v.CODE_POSTAL.ToString() == codePostal.Text
                               select v.IDVILLE);

                acheteur.IDVILLE = idville.First();
                acheteur.NOM_ACHETEUR = nom.Text;
                acheteur.PRENOM_ACHETEUR = prénom.Text;
                acheteur.ADRESSE = adresse.Text;
                acheteur.CODE_POSTAL = Int32.Parse(codePostal.Text);
                acheteur.EMAIL = email.Text;
                acheteur.TÉLÉPHONE = Int32.Parse(fixe.Text);
                acheteur.TÉLÉPHONE_MOBILE = Int32.Parse(mobile.Text);
                acheteur.DATE_CREATION = dateTimePicker1_créationClient.Value;

                var idcommercial = (from v in Accueil.modeleBase.COMMERCIAL
                                    where v.NOM_COMMERCIAL == listBoxCommerciaux.SelectedItem.ToString()
                select v.IDCOMMERCIAL);
                acheteur.IDCOMMERCIAL = idcommercial.First();

                Accueil.modeleBase.ACHETEUR.Add(acheteur);
                Accueil.modeleBase.SaveChanges();
            }
        }

        private void checkBox_Acheteur_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Acheteur.Checked)
            {
                checkBox_Vendeur.Checked = false;
                labelCommercial.Visible = true;
                listBoxCommerciaux.Visible = true;

                listBoxCommerciaux.Items.Clear();
                var nomCommerciaux = (from c in Accueil.modeleBase.COMMERCIAL
                                      select c.NOM_COMMERCIAL);
                foreach (string nom in nomCommerciaux)
                {
                    listBoxCommerciaux.Items.Add(nom);
                }
                Refresh();
            }
        }

        private void checkBox_Vendeur_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Vendeur.Checked)
            {
                checkBox_Acheteur.Checked = false;
                labelCommercial.Visible = false;
                listBoxCommerciaux.Visible = false;
                Refresh();
            }
        }

        private void ajouterBien_Click(object sender, EventArgs e)
        {
            if (checkBox_Vendeur.Checked)
            {

                VENDEUR vendeur = new VENDEUR();

                var idville = (from v in Accueil.modeleBase.VILLE
                               where v.CODE_POSTAL.ToString() == codePostal.Text
                               where v.NOM_VILLE == comboBox1_villes.Text
                               select v.IDVILLE).First();

                vendeur.IDVILLE = idville;
                vendeur.CODE_POSTAL = Int32.Parse(codePostal.Text);
                vendeur.NOM_VENDEUR = nom.Text;
                vendeur.PRÉNOM_VENDEUR = prénom.Text;
                vendeur.ADRESSE_VENDEUR = adresse.Text;
                vendeur.EMAIL = email.Text;

                string a = fixe.Text.Replace(" ", string.Empty);
                string b = mobile.Text.Replace(" ", string.Empty);
                vendeur.TÉLÉPHONE_FIXE = Int32.Parse(a);
                vendeur.TÉLÉPHONE_MOBILE = Int32.Parse(b);
                vendeur.DATE_CREATION = dateTimePicker1_créationClient.Value;

                Accueil.modeleBase.VENDEUR.Add(vendeur);
                Accueil.modeleBase.SaveChanges();


                maFenetreBien = new AjoutBien(vendeur);

                maFenetreBien.Show();
            }
        }

        private void créerFicheSouhaits_Click(object sender, EventArgs e)
        {
            if (checkBox_Acheteur.Checked)
            {
                ACHETEUR acheteur = new ACHETEUR();
                var idville = (from v in Accueil.modeleBase.VILLE
                               where v.CODE_POSTAL == Int32.Parse(codePostal.Text)
                               select v.IDVILLE);

                acheteur.IDVILLE = idville.First();
                acheteur.NOM_ACHETEUR = nom.Text;
                acheteur.PRENOM_ACHETEUR = prénom.Text;
                acheteur.ADRESSE = adresse.Text;
                acheteur.EMAIL = email.Text;
                acheteur.TÉLÉPHONE = Int32.Parse(fixe.Text);
                acheteur.TÉLÉPHONE_MOBILE = Int32.Parse(mobile.Text);

                var idcommercial = (from v in Accueil.modeleBase.COMMERCIAL
                                    where v.NOM_COMMERCIAL == listBoxCommerciaux.SelectedItem.ToString()
                                    select v.IDCOMMERCIAL);
                acheteur.IDCOMMERCIAL = idcommercial.First();

                Accueil.modeleBase.ACHETEUR.Add(acheteur);
                Accueil.modeleBase.SaveChanges();

                maFiche = new FicheDeSouhaits(/*acheteur*/);
            }

        }

        private void codePostal_TextChanged(object sender, EventArgs e)
        {
            comboBox1_villes.Items.Clear();

            var nomVille = (from v in Accueil.modeleBase.VILLE
                            where v.CODE_POSTAL.ToString() == codePostal.Text
                         select v.NOM_VILLE);

            foreach(string ville in nomVille)
            {
                //string villes_normales = ville.Replace(" ", string.Empty);
                comboBox1_villes.Items.Add(ville);
            }
        }

        private void éditerInfos_Click(object sender, EventArgs e)
        {
            if(vendeur_en_cours_fc.IDVENDEUR != null)
            {
                vendeur_en_cours_fc.NOM_VENDEUR = nom.Text;
                vendeur_en_cours_fc.PRÉNOM_VENDEUR = prénom.Text;


                Accueil.modeleBase.SaveChanges();
            }
        }
    }
}


