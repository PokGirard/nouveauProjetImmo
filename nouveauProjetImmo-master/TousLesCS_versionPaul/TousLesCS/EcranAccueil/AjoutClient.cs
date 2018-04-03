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
        FicheDeSouhaits maFenetreFiche;
        RDV_Visite maFenetreRDV;

        public FICHE_DE_SOUHAITS MA_FICHE { get; set; }
        public ACHETEUR MON_ACHETEUR { get; set; }
        public VENDEUR MON_VENDEUR { get; set; }

        public ChoixAffichage monChoixAffichage { get; set; }

        public enum ChoixAffichage
        {
            BIENS_A_VENDRE, BIENS_PROPOSES, BIENS_VISITES, FICHE_DE_SOUHAITS
        }

        public AjoutClient()
        {

            InitializeComponent();

            chargerComboboxCommerciaux();

        }

        public AjoutClient(ACHETEUR monAcheteur)
        {
            this.MON_ACHETEUR = monAcheteur;
            InitializeComponent();
            this.checkBox_Acheteur.Checked = true;
            this.nom.Text = monAcheteur.NOM_ACHETEUR;
            this.prénom.Text = monAcheteur.PRENOM_ACHETEUR;
            this.adresse.Text = monAcheteur.ADRESSE;
            this.codePostal.Text = monAcheteur.CODE_POSTAL.ToString();
            this.dateTimePicker1_créationClient.Value = monAcheteur.DATE_CREATION;
            this.fixe.Text = monAcheteur.TÉLÉPHONE.ToString();
            this.mobile.Text = monAcheteur.TÉLÉPHONE_MOBILE.ToString();
            this.email.Text = monAcheteur.EMAIL;


            chargerComboboxCommerciaux();

        }

        private void chargerComboboxCommerciaux()
        {

            var commerciaux = (from c in Accueil.modeleBase.COMMERCIAL
                               select c).ToList();

            foreach (COMMERCIAL c in commerciaux)
            {
                comboBoxCommerciaux.Items.Add(c.NOM_COMMERCIAL);
            }


        }

        public AjoutClient(VENDEUR vendeur_en_cours_fc)
        {
            this.MON_VENDEUR = vendeur_en_cours_fc;
            InitializeComponent();
            this.checkBox_Vendeur.Checked = true;
            this.nom.Text = vendeur_en_cours_fc.NOM_VENDEUR;
            this.prénom.Text = vendeur_en_cours_fc.PRÉNOM_VENDEUR;
            this.adresse.Text = vendeur_en_cours_fc.ADRESSE_VENDEUR;
            this.codePostal.Text = vendeur_en_cours_fc.CODE_POSTAL.ToString();
            this.dateTimePicker1_créationClient.Value = vendeur_en_cours_fc.DATE_CREATION;
            this.fixe.Text = vendeur_en_cours_fc.TÉLÉPHONE_FIXE.ToString();
            this.mobile.Text = vendeur_en_cours_fc.TÉLÉPHONE_MOBILE.ToString();
            this.email.Text = vendeur_en_cours_fc.EMAIL;

            chargerComboboxCommerciaux();


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
                ajouterBien.Visible = false;
                créerFicheSouhaits.Visible = true;
                checkBox_Vendeur.Checked = false;
                labelCommercial.Visible = true;
                comboBoxCommerciaux.Visible = true;
                button5_bienVisités.Visible = true;
                button6_ficheSouhaits.Visible = true;
                button4_biensVente.Visible = false;

                /*   comboBoxCommerciaux.Items.Clear();
                   var nomCommerciaux = (from c in Accueil.modeleBase.COMMERCIAL
                                         select c.NOM_COMMERCIAL);
                   foreach (string nom in nomCommerciaux)
                   {
                       comboBoxCommerciaux.Items.Add(nom);
                   } */
                Refresh();
            }
        }

        private void checkBox_Vendeur_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Vendeur.Checked)
            {
                ajouterBien.Visible = true;
                créerFicheSouhaits.Visible = false;
                button4_biensVente.Visible = true;
                checkBox_Acheteur.Checked = false;
                labelCommercial.Visible = false;
                button5_bienVisités.Visible = false;
                button6_ficheSouhaits.Visible = false;
                comboBoxCommerciaux.Visible = false;
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
                           where v.CODE_POSTAL.ToString() == codePostal.Text &&
                           v.NOM_VILLE == comboBox1_villes.Text
                           select v.IDVILLE).First();

            MON_ACHETEUR.IDVILLE = idville;
            MON_ACHETEUR.NOM_ACHETEUR = nom.Text;
            MON_ACHETEUR.PRENOM_ACHETEUR = prénom.Text;
            MON_ACHETEUR.ADRESSE = adresse.Text;
            MON_ACHETEUR.EMAIL = email.Text;
            MON_ACHETEUR.TÉLÉPHONE = Int32.Parse(fixe.Text);
            MON_ACHETEUR.TÉLÉPHONE_MOBILE = Int32.Parse(mobile.Text);
            MON_ACHETEUR.DATE_CREATION = dateTimePicker1_créationClient.Value;

            var idcommercial = (from v in Accueil.modeleBase.COMMERCIAL
                                where v.NOM_COMMERCIAL == comboBoxCommerciaux.SelectedItem.ToString()
                                select v.IDCOMMERCIAL).First();
            MON_ACHETEUR.IDCOMMERCIAL = idcommercial;

            Accueil.modeleBase.ACHETEUR.Add(MON_ACHETEUR);
            Accueil.modeleBase.SaveChanges();

        }

        private void codePostal_TextChanged(object sender, EventArgs e)
        {
            comboBox1_villes.Items.Clear();

            var nomVille = (from v in Accueil.modeleBase.VILLE
                            where v.CODE_POSTAL.ToString() == codePostal.Text
                            select v.NOM_VILLE);

            foreach (string ville in nomVille)
            {
                string villes_normales = ville.Replace(" ", string.Empty);
                comboBox1_villes.Items.Add(ville);
            }
        }

        private void éditerInfos_Click(object sender, EventArgs e)
        {
            if (MON_VENDEUR != null)
            {
                MON_VENDEUR.NOM_VENDEUR = nom.Text;
                MON_VENDEUR.PRÉNOM_VENDEUR = prénom.Text;


                Accueil.modeleBase.SaveChanges();
            }
        }

        private bool verifier_champs_acheteur()   // créer 2ème méthode vérif' pour champs vendeur
        {
            bool valide = true;

            string message_erreur = "Informations manquantes : \nVeuillez renseigner les champs suivants :\n";

            if (nom.Text == null || nom.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un nom de client \n";
                valide = false;
            }

            if (prénom.Text == null || prénom.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un prénom de client.";
                valide = false;
            }


            if (adresse.Text == null || adresse.Text == "")
            {
                message_erreur += " --> Veuillez indiquer une adresse de client \n";
                valide = false;
            }

            if (codePostal.Text == null || codePostal.Text == "")
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


            if (fixe.Text == null || fixe.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un numéro de fixe. \n";
                valide = false;
            }

            if (mobile.Text == null || mobile.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un numéro de mobile.";
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

            if (nom.Text == null || nom.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un nom de client \n";
                valide = false;
            }

            if (prénom.Text == null || prénom.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un prénom de client.";
                valide = false;
            }


            if (adresse.Text == null || adresse.Text == "")
            {
                message_erreur += " --> Veuillez indiquer une adresse de client \n";
                valide = false;
            }

            if (codePostal.Text == null || codePostal.Text == "")
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


            if (fixe.Text == null || fixe.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un numéro de fixe. \n";
                valide = false;
            }

            if (mobile.Text == null || mobile.Text == "")
            {
                message_erreur += " --> Veuillez indiquer un numéro de mobile.";
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
            buttonAccepterVisite.Visible = false;

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

                for (int i = 0; i < biens_En_Vente.Count(); i++)
                {


                    listView1.Items.Add(biens_En_Vente[i].IDBIEN.ToString()).SubItems.Add(biens_En_Vente[i].PRIX_SOUHAITÉ.ToString());
                    listView1.Items[i].SubItems.Add(biens_En_Vente[i].SURFACE_HABITABLE.ToString());
                    listView1.Items[i].SubItems.Add(biens_En_Vente[i].NB_PIÈCES.ToString());
                    listView1.Items[i].SubItems.Add(biens_En_Vente[i].ADRESSE_BIEN);



                }




            }
        }


        private void listView1_Click(object sender, EventArgs e)
        {
            if (monChoixAffichage == ChoixAffichage.BIENS_A_VENDRE)
            {
                string t = listView1.SelectedItems[0].SubItems[0].Text.Replace(" ", string.Empty);
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
                string t = listView1.SelectedItems[0].SubItems[0].Text.Replace(" ", string.Empty);
                int id_selec = Int32.Parse(t);
                BIEN bien_selectionne = (from b in Accueil.modeleBase.BIEN
                                         where b.IDBIEN == id_selec
                                         select b).FirstOrDefault();

                maFenetreBien = new AjoutBien(bien_selectionne);
                maFenetreBien.Show();
                return;
            }

            if (monChoixAffichage == ChoixAffichage.FICHE_DE_SOUHAITS)
            {
                string t = listView1.SelectedItems[0].SubItems[0].Text.Replace(" ", string.Empty);
                int id_selec = Int32.Parse(t);
                MA_FICHE = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                            where f.IDFICHESOUHAITS == id_selec
                            select f).First();

                maFenetreFiche = new FicheDeSouhaits(MA_FICHE);
                maFenetreFiche.Show();
                return;
            }




        }

        private void button6_ficheSouhaits_Click(object sender, EventArgs e)
        {
            monChoixAffichage = ChoixAffichage.FICHE_DE_SOUHAITS;
            buttonAccepterVisite.Visible = false;

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

                for (int i = 0; i < fd_souhait_acheteur.Count(); i++)
                {


                    listView1.Items.Add(fd_souhait_acheteur[i].IDFICHESOUHAITS.ToString()).SubItems.Add(fd_souhait_acheteur[i].STATUT);
                    listView1.Items[i].SubItems.Add(fd_souhait_acheteur[i].BUDGET.ToString());
                    listView1.Items[i].SubItems.Add(fd_souhait_acheteur[i].SURFACE_HABITABLE.ToString());
                    listView1.Items[i].SubItems.Add(fd_souhait_acheteur[i].NB_PIÈCE.ToString());

                }


                listView1.Refresh();
            }
        }

        private void button5_bienVisités_Click(object sender, EventArgs e)
        {
            monChoixAffichage = ChoixAffichage.BIENS_VISITES;
            buttonAccepterVisite.Visible = false;

            var id_fiche = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                            where f.IDACHETEUR == MON_ACHETEUR.IDACHETEUR
                            select f.IDFICHESOUHAITS).ToList();

            var id_prop_visites = (from pv in Accueil.modeleBase.PROPOSITION_VISITE
                                   where id_fiche.Contains(pv.IDFICHESOUHAITS)
                                   select pv.IDVISITE).ToList();

            var visites_effectuees = (from r in Accueil.modeleBase.RDV
                                      where id_prop_visites.Contains(r.IDVISITE)
                                      select r).ToList();

            listView1.Items.Clear();
            listView1.Columns[0].Text = "ID Rdv";
            listView1.Columns[1].Text = "Ville";
            listView1.Columns[2].Text = "Adresse";
            listView1.Columns[3].Text = "Prix";
            listView1.Columns[4].Text = "Date";

            for (int i = 0; i < visites_effectuees.Count(); i++)
            {

                int index = visites_effectuees[i].IDVISITE;
                PROPOSITION_VISITE proposition = (from p in Accueil.modeleBase.PROPOSITION_VISITE
                                                  where p.IDVISITE == index
                                                  select p).FirstOrDefault();

                BIEN b = (from b2 in Accueil.modeleBase.BIEN
                          where b2.IDBIEN == proposition.IDBIEN
                          select b2).FirstOrDefault();

                string ville = (from v in Accueil.modeleBase.VILLE
                                where v.IDVILLE == b.IDVILLE
                                select v.NOM_VILLE).FirstOrDefault();

                listView1.Items.Add(visites_effectuees[i].IDVISITE.ToString()).SubItems.Add(ville);
                listView1.Items[i].SubItems.Add(b.ADRESSE_BIEN);
                listView1.Items[i].SubItems.Add(b.PRIX_SOUHAITÉ.ToString());
                listView1.Items[i].SubItems.Add(proposition.DATERDV.ToString());

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

        private void buttonBienProposes_Click(object sender, EventArgs e)
        {

            monChoixAffichage = ChoixAffichage.BIENS_PROPOSES;
            buttonAccepterVisite.Visible = true;

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

                for (int i = 0; i < visites_proposees.Count; i++)
                {

                    int id_courant = visites_proposees[i].IDBIEN;

                    var b = (from b1 in Accueil.modeleBase.BIEN
                             where b1.IDBIEN == id_courant
                             select b1).FirstOrDefault();

                    string ville = (from v in Accueil.modeleBase.VILLE
                                    where v.IDVILLE == b.IDVILLE
                                    select v.NOM_VILLE).FirstOrDefault();


                    listView1.Items.Add(visites_proposees[i].IDVISITE.ToString()).SubItems.Add(ville);


                    listView1.Items[i].SubItems.Add(b.ADRESSE_BIEN);
                    listView1.Items[i].SubItems.Add(b.PRIX_SOUHAITÉ.ToString());
                    listView1.Items[i].SubItems.Add(visites_proposees[i].DATERDV.ToString());

                }


                listView1.Refresh();
            }



        }

        private void buttonAccepterVisite_Click(object sender, EventArgs e)
        {

            int id_proposition = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            PROPOSITION_VISITE proposition_retenue = (from p in Accueil.modeleBase.PROPOSITION_VISITE
                                                      where p.IDVISITE == id_proposition
                                                      select p).FirstOrDefault();

            maFenetreRDV = new RDV_Visite(proposition_retenue);



            RDV rdv = new RDV
            {
                IDVISITE = proposition_retenue.IDVISITE
            };

            Accueil.modeleBase.RDV.Add(rdv);
            Accueil.modeleBase.SaveChanges();

            maFenetreRDV.Show();




        }
    }
}


