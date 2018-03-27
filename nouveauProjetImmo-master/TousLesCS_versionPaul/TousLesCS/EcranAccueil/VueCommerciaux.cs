using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace EcranAccueil
{
    public partial class VueCommerciaux : Form
    {

        string inactifs = "INACTIF";
        string actifs = "ACTIF";
        string status = "ACTIF";
        
        public VueCommerciaux()
        {
            InitializeComponent();


            IQueryable<COMMERCIAL> ca = (from x in RechercherClient.modeleBase.COMMERCIAL
                                         select x);
            foreach (COMMERCIAL c in ca)
            {
                ListViewItem lvi = new ListViewItem(c.NOM_COMMERCIAL);

                lvi.SubItems.Add(c.PRENOM_COMMERCIAL);
                lvi.SubItems.Add(c.EMAIL);
                lvi.SubItems.Add(c.TÉLÉPHONE_MOBILE_PRO.ToString());
                lvi.SubItems.Add(c.TÉLÉPHONE_FIXE_PRO.ToString());
                lvi.SubItems.Add(c.TÉLÉPHONE_PERSONNEL.ToString());
                lvi.SubItems.Add(c.STATUT_COMMERCIAL);
                listView1.Items.Add(lvi);
            }

            
        }






        private void supprimerCommercial_Click(object sender, EventArgs e)
        {
            COMMERCIAL c = (from x in RechercherClient.modeleBase.COMMERCIAL
                            where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                            select x).First();
            RechercherClient.modeleBase.COMMERCIAL.Remove(c);
            RechercherClient.modeleBase.SaveChanges();
            effacer();
        }

        private void ajoutCommercial_Click(object sender, EventArgs e)
        {
            sauvegarde();

        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

            IQueryable<COMMERCIAL> c = (from x in RechercherClient.modeleBase.COMMERCIAL
                                        where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                                        select x);
            if (c.Count() == 0)
            {
                actif.Checked = true;
                actif.Enabled = false;
                inactif.Checked = false;
                inactif.Enabled = false;
            }
            else
            {
                actif.Enabled = true;
                inactif.Enabled = true;
            }

        }
        

        private void clear_Click(object sender, EventArgs e)
        {

            effacer();

            IQueryable<COMMERCIAL> ca = (from x in RechercherClient.modeleBase.COMMERCIAL
                                         select x);
            foreach (COMMERCIAL c in ca)
            {
                ListViewItem lvi = new ListViewItem(c.NOM_COMMERCIAL);

                lvi.SubItems.Add(c.PRENOM_COMMERCIAL);
                lvi.SubItems.Add(c.EMAIL);
                lvi.SubItems.Add(c.TÉLÉPHONE_MOBILE_PRO.ToString());
                lvi.SubItems.Add(c.TÉLÉPHONE_FIXE_PRO.ToString());
                lvi.SubItems.Add(c.TÉLÉPHONE_PERSONNEL.ToString());
                lvi.SubItems.Add(c.STATUT_COMMERCIAL);
                listView1.Items.Add(lvi);
            }
        }


        private void actif_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
            {
                status = "ACTIF";
                inactif.Checked = false;

            }

        }

        private void inactif_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
            {
                status = "INACTIF";
                actif.Checked = false;

            }


        }
        void effacer() {
            nom.Text = "";
            prenom.Text = "";
            email.Text = "";
            portablePro.Text = "";
            fixePro.Text = "";
            telephonePerso.Text = "";
            email.Text = "";
            listView2.Items.Clear();

        }

        private void actifView_Click(object sender, EventArgs e)
        {

            effacer();
            listView1.Items.Clear();
           // listView1.Clear();

            IQueryable<COMMERCIAL> commercial = (from x in RechercherClient.modeleBase.COMMERCIAL
                                        where x.STATUT_COMMERCIAL == "ACTIF"
                                        select x);
           foreach (COMMERCIAL c in commercial)
            {

                    ListViewItem lvi = new ListViewItem(c.NOM_COMMERCIAL);

                    lvi.SubItems.Add(c.PRENOM_COMMERCIAL);
                    lvi.SubItems.Add(c.EMAIL);
                    lvi.SubItems.Add(c.TÉLÉPHONE_MOBILE_PRO.ToString());
                    lvi.SubItems.Add(c.TÉLÉPHONE_FIXE_PRO.ToString());
                    lvi.SubItems.Add(c.TÉLÉPHONE_PERSONNEL.ToString());
                    lvi.SubItems.Add(c.STATUT_COMMERCIAL);

                    listView1.Items.Add(lvi);
    
            }

        }

        private void inactifView_Click(object sender, EventArgs e)
        {
            effacer();
            listView1.Items.Clear();

            IQueryable<COMMERCIAL> commercial = (from x in RechercherClient.modeleBase.COMMERCIAL
                                        where x.STATUT_COMMERCIAL == "INACTIF"
                                        select x);

            foreach (COMMERCIAL c in commercial)
            {
                ListViewItem lvi = new ListViewItem(c.NOM_COMMERCIAL);

                lvi.SubItems.Add(c.PRENOM_COMMERCIAL);
                lvi.SubItems.Add(c.EMAIL);
                lvi.SubItems.Add(c.TÉLÉPHONE_MOBILE_PRO.ToString());
                lvi.SubItems.Add(c.TÉLÉPHONE_FIXE_PRO.ToString());
                lvi.SubItems.Add(c.TÉLÉPHONE_PERSONNEL.ToString());
                lvi.SubItems.Add(c.STATUT_COMMERCIAL);
                listView1.Items.Add(lvi);
            }

        }

        private void tousView_Click(object sender, EventArgs e)
        {
            effacer();
            listView1.Items.Clear();
   
            IQueryable<COMMERCIAL> commercial = (from x in RechercherClient.modeleBase.COMMERCIAL
                                        select x);

            foreach (COMMERCIAL c in commercial)
            {

                ListViewItem lvi = new ListViewItem(c.NOM_COMMERCIAL);
                lvi.SubItems.Add(c.PRENOM_COMMERCIAL);
                lvi.SubItems.Add(c.EMAIL);
                lvi.SubItems.Add(c.TÉLÉPHONE_MOBILE_PRO.ToString());
                lvi.SubItems.Add(c.TÉLÉPHONE_FIXE_PRO.ToString());
                lvi.SubItems.Add(c.TÉLÉPHONE_PERSONNEL.ToString());
                lvi.SubItems.Add(c.STATUT_COMMERCIAL);
                listView1.Items.Add(lvi);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sauvegarde();
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Hide();


        }
        private void VueCommerciaux_FormClosing(object sender, FormClosingEventArgs e)
        {



            DialogResult result;

            if (nom.Text != "" || prenom.Text != "" || email.Text != "" || portablePro.Text != "" || fixePro.Text != "" || telephonePerso.Text != "" || email.Text != "")
            {
                result = MessageBox.Show("sauvegarder", "quitter", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    sauvegarde();

                nom.Text = ""; prenom.Text = ""; email.Text = ""; portablePro.Text = ""; fixePro.Text = ""; telephonePerso.Text = ""; email.Text = "";
                this.Close();


            }

        }
        private bool verifier_champs()
        {
            bool valide = true;

            string message_erreur = "Recherche impossible  \nVeuillez renseigner les champs vides \n";

            // switch()
            if (nom.Text != "" || prenom.Text != "" || email.Text != "" || portablePro.Text != "" || fixePro.Text != "" || telephonePerso.Text != "" || email.Text != "")
            {

                if (nom.Text == "" || prenom.Text == "" || email.Text == "" || portablePro.Text == "" || fixePro.Text == "" || telephonePerso.Text == "" || email.Text == "")
                {
                    // message_erreur += " --> Budget à définir \n";
                    valide = false;
                }
         /*   if( prenom.Text == "")
                {
                     message_erreur += " --> prenom \n";
                    valide = false;
                }
                */
            }

            /*      if (villes_selectionnees.Count() == 0)
                  {
                      message_erreur += " --> Aucune ville n'est sélectionnée.";
                      valide = false;
                  }

          */
            if (!valide)
            {
                MessageBox.Show(message_erreur);

            }
            
            return valide;


        }

        private void sauvegarde()
        {
            if (!verifier_champs()) return;

            IQueryable<COMMERCIAL> ca = (from x in RechercherClient.modeleBase.COMMERCIAL
                                         where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                                         select x);

            if (ca.Count() == 0)
            {
                actif.Checked = true;
                actif.Enabled = false;
                inactif.Checked = false;
                inactif.Enabled = false;
                status = "ACTIF";
                COMMERCIAL commercial = new COMMERCIAL();
                commercial.NOM_COMMERCIAL = nom.Text;
                commercial.PRENOM_COMMERCIAL = prenom.Text;
                commercial.EMAIL = email.Text;
                commercial.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text);
                commercial.TÉLÉPHONE_FIXE_PRO = Int32.Parse(fixePro.Text);
                commercial.TÉLÉPHONE_PERSONNEL = Int32.Parse(telephonePerso.Text);
                commercial.EMAIL = email.Text;
                commercial.STATUT_COMMERCIAL = status;

                RechercherClient.modeleBase.COMMERCIAL.Add(commercial);
                RechercherClient.modeleBase.SaveChanges();
            }
            else
            {
                COMMERCIAL c = (from x in RechercherClient.modeleBase.COMMERCIAL
                                where x.NOM_COMMERCIAL.StartsWith(nom.Text)
                                select x).First();
                actif.Enabled = true;
                inactif.Enabled = true;
                status = c.STATUT_COMMERCIAL;


                COMMERCIAL commercial = new COMMERCIAL();

                commercial.NOM_COMMERCIAL = nom.Text;
                commercial.PRENOM_COMMERCIAL = prenom.Text;
                commercial.EMAIL = email.Text;
                commercial.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text);
                commercial.TÉLÉPHONE_FIXE_PRO = Int32.Parse(fixePro.Text);
                commercial.TÉLÉPHONE_PERSONNEL = Int32.Parse(telephonePerso.Text);
                commercial.EMAIL = email.Text;
                commercial.STATUT_COMMERCIAL = c.STATUT_COMMERCIAL;


                foreach (ACHETEUR r in c.ACHETEUR)
                {
                    commercial.ACHETEUR.Add(r);
                }

                commercial.STATUT_COMMERCIAL = status;
                RechercherClient.modeleBase.COMMERCIAL.Add(commercial);
                RechercherClient.modeleBase.COMMERCIAL.Remove(c);
                RechercherClient.modeleBase.SaveChanges();
            }
            nom.Text = "";
            prenom.Text = "";
            email.Text = "";
            portablePro.Text = "";
            fixePro.Text = "";
            telephonePerso.Text = "";
            email.Text = "";
            listView2.Items.Clear();
            IQueryable<COMMERCIAL> commercials = (from x in RechercherClient.modeleBase.COMMERCIAL
                                                 select x);

            foreach (COMMERCIAL c in commercials)
            {

                ListViewItem lvi = new ListViewItem(c.NOM_COMMERCIAL);
                lvi.SubItems.Add(c.PRENOM_COMMERCIAL);
                lvi.SubItems.Add(c.EMAIL);
                lvi.SubItems.Add(c.TÉLÉPHONE_MOBILE_PRO.ToString());
                lvi.SubItems.Add(c.TÉLÉPHONE_FIXE_PRO.ToString());
                lvi.SubItems.Add(c.TÉLÉPHONE_PERSONNEL.ToString());
                lvi.SubItems.Add(c.STATUT_COMMERCIAL);
                listView1.Items.Add(lvi);
            }
        }

        private void rechercherCommercial_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            IQueryable<COMMERCIAL> c = (from v in RechercherClient.modeleBase.COMMERCIAL
                                            where (nom.Text != "" ? v.NOM_COMMERCIAL.StartsWith(nom.Text) : true) &&
                                            (prenom.Text != "" ? v.PRENOM_COMMERCIAL.StartsWith(prenom.Text) : true) &&
                                              (email.Text != "" ? v.EMAIL.StartsWith(email.Text) : true) &&
                                            (fixePro.Text != "" ? v.TÉLÉPHONE_FIXE_PRO.ToString().StartsWith(fixePro.Text) : true) &&
                                                  (portablePro.Text != "" ? v.TÉLÉPHONE_MOBILE_PRO.ToString().StartsWith(portablePro.Text) : true)

                                            select v);
                foreach (COMMERCIAL commercial in c)
                {

                      nom.Text = commercial.NOM_COMMERCIAL;
                     prenom.Text = commercial.PRENOM_COMMERCIAL;
                    email.Text= commercial.EMAIL;
                    portablePro.Text = commercial.TÉLÉPHONE_MOBILE_PRO.ToString();
                    fixePro.Text = commercial.TÉLÉPHONE_FIXE_PRO.ToString() ;
                     telephonePerso.Text = commercial.TÉLÉPHONE_PERSONNEL.ToString();
                    
                    if (actif.Checked == true)
                    {
                        commercial.STATUT_COMMERCIAL= actifs;

                    }
                    else if (actif.Checked == true)
                    {
                        commercial.STATUT_COMMERCIAL = inactifs;

                    }

                    listView1.Items.Clear();
                    ListViewItem lvi = new ListViewItem(commercial.NOM_COMMERCIAL);

                    lvi.SubItems.Add(commercial.PRENOM_COMMERCIAL);
                    lvi.SubItems.Add(commercial.EMAIL);
                    lvi.SubItems.Add(commercial.TÉLÉPHONE_MOBILE_PRO.ToString());
                    lvi.SubItems.Add(commercial.TÉLÉPHONE_FIXE_PRO.ToString());
                    lvi.SubItems.Add(commercial.TÉLÉPHONE_PERSONNEL.ToString());
                    lvi.SubItems.Add(commercial.STATUT_COMMERCIAL);

                    listView1.Items.Add(lvi);

                }

            
        }

    
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

             ACHETEUR acheteur=new ACHETEUR();

            for (int i = 1; i < listView2.SelectedItems.Count; i++)
            {
                int phone = Int32.Parse(listView2.SelectedItems[i].SubItems[3].Text);
                int postal = Int32.Parse(listView2.SelectedItems[i].SubItems[5].Text);
                string nom = listView2.SelectedItems[i].SubItems[0].Text.ToString(), prenom = listView2.SelectedItems[i].SubItems[1].Text.ToString(),
                   mail = listView2.SelectedItems[i].SubItems[2].Text.ToString(), adresse = listView2.SelectedItems[i].SubItems[4].Text.ToString(),
                   ville = listView2.SelectedItems[i].SubItems[6].Text.ToString(),date = listView2.SelectedItems[i].SubItems[7].Text.ToString();
                
                acheteur = (from v in RechercherClient.modeleBase.ACHETEUR
                            where (v.NOM_ACHETEUR.ToString().StartsWith(nom) &&
                               (v.PRENOM_ACHETEUR.StartsWith(prenom)) &&
                               (v.TÉLÉPHONE.Equals(phone)) &&
                               (v.EMAIL.StartsWith(mail)) &&
                               (v.ADRESSE.StartsWith(adresse)) &&
                               (v.VILLE.CODE_POSTAL.Equals(postal)) &&
                               (v.VILLE.NOM_VILLE.StartsWith(ville))&&
                               (v.DATE_CREATION.ToString().StartsWith(date))

                               )

                            select v).First();

            }
            

          //  AjoutClient ajoutClient = new AjoutClient();
                 AjoutClient ajoutClient = new AjoutClient(acheteur);

                ajoutClient.Show() ;
                this.Hide();

            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (listView1.SelectedItems != null)
            {


                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    nom.Text = listView1.SelectedItems[i].SubItems[0].Text.ToString();
                    prenom.Text = listView1.SelectedItems[i].SubItems[1].Text.ToString();
                    email.Text = listView1.SelectedItems[i].SubItems[2].Text.ToString();
                    portablePro.Text = listView1.SelectedItems[i].SubItems[3].Text.ToString();
                    fixePro.Text = listView1.SelectedItems[i].SubItems[4].Text.ToString();
                    telephonePerso.Text = listView1.SelectedItems[i].SubItems[5].Text.ToString();
                    status = listView1.SelectedItems[i].SubItems[6].Text.ToString();

                    if (String.Compare(status.ToUpper(), inactifs.ToUpper()) == 1)
                    {
                        actif.Checked = false;
                        inactif.Checked = true;

                    }
                    else if (String.Compare(status.ToUpper(), actifs.ToUpper()) == 1)
                    {
                        actif.Checked = true;
                        inactif.Checked = false;
                    }
                    
                    COMMERCIAL commercial = (from v in RechercherClient.modeleBase.COMMERCIAL
                                             where (nom.Text != "" ? v.NOM_COMMERCIAL.StartsWith(nom.Text) : true) &&
                                             (prenom.Text != "" ? v.PRENOM_COMMERCIAL.StartsWith(prenom.Text) : true) &&
                                               (email.Text != "" ? v.EMAIL.StartsWith(email.Text) : true) &&
                                             (fixePro.Text != "" ? v.TÉLÉPHONE_FIXE_PRO.ToString().StartsWith(fixePro.Text) : true) &&
                                                   (portablePro.Text != "" ? v.TÉLÉPHONE_MOBILE_PRO.ToString().StartsWith(portablePro.Text) : true)
                                            
                                             select v).First();
                    foreach (ACHETEUR acheteur in commercial.ACHETEUR)
                    {

                        ListViewItem lvi = new ListViewItem(acheteur.NOM_ACHETEUR);

                        lvi.SubItems.Add(acheteur.PRENOM_ACHETEUR);
                        lvi.SubItems.Add(acheteur.EMAIL);
                        lvi.SubItems.Add(acheteur.TÉLÉPHONE.ToString());

                        lvi.SubItems.Add(acheteur.ADRESSE);

                        lvi.SubItems.Add(acheteur.CODE_POSTAL.ToString());
                        lvi.SubItems.Add(acheteur .VILLE.ToString());
                        lvi.SubItems.Add(acheteur.DATE_CREATION.ToString());

                     //   ville = listView2.SelectedItems[i].SubItems[6].Text.ToString(),date = listView2.SelectedItems[i].SubItems[7].Text.ToString();

                        listView2.Items.Add(lvi);
                    }
                }
            }

            }
        }
    }


