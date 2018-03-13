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

        public static SuiteEntities modeleBase = new SuiteEntities();
        TypeClient typeClientChoisi = TypeClient.ACHETEUR;
        int ID_client_selectionne;
        List<ACHETEUR> acheteurs;
        List<VENDEUR> vendeurs;

        public enum TypeClient
        {
            VENDEUR, ACHETEUR
        }


        public RechercherClient()
        {
            InitializeComponent();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            fonction_recherche();

        }
        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

            fonction_recherche();
        }


        private void buttonAcheteur_Click(object sender, EventArgs e)
        {
            listView_resultat.Items.Clear();
            typeClientChoisi = TypeClient.ACHETEUR;
        }

        private void button_vendeur_Click(object sender, EventArgs e)
        {
            listView_resultat.Items.Clear();
            typeClientChoisi = TypeClient.VENDEUR;



            /*  List<string> villes = (from v in modeleBase.VILLE
                            select v.NOM_VILLE).ToList();

               foreach (string s in villes) Console.WriteLine(s); */


            /*       // Create a new Order object.
            VILLE ville = new VILLE()
            {
                IDVILLE = 12000,
                NOM_VILLE = "Seattle",
                CODE_POSTAL = 47500

            };
            modeleBase.VILLE.Add(ville); 



            // Submit the change to the database.
            try
            {
                modeleBase.SaveChanges();
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2);
                // Make some adjustments.
                // ...
                // Try again.
           //     modeleBase.SaveChanges(); 
            } */
        }


        public void fonction_recherche()
        {
            listView_resultat.Items.Clear();


            switch (typeClientChoisi)
            {
                case TypeClient.ACHETEUR:
                    recherche_acheteurs();
                    break;

                case TypeClient.VENDEUR:
                    recherche_vendeurs();
                    break;
            }


        }

        public void recherche_acheteurs()
        {
            acheteurs = (from a in modeleBase.ACHETEUR
                         where (textBoxNom.Text != "" ? a.NOM_ACHETEUR.StartsWith(textBoxNom.Text) : true) &&
                         (textBoxPrenom.Text != "" ? a.PRENOM_ACHETEUR.StartsWith(textBoxPrenom.Text) : true) &&
                           (textBoxEmail.Text != "" ? a.EMAIL.StartsWith(textBoxEmail.Text) : true) &&
                            (textBoxCommercial.Text != "" ? a.COMMERCIAL.NOM_COMMERCIAL.StartsWith(textBoxCommercial.Text) : true)
                         select a).ToList();

            if (acheteurs.Count != 0)
            {
                for (int i = 0; i < acheteurs.Count; i++)
                {
                    listView_resultat.Items.Add(acheteurs[i].IDACHETEUR.ToString()).SubItems.Add(acheteurs[i].NOM_ACHETEUR);
                    listView_resultat.Items[i].SubItems.Add(acheteurs[i].PRENOM_ACHETEUR);
                    listView_resultat.Items[i].SubItems.Add(acheteurs[i].EMAIL);
                }
            }
        }

        public void recherche_vendeurs()
        {
            vendeurs = (from v in modeleBase.VENDEUR
                        where (textBoxNom.Text != "" ? v.NOM_VENDEUR.StartsWith(textBoxNom.Text) : true) &&
                        (textBoxPrenom.Text != "" ? v.PRÉNOM_VENDEUR.StartsWith(textBoxPrenom.Text) : true) &&
                          (textBoxEmail.Text != "" ? v.EMAIL.StartsWith(textBoxEmail.Text) : true)


                        select v).ToList();

            if (vendeurs.Count != 0)
            {
                for (int i = 0; i < vendeurs.Count; i++)
                {

                    listView_resultat.Items.Add(vendeurs[i].IDVENDEUR.ToString()).SubItems.Add(vendeurs[i].NOM_VENDEUR);
                    listView_resultat.Items[i].SubItems.Add(vendeurs[i].PRÉNOM_VENDEUR);
                    listView_resultat.Items[i].SubItems.Add(vendeurs[i].EMAIL);
                }
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            fonction_recherche();
        }

        private void textBoxFixe_TextChanged(object sender, EventArgs e)
        {
            fonction_recherche();
        }

        private void textBoxCommercial_TextChanged(object sender, EventArgs e)
        {
            fonction_recherche();
        }

        private void listView_resultat_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView_resultat.SelectedItems.Count == 1)
            {
                if (typeClientChoisi == TypeClient.VENDEUR)
                {
                    ID_client_selectionne = vendeurs[0].IDVENDEUR;

                }
                else if (typeClientChoisi == TypeClient.ACHETEUR)
                {
                    ID_client_selectionne = acheteurs[0].IDACHETEUR;
                }


            }
            Console.WriteLine(ID_client_selectionne);
        }
    }
}
