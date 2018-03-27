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
    public partial class AjoutBien : Form
    {
        

        #region propriétés

        public VENDEUR monVendeur { get; set; }
        public ACHETEUR monAcheteur { get; set; }
        #endregion

        public AjoutBien()
        {
            InitializeComponent();
            
        }

        public AjoutBien(VENDEUR monVendeur)
        {
            this.monVendeur = monVendeur;
            InitializeComponent();
            this.nomClient.Text = monVendeur.NOM_VENDEUR;
            this.prénomVendeur.Text = monVendeur.PRÉNOM_VENDEUR;
            this.adresseVendeur.Text = monVendeur.ADRESSE_VENDEUR;

            var nomVille = (from v in Accueil.modeleBase.VILLE
                            where v.IDVILLE == monVendeur.VILLE.IDVILLE
                            select v.NOM_VILLE);

            this.villeVendeur.Text = nomVille.First();

            this.fixeVendeur.Text = monVendeur.TÉLÉPHONE_FIXE.ToString();
            this.mobileVendeur.Text = monVendeur.TÉLÉPHONE_MOBILE.ToString();
            this.emailVendeur.Text = monVendeur.EMAIL;
        }

        public AjoutBien(ACHETEUR monAcheteur)
        {
            this.monAcheteur = monAcheteur;
            InitializeComponent();
           
        }


        private void button5_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void nom_TextChanged(object sender, EventArgs e)
        {
            //var nomVendeur = (from v in Enfin.VENDEUR
            //                  where v.NOM_VENDEUR.StartsWith(this.nomVendeur.Text)
            //                  select v.NOM_VENDEUR);
            //this.nomVendeur.Text = nomVendeur.First();
        }

        private void button1_ajouterBien_Click(object sender, EventArgs e)
        {
            BIEN nouveauBien = new BIEN();

            var idville = (from v in Accueil.modeleBase.VILLE
                           where v.NOM_VILLE == textBox11_ville.Text
                           select v.IDVILLE);
            nouveauBien.IDVILLE = idville.First();

            var idvendeur = (from ve in Accueil.modeleBase.VENDEUR
                             where ve.EMAIL == emailVendeur.Text
                             select ve.IDVENDEUR);
            nouveauBien.IDVENDEUR = idvendeur.First();

            nouveauBien.SURFACE_HABITABLE = Int32.Parse(numericUpDown1_surfHab.Value.ToString());
            nouveauBien.SURFACE_PARCELLE = Int32.Parse(numericUpDown2_surfParc.Value.ToString());
            nouveauBien.NB_PIÈCES = Int32.Parse(numericUpDown3_nbPieces.ToString());
            nouveauBien.NB_CHAMBRES = Int32.Parse(numericUpDown4_nbChambres.ToString());
            nouveauBien.NB_SALLEDEBAIN = Int32.Parse(numericUpDown5_nbSdb.ToString());
            nouveauBien.PRIX_SOUHAITÉ = Int32.Parse(numericUpDown6_prix.ToString());

            if (checkBox1_garage.Checked)
            {
                nouveauBien.GARAGE = true;
            }
            if (checkBox2_cave.Checked)
            {
                nouveauBien.CAVE = true;
            }

            nouveauBien.ADRESSE_BIEN = textBox9_adresse.Text;
            


            nouveauBien.ZONE_DE_SAISIE = textBox12_commentaires.Text;
        }
    }
}
