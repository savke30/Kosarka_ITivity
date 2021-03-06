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
    
    public partial class Tim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tim()
        {
            this.Igracs = new HashSet<Igrac>();
            this.UcinakIgracas = new HashSet<UcinakIgraca>();
            this.UtakmicasDomaciTim = new HashSet<Utakmica>();
            this.UtakmicasGostujuciTim = new HashSet<Utakmica>();
        }
    
        public int TimID { get; set; }
        public string Naziv { get; set; }
        public int GradID { get; set; }
        public string NazivStadiona { get; set; }
        public string Trener { get; set; }
        public Nullable<int> SlikaID { get; set; }
        public int BrojGledalaca { get; set; }
    
        public virtual Grad Grad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Igrac> Igracs { get; set; }
        public virtual Slika Slika { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UcinakIgraca> UcinakIgracas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utakmica> UtakmicasDomaciTim { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utakmica> UtakmicasGostujuciTim { get; set; }
    }
}
