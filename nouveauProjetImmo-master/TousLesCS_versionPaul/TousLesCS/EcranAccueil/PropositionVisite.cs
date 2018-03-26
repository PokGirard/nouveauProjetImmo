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
    public partial class PropositionVisite : Form
    {


        #region proprietes

        public BIEN bien_fenetre_proposition { get; set; }

        public COMMERCIAL commercial_fenetre_proposition { get; set; }

        public FICHE_DE_SOUHAITS Fiche_fenetre_proposition { get; set; }


        #endregion

        public PropositionVisite()
        {
            InitializeComponent();
        }

        public PropositionVisite(FICHE_DE_SOUHAITS fiche_en_cours, BIEN bien_en_cours, COMMERCIAL commercial_en_cours)
        {
            Fiche_fenetre_proposition = fiche_en_cours;
            bien_fenetre_proposition = bien_en_cours;
            commercial_fenetre_proposition = commercial_en_cours;
            InitializeComponent();
            Initialisation_des_champs();

        }

        private void Initialisation_des_champs()
        {
            textBoxNomClient.Text = Fiche_fenetre_proposition.ACHETEUR.NOM_ACHETEUR;
            textBoxPrenomClient.Text = Fiche_fenetre_proposition.ACHETEUR.PRENOM_ACHETEUR;
            textBoxAdresse.Text = Fiche_fenetre_proposition.ACHETEUR.ADRESSE;
            commercial_fenetre_proposition.NOM_COMMERCIAL = commercial_fenetre_proposition.NOM_COMMERCIAL.Replace(" ", string.Empty);
            textBoxCommercial.Text = commercial_fenetre_proposition.NOM_COMMERCIAL;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCréer_Click(object sender, EventArgs e)
        {
            PROPOSITION_VISITE proposition = new PROPOSITION_VISITE()
            {
                IDFICHESOUHAITS = Fiche_fenetre_proposition.IDFICHESOUHAITS,
                IDBIEN = bien_fenetre_proposition.IDBIEN,
                DATERDV = dateTimePicker1.Value
            };



            RechercherClient.modeleBase.PROPOSITION_VISITE.Add(proposition);

            try
            {
                RechercherClient.modeleBase.SaveChanges();
            }
            catch (Exception e9)
            {
                MessageBox.Show("erreur");
            }

        }
    }
}
