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

    public partial class FicheDeSouhaits : Form
    {

        bool cave, garage, enCours;
        List<BIEN> biens;
        List<VILLE> villes_selectionnees = new List<VILLE>();
        VILLE ville_en_cours;
        BIEN bien_en_cours;
        PropositionVisite fenetreProposition;

        ACHETEUR acheteur_reference = (from a in RechercherClient.modeleBase.ACHETEUR
                                       where a.IDACHETEUR == 2
                                       select a
                                       ).FirstOrDefault();

        FICHE_DE_SOUHAITS fiche_de_reference = (from f in RechercherClient.modeleBase.FICHE_DE_SOUHAITS
                                                where f.IDFICHESOUHAITS == 1
                                                select f
                                       ).FirstOrDefault();





        public FicheDeSouhaits()
        {
            InitializeComponent();
            Charger_Liste_Villes();
            Charger_Liste_Commerciaux();
        }

        private void Charger_Liste_Villes()
        {
            List<VILLE> villes = (from v in RechercherClient.modeleBase.VILLE
                                  select v).ToList();
            villes.Sort((x, y) => string.Compare(x.NOM_VILLE, y.NOM_VILLE));
            foreach (VILLE v in villes)
            {
                string nomV = v.NOM_VILLE;
                nomV = nomV.Replace(" ", string.Empty);
                listViewVillesDeroulante.Items.Add(nomV);
            }
        }


        private void Charger_Liste_Commerciaux()
        {
            List<COMMERCIAL> commerciaux = (from c in RechercherClient.modeleBase.COMMERCIAL
                                            select c).ToList();

            foreach (COMMERCIAL c in commerciaux)

                comboBoxListeCommerciaux.Items.Add(c.NOM_COMMERCIAL);
        }


        private void button_creation_fiche_Click(object sender, EventArgs e)
        {
            try
            {

                string villeA = ville_en_cours.NOM_VILLE;
                villeA = villeA.Replace(" ", string.Empty);

                int surfHab = (int)numericSurfaceHab.Value;
                int surfParc = (int)numericSurfParcelle.Value;

                int budg = int.Parse(textBoxBudget.Text);


                // Create a new Order object.
                FICHE_DE_SOUHAITS nouvelleFiche = new FICHE_DE_SOUHAITS()
                {

                    IDACHETEUR = 2, // Felix
                    VILLE = villeA,
                    BUDGET = int.Parse(textBoxBudget.Text),
                    SURFACE_HABITABLE = surfHab,
                    SURFACE_PARCELLE = surfParc,
                    CAVE = (cave ? true : false),
                    GARAGE = (garage ? true : false),

                };
                RechercherClient.modeleBase.FICHE_DE_SOUHAITS.Add(nouvelleFiche);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }

            // Submit the change to the database.
            try
            {
                RechercherClient.modeleBase.SaveChanges();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);

            }
        }

        private void buttonOuiCave_Click(object sender, EventArgs e)
        {
            cave = true;
            buttonOuiCave.ForeColor = Color.Green;
            buttonOuiCave.Font = new Font(buttonStatut_En_Cours.Font, FontStyle.Bold);
            buttonNonCave.ForeColor = Color.Black;
            buttonNonCave.Font = new Font(buttonStatut_Obsolete.Font, FontStyle.Regular);
        }

        private void buttonNonCave_Click(object sender, EventArgs e)
        {
            cave = false;
            buttonOuiCave.ForeColor = Color.Black;
            buttonOuiCave.Font = new Font(buttonStatut_En_Cours.Font, FontStyle.Regular);
            buttonNonCave.Font = new Font(buttonStatut_Obsolete.Font, FontStyle.Bold);
            buttonNonCave.ForeColor = Color.Red;
        }

        private void buttonOuiGarage_Click(object sender, EventArgs e)
        {
            garage = true;
            buttonOuiGarage.ForeColor = Color.Green;
            buttonOuiGarage.Font = new Font(buttonStatut_En_Cours.Font, FontStyle.Bold);
            buttonNonGarage.ForeColor = Color.Black;
            buttonNonGarage.Font = new Font(buttonStatut_Obsolete.Font, FontStyle.Regular);
        }

        private void buttonNonGarage_Click(object sender, EventArgs e)
        {
            garage = false;
            buttonOuiGarage.ForeColor = Color.Black;
            buttonOuiGarage.Font = new Font(buttonStatut_En_Cours.Font, FontStyle.Regular);
            buttonNonGarage.Font = new Font(buttonStatut_Obsolete.Font, FontStyle.Bold);
            buttonNonGarage.ForeColor = Color.Red;
        }

        private void buttonStatut_En_Cours_Click(object sender, EventArgs e)
        {
            enCours = true;
            graphisme_statut_en_cours();
            Refresh();
        }

        private void buttonStatut_Obsolete_Click(object sender, EventArgs e)
        {
            enCours = false;
            graphisme_statut_obsolete();
            Refresh();
        }

        private void buttonAjouterVille_Click(object sender, EventArgs e)
        {
            if (listViewVillesDeroulante.SelectedItems.Count != 0 && !villes_selectionnees.Contains(ville_en_cours))
            {
                villes_selectionnees.Add(ville_en_cours);
                listVillesSelectionnees.Clear();
                villes_selectionnees.Sort((x, y) => string.Compare(x.NOM_VILLE, y.NOM_VILLE));
                foreach (VILLE v in villes_selectionnees)
                {
                    string nomV = v.NOM_VILLE;
                    nomV = nomV.Replace(" ", string.Empty);
                    listVillesSelectionnees.Items.Add(nomV);
                }
            }

        }

        private void listViewVillesDeroulante_Click(object sender, EventArgs e)
        {

            if (listViewVillesDeroulante.SelectedItems.Count != 0)
            {

                string enCours = listViewVillesDeroulante.SelectedItems[0].Text;

                int idVille = (from v in RechercherClient.modeleBase.VILLE
                               where (v.NOM_VILLE == enCours)
                               select v.IDVILLE).First();

                VILLE v2 = (from v in RechercherClient.modeleBase.VILLE
                            where (v.IDVILLE == idVille)
                            select v).First();

                ville_en_cours = v2;
            }
        }


        private void buttonSupprimerVille_Click(object sender, EventArgs e)
        {
            if (villes_selectionnees.Count() != 0 && villes_selectionnees.Contains(ville_en_cours))
            {
                listVillesSelectionnees.Items.Remove(listVillesSelectionnees.SelectedItems[0]);
                villes_selectionnees.Remove(ville_en_cours);
            }
        }


        private bool verifier_champs()
        {
            bool valide = true;

            string message_erreur = "Recherche impossible : \nVeuillez renseigner les champs suivants :\n";

            if (textBoxBudget.Text == null || textBoxBudget.Text == "")
            {
                message_erreur += " --> Budget à définir \n";
                valide = false;
            }

            if (villes_selectionnees.Count() == 0)
            {
                message_erreur += " --> Aucune ville n'est sélectionnée.";
                valide = false;
            }


            if (!valide)
            {
                MessageBox.Show(message_erreur);

            }

            return valide;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_modifier_fiche_Click(object sender, EventArgs e)
        {

            // attribuer les nouveaux champs s'ils sont remplis et modifiés.

            short id_fiche_selectionnee = 1;

            FICHE_DE_SOUHAITS fiche_a_traiter = (from f in RechercherClient.modeleBase.FICHE_DE_SOUHAITS
                                                 where (f.IDFICHESOUHAITS == id_fiche_selectionnee)
                                                 select f
                                               ).FirstOrDefault();

            try
            {

                if (!fiche_a_traiter.VILLE.Equals(ville_en_cours))
                {
                    fiche_a_traiter.VILLE = "Talence";

                }

                if (!cave == fiche_a_traiter.CAVE)
                {
                    {
                        fiche_a_traiter.CAVE = cave;

                    }

                }

                if (!garage == fiche_a_traiter.GARAGE)
                {
                    {
                        fiche_a_traiter.GARAGE = garage;

                    }
                }


                if (numericUpDownNbPieces.Value != fiche_a_traiter.NB_PIÈCE)
                {
                    fiche_a_traiter.NB_PIÈCE = (int)numericUpDownNbPieces.Value;

                }


                if (numericSurfaceHab.Value != fiche_a_traiter.SURFACE_HABITABLE)
                {
                    fiche_a_traiter.SURFACE_HABITABLE = (int)numericSurfaceHab.Value;
                }


                if (numericSurfParcelle.Value != fiche_a_traiter.SURFACE_PARCELLE)
                {
                    fiche_a_traiter.SURFACE_PARCELLE = (int)numericSurfParcelle.Value;
                }


                RechercherClient.modeleBase.SaveChanges();

            }
            catch (Exception e4)
            {
                MessageBox.Show("Erreur de sauvegarde.");
                return;
            }

            MessageBox.Show("Les modifications ont bien été enregistrées");



        }

        private void buttonPropositionVisite_Click(object sender, EventArgs e)
        {
            fenetreProposition = new PropositionVisite(fiche_de_reference, bien_en_cours, acheteur_reference.COMMERCIAL);

            fenetreProposition.Show();
        }



        private void listView_resultats_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = listView_resultats.SelectedItems[0];
            foreach (BIEN b in biens)
            {
                if (b.IDBIEN == Int16.Parse((sel.SubItems[7].Text)))
                {
                    bien_en_cours = b;
                    return;
                }
            }

        }

        private void button_recherche_biens_Click(object sender, EventArgs e)
        {
            if (!verifier_champs()) return;
            listView_resultats.Items.Clear();

            int budget_choisi = int.Parse(textBoxBudget.Text);

            biens = (from b in RechercherClient.modeleBase.BIEN
                     where (b.STATUT == "DISPONIBLE")
                     && (textBoxBudget.Text != null ? b.PRIX_SOUHAITÉ <= budget_choisi : true)
                        && (b.CAVE == cave ? true : false)
                     && (b.GARAGE == garage ? true : false)
                                      && (b.NB_PIÈCES >= numericUpDownNbPieces.Value)
                     && (b.SURFACE_HABITABLE >= numericSurfaceHab.Value)
                     && (b.SURFACE_PARCELLE >= numericSurfParcelle.Value)
                     select b).ToList();

            biens.RemoveAll(x => !villes_selectionnees.Contains(x.VILLE));

            if (biens.Count != 0)
            {
                for (int i = 0; i < biens.Count; i++)
                {
                    var numVille = biens[i].IDVILLE;

                    string nomVille = (from v in RechercherClient.modeleBase.VILLE
                                       where (v.IDVILLE == numVille)
                                       select v.NOM_VILLE).First().ToString();

                    listView_resultats.Items.Add(nomVille).SubItems.Add(biens[i].PRIX_SOUHAITÉ.ToString());

                    listView_resultats.Items[i].SubItems.Add(biens[i].SURFACE_PARCELLE.ToString());
                    listView_resultats.Items[i].SubItems.Add(biens[i].SURFACE_HABITABLE.ToString());
                    listView_resultats.Items[i].SubItems.Add(biens[i].NB_PIÈCES.ToString());
                    listView_resultats.Items[i].SubItems.Add(biens[i].GARAGE == true ? "Oui" : "Non");
                    listView_resultats.Items[i].SubItems.Add(biens[i].CAVE == true ? "Oui" : "Non");
                    listView_resultats.Items[i].SubItems.Add(biens[i].IDBIEN.ToString());

                }
            }
        }

        private void graphisme_statut_obsolete()
        {
            buttonStatut_En_Cours.ForeColor = Color.Black;
            buttonStatut_En_Cours.Font = new Font(buttonStatut_En_Cours.Font, FontStyle.Regular);
            buttonStatut_Obsolete.Font = new Font(buttonStatut_Obsolete.Font, FontStyle.Bold);
            buttonStatut_Obsolete.ForeColor = Color.Red;
        }

        private void graphisme_statut_en_cours()
        {
            buttonStatut_En_Cours.ForeColor = Color.Green;
            buttonStatut_En_Cours.Font = new Font(buttonStatut_En_Cours.Font, FontStyle.Bold);
            buttonStatut_Obsolete.ForeColor = Color.Black;
            buttonStatut_Obsolete.Font = new Font(buttonStatut_Obsolete.Font, FontStyle.Regular);
        }

    }
}
