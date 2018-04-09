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
    public partial class RechercherClient : Form
    {
        //DOIT CLEAR LES LISTES DE RESULTATS LOSQUE L ON CLIQUE SUR RECHERCHER A NOUVEAU (SINON RESULTATS EN DOUBLON, TRIPLE, ETC...) >>>>OK

        static AjoutClient fenetreModificationClient;

        TypeClient typeClientChoisi = TypeClient.ACHETEUR;
        List<ACHETEUR> acheteurs;
        List<VENDEUR> vendeurs;
        ACHETEUR acheteur_en_cours_fc;
        VENDEUR vendeur_en_cours_fc;


        public enum TypeClient
        {
            VENDEUR, ACHETEUR
        }


        public RechercherClient()
        {
            InitializeComponent();
        }


        private void buttonAcheteur_Click(object sender, EventArgs e)
        {
            typeClientChoisi = TypeClient.ACHETEUR;
            buttonAcheteur.Font = new Font(buttonAcheteur.Font, FontStyle.Bold);
            buttonVendeur.Font = new Font(buttonVendeur.Font, FontStyle.Regular);
        }

        private void button_vendeur_Click(object sender, EventArgs e)
        {
            typeClientChoisi = TypeClient.VENDEUR;
            buttonAcheteur.Font = new Font(buttonAcheteur.Font, FontStyle.Regular);
            buttonVendeur.Font = new Font(buttonVendeur.Font, FontStyle.Bold);
        }


        public void fonction_recherche()
        {
            listView_resultat.Items.Clear();

            if (typeClientChoisi == TypeClient.ACHETEUR) recherche_acheteurs();
            else recherche_vendeurs();

        }

        public void recherche_acheteurs()
        {
            Requetes_tout_acheteurs();

            if (acheteurs.Count != 0)

                for (int i = 0; i < acheteurs.Count; i++)

                    afficher_resultats_acheteurs(i);

        }

        public void recherche_acheteurs_actifs()
        {
            var idAcheteurs = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                               where f.STATUT == "EN COURS"
                               select f.IDACHETEUR).Distinct().ToList();

            if (idAcheteurs.Count != 0)
            {

                for (int i = 0; i < idAcheteurs.Count; i++)
                {
                    int t = idAcheteurs[i];

                    ACHETEUR a = (from a1 in Accueil.modeleBase.ACHETEUR
                                  where a1.IDACHETEUR == t
                                  select a1).FirstOrDefault();
                    afficher_resultats_acheteurs(a, i);

                }
            }

        }

        private void afficher_resultats_acheteurs(ACHETEUR a, int i)
        {
            listView_resultat.Items.Add(a.IDACHETEUR.ToString()).SubItems.Add(a.NOM_ACHETEUR);
            listView_resultat.Items[i].SubItems.Add(a.PRENOM_ACHETEUR);
            listView_resultat.Items[i].SubItems.Add(a.EMAIL);
        }

        private void afficher_resultats_acheteurs(int i)
        {
            listView_resultat.Items.Add(acheteurs[i].IDACHETEUR.ToString()).SubItems.Add(acheteurs[i].NOM_ACHETEUR);
            listView_resultat.Items[i].SubItems.Add(acheteurs[i].PRENOM_ACHETEUR);
            listView_resultat.Items[i].SubItems.Add(acheteurs[i].EMAIL);
        }

        private void Requetes_tout_acheteurs()
        {
            if (checkBox1_toutesFiches.Checked)
            {
                acheteurs = (from a in Accueil.modeleBase.ACHETEUR
                             select a).ToList();
            }

            else
            {
                acheteurs = (from a in Accueil.modeleBase.ACHETEUR
                             where (textBoxNom.Text != "" ? a.NOM_ACHETEUR.StartsWith(textBoxNom.Text) : true) &&
                             (textBoxPrenom.Text != "" ? a.PRENOM_ACHETEUR.StartsWith(textBoxPrenom.Text) : true) &&
                               (textBoxEmail.Text != "" ? a.EMAIL.StartsWith(textBoxEmail.Text) : true) &&
                             (textBoxVille.Text != "" ? a.IDVILLE == (from v in Accueil.modeleBase.VILLE
                                                                      where v.NOM_VILLE.Equals(textBoxVille.Text)
                                                                      select v.IDVILLE).FirstOrDefault() : true) &&
                            (textBoxFixe.Text != "" ? a.TÉLÉPHONE.ToString().StartsWith(textBoxFixe.Text) : true) &&
                             (textBoxMobile.Text != "" ? a.TÉLÉPHONE_MOBILE.ToString().StartsWith(textBoxMobile.Text) : true) &&
                                (textBoxCommercial.Text != "" ? a.COMMERCIAL.NOM_COMMERCIAL.StartsWith(textBoxCommercial.Text) : true)
                                && (a.DATE_CREATION <= dateTimeAjout.Value)

                             select a).ToList();
            }
        }

        public void recherche_vendeurs()
        {
            Requete_vendeurs();

            if (vendeurs.Count != 0)
                for (int i = 0; i < vendeurs.Count; i++)
                    afficher_resultats_vendeurs(i);
        }


        private void afficher_resultats_vendeurs(int i)
        {
            listView_resultat.Items.Add(vendeurs[i].IDVENDEUR.ToString()).SubItems.Add(vendeurs[i].NOM_VENDEUR);
            listView_resultat.Items[i].SubItems.Add(vendeurs[i].PRÉNOM_VENDEUR);
            listView_resultat.Items[i].SubItems.Add(vendeurs[i].EMAIL);
        }

        private void Requete_vendeurs()
        {
            vendeurs = (from v in Accueil.modeleBase.VENDEUR
                        where (textBoxNom.Text != "" ? v.NOM_VENDEUR.StartsWith(textBoxNom.Text) : true) &&
                        (textBoxPrenom.Text != "" ? v.PRÉNOM_VENDEUR.StartsWith(textBoxPrenom.Text) : true) &&
                          (textBoxEmail.Text != "" ? v.EMAIL.StartsWith(textBoxEmail.Text) : true) &&
                               (textBoxFixe.Text != "" ? v.TÉLÉPHONE_FIXE.ToString().StartsWith(textBoxFixe.Text) : true) &&
                              (textBoxMobile.Text != "" ? v.TÉLÉPHONE_MOBILE.ToString().StartsWith(textBoxMobile.Text) : true) &&
                            (textBoxVille.Text != "" ? v.IDVILLE == (from v2 in Accueil.modeleBase.VILLE
                                                                     where v2.NOM_VILLE.Equals(textBoxVille.Text)
                                                                     select v2.IDVILLE).FirstOrDefault() : true)
    && (v.DATE_CREATION <= dateTimeAjout.Value)
                        select v).ToList();
        }

        private void buttonLancerRecherche_Click(object sender, EventArgs e)
        {
            listView_resultat.Items.Clear();
            if (checkBox1_toutesFiches.Checked)
            {

                if (checkBox1_toutesFiches.Checked)
                {
                    acheteurs = (from a in Accueil.modeleBase.ACHETEUR
                                 select a).ToList();

                    fonction_recherche();
                    
                }

                else
                {
                    recherche_acheteurs_actifs();
                }

            }
            else
            {
                fonction_recherche();
            }





        }

        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            if (listView_resultat.SelectedItems.Count != 0)
            {

                if (typeClientChoisi == TypeClient.VENDEUR)
                {
                    int id_vendeur = int.Parse(listView_resultat.SelectedItems[0].SubItems[0].Text);

                    vendeur_en_cours_fc = (from v in Accueil.modeleBase.VENDEUR
                                           where v.IDVENDEUR == (short)id_vendeur
                                           select v).FirstOrDefault();

                    fenetreModificationClient = new AjoutClient(vendeur_en_cours_fc);
                    fenetreModificationClient.Show();
                }
                else
                {

                    int id_acheteur = int.Parse(listView_resultat.SelectedItems[0].SubItems[0].Text);

                    acheteur_en_cours_fc = (from v in Accueil.modeleBase.ACHETEUR
                                            where v.IDACHETEUR == (short)id_acheteur
                                            select v).FirstOrDefault();

                    fenetreModificationClient = new AjoutClient(acheteur_en_cours_fc);
                    fenetreModificationClient.Show();
                }

            }
            else
            {
                MessageBox.Show("Sélectionnez un client.");
            }
        }
        private void RechercherClient_Load(object sender, EventArgs e)
        {
            //vide et c'est normal
        }

        private void checkBox1_toutesFiches_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_toutesFiches.Checked)
            {
                buttonAcheteur.Enabled = false;
                buttonVendeur.Enabled = false;
                textBoxNom.Enabled = false;
                textBoxPrenom.Enabled = false;
                textBoxVille.Enabled = false;
                textBoxFixe.Enabled = false;
                textBoxMobile.Enabled = false;
                textBoxEmail.Enabled = false;
                dateTimeAjout.Enabled = false;
                textBoxCommercial.Enabled = false;
                buttonAcheteur.Font = new Font(buttonAcheteur.Font, FontStyle.Regular);
                buttonVendeur.Font = new Font(buttonVendeur.Font, FontStyle.Regular);
            }
            else
            {
                buttonAcheteur.Enabled = true;
                buttonVendeur.Enabled = false;
                textBoxNom.Enabled = true;
                textBoxPrenom.Enabled = true;
                textBoxVille.Enabled = true;
                textBoxFixe.Enabled = true;
                textBoxMobile.Enabled = true;
                textBoxEmail.Enabled = true;
                dateTimeAjout.Enabled = true;
                textBoxCommercial.Enabled = true;
            }
        }
    }
}
