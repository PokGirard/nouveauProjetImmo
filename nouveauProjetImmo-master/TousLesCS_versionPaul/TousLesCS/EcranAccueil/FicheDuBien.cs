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
    public partial class FicheDuBien : Form
    {
        public BIEN bien_en_cours { get; set; }

        public FicheDuBien(BIEN bien_en_cours)
        {
            InitializeComponent();
            this.bien_en_cours = bien_en_cours;

            remplissageBox();
        }

        Bitmap bmp;

        private void FicheDuBien_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void remplissageBox()
        {
           
            this.surface_hab.Value = bien_en_cours.SURFACE_HABITABLE;
            this.surface_parc.Value = bien_en_cours.SURFACE_PARCELLE;
            this.nb_pieces.Value = bien_en_cours.NB_PIÈCES;
            this.nb_chambres.Value = bien_en_cours.NB_CHAMBRES;
            this.nb_sdb.Value = bien_en_cours.NB_SALLEDEBAIN;

            if (bien_en_cours.GARAGE)
                this.comboBox_garage.Text = "OUI";
            else
                this.comboBox_garage.Text = "NON";
            if (bien_en_cours.CAVE)
                this.comboBox_cave.Text = "OUI";
            else
                this.comboBox_cave.Text = "NON";

            this.textBox_descr_bien.Text = bien_en_cours.ADRESSE_BIEN;
            this.code_postal.Text = bien_en_cours.CODE_POSTAL.ToString();
            var ville = (from v in Accueil.modeleBase.VILLE
                         where v.IDVILLE == bien_en_cours.IDVILLE
                         select v.NOM_VILLE).FirstOrDefault();
            this.ville.Text = ville;
            this.commentaires.Text = bien_en_cours.ZONE_DE_SAISIE;

            this.Show();
        }
    

    }
}
