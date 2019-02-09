//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kosarka_ITivity_Dejan_Savanovic.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Utakmica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utakmica()
        {
            this.UcinakIgracas = new HashSet<UcinakIgraca>();
        }
    
        public int UtakmicaID { get; set; }
        public int KoloID { get; set; }
        public System.DateTime DatumOdigravanja { get; set; }
        public int DomaciTim { get; set; }
        public int GostujuciTim { get; set; }
        public byte PoeniDomaciTim { get; set; }
        public byte PoeniGostujuciTim { get; set; }
    
        public virtual Kolo Kolo { get; set; }
        public virtual Tim TimDomaci { get; set; }
        public virtual Tim TimGostujuci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UcinakIgraca> UcinakIgracas { get; set; }
    }
}
