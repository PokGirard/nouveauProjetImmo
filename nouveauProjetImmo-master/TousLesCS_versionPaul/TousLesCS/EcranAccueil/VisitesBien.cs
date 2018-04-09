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
        BIEN bien_en_cours = null;
        public VisitesBien(BIEN bien_en_cours)
        {
            InitializeComponent();
            this.bien_en_cours = bien_en_cours;
            charger_liste_visites();
        }

        private void charger_liste_visites()
        {
            //a remplir
        }

        private void sous_seing_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
