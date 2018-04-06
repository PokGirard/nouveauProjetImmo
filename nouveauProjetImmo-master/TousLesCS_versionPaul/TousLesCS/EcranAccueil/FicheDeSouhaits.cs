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
        //DISABLE FICHE DE SOUHAIT QUAND OBSOLETE

        List<BIEN> biens_selectionnes;
        BIEN bien_en_cours;
        List<VILLE> villes_selectionnees = new List<VILLE>();
        VILLE ville_en_cours;
        string statut_fiche;

        PropositionVisite fenetreProposition;

        ACHETEUR acheteur_de_reference;
        FICHE_DE_SOUHAITS fiche_de_reference;

        public FicheDeSouhaits()
        {

            InitializeComponent();
            Charger_Liste_Villes();
            ChargerListe_Villes_selectionnees();
            Preremplir_champs_client();
            statut_fiche = "EN COURS";
        }
        public FicheDeSouhaits(ACHETEUR acheteur_de_reference)
        {
            this.acheteur_de_reference = acheteur_de_reference;
            InitializeComponent();
            Charger_Liste_Villes();
            Preremplir_champs_client();
            statut_fiche = "EN COURS";
        }

        private void Preremplir_champs_client()
        {
            textBoxNom.Text = acheteur_de_reference.NOM_ACHETEUR;
            textBoxPrenom.Text = acheteur_de_reference.PRENOM_ACHETEUR;
            textBoxAdresseClient.Text = acheteur_de_reference.ADRESSE;
            textBoxEmail.Text = acheteur_de_reference.EMAIL;
            textBoxVilleClient.Text = acheteur_de_reference.VILLE.NOM_VILLE;
            textBoxTelFixe.Text = acheteur_de_reference.TÉLÉPHONE.ToString();
            textBoxTelMobile.Text = acheteur_de_reference.TÉLÉPHONE_MOBILE.ToString();

        }

        public FicheDeSouhaits(FICHE_DE_SOUHAITS fiche_de_reference)
        {

            this.fiche_de_reference = fiche_de_reference;

            acheteur_de_reference = fiche_de_reference.ACHETEUR;

            InitializeComponent();
            Charger_Liste_Villes();
            ChargerListe_Villes_selectionnees();
            Preremplir_champs_client();
            Preremplir_champs_fiche();
            statut_fiche = fiche_de_reference.STATUT;

        }

        private void Preremplir_champs_fiche()
        {
            textBoxBudget.Text = fiche_de_reference.BUDGET.ToString();
            numericSurfaceHab.Value = (decimal)fiche_de_reference.SURFACE_HABITABLE;
            numericSurfParcelle.Value = (decimal)fiche_de_reference.SURFACE_PARCELLE;
            numericUpDownNbPieces.Value = (decimal)fiche_de_reference.NB_PIÈCE;

            if ((bool)fiche_de_reference.CAVE) checkBoxCave.Checked = true;
            if ((bool)fiche_de_reference.GARAGE) checkBoxGarage.Checked = true;

            string statut = fiche_de_reference.STATUT.Replace(" ", string.Empty);

            if (statut == "ENCOURS")
            {

                graphisme_statut_en_cours();
            }
            else if (statut == "OBSOLETE")
            {

                graphisme_statut_obsolete();
            }

            Refresh();

        }

        private static string supprimer_espaces(string statut)
        {

            statut.TrimEnd(' ');

            return statut;
        }

        private void ChargerListe_Villes_selectionnees()
        {
            villes_selectionnees = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                                    from v in f.VILLE1
                                    where f.IDFICHESOUHAITS == fiche_de_reference.IDFICHESOUHAITS
                                    select v).ToList();

            foreach (VILLE v in villes_selectionnees)
            {
                listVillesSelectionnees.Items.Add(v.NOM_VILLE);

            }

        }

        private void Charger_Liste_Villes()
        {
            List<VILLE> villes = (from v in Accueil.modeleBase.VILLE
                                  select v).ToList();
            villes.Sort((x, y) => string.Compare(x.NOM_VILLE, y.NOM_VILLE));
            foreach (VILLE v in villes)
            {
                string nomV = v.NOM_VILLE;
                nomV = nomV.Replace(" ", string.Empty);
                listViewVillesDeroulante.Items.Add(nomV);
            }
        }
      
        private void button_creation_fiche_Click(object sender, EventArgs e)
        {
            FICHE_DE_SOUHAITS nouvelleFiche = null;
            try
            {
                nouvelleFiche = new FICHE_DE_SOUHAITS()
                {
                    IDACHETEUR = acheteur_de_reference.IDACHETEUR,
                    BUDGET = int.Parse(textBoxBudget.Text),
                    SURFACE_HABITABLE = (int)numericSurfaceHab.Value,
                    SURFACE_PARCELLE = (int)numericSurfParcelle.Value,
                    NB_PIÈCE = (int)numericUpDownNbPieces.Value,
                    CAVE = checkBoxCave.Checked,
                    GARAGE = checkBoxGarage.Checked,
                    STATUT = "EN COURS"
                };
                Accueil.modeleBase.FICHE_DE_SOUHAITS.Add(nouvelleFiche);

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
            // Submit the change to the database.
            try
            {
                Accueil.modeleBase.SaveChanges();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);

            }
            FICHE_DE_SOUHAITS fiche_recup = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                                             where f.IDACHETEUR == nouvelleFiche.IDACHETEUR &&
                                              f.BUDGET == nouvelleFiche.BUDGET &&
                                                f.SURFACE_HABITABLE == nouvelleFiche.SURFACE_HABITABLE &&
                    f.SURFACE_PARCELLE == nouvelleFiche.SURFACE_PARCELLE &&
                    f.CAVE == nouvelleFiche.CAVE &&
                    f.GARAGE == nouvelleFiche.GARAGE &&
                    f.STATUT == nouvelleFiche.STATUT
                                             select f).FirstOrDefault();
            var f1 = (from f in Accueil.modeleBase.FICHE_DE_SOUHAITS
                      where f.IDFICHESOUHAITS == fiche_recup.IDFICHESOUHAITS
                      select f).First();

            Accueil.modeleBase.FICHE_DE_SOUHAITS.Attach(f1);

            foreach (VILLE v in villes_selectionnees)
            {
                Accueil.modeleBase.VILLE.Attach(v);
                f1.VILLE1.Add(v);
                Accueil.modeleBase.SaveChanges();
            }

            try
            {
                Accueil.modeleBase.SaveChanges();

            }
            catch (Exception e78)
            {
                MessageBox.Show("non");
            }
        }

        private void buttonStatut_En_Cours_Click(object sender, EventArgs e)
        {
            statut_fiche = "EN COURS";
            graphisme_statut_en_cours();
            Refresh();
        }

        private void buttonStatut_Obsolete_Click(object sender, EventArgs e)
        {
            statut_fiche = "OBSOLETE";
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
            listVillesSelectionnees.Refresh();

        }

        private void listViewVillesDeroulante_Click(object sender, EventArgs e)
        {

            if (listViewVillesDeroulante.SelectedItems.Count != 0)
            {

                string enCours = listViewVillesDeroulante.SelectedItems[0].Text;

                int idVille = (from v in Accueil.modeleBase.VILLE
                               where (v.NOM_VILLE == enCours)
                               select v.IDVILLE).First();

                VILLE v2 = (from v in Accueil.modeleBase.VILLE
                            where (v.IDVILLE == idVille)
                            select v).First();

                ville_en_cours = v2;
            }
        }

        private void buttonSupprimerVille_Click(object sender, EventArgs e)
        {
            if (villes_selectionnees.Count() != 0 && listVillesSelectionnees.SelectedItems.Count != 0)
            {
                string a = listVillesSelectionnees.SelectedItems[0].Text.Replace(" ", string.Empty);
                ville_en_cours = (from v1 in Accueil.modeleBase.VILLE
                                  where v1.NOM_VILLE == a
                                  select v1).FirstOrDefault();
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

            List<VILLE> villes_stockees_base = fiche_de_reference.VILLE1.ToList();

            try
            {

                if (!villes_stockees_base.All(villes_selectionnees.Contains) || !villes_selectionnees.All(villes_stockees_base.Contains))

                    MAJ_villes_recherche(villes_stockees_base);
                if (fiche_de_reference.BUDGET != int.Parse(textBoxBudget.Text))

                    fiche_de_reference.BUDGET = int.Parse(textBoxBudget.Text);
                if (checkBoxCave.Checked != fiche_de_reference.CAVE)
                    fiche_de_reference.CAVE = checkBoxCave.Checked;

                if (checkBoxGarage.Checked != fiche_de_reference.GARAGE)

                    fiche_de_reference.GARAGE = checkBoxGarage.Checked;

                if (numericUpDownNbPieces.Value != fiche_de_reference.NB_PIÈCE)

                    fiche_de_reference.NB_PIÈCE = (int)numericUpDownNbPieces.Value;
                if (numericSurfaceHab.Value != fiche_de_reference.SURFACE_HABITABLE)

                    fiche_de_reference.SURFACE_HABITABLE = (int)numericSurfaceHab.Value;

                if (numericSurfParcelle.Value != fiche_de_reference.SURFACE_PARCELLE)

                    fiche_de_reference.SURFACE_PARCELLE = (int)numericSurfParcelle.Value;

                if (statut_fiche != fiche_de_reference.STATUT)
                {
                    fiche_de_reference.STATUT = statut_fiche;
                }

                Accueil.modeleBase.SaveChanges();
            }
            catch (Exception e4)
            {
                MessageBox.Show("Erreur de sauvegarde.");
                return;
            }

            MessageBox.Show("Les modifications ont bien été enregistrées");

        }

        private void MAJ_villes_recherche(List<VILLE> villes_base)
        {
            // supression
            foreach (VILLE v in villes_base)

                if (!villes_selectionnees.Contains(v))
                    fiche_de_reference.VILLE1.Remove(v);
            // ajout
            foreach (VILLE v in villes_selectionnees)

                if (!villes_base.Contains(v))

                    fiche_de_reference.VILLE1.Add(v);
        }

        private void buttonPropositionVisite_Click(object sender, EventArgs e)
        {

            short sel = Int16.Parse(listView_resultats.SelectedItems[0].SubItems[7].Text);

            bien_en_cours = (from b in Accueil.modeleBase.BIEN
                             where b.IDBIEN == sel
                             select b).FirstOrDefault();

            fenetreProposition = new PropositionVisite(fiche_de_reference, bien_en_cours);

            fenetreProposition.Show();
        }



        private void button_recherche_biens_Click(object sender, EventArgs e)
        {
            if (!verifier_champs()) return;
            listView_resultats.Items.Clear();

            int budget_choisi = int.Parse(textBoxBudget.Text);

            biens_selectionnes = (from b in Accueil.modeleBase.BIEN
                                  where (b.STATUT == "DISPONIBLE")
                                  && (textBoxBudget.Text != null ? b.PRIX_SOUHAITÉ <= budget_choisi : true)
                                     && (b.CAVE == checkBoxCave.Checked ? true : false)
                                  && (b.GARAGE == checkBoxGarage.Checked ? true : false)
                                                   && (b.NB_PIÈCES >= numericUpDownNbPieces.Value)
                                  && (b.SURFACE_HABITABLE >= numericSurfaceHab.Value)
                                  && (b.SURFACE_PARCELLE >= numericSurfParcelle.Value)
                                  select b).ToList();

            biens_selectionnes.RemoveAll(x => !villes_selectionnees.Contains(x.VILLE));

            if (biens_selectionnes.Count != 0)
            {
                for (int i = 0; i < biens_selectionnes.Count; i++)
                {
                    var numVille = biens_selectionnes[i].IDVILLE;

                    string nomVille = (from v in Accueil.modeleBase.VILLE
                                       where (v.IDVILLE == numVille)
                                       select v.NOM_VILLE).First().ToString();

                    listView_resultats.Items.Add(nomVille).SubItems.Add(biens_selectionnes[i].PRIX_SOUHAITÉ.ToString());

                    listView_resultats.Items[i].SubItems.Add(biens_selectionnes[i].SURFACE_PARCELLE.ToString());
                    listView_resultats.Items[i].SubItems.Add(biens_selectionnes[i].SURFACE_HABITABLE.ToString());
                    listView_resultats.Items[i].SubItems.Add(biens_selectionnes[i].NB_PIÈCES.ToString());
                    listView_resultats.Items[i].SubItems.Add(biens_selectionnes[i].GARAGE == true ? "Oui" : "Non");
                    listView_resultats.Items[i].SubItems.Add(biens_selectionnes[i].CAVE == true ? "Oui" : "Non");
                    listView_resultats.Items[i].SubItems.Add(biens_selectionnes[i].IDBIEN.ToString());

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

        private void FicheDeSouhaits_Load(object sender, EventArgs e)
        {
            //vide et c'est normal
        }

        private void button_creerProposition_Click(object sender, EventArgs e)
        {

            if (fiche_de_reference == null || bien_en_cours == null) return;

            PropositionVisite proposition = new PropositionVisite(fiche_de_reference, bien_en_cours);
            proposition.Show();
        }

        private void listView_resultats_Click(object sender, EventArgs e)
        {
            if (listView_resultats.SelectedItems.Count != 0)
            {
                int idBien = int.Parse(listView_resultats.SelectedItems[0].SubItems[7].Text);

                bien_en_cours = (from b in Accueil.modeleBase.BIEN
                                 where (b.IDBIEN == idBien)
                                 select b).First();

            }
        }
    }
}
