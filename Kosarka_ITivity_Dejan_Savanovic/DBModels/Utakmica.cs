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
        public byte PoeniPrvaCetvrtina { get; set; }
        public byte PoeniDrugaCetvrtina { get; set; }
        public byte PoneiTrecaCetvrtina { get; set; }
        public byte PoeniCetvrtaCetvrtina { get; set; }
        public byte PoeniProduzetak { get; set; }
        public int BrojGledalaca { get; set; }
        public byte PrvaCetvrtinaGosti { get; set; }
        public byte DrugaCetvrtinaGosti { get; set; }
        public byte TrecaCetvrtinaGosti { get; set; }
        public byte CetvrtaCetvrtinaGosti { get; set; }
        public byte ProduzetakGosti { get; set; }
    
        public virtual Kolo Kolo { get; set; }
        public virtual Tim DomaciTimPokazatelj { get; set; }
        public virtual Tim GostujuciTimPokazatelj { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UcinakIgraca> UcinakIgracas { get; set; }
    }
}
