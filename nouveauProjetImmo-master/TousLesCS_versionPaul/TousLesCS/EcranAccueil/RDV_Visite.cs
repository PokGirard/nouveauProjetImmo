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
    public partial class RDV_Visite : Form
    {

        public PROPOSITION_VISITE proposition_selectionnee { get; set; }
        public BIEN bien_en_cours { get; set; }

        public COMMERCIAL commercial_fenetre_proposition { get; set; }

        public FICHE_DE_SOUHAITS fiche_en_cours { get; set; }
        public ACHETEUR acheteur_en_cours { get; set; }
        public RDV_Visite()
        {
            InitializeComponent();
        }

        public RDV_Visite(PROPOSITION_VISITE proposition_en_cours)
        {
            proposition_selectionnee = proposition_en_cours;
            bien_en_cours = proposition_selectionnee.BIEN;
            acheteur_en_cours = proposition_selectionnee.FICHE_DE_SOUHAITS.ACHETEUR;
            commercial_fenetre_proposition = proposition_selectionnee.FICHE_DE_SOUHAITS.ACHETEUR.COMMERCIAL;
            InitializeComponent();
            Initialisation_des_champs();
        }

        private void Initialisation_des_champs()
        {
            textBoxNomClient.Text = acheteur_en_cours.NOM_ACHETEUR;
            textBoxPrenomClient.Text = acheteur_en_cours.PRENOM_ACHETEUR;
            textBoxDesignation.Text = bien_en_cours.NB_PIÈCES + " pièces -- " + bien_en_cours.PRIX_SOUHAITÉ + " € -- ( " + bien_en_cours.VILLE.NOM_VILLE + " ) ";
            textBoxAdresse.Text = bien_en_cours.ADRESSE_BIEN;
            commercial_fenetre_proposition.NOM_COMMERCIAL = commercial_fenetre_proposition.NOM_COMMERCIAL.Replace(" ", string.Empty);
            textBoxCommercial.Text = commercial_fenetre_proposition.NOM_COMMERCIAL;
            dateTimePicker1.Value = proposition_selectionnee.DATERDV;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

     /*   private void buttonCréer_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value < DateTime.Now)
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

        } */

        private void buttonAnnuler_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCréer_Click_1(object sender, EventArgs e)
        {

            RDV rdv = new RDV
            {
                IDVISITE = proposition_selectionnee.IDVISITE
                
            };

            Accueil.modeleBase.RDV.Add(rdv);
            Accueil.modeleBase.SaveChanges();
            MessageBox.Show(" Le rdv a bien été confirmé.");

            imprimerFiche(sender, e);

            // mise à jour du statut de la proposition de visite 

            var prop = (from p in Accueil.modeleBase.PROPOSITION_VISITE
                        where p.IDVISITE == proposition_selectionnee.IDVISITE
                        select p).FirstOrDefault();

            prop.STATUT_PROPOSITION = "ACCEPTEE";


            try
            {
                Accueil.modeleBase.SaveChanges();
            } catch(Exception e1)
            {
                MessageBox.Show(" erreur lors de la mise à jour " + e1.Message);
            }

            Close();
        }

        Bitmap bmp;

        private void imprimerFiche(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
