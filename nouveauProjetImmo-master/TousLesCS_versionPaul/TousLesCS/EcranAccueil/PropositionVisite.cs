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

        public BIEN bien_en_cours { get; set; }

        public COMMERCIAL commercial_fenetre_proposition { get; set; }

        public FICHE_DE_SOUHAITS fiche_en_cours { get; set; }


        #endregion

        public PropositionVisite()
        {
            InitializeComponent();
        }

        public PropositionVisite(FICHE_DE_SOUHAITS fiche_en_cours, BIEN bien_en_cours, COMMERCIAL commercial_en_cours)
        {
            this.fiche_en_cours = fiche_en_cours;
            this.bien_en_cours = bien_en_cours;
            commercial_fenetre_proposition = commercial_en_cours;
            InitializeComponent();
            Initialisation_des_champs();

        }

        private void Initialisation_des_champs()
        {
            textBoxNomClient.Text = fiche_en_cours.ACHETEUR.NOM_ACHETEUR;
            textBoxPrenomClient.Text = fiche_en_cours.ACHETEUR.PRENOM_ACHETEUR;
            textBoxDesignation.Text = bien_en_cours.NB_PIÈCES + " pièces -- " + bien_en_cours.PRIX_SOUHAITÉ + " € -- ( " + bien_en_cours.VILLE.NOM_VILLE + " ) ";
            textBoxAdresse.Text = bien_en_cours.ADRESSE_BIEN;
            commercial_fenetre_proposition.NOM_COMMERCIAL = commercial_fenetre_proposition.NOM_COMMERCIAL.Replace(" ", string.Empty);
            textBoxCommercial.Text = commercial_fenetre_proposition.NOM_COMMERCIAL;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCréer_Click(object sender, EventArgs e)
        {

            if(dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("La date choisie ne peut être antérieure à aujourd'hui.");
                return;
            }

            PROPOSITION_VISITE proposition = new PROPOSITION_VISITE()
            {
                IDFICHESOUHAITS = fiche_en_cours.IDFICHESOUHAITS,
                IDBIEN = bien_en_cours.IDBIEN,
                DATERDV = dateTimePicker1.Value
            };

            Accueil.modeleBase.PROPOSITION_VISITE.Add(proposition);

            try
            {
                Accueil.modeleBase.SaveChanges();
                MessageBox.Show("La proposition de visite a bien été créée");
                Close();
            }
            catch (Exception e9)
            {
                MessageBox.Show("erreur");
            }

        }

     
    }
}
