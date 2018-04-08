using System;
using System.Windows.Forms;

namespace EcranAccueil
{
    public partial class Accueil : Form
    {
        public static basefinaleEntities modeleBase = new basefinaleEntities();
        public Accueil()
        {
            InitializeComponent();
        }

        private void button_gestion_des_clients_Click(object sender, EventArgs e)
        {
            FenetreChoix fenetreChoix = new FenetreChoix();
            fenetreChoix.Show();
            //this.Hide();

        }

        private void button_ajouter_bien_catalogue_Click(object sender, EventArgs e)
        {
            AjoutBien ajoutMaison = new AjoutBien();
            ajoutMaison.Show();
            //this.Hide();
        }

        private void button_gestion_des_commerciaux_Click(object sender, EventArgs e)
        {
            VueCommerciaux commerciaux = new VueCommerciaux();
            commerciaux.Show();
        }

        private void button_catalogue_Click(object sender, EventArgs e)
        {
            CatalogueBiens catalogue = new CatalogueBiens();
            catalogue.Show();
        }
    }
}
