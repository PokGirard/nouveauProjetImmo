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

        static AjoutClient fenetreModificationClient;

       
        TypeClient typeClientChoisi = TypeClient.ACHETEUR;
        int ID_client_selectionne;
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
        }

        private void button_vendeur_Click(object sender, EventArgs e)
        {
            typeClientChoisi = TypeClient.VENDEUR;
        }


        public void fonction_recherche()
        {
            listView_resultat.Items.Clear();

            if (typeClientChoisi == TypeClient.ACHETEUR) recherche_acheteurs();
            else recherche_vendeurs();

        }

        public void recherche_acheteurs()
        {
            Requete_acheteurs();

            if (acheteurs.Count != 0)

                for (int i = 0; i < acheteurs.Count; i++)

                    afficher_resultats_acheteurs(i);

        }

        private void afficher_resultats_acheteurs(int i)
        {
            listView_resultat.Items.Add(acheteurs[i].IDACHETEUR.ToString()).SubItems.Add(acheteurs[i].NOM_ACHETEUR);
            listView_resultat.Items[i].SubItems.Add(acheteurs[i].PRENOM_ACHETEUR);
            listView_resultat.Items[i].SubItems.Add(acheteurs[i].EMAIL);
        }

        private void Requete_acheteurs()
        {
            acheteurs = (from a in Accueil.modeleBase.ACHETEUR
                         where (textBoxNom.Text != "" ? a.NOM_ACHETEUR.StartsWith(textBoxNom.Text) : true) &&
                         (textBoxPrenom.Text != "" ? a.PRENOM_ACHETEUR.StartsWith(textBoxPrenom.Text) : true) &&
                           (textBoxEmail.Text != "" ? a.EMAIL.StartsWith(textBoxEmail.Text) : true) &&
                         (textBoxVille.Text != "" ? a.IDVILLE == (from v in Accueil.modeleBase.VILLE
                                                                  where v.NOM_VILLE.Equals(textBoxVille.Text)
                                                                  select v.IDVILLE).FirstOrDefault() : true) &&
                        (textBoxFixe.Text != "" ? a.TÉLÉPHONE.ToString().StartsWith(textBoxFixe.Text) : true) &&
                            (textBoxCommercial.Text != "" ? a.COMMERCIAL.NOM_COMMERCIAL.StartsWith(textBoxCommercial.Text) : true)
                            && (a.DATE_CREATION <= dateTimeAjout.Value)
                         select a).ToList();
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
            fonction_recherche();
        }

        private void buttonModifierClient_Click(object sender, EventArgs e)
        {

            if (typeClientChoisi == TypeClient.VENDEUR)
            {
                vendeur_en_cours_fc = (from v in Accueil.modeleBase.VENDEUR
                                       where v.IDVENDEUR == /*Convert.ToInt16(*/ID_client_selectionne//)
                                       select v
                                       ).First();
                fenetreModificationClient = new AjoutClient(vendeur_en_cours_fc);
            }
            else
            {
                acheteur_en_cours_fc = (from a in Accueil.modeleBase.ACHETEUR
                                        where a.IDACHETEUR == /*Convert.ToInt16(*/ID_client_selectionne//)
                                        select a).First();
                //fenetreModificationClient = new AjoutClient(acheteur_en_cours_fc);
            }
            


        }

        private void listView_resultat_Click(object sender, EventArgs e)
        {
            
                if (typeClientChoisi == TypeClient.VENDEUR)
                {
                    ID_client_selectionne = vendeurs[0].IDVENDEUR;

                }
                else if (typeClientChoisi == TypeClient.ACHETEUR)
                {
                    ID_client_selectionne = acheteurs[0].IDACHETEUR;
                }
            
            Console.WriteLine(ID_client_selectionne);
        }
    }
}
