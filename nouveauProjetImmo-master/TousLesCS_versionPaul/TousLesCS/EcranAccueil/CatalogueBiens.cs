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
    public partial class CatalogueBiens : Form
    {
        BIEN bien;
        EtatBien etatRecherché = EtatBien.DISPONIBLE;
        public CatalogueBiens()
        {
            InitializeComponent();
            remplir_listeview();
        }

        private enum EtatBien { DISPONIBLE, SOUSSEING, VENDU, RETIRE }

        private void disponible_Click(object sender, EventArgs e)
        {
            etatRecherché = EtatBien.DISPONIBLE;
            remplir_listeview();
            disponible_button.Font = new Font(disponible_button.Font, FontStyle.Bold);
            sous_seing_button.Font = new Font(sous_seing_button.Font, FontStyle.Regular);
            vendu_button.Font = new Font(vendu_button.Font, FontStyle.Regular);
            archive_button.Font = new Font(archive_button.Font, FontStyle.Regular);
        }

        private void sous_seing_button_Click(object sender, EventArgs e)
        {
            etatRecherché = EtatBien.SOUSSEING;
            remplir_listeview();
            disponible_button.Font = new Font(disponible_button.Font, FontStyle.Regular);
            sous_seing_button.Font = new Font(sous_seing_button.Font, FontStyle.Bold);
            vendu_button.Font = new Font(vendu_button.Font, FontStyle.Regular);
            archive_button.Font = new Font(archive_button.Font, FontStyle.Regular);
        }

        private void vendu_button_Click(object sender, EventArgs e)
        {
            etatRecherché = EtatBien.VENDU;
            remplir_listeview();
            disponible_button.Font = new Font(disponible_button.Font, FontStyle.Regular);
            sous_seing_button.Font = new Font(sous_seing_button.Font, FontStyle.Regular);
            vendu_button.Font = new Font(vendu_button.Font, FontStyle.Bold);
            archive_button.Font = new Font(archive_button.Font, FontStyle.Regular);
        }

        private void archive_button_Click(object sender, EventArgs e)
        {
            etatRecherché = EtatBien.RETIRE;
            remplir_listeview();
            disponible_button.Font = new Font(disponible_button.Font, FontStyle.Regular);
            sous_seing_button.Font = new Font(sous_seing_button.Font, FontStyle.Regular);
            vendu_button.Font = new Font(vendu_button.Font, FontStyle.Regular);
            archive_button.Font = new Font(archive_button.Font, FontStyle.Bold);
        }

        private void remplir_listeview()
        {
            listViewbiens.Items.Clear();
            string etatbienrecherche = "";
            switch (etatRecherché)
            {
                case EtatBien.DISPONIBLE:
                    etatbienrecherche += "DISPONIBLE";
                    break;
                case EtatBien.SOUSSEING:
                    etatbienrecherche += "SOUS-SEING";
                    break;
                case EtatBien.VENDU:
                    etatbienrecherche += "VENDU";
                    break;
                case EtatBien.RETIRE:
                    etatbienrecherche += "RETIRE";
                    break;

            }

            List<BIEN> biens = (from b in Accueil.modeleBase.BIEN
                                where (b.STATUT == etatbienrecherche)
                                select b).ToList();

            if (biens.Count != 0)
            {
                for (int i = 0; i < biens.Count; i++)
                {
                    var numVille = biens[i].IDVILLE;

                    string nomVille = (from v in Accueil.modeleBase.VILLE
                                       where (v.IDVILLE == numVille)
                                       select v.NOM_VILLE).First().ToString();
                    nomVille = nomVille.Replace(" ", string.Empty);
                    listViewbiens.Items.Add(nomVille).SubItems.Add(biens[i].PRIX_SOUHAITÉ.ToString());

                    listViewbiens.Items[i].SubItems.Add(biens[i].SURFACE_PARCELLE.ToString());
                    listViewbiens.Items[i].SubItems.Add(biens[i].SURFACE_HABITABLE.ToString());
                    listViewbiens.Items[i].SubItems.Add(biens[i].NB_PIÈCES.ToString());
                    listViewbiens.Items[i].SubItems.Add(biens[i].GARAGE == true ? "Oui" : "Non");
                    listViewbiens.Items[i].SubItems.Add(biens[i].CAVE == true ? "Oui" : "Non");
                }
            }
        }

        private void voir_bien_button_Click(object sender, EventArgs e)
        {

        }
    }
}
