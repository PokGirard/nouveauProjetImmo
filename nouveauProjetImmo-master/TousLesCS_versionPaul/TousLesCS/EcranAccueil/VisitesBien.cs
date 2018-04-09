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
    public partial class VisitesBien : Form
    {
        BIEN bien_en_cours;
        public VisitesBien(BIEN bien_en_cours)
        {
            InitializeComponent();
            this.bien_en_cours = bien_en_cours;
            charger_liste_visites();
        }

        private void charger_liste_visites()
        {
            //a remplir


            // 1 -- trouver tous les rdv correspondants

            var prop = (from pv in Accueil.modeleBase.PROPOSITION_VISITE
                        where pv.IDBIEN == bien_en_cours.IDBIEN &&
                         pv.STATUT_PROPOSITION.Replace(" ", string.Empty) == "ACCEPTEE" // facultatif
                        select pv.IDVISITE).ToList();

            var id_rdv = (from r in Accueil.modeleBase.RDV
                          where prop.Contains(r.IDVISITE)
                          select r).ToList();


            if (id_rdv.Count != 0)
            {

                for (int i = 0; i < id_rdv.Count; i++)
                {


                    // 2 -- retrouver l'acheteur : RDV --> Proposition de visite --> fiches de souhaits / IDAcheteur (distincts)

                    int id_visite_temp = id_rdv[i].IDVISITE;

                    var id_fiche1 = (from pv in Accueil.modeleBase.PROPOSITION_VISITE
                                     where pv.IDBIEN == bien_en_cours.IDBIEN &&
                                      pv.STATUT_PROPOSITION.Replace(" ", string.Empty) == "ACCEPTEE"
                                      && id_visite_temp == pv.IDVISITE
                                     select pv.IDFICHESOUHAITS).FirstOrDefault();

                    int id_acheteur = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                                       where f.IDFICHESOUHAITS == id_fiche1
                                       select f.IDACHETEUR).FirstOrDefault();

                    ACHETEUR a = (from a1 in Accueil.modeleBase.ACHETEUR
                                  where a1.IDACHETEUR == id_acheteur
                                  select a1).FirstOrDefault();

                    PROPOSITION_VISITE prop2 = (from p in Accueil.modeleBase.PROPOSITION_VISITE
                                                where p.IDVISITE == id_visite_temp
                                                select p).FirstOrDefault();

                    listViewbiens.Items.Add(a.NOM_ACHETEUR).SubItems.Add(a.PRENOM_ACHETEUR);
                    listViewbiens.Items[i].SubItems.Add(prop2.DATERDV.ToString());




                }



            }



        }

        private void sous_seing_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VisitesBien_Load(object sender, EventArgs e)
        {

        }
    }
}
