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
    //METTRE DES VERIFS QUIL Y A DES BIENS DANS LES LISTES SINON PLANTAGE LORS DE VOIR PROPOSITION FICHES ETC...
    //MODIFS COMMERCIAL A SAUVER (NE SE SAUVE PAS CORRECTEMENT) >>>>> Checked
    //AFFICHAGE
    //BOUTON RETOUR MENU A AJOUTER    >>>>>>>> Checked
    //AFFICHAGE VILLE CORRESPONDANT AU CODEPOSTAL A LOUVERTURE NE FONCTIONNE PAS + BLOQUER COMBOBOX_COMMERCIAUX  >>>>> Checked

    public partial class AjoutClient : Form
    {

        AjoutBien maFenetreBien;
        FicheDeSouhaits maFenetreFiche;
        RDV_Visite maFenetreRDV;

        public FICHE_DE_SOUHAITS MA_FICHE { get; set; }
        public ACHETEUR MON_ACHETEUR { get; set; }
        public VENDEUR MON_VENDEUR { get; set; }
        private bool clientExisteDeja = false;
        public ChoixAffichage monChoixAffichage { get; set; }

        public enum ChoixAffichage
        {
            BIENS_A_VENDRE, BIENS_PROPOSES, BIENS_VISITES, FICHE_DE_SOUHAITS
        }

        #region constructeurs
        public AjoutClient()
        {

            InitializeComponent();
            button1_retourMenu.Enabled = true;
            chargerComboboxCommerciaux();
            comboBoxCommerciaux.Enabled = true;
            dateTimePicker1_créationClient.Enabled = false;

        }

        public AjoutClient(ACHETEUR monAcheteur)
        {

            this.MON_ACHETEUR = monAcheteur;
            InitializeComponent();
            initialisationClientExistant();
            this.checkBox_Acheteur.Checked = true;
            this.textBoxNom.Text = monAcheteur.NOM_ACHETEUR.Trim();
            this.textBoxprénom.Text = monAcheteur.PRENOM_ACHETEUR.Trim();
            this.adresse.Text = monAcheteur.ADRESSE.Trim();
            this.textBoxcodePostal.Text = monAcheteur.CODE_POSTAL.ToString().Trim();
            this.dateTimePicker1_créationClient.Value = monAcheteur.DATE_CREATION;
            this.dateTimePicker1_créationClient.Enabled = false;
            this.textBoxfixe.Text = "0" + monAcheteur.TÉLÉPHONE.ToString().Trim();
            this.textBoxMobile.Text = "0" + monAcheteur.TÉLÉPHONE_MOBILE.ToString().Trim();
            this.email.Text = monAcheteur.EMAIL.Trim();
            this.checkBox_Vendeur.Enabled = false;
            this.checkBox_Acheteur.Enabled = false;
            comboBoxCommerciaux.Enabled = false;
            chargerComboboxCommerciaux();

            var nomVille = (from v in Accueil.modeleBase.VILLE
                            where v.IDVILLE == MON_ACHETEUR.IDVILLE
                            select v.NOM_VILLE).First();
            this.comboBox1_villes.Text = nomVille;
        }

        public AjoutClient(VENDEUR vendeur_en_cours_fc)
        {
            this.MON_VENDEUR = vendeur_en_cours_fc;
            InitializeComponent();
            initialisationClientExistant();
            this.checkBox_Vendeur.Checked = true;
            this.textBoxNom.Text = vendeur_en_cours_fc.NOM_VENDEUR.Trim();
            this.textBoxprénom.Text = vendeur_en_cours_fc.PRÉNOM_VENDEUR.Trim();
            this.adresse.Text = vendeur_en_cours_fc.ADRESSE_VENDEUR.Trim();
            this.textBoxcodePostal.Text = vendeur_en_cours_fc.CODE_POSTAL.ToString().Trim();
            this.dateTimePicker1_créationClient.Value = vendeur_en_cours_fc.DATE_CREATION;

            this.textBoxfixe.Text = "0" + vendeur_en_cours_fc.TÉLÉPHONE_FIXE.ToString().Trim();
            this.textBoxMobile.Text = "0" + vendeur_en_cours_fc.TÉLÉPHONE_MOBILE.ToString().Trim();
            this.email.Text = vendeur_en_cours_fc.EMAIL.Trim();
            this.checkBox_Vendeur.Enabled = false;
            this.checkBox_Acheteur.Enabled = false;
            comboBoxCommerciaux.Enabled = false;
            this.dateTimePicker1_créationClient.Enabled = false;
            buttonBienProposes.Enabled = false;
            chargerComboboxCommerciaux();

            var nomVille = (from v in Accueil.modeleBase.VILLE
                            where v.IDVILLE == MON_VENDEUR.IDVILLE
                            select v.NOM_VILLE).First();
            this.comboBox1_villes.Text = nomVille.Trim();
        }

        private void initialisationClientExistant()
        {

            this.titreFenetre.Text = "Fiche Client";
            this.éditerInfos.Enabled = true;
            clientExisteDeja = true;
            blocageBoxVendeur(false);

        }

        private void blocageBoxVendeur(bool estModifiable)
        {
            textBoxNom.Enabled = estModifiable;
            textBoxprénom.Enabled = estModifiable;
            adresse.Enabled = estModifiable;
            textBoxcodePostal.Enabled = estModifiable;
            textBoxfixe.Enabled = estModifiable;
            textBoxMobile.Enabled = estModifiable;
            email.Enabled = estModifiable;
            comboBox1_villes.Enabled = estModifiable;
            comboBoxCommerciaux.Enabled = estModifiable;

            button1_retourMenu.Enabled = !estModifiable;

        }
        #endregion constructeurs

        private void chargerComboboxCommerciaux()
        {

            var commerciaux = (from c in Accueil.modeleBase.COMMERCIAL
                               where c.STATUT_COMMERCIAL == "ACTIF"
                               select c).ToList();

            foreach (COMMERCIAL c in commerciaux)
            {
                comboBoxCommerciaux.Items.Add(c.NOM_COMMERCIAL);
            }

            if (clientExisteDeja && checkBox_Acheteur.Checked)
            {
                int idcommercial = MON_ACHETEUR.IDCOMMERCIAL;
                var nomCommercial = (from c in Accueil.modeleBase.COMMERCIAL
                                     where c.IDCOMMERCIAL == idcommercial
                                     select c).ToList();
                comboBoxCommerciaux.Text = nomCommercial[0].NOM_COMMERCIAL;
            }
        }

        private void créer_Click(object sender, EventArgs e)
        {
            if (checkBox_Vendeur.Checked)
            {

                VENDEUR vendeur = new VENDEUR();

                var idville = (from v in Accueil.modeleBase.VILLE
                               where v.CODE_POSTAL.ToString() == textBoxcodePostal.Text
                               select v.IDVILLE);

                vendeur.IDVILLE = idville.First();
                vendeur.CODE_POSTAL = Int32.Parse(textBoxcodePostal.Text);
                vendeur.NOM_VENDEUR = textBoxNom.Text;
                vendeur.PRÉNOM_VENDEUR = textBoxprénom.Text;
                vendeur.ADRESSE_VENDEUR = adresse.Text;
                vendeur.EMAIL = email.Text;

                string a = textBoxfixe.Text.TrimEnd();
                string b = textBoxMobile.Text.TrimEnd();
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
                               where v.CODE_POSTAL.ToString() == textBoxcodePostal.Text
                               select v.IDVILLE);

                acheteur.IDVILLE = idville.First();
                acheteur.NOM_ACHETEUR = textBoxNom.Text;
                acheteur.PRENOM_ACHETEUR = textBoxprénom.Text;
                acheteur.ADRESSE = adresse.Text;
                acheteur.CODE_POSTAL = Int32.Parse(textBoxcodePostal.Text);
                acheteur.EMAIL = email.Text;
                acheteur.TÉLÉPHONE = Int32.Parse(textBoxfixe.Text);
                acheteur.TÉLÉPHONE_MOBILE = Int32.Parse(textBoxMobile.Text);
                acheteur.DATE_CREATION = dateTimePicker1_créationClient.Value;

                var idcommercial = (from v in Accueil.modeleBase.COMMERCIAL
                                    where v.NOM_COMMERCIAL == comboBoxCommerciaux.SelectedItem.ToString()
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
                ajouterBien.Enabled = false;
                créerFicheSouhaits.Enabled = true;
                checkBox_Vendeur.Checked = false;
                labelCommercial.Enabled = true;
                comboBoxCommerciaux.Enabled = true;
                button5_bienVisités.Enabled = true;
                button6_ficheSouhaits.Enabled = true;
                button4_biensVente.Enabled = false;

                Refresh();
            }
        }

        private void checkBox_Vendeur_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Vendeur.Checked)
            {
                ajouterBien.Enabled = true;
                créerFicheSouhaits.Enabled = false;
                button4_biensVente.Enabled = true;
                checkBox_Acheteur.Checked = false;
                labelCommercial.Enabled = false;
                button5_bienVisités.Enabled = false;
                button6_ficheSouhaits.Enabled = false;
                comboBoxCommerciaux.Enabled = false;
                Refresh();
            }
        }

        private void ajouterBien_Click(object sender, EventArgs e)
        {

            if (!checkBox_Vendeur.Checked)
            {
                MessageBox.Show("Veuillez cocher la case vendeur.");
                return;
            }

            if (verifier_champs_vendeur())
            {

                if (MON_VENDEUR == null)
                {
                    VENDEUR vendeur = new VENDEUR();

                    var idville = (from v in Accueil.modeleBase.VILLE
                                   where v.CODE_POSTAL.ToString() == textBoxcodePostal.Text &&
                                    v.NOM_VILLE == comboBox1_villes.Text
                                   select v.IDVILLE).FirstOrDefault();

                    vendeur.IDVILLE = idville;
                    vendeur.CODE_POSTAL = Int32.Parse(textBoxcodePostal.Text);
                    vendeur.NOM_VENDEUR = textBoxNom.Text;
                    vendeur.PRÉNOM_VENDEUR = textBoxprénom.Text;
                    vendeur.ADRESSE_VENDEUR = adresse.Text;
                    vendeur.EMAIL = email.Text;

                    string a = textBoxfixe.Text.TrimEnd();
                    string b = textBoxMobile.Text.TrimEnd();
                    vendeur.TÉLÉPHONE_FIXE = Int32.Parse(a);
                    vendeur.TÉLÉPHONE_MOBILE = Int32.Parse(b);

                    vendeur.DATE_CREATION = dateTimePicker1_créationClient.Value;

                    Accueil.modeleBase.VENDEUR.Add(vendeur);
                    Accueil.modeleBase.SaveChanges();


                    this.checkBox_Vendeur.Enabled = false;
                    this.checkBox_Acheteur.Enabled = false;
                    maFenetreBien = new AjoutBien(vendeur);

                }
                else
                {
                    maFenetreBien = new AjoutBien(MON_VENDEUR);
                }
                maFenetreBien.Show();
            }
        }

        private void créerFicheSouhaits_Click(object sender, EventArgs e)
        {

            if (!checkBox_Acheteur.Checked)
            {
                MessageBox.Show("Veuillez cocher la case acheteur.");
                return;
            }

            if (verifier_champs_acheteur())
            {

                if (MON_ACHETEUR == null)
                    creation_acheteur();

                creation_fiche();

            }


        }

        private void creation_fiche()
        {

            maFenetreFiche = new FicheDeSouhaits(MON_ACHETEUR);
            maFenetreFiche.Show();

        }

        private void creation_acheteur()
        {
            MON_ACHETEUR = new ACHETEUR();
            var idville = (from v in Accueil.modeleBase.VILLE
                           where v.CODE_POSTAL.ToString() == textBoxcodePostal.Text &&
                           v.NOM_VILLE == comboBox1_villes.Text
                           select v.IDVILLE).First();

            MON_ACHETEUR.IDVILLE = idville;
            MON_ACHETEUR.NOM_ACHETEUR = textBoxNom.Text;
            MON_ACHETEUR.PRENOM_ACHETEUR = textBoxprénom.Text;
            MON_ACHETEUR.ADRESSE = adresse.Text;
            MON_ACHETEUR.CODE_POSTAL = Int32.Parse(textBoxcodePostal.Text);
            MON_ACHETEUR.EMAIL = email.Text;
            MON_ACHETEUR.TÉLÉPHONE = Int32.Parse(textBoxfixe.Text);
            MON_ACHETEUR.TÉLÉPHONE_MOBILE = Int32.Parse(textBoxMobile.Text);
            MON_ACHETEUR.DATE_CREATION = dateTimePicker1_créationClient.Value;

            var idcommercial = (from v in Accueil.modeleBase.COMMERCIAL
                                where v.NOM_COMMERCIAL == comboBoxCommerciaux.SelectedItem.ToString()
                                select v.IDCOMMERCIAL).First();
            MON_ACHETEUR.IDCOMMERCIAL = idcommercial;

            Accueil.modeleBase.ACHETEUR.Add(MON_ACHETEUR);
            this.checkBox_Vendeur.Enabled = false;
            this.checkBox_Acheteur.Enabled = false;
            Accueil.modeleBase.SaveChanges();

        }

        private void codePostal_TextChanged(object sender, EventArgs e)
        {
            comboBox1_villes.Items.Clear();
            comboBox1_villes.Text = "";

            var nomVille = (from v in Accueil.modeleBase.VILLE
                            where v.CODE_POSTAL.ToString() == textBoxcodePostal.Text
                            select v.NOM_VILLE);


            foreach (string ville in nomVille)
            {
                string villes_normales = ville.TrimEnd();
                comboBox1_villes.Items.Add(ville);
            }
        }

        private void éditerInfos_Click(object sender, EventArgs e)
        {
            if (éditerInfos.Text == "Editer les informations")
            {

                blocageBoxVendeur(true);
                éditerInfos.Text = "Valider les modifications";
            }
            else
            {
                envoyer_les_modifications();
                blocageBoxVendeur(false);
                éditerInfos.Text = "Editer les informations";
            }

        }

        private void envoyer_les_modifications()
        {
            if (checkBox_Vendeur.Checked && MON_VENDEUR != null && verifier_champs_vendeur())
            {
                try
                {
                    MON_VENDEUR.NOM_VENDEUR = textBoxNom.Text.Trim();
                    MON_VENDEUR.PRÉNOM_VENDEUR = textBoxprénom.Text.Trim();
                    MON_VENDEUR.TÉLÉPHONE_MOBILE = int.Parse(textBoxMobile.Text.Trim());
                    MON_VENDEUR.TÉLÉPHONE_FIXE = int.Parse(textBoxfixe.Text.Trim());
                    MON_VENDEUR.CODE_POSTAL = int.Parse(textBoxcodePostal.Text.Trim());
                    MON_VENDEUR.ADRESSE_VENDEUR = adresse.Text.Trim();

                    int codePostal2 = int.Parse(textBoxcodePostal.Text.Trim());

                    int idVille = (from v in Accueil.modeleBase.VILLE
                                   where v.CODE_POSTAL == codePostal2
                                   select v.IDVILLE).FirstOrDefault();

                    MON_VENDEUR.IDVILLE = idVille;
                    MON_VENDEUR.CODE_POSTAL = codePostal2;

                    Accueil.modeleBase.SaveChanges();
                    MessageBox.Show("Les modifications ont bien été enregistrées");

                }
                catch (Exception e45)
                {
                    MessageBox.Show(e45.Message);
                }
            }

            else if (checkBox_Acheteur.Checked && MON_ACHETEUR != null && verifier_champs_acheteur())
            {
                try
                {
                    MON_ACHETEUR.NOM_ACHETEUR = textBoxNom.Text.Trim();
                    MON_ACHETEUR.PRENOM_ACHETEUR = textBoxprénom.Text.Trim();
                    MON_ACHETEUR.TÉLÉPHONE_MOBILE = int.Parse(textBoxMobile.Text.Trim());
                    MON_ACHETEUR.TÉLÉPHONE = int.Parse(textBoxfixe.Text.Trim());
                    int codePostal2 = int.Parse(textBoxcodePostal.Text.Trim());

                    int idVille = (from v in Accueil.modeleBase.VILLE
                                   where v.CODE_POSTAL == codePostal2
                                   select v.IDVILLE).FirstOrDefault();

                    MON_ACHETEUR.IDVILLE = idVille;
                    MON_ACHETEUR.CODE_POSTAL = codePostal2;

                    var commercial = (from c in Accueil.modeleBase.COMMERCIAL
                                      where c.NOM_COMMERCIAL == comboBoxCommerciaux.Text.Trim()
                                      select c).First();
                    MON_ACHETEUR.COMMERCIAL = commercial;
                    MON_ACHETEUR.ADRESSE = adresse.Text.Trim();


                    Accueil.modeleBase.SaveChanges();
                    MessageBox.Show("Les modifications ont bien été enregistrées");

                }
                catch (Exception e45)
                {
                    MessageBox.Show(e45.Message);
                }
            }
        }
        private bool verifier_champs_acheteur()   // créer 2ème méthode vérif' pour champs vendeur
        {
            bool valide = true;

            string message_erreur = "Informations manquantes : \nVeuillez renseigner les champs suivants :\n";

            if (textBoxNom.Text == null || textBoxNom.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un nom de client \n";
                valide = false;
            }

            if (textBoxprénom.Text == null || textBoxprénom.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un prénom de client.";
                valide = false;
            }


            if (adresse.Text == null || adresse.Text == "")
            {
                message_erreur += " --> Veuillez indiquer une adresse de client \n";
                valide = false;
            }

            if (textBoxcodePostal.Text == null || textBoxcodePostal.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un code postal.";
                valide = false;
            }


            if (comboBox1_villes.Text == "" && MON_ACHETEUR == null)
            {
                message_erreur += " --> Veuillez sélectionner une ville \n";
                valide = false;
            }

            if (email == null || email.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un email.";
                valide = false;
            }


            if (textBoxfixe.Text == null || textBoxfixe.Text == "" || textBoxfixe.Text.Trim().Length != 10)
            {
                message_erreur += " --> Veuillez indiquer un numéro de fixe composé de 10 chiffres. \n";
                valide = false;
            }

            if (textBoxMobile.Text == null || textBoxMobile.Text == "" || textBoxMobile.Text.Trim().Length != 10)
            {
                message_erreur += " --> Veuillez indiquer un numéro de mobile composé de 10 chiffres.";
                valide = false;
            }


            if (MON_ACHETEUR == null && (comboBoxCommerciaux.SelectedIndex == -1))
            {
                message_erreur += " --> Veuillez sélectionner un commercial";
                valide = false;
            }

            if (!checkBox_Acheteur.Checked && !checkBox_Vendeur.Checked)
            {
                message_erreur += " --> Veuillez sélectionner un type de client";
                valide = false;
            }

            if (!valide)
            {
                MessageBox.Show(message_erreur);

            }

            return valide;

        }

        private bool verifier_champs_vendeur()   // créer 2ème méthode vérif' pour champs vendeur
        {
            bool valide = true;

            string message_erreur = "Informations manquantes : \nVeuillez renseigner les champs suivants :\n";

            if (textBoxNom.Text == null || textBoxNom.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un nom de client \n";
                valide = false;
            }

            if (textBoxprénom.Text == null || textBoxprénom.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un prénom de client.";
                valide = false;
            }

            if (adresse.Text == null || adresse.Text == "")
            {
                message_erreur += " --> Veuillez indiquer une adresse de client \n";
                valide = false;
            }

            if (textBoxcodePostal.Text == null || textBoxcodePostal.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un code postal.";
                valide = false;
            }

            if (comboBox1_villes.Text == "" && MON_VENDEUR == null)
            {
                message_erreur += " --> Veuillez sélectionner une ville \n";
                valide = false;
            }

            if (email == null || email.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un email.";
                valide = false;
            }

            if (textBoxfixe.Text == null || textBoxfixe.Text == "" || textBoxfixe.Text.Trim().Length != 10)
            {
                message_erreur += " --> Veuillez indiquer un numéro de fixe composé de 10 chiffres. \n";
                valide = false;
            }

            if (textBoxMobile.Text == null || textBoxMobile.Text == "" || textBoxMobile.Text.Trim().Length != 10)
            {
                message_erreur += " --> Veuillez indiquer un numéro de mobile composé de 10 chiffres.";
                valide = false;
            }


            if (!valide)
            {
                MessageBox.Show(message_erreur);

            }

            return valide;

        }

        private void button4_biensVente_Click(object sender, EventArgs e)
        {
            monChoixAffichage = ChoixAffichage.BIENS_A_VENDRE;
            buttonAccepterVisite.Enabled = false;

            if (MON_VENDEUR != null)
            {
                var biens_En_Vente = (from b in Accueil.modeleBase.BIEN
                                      where b.IDVENDEUR == MON_VENDEUR.IDVENDEUR
                                      select b).ToList();

                listView1.Items.Clear();

                listView1.Columns[0].Text = "ID du bien";
                listView1.Columns[1].Text = "Prix";
                listView1.Columns[2].Text = "Surface";
                listView1.Columns[3].Text = "Nb Pièces";
                listView1.Columns[4].Text = "Adresse";

                if (biens_En_Vente.Count == 0) return;

                for (int i = 0; i < biens_En_Vente.Count; i++)
                {
                    listView1.Items.Add(biens_En_Vente[i].IDBIEN.ToString()).SubItems.Add(biens_En_Vente[i].PRIX_SOUHAITÉ.ToString());
                    listView1.Items[i].SubItems.Add(biens_En_Vente[i].SURFACE_HABITABLE.ToString().Trim());
                    listView1.Items[i].SubItems.Add(biens_En_Vente[i].NB_PIÈCES.ToString().Trim());
                    listView1.Items[i].SubItems.Add(biens_En_Vente[i].ADRESSE_BIEN.Trim());
                }
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (monChoixAffichage == ChoixAffichage.BIENS_A_VENDRE)
            {
                string t = listView1.SelectedItems[0].SubItems[0].Text.TrimEnd();
                int id_selec = Int32.Parse(t);
                BIEN bien_selectionne = (from b in Accueil.modeleBase.BIEN
                                         where b.IDBIEN == id_selec
                                         select b).FirstOrDefault();

                maFenetreBien = new AjoutBien(bien_selectionne);
                maFenetreBien.Show();
                return;
            }

            if (monChoixAffichage == ChoixAffichage.BIENS_VISITES)
            {
                string t = listView1.SelectedItems[0].SubItems[0].Text.TrimEnd();
                int id_selec = Int32.Parse(t);

                var RDV = (from b in Accueil.modeleBase.RDV
                           where b.IDRDV == id_selec
                           select b).FirstOrDefault();

                var prop = (from p in Accueil.modeleBase.PROPOSITION_VISITE
                            where p.IDVISITE == RDV.IDVISITE
                            select p.IDBIEN).FirstOrDefault();

                var bien_selectionne = (from b in Accueil.modeleBase.BIEN
                                        where b.IDBIEN == prop
                                        select b).FirstOrDefault();

                maFenetreBien = new AjoutBien(bien_selectionne);
                maFenetreBien.Show();
                return;
            }

            if (monChoixAffichage == ChoixAffichage.FICHE_DE_SOUHAITS)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    buttonAccepterVisite.Enabled = true;
                }
                else
                {
                    buttonAccepterVisite.Enabled = false;
                }

                //string t = listView1.SelectedItems[0].SubItems[0].Text.TrimEnd();
                //int id_selec = Int32.Parse(t);
                //MA_FICHE = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                //            where f.IDFICHESOUHAITS == id_selec
                //            select f).First();

                //maFenetreFiche = new FicheDeSouhaits(MA_FICHE);
                //maFenetreFiche.Show();
                //return;
            }

            if (monChoixAffichage == ChoixAffichage.BIENS_PROPOSES)
            {

                if (listView1.SelectedItems.Count != 0)
                {
                    if (listView1.SelectedItems[0].SubItems[5].Text.TrimEnd() == "ACCEPTEE" || listView1.SelectedItems[0].SubItems[5].Text.TrimEnd() == "REFUSEE")
                    {
                        buttonRefuserVisite.Enabled = false;
                        buttonAccepterVisite.Enabled = false;
                    }
                    else
                    {
                        buttonRefuserVisite.Enabled = true;
                        buttonAccepterVisite.Enabled = true;
                    }

                    string t = listView1.SelectedItems[0].SubItems[0].Text.TrimEnd();
                    int id_selec = Int32.Parse(t);


                    var prop = (from p in Accueil.modeleBase.PROPOSITION_VISITE
                                where p.IDVISITE == id_selec
                                select p.IDBIEN).FirstOrDefault();

                    var bien_selectionne = (from b in Accueil.modeleBase.BIEN
                                            where b.IDBIEN == prop
                                            select b).FirstOrDefault();

                    maFenetreBien = new AjoutBien(bien_selectionne);
                    maFenetreBien.Show();
                    return;
                }
            }

        }

        private void button6_ficheSouhaits_Click(object sender, EventArgs e)
        {
            monChoixAffichage = ChoixAffichage.FICHE_DE_SOUHAITS;
            buttonAccepterVisite.Text = "Voir la fiche";
            buttonAccepterVisite.Enabled = false;

            if (MON_ACHETEUR != null)
            {
                var fd_souhait_acheteur = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                                           where f.IDACHETEUR == MON_ACHETEUR.IDACHETEUR
                                           select f).ToList();

                listView1.Items.Clear();
                listView1.Columns[0].Text = "ID fiche";
                listView1.Columns[1].Text = "Statut";
                listView1.Columns[2].Text = "Budget";
                listView1.Columns[3].Text = "Surface";
                listView1.Columns[4].Text = "Nombre pièces";


                if (fd_souhait_acheteur.Count == 0) return;

                for (int i = 0; i < fd_souhait_acheteur.Count; i++)
                {
                    listView1.Items.Add(fd_souhait_acheteur[i].IDFICHESOUHAITS.ToString()).SubItems.Add(fd_souhait_acheteur[i].STATUT.Trim());
                    listView1.Items[i].SubItems.Add(fd_souhait_acheteur[i].BUDGET.ToString().Trim());
                    listView1.Items[i].SubItems.Add(fd_souhait_acheteur[i].SURFACE_HABITABLE.ToString().Trim());
                    listView1.Items[i].SubItems.Add(fd_souhait_acheteur[i].NB_PIÈCE.ToString().Trim());
                }
                listView1.Refresh();
            }
        }

        private void button5_bienVisités_Click(object sender, EventArgs e)
        {
            monChoixAffichage = ChoixAffichage.BIENS_VISITES;
            buttonAccepterVisite.Enabled = false;

            var fiches_souhait = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                                  where f.IDACHETEUR == MON_ACHETEUR.IDACHETEUR
                                  select f.IDFICHESOUHAITS).ToList();

            var prop_visites_acceptees = (from pv in Accueil.modeleBase.PROPOSITION_VISITE
                                          where fiches_souhait.Contains(pv.IDFICHESOUHAITS) &&
                                          pv.STATUT_PROPOSITION == "ACCEPTEE"
                                          select pv.IDVISITE).ToList();

            var dateRDV = (from r in Accueil.modeleBase.RDV
                           where r.PROPOSITION_VISITE.DATERDV <= DateTime.Today &&
                           prop_visites_acceptees.Contains(r.IDVISITE)
                           select r).Distinct().ToList();

            listView1.Items.Clear();
            listView1.Columns[0].Text = "ID Rdv";
            listView1.Columns[1].Text = "Ville";
            listView1.Columns[2].Text = "Adresse";
            listView1.Columns[3].Text = "Prix";
            listView1.Columns[4].Text = "Date";

            if (dateRDV.Count == 0) return;

            for (int i = 0; i < dateRDV.Count; i++)
            {

                int index = dateRDV[i].IDVISITE;
                PROPOSITION_VISITE proposition = (from p in Accueil.modeleBase.PROPOSITION_VISITE
                                                  where p.IDVISITE == index &&
                                                   p.STATUT_PROPOSITION == "ACCEPTEE"
                                                  select p).FirstOrDefault();

                BIEN b = (from b2 in Accueil.modeleBase.BIEN
                          where b2.IDBIEN == proposition.IDBIEN
                          select b2).FirstOrDefault();

                string ville = (from v in Accueil.modeleBase.VILLE
                                where v.IDVILLE == b.IDVILLE
                                select v.NOM_VILLE).FirstOrDefault();

                listView1.Items.Add(dateRDV[i].IDVISITE.ToString()).SubItems.Add(ville.Trim());
                listView1.Items[i].SubItems.Add(b.ADRESSE_BIEN.Trim());
                listView1.Items[i].SubItems.Add(b.PRIX_SOUHAITÉ.ToString().Trim());
                listView1.Items[i].SubItems.Add(proposition.DATERDV.ToString().Trim());
                listView1.Refresh();

            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            string t = "";


            if (MON_ACHETEUR == null && MON_VENDEUR == null)
            {
                MessageBox.Show("Veuillez sélectionner le client à supprimer.");
                return;
            }

            else if (checkBox_Acheteur.Checked && MON_ACHETEUR != null)
            {
                t += (MON_ACHETEUR.NOM_ACHETEUR + " (acheteur) : confirmer la suppression ? ");
            }
            else if (checkBox_Vendeur.Checked)
            {
                t += (MON_VENDEUR.NOM_VENDEUR + " (vendeur) : confirmer la suppression ? ");
            }


            DialogResult dr = MessageBox.Show(t, "Suppression", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    if (checkBox_Acheteur.Checked)
                    {
                        // supprimer les fiches de souhait ?

                        Accueil.modeleBase.ACHETEUR.Remove(MON_ACHETEUR);
                        MON_ACHETEUR = null;
                    }

                    if (checkBox_Vendeur.Checked)
                    {
                        Accueil.modeleBase.VENDEUR.Remove(MON_VENDEUR);
                        MON_VENDEUR = null;
                    }

                    try
                    {
                        Accueil.modeleBase.SaveChanges();
                        MessageBox.Show("Suppression effectuée.");
                        this.Close();
                    }
                    catch (Exception e125)
                    {
                        MessageBox.Show(e125.Message);
                    }



                    break;
                case DialogResult.No:
                    break;
            }


        }

        public void buttonBienProposes_Click(object sender, EventArgs e)
        {
            monChoixAffichage = ChoixAffichage.BIENS_PROPOSES;
            buttonAccepterVisite.Text = "Accepter la visite";
            buttonAccepterVisite.Enabled = false;

            if (MON_ACHETEUR != null)
            {
                var id_fiches = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                                 where f.IDACHETEUR == MON_ACHETEUR.IDACHETEUR
                                 select f.IDFICHESOUHAITS).ToList();

                var visites_proposees = (from pv in Accueil.modeleBase.PROPOSITION_VISITE
                                         where id_fiches.Contains(pv.IDFICHESOUHAITS)
                                         select pv).ToList();

                listView1.Items.Clear();
                listView1.Columns[0].Text = "ID Proposition";
                listView1.Columns[1].Text = "Ville";
                listView1.Columns[2].Text = "Adresse";
                listView1.Columns[3].Text = "Prix";
                listView1.Columns[4].Text = "Date";
                listView1.Columns[5].Text = "Statut";

                if (visites_proposees.Count == 0) return;

                for (int i = 0; i < visites_proposees.Count; i++)
                {

                    int id_courant = visites_proposees[i].IDBIEN;

                    var b = (from b1 in Accueil.modeleBase.BIEN
                             where b1.IDBIEN == id_courant
                             select b1).FirstOrDefault();

                    string ville = (from v in Accueil.modeleBase.VILLE
                                    where v.IDVILLE == b.IDVILLE
                                    select v.NOM_VILLE).FirstOrDefault();


                    listView1.Items.Add(visites_proposees[i].IDVISITE.ToString()).SubItems.Add(ville.Trim());

                    listView1.Items[i].SubItems.Add(b.ADRESSE_BIEN.Trim());
                    listView1.Items[i].SubItems.Add(b.PRIX_SOUHAITÉ.ToString().Trim());
                    listView1.Items[i].SubItems.Add(visites_proposees[i].DATERDV.ToString().Trim());
                    listView1.Items[i].SubItems.Add(visites_proposees[i].STATUT_PROPOSITION.Trim());
                }


                listView1.Refresh();
            }
        }

        private void buttonAccepterVisite_Click(object sender, EventArgs e)
        {
            if (buttonAccepterVisite.Text == "Voir la fiche")
            {
                string t = listView1.SelectedItems[0].SubItems[0].Text.TrimEnd();
                int id_selec = Int32.Parse(t);
                MA_FICHE = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                            where f.IDFICHESOUHAITS == id_selec
                            select f).First();

                maFenetreFiche = new FicheDeSouhaits(MA_FICHE);
                maFenetreFiche.Show();
                return;
            }

            int id_proposition = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            PROPOSITION_VISITE proposition_retenue = (from p in Accueil.modeleBase.PROPOSITION_VISITE
                                                      where p.IDVISITE == id_proposition
                                                      select p).FirstOrDefault();

            if (proposition_retenue.STATUT_PROPOSITION.TrimEnd() != "EN ATTENTE")
            {
                MessageBox.Show(" La proposition a déjà été traitée.");
                return;
            }

            maFenetreRDV = new RDV_Visite(proposition_retenue);



            /*   RDV rdv = new RDV
               {
                   IDVISITE = proposition_retenue.IDVISITE
               };

               Accueil.modeleBase.RDV.Add(rdv);
               Accueil.modeleBase.SaveChanges(); */

            // ---------> se fait via le bouton créer de la fenêtre RDV..non ?

            maFenetreRDV.Show();
            /*while (maFenetreRDV.IsAccessible)
            {
                continue;
            }
            buttonBienProposes_Click(sender, e);
            buttonRefuserVisite.Enabled = false;
            buttonAccepterVisite.Enabled = false;*/




        }

        private void button1_retourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefuserVisite_Click(object sender, EventArgs e)
        {
            int id_proposition = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            PROPOSITION_VISITE proposition_retenue = (from p in Accueil.modeleBase.PROPOSITION_VISITE
                                                      where p.IDVISITE == id_proposition
                                                      select p).FirstOrDefault();

            if (proposition_retenue.STATUT_PROPOSITION.TrimEnd() != "EN ATTENTE")
            {
                MessageBox.Show(" La proposition a déjà été traitée.");
                return;
            }
            proposition_retenue.STATUT_PROPOSITION = "REFUSEE";
            Accueil.modeleBase.SaveChanges();
            buttonBienProposes_Click(sender, e);
            buttonRefuserVisite.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //vide
        }
    }
}


