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
    
    public partial class COMMERCIAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMMERCIAL()
        {
            this.ACHETEUR = new HashSet<ACHETEUR>();
        }
    
        public short IDCOMMERCIAL { get; set; }
        public string NOM_COMMERCIAL { get; set; }
        public string PRENOM_COMMERCIAL { get; set; }
        public int TÉLÉPHONE_FIXE_PRO { get; set; }
        public int TÉLÉPHONE_MOBILE_PRO { get; set; }
        public Nullable<int> TÉLÉPHONE_PERSONNEL { get; set; }
        public string EMAIL { get; set; }
        public string STATUT_COMMERCIAL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHETEUR> ACHETEUR { get; set; }
    }
}
