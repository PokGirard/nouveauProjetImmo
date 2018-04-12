using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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

        public string commercial_fenetre_proposition;

        public FICHE_DE_SOUHAITS fiche_en_cours { get; set; }


        #endregion

        public PropositionVisite()
        {
            InitializeComponent();
        }

        public PropositionVisite(FICHE_DE_SOUHAITS fiche_en_cours, BIEN bien_en_cours)
        {
            this.fiche_en_cours = fiche_en_cours;
            this.bien_en_cours = bien_en_cours;

            int idcommercial = fiche_en_cours.ACHETEUR.IDCOMMERCIAL;
            var nomCommercial = (from c in Accueil.modeleBase.COMMERCIAL
                                 where c.IDCOMMERCIAL == idcommercial
                                 select c).ToList();
            commercial_fenetre_proposition = nomCommercial[0].NOM_COMMERCIAL;
     
            InitializeComponent();
            Initialisation_des_champs();

        }

        private void Initialisation_des_champs()
        {

            textBoxNomClient.Text = fiche_en_cours.ACHETEUR.NOM_ACHETEUR;
            textBoxPrenomClient.Text = fiche_en_cours.ACHETEUR.PRENOM_ACHETEUR;
            textBoxDesignation.Text = bien_en_cours.NB_PIÈCES + " pièces -- " + bien_en_cours.PRIX_SOUHAITÉ + " € -- ( " + bien_en_cours.VILLE.NOM_VILLE.TrimEnd() + " ) ";
            textBoxAdresse.Text = bien_en_cours.ADRESSE_BIEN;
            textBoxCommercial.Text = commercial_fenetre_proposition;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCréer_Click(object sender, EventArgs e)
        {

            if(dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("La date choisie ne peut être antérieure ou égale à aujourd'hui.");
                return;
            }

            PROPOSITION_VISITE proposition = new PROPOSITION_VISITE()
            {
                IDFICHESOUHAITS = fiche_en_cours.IDFICHESOUHAITS,
                IDBIEN = bien_en_cours.IDBIEN,
                DATERDV = dateTimePicker1.Value,
                STATUT_PROPOSITION = "EN ATTENTE"
            };
           
            Accueil.modeleBase.PROPOSITION_VISITE.Add(proposition);

            try
            {
                Accueil.modeleBase.SaveChanges();
                MessageBox.Show("La proposition de visite a bien été créée");
                impression_fiche_bien();
                this.Close();
            }
            catch (Exception e9)
            {
                MessageBox.Show("erreur");
            }

        }

        private void impression_fiche_bien()
        {
            //GENERER FICHIER TEXTE A IMPRIMER(BON DE VISITE)
            string line1 = "PROPOSITION DE VISITE POUR LE BIEN :";
            string blank = " ";
            string line2 = "" + textBoxDesignation.Text.TrimEnd();
            
            string line3 = "Adresse : " + textBoxAdresse.Text.TrimEnd();
        
            string line5 = "Surface habitable : \t" + bien_en_cours.SURFACE_HABITABLE;
            string line6 = "Surface parcelle : \t" + bien_en_cours.SURFACE_PARCELLE;
            string line7 = "Nb pièces : \t" + bien_en_cours.NB_PIÈCES;
            string line8 = "Nb chambres : \t" + bien_en_cours.NB_CHAMBRES;
            string line9 = "Nb Salle de bain : \t" + bien_en_cours.NB_SALLEDEBAIN;
            string line10 = "Garage : \t";
            if (bien_en_cours.GARAGE == true) { line10 += "oui"; }
            else { line10 += "non"; }
            string line11 = "Cave : \t";
            if (bien_en_cours.CAVE == true) { line11 += "oui"; }
            else { line11 += "non"; }
  
            string line12 = "Prix souhaité : \t" + bien_en_cours.PRIX_SOUHAITÉ;

            string[] texte = { line1, blank, line2, blank, line3, blank, line5, line6, line7, line8, line9, line10, line11, blank, line12};
            File.WriteAllLines(@"c:\temp\propositionVisite.txt", texte);
            //IMPRESSION DU FICHIER TEXTE
            StreamReader Printfile;
            Font printFont = new Font("Times New Roman", 14.0f);
            using (Printfile = new StreamReader(@"c:\temp\propositionVisite.txt"))
            {
                try
                {
                    PrintDocument docToPrint = new PrintDocument();
                    docToPrint.DocumentName = "propositionVisite";
                    docToPrint.PrintPage += (s, ev) =>
                    {
                        float linesPerPage = 0;
                        float yPos = 0;
                        int count = 0;
                        float leftMargin = ev.MarginBounds.Left;
                        float topMargin = ev.MarginBounds.Top;
                        string line = null;


                        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);


                        while (count < linesPerPage && ((line = Printfile.ReadLine()) != null))
                        {
                            yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                            ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                            count++;
                        }


                        if (line != null)
                            ev.HasMorePages = true;
                        else
                            ev.HasMorePages = false;
                    };
                    docToPrint.Print();
                }
                catch (System.Exception f)
                {
                    MessageBox.Show(f.Message);
                }
            }
        }
     
    }
}
