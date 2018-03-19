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
    public partial class VueCommerciaux : Form
    {
        public VueCommerciaux()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /* VENDEUR vendeur = new VENDEUR();

 var idville = (from v in Enfin.VILLE
                where v.NOM_VILLE == ville.Text
                select v.IDVILLE);

 vendeur.IDVILLE = idville.First();
 vendeur.NOM_VENDEUR = nom.Text;
 vendeur.PRÉNOM_VENDEUR = prénom.Text;
 vendeur.ADRESSE_VENDEUR = adresse.Text;
 vendeur.CODE_POSTAL = Int32.Parse(codePostal.Text);
 vendeur.VILLE = ville.Text;
 vendeur.EMAIL = email.Text;
 vendeur.TÉLÉPHONE_FIXE = Int32.Parse(fixe.Text);
 vendeur.TÉLÉPHONE_MOBILE = Int32.Parse(mobile.Text);

 modeleBase.COMMERCIAL.Add(commercial);
 modeleBase.SaveChanges();
 */
            COMMERCIAL commercial = new COMMERCIAL();
            commercial.NOM_COMMERCIAL = nom.Text;
            commercial.PRENOM_COMMERCIAL = prenom.Text;
            commercial.EMAIL = email.Text;
            commercial.TÉLÉPHONE_MOBILE_PRO = Int32.Parse(portablePro.Text);
            commercial.TÉLÉPHONE_FIXE_PRO = Int32.Parse(fixePro.Text);
            commercial.TÉLÉPHONE_PERSONNEL = Int32.Parse(telephonePerso.Text);
            commercial.EMAIL = email.Text;
            commercial.STATUT_COMMERCIAL = "actif";

            modeleBase.COMMERCIAL.Add(commercial);
            modeleBase.SaveChanges();
        }
        public SuiteEntities modeleBase = new SuiteEntities();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nomCommerciaux = (from c in modeleBase.COMMERCIAL
                                  select c.NOM_COMMERCIAL);
            foreach (string nom in nomCommerciaux)
            {
                listBox1.Items.Add(nom);
            }
            Refresh();
        }
    }
}
