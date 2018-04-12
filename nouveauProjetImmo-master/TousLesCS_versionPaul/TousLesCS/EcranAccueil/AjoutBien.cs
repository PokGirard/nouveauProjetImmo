using EcranAccueil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcranAccueil
{
    
    public partial class AjoutBien : Form
    {


        #region propriétés
        public BIEN bien_en_cours { get; set; }
        private bool bienExisteDeja = false;
        private bool clientExisteDeja = false;
        public VENDEUR monVendeur { get; set; }
        public ACHETEUR monAcheteur { get; set; }
        #endregion

        #region constructeurs
        public AjoutBien()
        {
            InitializeComponent();
            this.button_voir_visites.Enabled = false;
        }

        public AjoutBien(VENDEUR monVendeur)
        {
            InitializeComponent();
            clientExisteDeja = true;
            this.titreFenetreAjoutBien.Text = "CREER UN BIEN";

            blocageBoxVendeur(false);

            this.monVendeur = monVendeur;
            this.comboBox1_status.Text = "DISPONIBLE";
            this.nomClient.Text = monVendeur.NOM_VENDEUR;
            this.prénomVendeur.Text = monVendeur.PRÉNOM_VENDEUR;
            this.adresseVendeur.Text = monVendeur.ADRESSE_VENDEUR;

            var maVille = (from v in Accueil.modeleBase.VILLE
                           where v.IDVILLE == monVendeur.IDVILLE
                           select v.NOM_VILLE).First();

            this.comboBox1_villesClient.Text = maVille;
            this.codePostalVendeur.Text = monVendeur.CODE_POSTAL.ToString();
            this.fixeVendeur.Text = monVendeur.TÉLÉPHONE_FIXE.ToString();
            this.mobileVendeur.Text = monVendeur.TÉLÉPHONE_MOBILE.ToString();
            this.emailVendeur.Text = monVendeur.EMAIL;
            this.dateTimePicker1_créationClient.Value = monVendeur.DATE_CREATION;


        }

        public AjoutBien(BIEN bien_en_cours)
        {
            InitializeComponent();

            this.titreFenetreAjoutBien.Text = "VOIR LE BIEN";
            this.button1_ajouterBien.Text = "MODIFIER LE BIEN";
            clientExisteDeja = true;
            this.bien_en_cours = bien_en_cours;
            blocageBoxVendeur(false);
            blocageBoxBien(false);
            actualisationBien();

            bienExisteDeja = true;
        }
        #endregion constructeurs
        private void blocageBoxBien(Boolean estModifiable)
        {
            if (bien_en_cours.STATUT != "RETIRE")
            {
                numericUpDown1_surfHab.Enabled = estModifiable;
                numericUpDown2_surfParc.Enabled = estModifiable;
                numericUpDown3_nbPieces.Enabled = estModifiable;
                numericUpDown4_nbChambres.Enabled = estModifiable;
                numericUpDown5_nbSdb.Enabled = estModifiable;
                numericUpDown6_prix.Enabled = estModifiable;
                textBox12_commentaires.Enabled = estModifiable;
                textBox9_adresse.Enabled = estModifiable;
                textBox10_codePostal.Enabled = estModifiable;
                checkBox1_garage.Enabled = estModifiable;
                checkBox2_cave.Enabled = estModifiable;

                comboBox2_villesBien.Enabled = estModifiable;
                //on peut supprimer et imprimer par contre
                //button2_imprimerFiche.Enabled = !estModifiable;
                button_voir_visites.Enabled = !estModifiable;
                button3_supprimer.Enabled = !estModifiable;
                button_voir_visites.Enabled = !estModifiable;
            }
            else
            {
                numericUpDown1_surfHab.Enabled = false;
                numericUpDown2_surfParc.Enabled = false;
                numericUpDown3_nbPieces.Enabled = false;
                numericUpDown4_nbChambres.Enabled = false;
                numericUpDown5_nbSdb.Enabled = false;
                numericUpDown6_prix.Enabled = false;
                textBox12_commentaires.Enabled = false;
                textBox9_adresse.Enabled = false;
                textBox10_codePostal.Enabled = false;
                checkBox1_garage.Enabled = false;
                checkBox2_cave.Enabled = false;

                comboBox2_villesBien.Enabled = false;
                //on peut supprimer et imprimer par contre
                //button2_imprimerFiche.Enabled = !estModifiable;
                button_voir_visites.Enabled = !estModifiable;
                button3_supprimer.Enabled = !estModifiable;
                button_voir_visites.Enabled = !estModifiable;

            }
            comboBox1_status.Enabled = estModifiable;

        }
        private void blocageBoxVendeur(bool estModifiable)
        {
            nomClient.Enabled = estModifiable;
            prénomVendeur.Enabled = estModifiable;
            adresseVendeur.Enabled = estModifiable;
            codePostalVendeur.Enabled = estModifiable;
            fixeVendeur.Enabled = estModifiable;
            mobileVendeur.Enabled = estModifiable;
            emailVendeur.Enabled = estModifiable;
            comboBox1_villesClient.Enabled = estModifiable;
        }
        private void button5_annuler_Click(object sender, EventArgs e)
        {
            if (button5_annuler.Text.Equals("ANNULER LES MODIFICATIONS"))
            {
                blocageBoxBien(false);
                button1_ajouterBien.Text = "MODIFIER LE BIEN";
                button5_annuler.Text = "RETOUR MENU";
                actualisationBien();
            }
            else this.Close();
        }

        private void button1_ajouterBien_Click(object sender, EventArgs e)
        {
            if (verifier_champs())
            {
                if (bien_en_cours == null && !bienExisteDeja)
                {
                    modification_ou_creation_bien();
                    button1_ajouterBien.Text = "MODIFIER LE BIEN";
                    blocageBoxBien(false);
                    MessageBox.Show("L'ajout du bien a été réalisé avec succès");
                    generation_mail();
                }
                else if (button1_ajouterBien.Text.Equals("MODIFIER LE BIEN"))
                {
                    blocageBoxBien(true);
                    button1_ajouterBien.Text = "VALIDER LES MODIFICATIONS";
                    button5_annuler.Text = "ANNULER LES MODIFICATIONS";
                }
                else
                {
                    modification_ou_creation_bien();
                    Accueil.modeleBase.SaveChanges();
                    blocageBoxBien(false);
                    button1_ajouterBien.Text = "MODIFIER LE BIEN";
                    button5_annuler.Text = "RETOUR MENU";
                    actualisationBien();
                    MessageBox.Show("Modifications sauvegardées");
                }
            }
        }

        #region verifications
        private bool verifier_champs()
        {
            bool valide = true;

            string message_erreur = "Informations manquantes : \nVeuillez renseigner les champs suivants :\n";

            if (!estNumerique(mobileVendeur) || mobileVendeur.Text.Count() == 0)
            {
                message_erreur += " --> Veuillez indiquer un numéro de mobile valide. \n";
                valide = false;
            }
            if (!estNumerique(fixeVendeur) || fixeVendeur.Text.Count() == 0)
            {
                message_erreur += " --> Veuillez indiquer un numéro fixe valide. \n";
                valide = false;
            }
            if (!estNumerique(codePostalVendeur) || codePostalVendeur.Text.Count() == 0)
            {
                message_erreur += " --> Veuillez indiquer un code postal client valide. \n";
                valide = false;
            }
            if (!estNumerique(textBox10_codePostal) || textBox10_codePostal.Text.Count() == 0)
            {
                message_erreur += " --> Veuillez indiquer un code postal du bien valide. \n";
                valide = false;
            }
            if (numericUpDown1_surfHab.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer une surface habitable \n";
                valide = false;
            }

            if (numericUpDown2_surfParc.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer une surface de parcelle. \n";
                valide = false;
            }


            if (numericUpDown3_nbPieces.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer un nombre de pièces. \n";
                valide = false;
            }

            if (numericUpDown4_nbChambres.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer un nombre de chambres. \n";
                valide = false;
            }

            if (numericUpDown5_nbSdb.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer un nombre de salles de bain. \n";
                valide = false;
            }

            if (numericUpDown6_prix.Value == 0)
            {
                message_erreur += " --> Veuillez indiquer un prix. \n";
                valide = false;
            }


            if (textBox9_adresse.Text == "" || textBox9_adresse.Text == null)
            {
                message_erreur += " --> Veuillez indiquer une adresse. \n";
                valide = false;
            }

            if (textBox10_codePostal.Text == "" || textBox10_codePostal.Text == null)
            {
                message_erreur += " --> Veuillez indiquer un code postal.\n";
                valide = false;
            }

            if (textBox12_commentaires.Text.Count() > 150)
            {
                message_erreur += " --> Veuillez réduire le nombre de caractères dans la section commentaires. \n";
                valide = false;
            }

            // vérifier si la ville est contenue dans la base

            if (comboBox2_villesBien.Text == "" || comboBox2_villesBien.Text == null)
            {
                message_erreur += " --> Veuillez indiquer une ville."; valide = false;
            }

            else
            {
                string ville1 = comboBox2_villesBien.Text.TrimEnd();
                int cp = int.Parse(textBox10_codePostal.Text); // vérifier si la ville est contenue dans la base 
                var ville = (from v in Accueil.modeleBase.VILLE
                             where v.NOM_VILLE == ville1 && v.CODE_POSTAL == cp
                             select v).FirstOrDefault();
            }


            if (!valide)
            {
                MessageBox.Show(message_erreur);

            }

            return valide;
        }

        private Boolean estNumerique(TextBox box)
        {
            bool isNumeric = true;
            foreach (char c in box.Text)
            {
                if (!Char.IsNumber(c))
                {
                    isNumeric = false;
                    break;
                }
            }
            return isNumeric;
        }

        #endregion verifications

        private void modification_ou_creation_bien()
        {
            BIEN bien_en_modification;
            if (verifier_champs())
            {
                if (!clientExisteDeja)
                {
                    VENDEUR vendeur = new VENDEUR();

                    var idville = (from v in Accueil.modeleBase.VILLE
                                   where v.CODE_POSTAL.ToString() == codePostalVendeur.Text.Trim() &&
                                    v.NOM_VILLE == comboBox1_villesClient.Text.Trim()
                                   select v.IDVILLE).FirstOrDefault();


                    vendeur.IDVILLE = idville;
                    vendeur.CODE_POSTAL = Int32.Parse(codePostalVendeur.Text.Trim());
                    vendeur.NOM_VENDEUR = nomClient.Text.Trim();
                    vendeur.PRÉNOM_VENDEUR = prénomVendeur.Text.Trim();
                    vendeur.ADRESSE_VENDEUR = adresseVendeur.Text.Trim();
                    vendeur.EMAIL = emailVendeur.Text.Trim();

                    string a = fixeVendeur.Text.Trim();
                    string b = mobileVendeur.Text.Trim();
                    vendeur.TÉLÉPHONE_FIXE = Int32.Parse(a);
                    vendeur.TÉLÉPHONE_MOBILE = Int32.Parse(b);

                    vendeur.DATE_CREATION = dateTimePicker1_créationClient.Value;

                    try
                    {
                        Accueil.modeleBase.VENDEUR.Add(vendeur);
                        Accueil.modeleBase.SaveChanges();
                        MessageBox.Show("Le vendeur a bien été créé.");
                        blocageBoxVendeur(false);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("erreur -- " + e1.Message);
                    }
                }
                if (!bienExisteDeja)
                {
                    bien_en_modification = new BIEN();

                    var idville = (from v in Accueil.modeleBase.VILLE
                                   where v.NOM_VILLE == comboBox2_villesBien.Text
                                   select v.IDVILLE);
                    bien_en_modification.IDVILLE = idville.First();


                    var idvendeur = (from ve in Accueil.modeleBase.VENDEUR
                                     where ve.EMAIL == emailVendeur.Text
                                     select ve.IDVENDEUR).FirstOrDefault();

                    bien_en_modification.IDVENDEUR = idvendeur;

                }
                else
                {
                    bien_en_modification = bien_en_cours;
                }
                bien_en_modification.SURFACE_HABITABLE = (int)numericUpDown1_surfHab.Value;
                bien_en_modification.SURFACE_PARCELLE = (int)numericUpDown2_surfParc.Value;
                bien_en_modification.NB_PIÈCES = (int)numericUpDown3_nbPieces.Value;
                bien_en_modification.NB_CHAMBRES = (int)numericUpDown4_nbChambres.Value;
                bien_en_modification.NB_SALLEDEBAIN = (int)numericUpDown5_nbSdb.Value;
                bien_en_modification.PRIX_SOUHAITÉ = (int)numericUpDown6_prix.Value;
                bien_en_modification.ADRESSE_BIEN = textBox9_adresse.Text.Trim();
                bien_en_modification.ZONE_DE_SAISIE = textBox12_commentaires.Text.Trim();
                bien_en_modification.CODE_POSTAL = Int32.Parse(textBox10_codePostal.Text.Trim());
                bien_en_modification.DATE_MISEENVENTE = dateTimePicker1_miseEnVente.Value;
                bien_en_modification.STATUT = comboBox1_status.Text.Trim();
                var idville2 = (from v in Accueil.modeleBase.VILLE
                               where v.NOM_VILLE == comboBox2_villesBien.Text.Trim() &&
                               v.CODE_POSTAL.ToString() == textBox10_codePostal.Text.Trim()
                                select v.IDVILLE);
                bien_en_modification.IDVILLE = idville2.First();


                if (checkBox1_garage.Checked) bien_en_modification.GARAGE = true;
                else bien_en_modification.GARAGE = false;

                if (checkBox2_cave.Checked) bien_en_modification.CAVE = true;
                else bien_en_modification.CAVE = false;

                if (!bienExisteDeja)
                {
                    try
                    {
                        Accueil.modeleBase.BIEN.Add(bien_en_modification);
                        bien_en_modification.NB_VISITES = 0;
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show(e2.Message);
                    }
                }

                Accueil.modeleBase.SaveChanges();
                bienExisteDeja = true;
                clientExisteDeja = true;
                bien_en_cours = bien_en_modification;
            }

        }

        private void button3_supprimer_Click(object sender, EventArgs e)
        {
            //code rajouté pour suppression du bien : compte des visites du bien

            if (confirmation())
            {
                var prop = (from pv in Accueil.modeleBase.PROPOSITION_VISITE
                            where pv.IDBIEN == bien_en_cours.IDBIEN
                            select pv.IDVISITE).Distinct().ToList();

                var rdv = (from r in Accueil.modeleBase.RDV
                           where prop.Contains(r.IDVISITE)
                           select r).Distinct().ToList();

                if (rdv.Count() == 0)
                {
                    if (prop.Count != 0)
                    {
                        foreach (int p in prop)
                        {
                            var proposition_a_supprimer = (from pv in Accueil.modeleBase.PROPOSITION_VISITE
                                                           where pv.IDBIEN == p
                                                           select pv).FirstOrDefault();

                            Accueil.modeleBase.PROPOSITION_VISITE.Remove(proposition_a_supprimer);
                        }
                    }
                    Accueil.modeleBase.BIEN.Remove(bien_en_cours);
                    Accueil.modeleBase.SaveChanges();
                    MessageBox.Show("Bien supprimé de la base.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Le bien n'a pu être supprimé car des rendez-vous lui sont associés.");
                }
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
        private void actualisationBien()
        {
            this.comboBox1_status.Text = bien_en_cours.STATUT.Trim();
            this.nomClient.Text = bien_en_cours.VENDEUR.NOM_VENDEUR.Trim();
            this.prénomVendeur.Text = bien_en_cours.VENDEUR.PRÉNOM_VENDEUR.Trim();
            this.adresseVendeur.Text = bien_en_cours.VENDEUR.ADRESSE_VENDEUR.Trim();
            this.comboBox1_villesClient.Text = bien_en_cours.VENDEUR.VILLE.NOM_VILLE.Trim();
            this.codePostalVendeur.Text = bien_en_cours.VENDEUR.VILLE.CODE_POSTAL.ToString();
            this.fixeVendeur.Text = bien_en_cours.VENDEUR.TÉLÉPHONE_FIXE.ToString();
            this.mobileVendeur.Text = bien_en_cours.VENDEUR.TÉLÉPHONE_MOBILE.ToString();
            this.emailVendeur.Text = bien_en_cours.VENDEUR.EMAIL.Trim();

            this.numericUpDown1_surfHab.Value = bien_en_cours.SURFACE_HABITABLE;
            this.numericUpDown2_surfParc.Value = bien_en_cours.SURFACE_PARCELLE;
            this.numericUpDown3_nbPieces.Value = bien_en_cours.NB_PIÈCES;
            this.numericUpDown4_nbChambres.Value = bien_en_cours.NB_CHAMBRES;
            this.numericUpDown5_nbSdb.Value = bien_en_cours.NB_SALLEDEBAIN;

            if (bien_en_cours.GARAGE)
                this.checkBox1_garage.Checked = true;
            if (bien_en_cours.CAVE)
                this.checkBox2_cave.Checked = true;
            this.numericUpDown6_prix.Value = bien_en_cours.PRIX_SOUHAITÉ;
            this.textBox9_adresse.Text = bien_en_cours.ADRESSE_BIEN.Trim();
            this.textBox10_codePostal.Text = bien_en_cours.CODE_POSTAL.ToString();
            var ville = (from v in Accueil.modeleBase.VILLE
                         where v.IDVILLE == bien_en_cours.IDVILLE
                         select v.NOM_VILLE).FirstOrDefault();
            this.comboBox2_villesBien.Text = ville.Trim();
            this.dateTimePicker1_miseEnVente.Value = bien_en_cours.DATE_MISEENVENTE;
            this.textBox12_commentaires.Text = bien_en_cours.ZONE_DE_SAISIE.Trim();


        }

        #region impression
        /*private void button2_imprimerFiche_Click(object sender, EventArgs e)
        {
            //GENERER FICHIER TEXTE A IMPRIMER(BON DE VISITE)
            string line1 = "FICHE DE DESCRIPTION DU BIEN :";
            string blank0 = " ";
            string line3 = "Adresse : " + bien_en_cours.ADRESSE_BIEN;
            string blank2 = " ";
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

            string[] texte = { line1, blank0, line3, blank2, line5, line6, line7, line8, line9, line10, line11 };
            File.WriteAllLines(@"c:\temp\FichedeBien.txt", texte);
            //IMPRESSION DU FICHIER TEXTE
            StreamReader Printfile;
            Font printFont = new Font("Times New Roman", 14.0f);
            using (Printfile = new StreamReader(@"c:\temp\FichedeBien.txt"))
            {
                try
                {
                    PrintDocument docToPrint = new PrintDocument();
                    docToPrint.DocumentName = "FichedeBien";
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
        }*/
        #endregion impression

        private void codePostalVendeur_TextChanged(object sender, EventArgs e)
        {
            comboBox1_villesClient.Items.Clear();

            var nomVille = (from v in Accueil.modeleBase.VILLE
                            where v.CODE_POSTAL.ToString() == codePostalVendeur.Text
                            select v.NOM_VILLE.Trim());

            foreach (string ville in nomVille)
            {
                string villes_normales = ville.Trim();
                comboBox1_villesClient.Items.Add(villes_normales);
            }
        }

        private void textBox10_codePostal_TextChanged(object sender, EventArgs e)
        {
            comboBox2_villesBien.Items.Clear();

            var nomVille = (from v in Accueil.modeleBase.VILLE
                            where v.CODE_POSTAL.ToString() == textBox10_codePostal.Text
                            select v.NOM_VILLE.Trim());

            foreach (string ville in nomVille)
            {
                string villes_normales = ville.Trim();
                comboBox2_villesBien.Items.Add(villes_normales);
            }
        }

        private void textBox12_commentaires_TextChanged(object sender, EventArgs e)
        {

            var listechar = textBox12_commentaires.Text.ToCharArray();
            int nbc = 0;
            foreach (char c in listechar)
            {
                nbc++;
            }
            label26.Text = "(" + (150 - nbc) + " caractères restants)";

        }

        private void generation_mail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("appli.immobilly@gmail.com");

            var mailCommerciaux = (from c in Accueil.modeleBase.COMMERCIAL
                                   select c.EMAIL).ToList();
            foreach (string email in mailCommerciaux)
            {
                mail.To.Add(email);
            }

            mail.Subject = "Un bien a été ajouté dans la base";
            mail.Body = "Un bien a été ajouté dans la base : \n";
            mail.Body += "Descriptif : " + bien_en_cours.NB_PIÈCES + " pièces -- " + bien_en_cours.PRIX_SOUHAITÉ + " € -- ( " + bien_en_cours.VILLE.NOM_VILLE.TrimEnd() + " ) ";
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("appli.immobilly@gmail.com", "immobilly2018");
            SmtpServer.EnableSsl = true;

            try
            {
                SmtpServer.Send(mail);
                MessageBox.Show("Mail envoyé aux commerciaux.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "Exception caught in CreateTestMessage1(): {0}",
                    ex.ToString());
            }
        }

        private void button_voir_visites_Click(object sender, EventArgs e)
        {
            VisitesBien affichage_visites = new VisitesBien(bien_en_cours);
            affichage_visites.Show();
        }
    }
}
