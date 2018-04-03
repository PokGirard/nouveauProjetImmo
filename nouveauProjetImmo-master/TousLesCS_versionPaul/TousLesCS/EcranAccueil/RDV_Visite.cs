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
    public partial class RDV_Visite : Form
    {

        public PROPOSITION_VISITE PROPOSITION_SELECTIONNEE { get; set; }
        public RDV_Visite()
        {
            InitializeComponent();
        }

        public RDV_Visite(PROPOSITION_VISITE proposition_en_cours)
        {
            this.PROPOSITION_SELECTIONNEE = proposition_en_cours;
            InitializeComponent();
        }


    }
}
