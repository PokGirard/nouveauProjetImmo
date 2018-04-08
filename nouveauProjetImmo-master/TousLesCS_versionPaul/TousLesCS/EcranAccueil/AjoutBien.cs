using EcranAccueil;
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
    // BUG DES 2 COMBOBOX CORRIGE 
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
            blocageBoxVendeur(false);
            blocageBoxBien(false);

            this.bien_en_cours = bien_en_cours;

            actualisationBien();


            bienExisteDeja = true;
        }
        #endregion constructeurs
        private void blocageBoxBien(Boolean estModifiable)
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
            comboBox1_status.Enabled = estModifiable;
            comboBox2_villesBien.Enabled = estModifiable;
            //on peut supprimer et imprimer par contre
            button2_imprimerFiche.Enabled = !estModifiable;
            button3_supprimer.Enabled = !estModifiable;
            
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

            if(textBox12_commentaires.Text.Count() > 150)
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
                string ville1 = comboBox2_villesBien.Text.Replace(" ", string.Empty);
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
                                   where v.CODE_POSTAL.ToString() == codePostalVendeur.Text &&
                                    v.NOM_VILLE == comboBox1_villesClient.Text
                                   select v.IDVILLE).FirstOrDefault();


                    vendeur.IDVILLE = idville;
                    vendeur.CODE_POSTAL = Int32.Parse(codePostalVendeur.Text);
                    vendeur.NOM_VENDEUR = nomClient.Text;
                    vendeur.PRÉNOM_VENDEUR = prénomVendeur.Text;
                    vendeur.ADRESSE_VENDEUR = adresseVendeur.Text;
                    vendeur.EMAIL = emailVendeur.Text;

                    string a = fixeVendeur.Text.Replace(" ", string.Empty);
                    string b = mobileVendeur.Text.Replace(" ", string.Empty);
                    vendeur.TÉLÉPHONE_FIXE = Int32.Parse(a);
                    vendeur.TÉLÉPHONE_MOBILE = Int32.Parse(b);

                    vendeur.DATE_CREATION = dateTimePicker1_créationClient.Value;

                    try
                    {
                        Accueil.modeleBase.VENDEUR.Add(vendeur);
                        Accueil.modeleBase.SaveChanges();
                        MessageBox.Show("Le vendeur a bien été créé.");
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
                bien_en_modification.ADRESSE_BIEN = textBox9_adresse.Text;
                bien_en_modification.ZONE_DE_SAISIE = textBox12_commentaires.Text;
                bien_en_modification.CODE_POSTAL = Int32.Parse(textBox10_codePostal.Text);
                bien_en_modification.DATE_MISEENVENTE = dateTimePicker1_miseEnVente.Value;
                bien_en_modification.STATUT = comboBox1_status.Text;


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
                        MessageBox.Show(" Le bien a été ajouté dans la base.");
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
            bien_en_cours.STATUT = "RETIRE";
            Accueil.modeleBase.SaveChanges();
            actualisationBien();

        }

        private void actualisationBien()
        {
            this.comboBox1_status.Text = bien_en_cours.STATUT.Replace(" ", string.Empty);
            if (comboBox1_status.Text.Equals("RETIRE"))
            {
                button1_ajouterBien.Enabled = false;
            }
            this.nomClient.Text = bien_en_cours.VENDEUR.NOM_VENDEUR;
            this.prénomVendeur.Text = bien_en_cours.VENDEUR.PRÉNOM_VENDEUR;
            this.adresseVendeur.Text = bien_en_cours.VENDEUR.ADRESSE_VENDEUR;
            this.comboBox1_villesClient.Text = bien_en_cours.VENDEUR.VILLE.NOM_VILLE;
            this.codePostalVendeur.Text = bien_en_cours.VENDEUR.VILLE.CODE_POSTAL.ToString();
            this.fixeVendeur.Text = bien_en_cours.VENDEUR.TÉLÉPHONE_FIXE.ToString();
            this.mobileVendeur.Text = bien_en_cours.VENDEUR.TÉLÉPHONE_MOBILE.ToString();
            this.emailVendeur.Text = bien_en_cours.VENDEUR.EMAIL;

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
            this.textBox9_adresse.Text = bien_en_cours.ADRESSE_BIEN;
            this.textBox10_codePostal.Text = bien_en_cours.CODE_POSTAL.ToString();
            var ville = (from v in Accueil.modeleBase.VILLE
                         where v.IDVILLE == bien_en_cours.IDVILLE
                         select v.NOM_VILLE).FirstOrDefault();
            this.comboBox2_villesBien.Text = ville;
            this.dateTimePicker1_miseEnVente.Value = bien_en_cours.DATE_MISEENVENTE;
            this.textBox12_commentaires.Text = bien_en_cours.ZONE_DE_SAISIE;


        }

        private void button2_imprimerFiche_Click(object sender, EventArgs e)
        {
            FicheDuBien fiche = new FicheDuBien(bien_en_cours);
            fiche.Show();
        }

        private void codePostalVendeur_TextChanged(object sender, EventArgs e)
        {
            comboBox1_villesClient.Items.Clear();

            var nomVille = (from v in Accueil.modeleBase.VILLE
                            where v.CODE_POSTAL.ToString() == codePostalVendeur.Text
                            select v.NOM_VILLE);

            foreach (string ville in nomVille)
            {
                string villes_normales = ville.Replace(" ", string.Empty);
                comboBox1_villesClient.Items.Add(ville);
            }
        }

        private void textBox10_codePostal_TextChanged(object sender, EventArgs e)
        {
            comboBox2_villesBien.Items.Clear();

            var nomVille = (from v in Accueil.modeleBase.VILLE
                            where v.CODE_POSTAL.ToString() == textBox10_codePostal.Text
                            select v.NOM_VILLE);

            foreach (string ville in nomVille)
            {
                string villes_normales = ville.Replace(" ", string.Empty);
                comboBox2_villesBien.Items.Add(ville);
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
    }
}
