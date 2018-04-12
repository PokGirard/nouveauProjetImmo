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
            textBoxDesignation.Text = bien_en_cours.NB_PIÈCES + " pièces -- " + bien_en_cours.PRIX_SOUHAITÉ + " € -- ( " + bien_en_cours.VILLE.NOM_VILLE.TrimEnd() + " ) ";
            textBoxAdresse.Text = bien_en_cours.ADRESSE_BIEN;
            commercial_fenetre_proposition.NOM_COMMERCIAL = commercial_fenetre_proposition.NOM_COMMERCIAL.TrimEnd();
            textBoxCommercial.Text = commercial_fenetre_proposition.NOM_COMMERCIAL;
            dateTimePicker1.Value = proposition_selectionnee.DATERDV;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }


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
            }
            catch (Exception e1)
            {
                MessageBox.Show(" erreur lors de la mise à jour " + e1.Message);
            }

            Close();
        }

        //Bitmap bmp;

        private void imprimerFiche(object sender, EventArgs e)
        {
            //GENERER FICHIER TEXTE A IMPRIMER(BON DE VISITE)
            string line0 = "IMMOBILLY";
            string blank = " ";
            string line1 = "BON DE VISITE";

            string linecodecivil1 = "Dans le cadre de sa mission d’intermédiaire (prévue par la loi Hoguet et plus";
            string linecodecivil2 = "particulièrement par le Code Civil article 1993), Immobilly rend compte";
            string linecodecivil3 = "systématiquement de ses visites à ses mandats.";
            string linecodecivil4 = "A ce titre, et pour respecter nos engagements, nous vous remercions de bien";
            string linecodecivil5 = "vouloir compléter ce document.";

            string lineclient = "CLIENT :";
            string line2 = "Madame, Monsieur " + textBoxNomClient.Text.TrimEnd() + " " + textBoxPrenomClient.Text.TrimEnd();
            string line3 = "Résidant : " + acheteur_en_cours.ADRESSE.TrimEnd() + ", " + acheteur_en_cours.CODE_POSTAL + ", " + acheteur_en_cours.VILLE;
            string line4 = "Date : " + proposition_selectionnee.DATERDV;

            string line5 = "Par l'intermédiaire de M/Mme : " + commercial_fenetre_proposition.NOM_COMMERCIAL.TrimEnd() + " " + commercial_fenetre_proposition.PRENOM_COMMERCIAL.TrimEnd();
            string line6 = "mandataire immobilier pour le compte de la SARL IMMO BAXTER";

            string linebien = "BIEN :";
            string line7 = "Pour le bien " + textBoxDesignation.Text.TrimEnd();
            string line8 = "Situé : " + textBoxAdresse.Text.TrimEnd() + ", " + bien_en_cours.CODE_POSTAL + ", " + bien_en_cours.VILLE;

            string line9 = "Pour valoir ce que de droit, ";
            string line10 = "Fait à ..............., le ..../..../....";


            string line11 = "Le Visiteur                                        Le mandataire";

            string[] texte = { line0, blank, line1, blank, linecodecivil1,linecodecivil2, linecodecivil3, linecodecivil4, linecodecivil5, blank, lineclient, line2, line3, line4, blank, line5, line6, blank, linebien, line7, line8, blank, line9, line10, blank, line11 };
            File.WriteAllLines(@"c:\temp\bonDeVisite.txt", texte);
            //IMPRESSION DU FICHIER TEXTE
            StreamReader Printfile;
            Font printFont = new Font("Times New Roman", 14.0f);
            using (Printfile = new StreamReader(@"c:\temp\bonDeVisite.txt"))
            {
                try
                {
                    PrintDocument docToPrint = new PrintDocument();
                    docToPrint.DocumentName = "BonDeVisite";
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

        /*
        Graphics g = this.CreateGraphics();
        bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
        Graphics mg = Graphics.FromImage(bmp);
        mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
        printPreviewDialog1.ShowDialog();*/


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}

