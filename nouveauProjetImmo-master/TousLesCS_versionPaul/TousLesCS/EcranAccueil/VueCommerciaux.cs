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



        public VueCommerciaux()
        {
            InitializeComponent();

            IQueryable<COMMERCIAL> liste_c = (from c in Accueil.modeleBase.COMMERCIAL
                                              select c);
            charger_listView_commerciaux(liste_c);

        }


        private void supprimerCommercial_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            else if (confirmation())
            {
                var id_selec = listView1.SelectedItems[0].SubItems[7].Text.TrimEnd();

                short id = short.Parse(id_selec);

                COMMERCIAL commercial_a_supprimer = (from c in Accueil.modeleBase.COMMERCIAL
                                                     where c.IDCOMMERCIAL == id
                                                     select c).FirstOrDefault();

                try
                {

                    Accueil.modeleBase.COMMERCIAL.Remove(commercial_a_supprimer);
                    Accueil.modeleBase.SaveChanges();
                    MessageBox.Show("Le commmercial a bien été supprimé de la base de données");
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message + " -- erreur lors de la suppression.");
                }
                effacer_champs();

                IQueryable<COMMERCIAL> liste_c = (from c in Accueil.modeleBase.COMMERCIAL
                                                  select c);
                charger_listView_commerciaux(liste_c);
            }
        }

        private bool confirmation()
        {
            if (MessageBox.Show(this, "Etes-vous sûr ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }
        private void ajoutCommercial_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
                modifier_commercial();
            else
                ajouter_commercial();


            IQueryable<COMMERCIAL> liste_c = (from c in Accueil.modeleBase.COMMERCIAL
                                              select c);
            charger_listView_commerciaux(liste_c);

        }


        private void ajouter_commercial()
        {

            if (!verifier_champs()) return;

            if (present_dans_base())
            {
                MessageBox.Show("Le commercial est déjà présent dans la base");
                return;

            }

            COMMERCIAL commercial = new COMMERCIAL();
            commercial.NOM_COMMERCIAL = nom.Text.TrimEnd();
            commercial.PRENOM_COMMERCIAL = prenom.Text.TrimEnd();
            commercial.EMAIL = email.Text.TrimEnd();
            commercial.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text.TrimEnd());
            commercial.TÉLÉPHONE_FIXE_PRO = Int32.Parse(fixePro.Text.TrimEnd());
            commercial.TÉLÉPHONE_PERSONNEL = Int32.Parse(telPerso.Text.TrimEnd());
            commercial.EMAIL = email.Text.TrimEnd();
            commercial.STATUT_COMMERCIAL = "ACTIF";

            try
            {

                Accueil.modeleBase.COMMERCIAL.Add(commercial);
                Accueil.modeleBase.SaveChanges();

                MessageBox.Show(" Le commercial a bien été ajouté dans la base");
            }
            catch (Exception e1)
            {
                MessageBox.Show(" Erreur lors de l'ajout : -- " + e1.Message);
            }
        }

        private bool present_dans_base()
        {

            COMMERCIAL commercial_deja_present = (from v in Accueil.modeleBase.COMMERCIAL
                                                  where v.NOM_COMMERCIAL.TrimEnd() == nom.Text.TrimEnd() &&
                                                     v.PRENOM_COMMERCIAL.TrimEnd() == prenom.Text.TrimEnd() &&
                                                    v.EMAIL.TrimEnd() == email.Text.TrimEnd() &&
                                                    v.TÉLÉPHONE_FIXE_PRO.ToString().TrimEnd() == fixePro.Text.TrimEnd() &&
                                                           v.TÉLÉPHONE_MOBILE_PRO.ToString().TrimEnd() == portablePro.Text.TrimEnd() &&
                                                          v.TÉLÉPHONE_FIXE_PRO.ToString().TrimEnd() == fixePro.Text.TrimEnd()
                                                  select v).FirstOrDefault();

            if (commercial_deja_present != null) return true;
            return false;
        }

        private void modifier_commercial()
        {


            if (!verifier_champs()) return;


            try
            {
                short id = short.Parse(listView1.SelectedItems[0].SubItems[7].Text.TrimEnd());

                COMMERCIAL co = (from c in Accueil.modeleBase.COMMERCIAL
                                 where c.IDCOMMERCIAL == id
                                 select c).FirstOrDefault();

                if (nom.Text.ToString().TrimEnd() != co.NOM_COMMERCIAL.TrimEnd())
                {
                    co.NOM_COMMERCIAL = nom.Text.ToString();
                }

                if (prenom.Text.ToString().TrimEnd() != co.PRENOM_COMMERCIAL.TrimEnd())
                {
                    co.PRENOM_COMMERCIAL = prenom.Text.ToString();
                }

                if (email.Text.ToString().TrimEnd() != co.EMAIL.TrimEnd())
                {
                    co.EMAIL = email.Text.ToString();
                }

                if (telPerso.Text.ToString().TrimEnd() != co.TÉLÉPHONE_PERSONNEL.ToString().TrimEnd())
                {
                    co.TÉLÉPHONE_PERSONNEL = Int32.Parse(telPerso.Text.ToString().TrimEnd());
                }

                if (portablePro.Text.ToString().TrimEnd() != co.TÉLÉPHONE_MOBILE_PRO.ToString().TrimEnd())
                {
                    co.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text.ToString().TrimEnd());
                }


                if (fixePro.Text.ToString().TrimEnd() != co.TÉLÉPHONE_FIXE_PRO.ToString().TrimEnd())
                {
                    co.TÉLÉPHONE_FIXE_PRO = Int32.Parse(fixePro.Text.ToString().TrimEnd());
                }

                if (portablePro.Text.ToString().TrimEnd() != co.TÉLÉPHONE_MOBILE_PRO.ToString().TrimEnd())
                {
                    co.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text.ToString().TrimEnd());
                }


                if (inactif.Checked && co.STATUT_COMMERCIAL.ToString().TrimEnd() == "ACTIF")
                {
                    co.STATUT_COMMERCIAL = "INACTIF";
                }

                if (actif.Checked && co.STATUT_COMMERCIAL.ToString().TrimEnd() == "INACTIF")
                {
                    co.STATUT_COMMERCIAL = "ACTIF";
                }


                Accueil.modeleBase.SaveChanges();
                MessageBox.Show(" Le commercial a bien été modifié.");

            }
            catch (Exception e1)
            {
                MessageBox.Show(" Erreur lors de la modification. -- " + e1.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {

            effacer_champs();


        }

        void effacer_champs()
        {
            nom.Text = "";
            prenom.Text = "";
            email.Text = "";
            portablePro.Text = "";
            fixePro.Text = "";
            telPerso.Text = "";
            email.Text = "";

        }

        private void actifView_Click(object sender, EventArgs e)
        {
            effacer_champs();
            IQueryable<COMMERCIAL> commercial = (from x in Accueil.modeleBase.COMMERCIAL
                                                 where x.STATUT_COMMERCIAL == "ACTIF"
                                                 select x);

            charger_listView_commerciaux(commercial);

        }

        private void inactifView_Click(object sender, EventArgs e)
        {
            effacer_champs();

            IQueryable<COMMERCIAL> commercial = (from x in Accueil.modeleBase.COMMERCIAL
                                                 where x.STATUT_COMMERCIAL == "INACTIF"
                                                 select x);

            charger_listView_commerciaux(commercial);

        }

        private void tousView_Click(object sender, EventArgs e)
        {
            effacer_champs();
            IQueryable<COMMERCIAL> liste_c = (from c in Accueil.modeleBase.COMMERCIAL
                                              select c);
            charger_listView_commerciaux(liste_c);
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }



        private bool verifier_champs()
        {
            bool valide = true;
            string message_erreur = "Commande impossible  \nVeuillez renseigner les champs vides \n";

            if (nom.Text == "" || prenom.Text == "" || email.Text == "" || portablePro.Text == "" || fixePro.Text == "" || telPerso.Text == "" || email.Text == "")
                valide = false;

            if (telephoneClient.Text.Trim().Length != 10 || telephonesPerso.Text.Trim().Length != 10 || telPerso.Text.Trim().Length != 10)
            {
                message_erreur += " Veuillez renseigner un numéro de téléphone à 10 chiffres.";
                valide = false;
            }

            if (!valide)
                MessageBox.Show(message_erreur);

            return valide;
        }




        private void rechercherCommercial_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            IQueryable<COMMERCIAL> liste_commerciaux = (from v in Accueil.modeleBase.COMMERCIAL
                                                        where (nom.Text != "" ? v.NOM_COMMERCIAL.StartsWith(nom.Text.TrimEnd()) : true) &&
                                                        (prenom.Text != "" ? v.PRENOM_COMMERCIAL.StartsWith(prenom.Text.TrimEnd()) : true) &&
                                                          (email.Text != "" ? v.EMAIL.StartsWith(email.Text.TrimEnd()) : true) &&
                                                        (fixePro.Text != "" ? v.TÉLÉPHONE_FIXE_PRO.ToString().StartsWith(fixePro.Text.TrimEnd()) : true) &&
                                                              (portablePro.Text != "" ? v.TÉLÉPHONE_MOBILE_PRO.ToString().StartsWith(portablePro.Text.TrimEnd()) : true)
                                                        select v);

            charger_listView_commerciaux(liste_commerciaux);
        }


        private void charger_listView_commerciaux(IQueryable<COMMERCIAL> liste)
        {

            listView1.Items.Clear();
            foreach (COMMERCIAL c in liste)
            {
                ListViewItem lvi = new ListViewItem(c.NOM_COMMERCIAL.Trim());

                lvi.SubItems.Add(c.PRENOM_COMMERCIAL.Trim());
                lvi.SubItems.Add(c.EMAIL.Trim());
                lvi.SubItems.Add("0" + c.TÉLÉPHONE_MOBILE_PRO.ToString().Trim());
                lvi.SubItems.Add("0" + c.TÉLÉPHONE_FIXE_PRO.ToString().Trim());
                lvi.SubItems.Add("0" + c.TÉLÉPHONE_PERSONNEL.ToString().Trim());
                lvi.SubItems.Add(c.STATUT_COMMERCIAL.Trim());
                lvi.SubItems.Add(c.IDCOMMERCIAL.ToString().Trim());
                listView1.Items.Add(lvi);
            }




            /*     listView1.Items.Clear();

                 IQueryable<COMMERCIAL> ca = (from x in Accueil.modeleBase.COMMERCIAL
                                              select x);
                 foreach (COMMERCIAL c in ca)
                 {
                     ListViewItem lvi = new ListViewItem(c.NOM_COMMERCIAL.Trim());

                     lvi.SubItems.Add(c.PRENOM_COMMERCIAL.Trim());
                     lvi.SubItems.Add(c.EMAIL.Trim());
                     lvi.SubItems.Add("0" + c.TÉLÉPHONE_MOBILE_PRO.ToString().Trim());
                     lvi.SubItems.Add("0" + c.TÉLÉPHONE_FIXE_PRO.ToString().Trim());
                     lvi.SubItems.Add("0" + c.TÉLÉPHONE_PERSONNEL.ToString().Trim());
                     lvi.SubItems.Add(c.STATUT_COMMERCIAL.Trim());
                     lvi.SubItems.Add(c.IDCOMMERCIAL.ToString().Trim());
                     listView1.Items.Add(lvi);
                 } */
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (listView1.SelectedItems.Count > 0)
            {
                remplir_champs_selection();


                string string_id = listView1.SelectedItems[0].SubItems[7].Text.TrimEnd();

                int id = int.Parse(string_id);

                COMMERCIAL c = (from c1 in Accueil.modeleBase.COMMERCIAL
                                where c1.IDCOMMERCIAL == id
                                select c1).FirstOrDefault();


                foreach (ACHETEUR a in c.ACHETEUR)
                {

                    ListViewItem lvi = new ListViewItem(a.NOM_ACHETEUR.Trim());

                    lvi.SubItems.Add(a.PRENOM_ACHETEUR.Trim());
                    lvi.SubItems.Add(a.EMAIL.Trim());
                    lvi.SubItems.Add("0" + a.TÉLÉPHONE.ToString().Trim());
                    lvi.SubItems.Add(a.ADRESSE.Trim());
                    lvi.SubItems.Add(a.CODE_POSTAL.ToString().Trim());
                    lvi.SubItems.Add(a.IDACHETEUR.ToString().Trim());
                    listView2.Items.Add(lvi);
                }
            }
        }

        private void remplir_champs_selection()
        {
            nom.Text = listView1.SelectedItems[0].SubItems[0].Text;
            prenom.Text = listView1.SelectedItems[0].SubItems[1].Text;
            email.Text = listView1.SelectedItems[0].SubItems[2].Text;
            portablePro.Text = listView1.SelectedItems[0].SubItems[3].Text;
            fixePro.Text = listView1.SelectedItems[0].SubItems[4].Text;
            telPerso.Text = listView1.SelectedItems[0].SubItems[5].Text;
            string statut = listView1.SelectedItems[0].SubItems[6].Text;

            statut = statut.TrimEnd();

            if (statut == "ACTIF")
            {

                actif.Checked = true;
                inactif.Checked = false;

            }
            else
            {
                inactif.Checked = true;
                actif.Checked = false;
            }
        }

        private void VueCommerciaux_Load(object sender, EventArgs e)
        {
            //vide et c'est normal
        }

        private void button1_voirFicheClient_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                button1_voirFicheClient.Enabled = true;
                string a1 = listView2.SelectedItems[0].SubItems[6].Text;

                int id = int.Parse(a1);

                ACHETEUR acheteur = (from a in Accueil.modeleBase.ACHETEUR
                                     where a.IDACHETEUR == id
                                     select a).FirstOrDefault();

                AjoutClient ajoutClient = new AjoutClient(acheteur);
                ajoutClient.Show();
                Close();
            }
        }

        private void listView2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count != 0)
            {
                button1_voirFicheClient.Enabled = true;
            }
            else
            {
                button1_voirFicheClient.Enabled = false;
            }
        }
    }
}



