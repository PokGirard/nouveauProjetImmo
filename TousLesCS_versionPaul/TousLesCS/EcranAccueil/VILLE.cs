//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcranAccueil
{
    using System;
    using System.Collections.Generic;
    
    public partial class VILLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VILLE()
        {
            this.ACHETEUR = new HashSet<ACHETEUR>();
            this.BIEN = new HashSet<BIEN>();
            this.VENDEUR = new HashSet<VENDEUR>();
            this.FICHE_DE_SOUHAITS = new HashSet<FICHE_DE_SOUHAITS>();
        }
    
        public short IDVILLE { get; set; }
        public string NOM_VILLE { get; set; }
        public int CODE_POSTAL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHETEUR> ACHETEUR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIEN> BIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDEUR> VENDEUR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FICHE_DE_SOUHAITS> FICHE_DE_SOUHAITS { get; set; }
    }
}
