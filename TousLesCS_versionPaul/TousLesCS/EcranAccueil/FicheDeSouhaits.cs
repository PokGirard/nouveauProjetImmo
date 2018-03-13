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


    public partial class FicheDeSouhaits : Form
    {
        bool cave, garage;
        List<BIEN> biens;

        short IDAcheteur_courant = 8;


        public FicheDeSouhaits()
        {
            InitializeComponent();
        }

        private void button_creation_fiche_Click(object sender, EventArgs e)
        {


            // Create a new Order object.
            FICHE_DE_SOUHAITS nouvelleFiche = new FICHE_DE_SOUHAITS()
            {
                IDACHETEUR = IDAcheteur_courant,
                VILLE = textBoxVille.Text,
                SURFACE_HABITABLE = int.Parse(numericSurfaceHab.Value.ToString()),
                SURFACE_PARCELLE = int.Parse(numericSurfParcelle.Value.ToString()),
                CAVE = (cave ? true : false),
                GARAGE = (garage ? true : false),
                BUDGET = int.Parse(textBoxBudget.Text)

            };
            RechercherClient.modeleBase.FICHE_DE_SOUHAITS.Add(nouvelleFiche);


            // Submit the change to the database.
            try
            {
                RechercherClient.modeleBase.SaveChanges();
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2);

            }
        }

        private void buttonOuiCave_Click(object sender, EventArgs e)
        {
            cave = true;
        }

        private void buttonNonCave_Click(object sender, EventArgs e)
        {
            cave = false;
        }

        private void buttonOuiGarage_Click(object sender, EventArgs e)
        {
            garage = true;
        }

        private void buttonNonGarage_Click(object sender, EventArgs e)
        {
            garage = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            biens = (from b in RechercherClient.modeleBase.BIEN
                   //      where (textBoxNom.Text != "" ? b.NOM_ACHETEUR.StartsWith(textBoxNom.Text) : true) &&
                        
                         select b).ToList();

            if (biens.Count != 0)
            {
                for (int i = 0; i < biens.Count; i++)
                {
                    listView_resultats.Items.Add(biens[i].SURFACE_PARCELLE.ToString()).SubItems.Add(biens[i].SURFACE_HABITABLE.ToString());
                  

                    //    listView_resultat.Items[i].SubItems.Add(acheteurs[i].PRENOM_ACHETEUR);
                    //  listView_resultat.Items[i].SubItems.Add(acheteurs[i].EMAIL);
                }
            }
        }

        private void textBoxVille_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
