//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcranAccueil
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROPOSITION_VISITE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROPOSITION_VISITE()
        {
            this.RDV = new HashSet<RDV>();
        }
    
        public short IDVISITE { get; set; }
        public short IDFICHESOUHAITS { get; set; }
        public short IDBIEN { get; set; }
        public System.DateTime DATERDV { get; set; }
        public string STATUT_PROPOSITION { get; set; }
    
        public virtual BIEN BIEN { get; set; }
        public virtual FICHE_DE_SOUHAITS FICHE_DE_SOUHAITS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RDV> RDV { get; set; }
    }
}
