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
    
    public partial class UcinakIgraca
    {
        public int UcinakIgracaID { get; set; }
        public int IgracID { get; set; }
        public int UtakmicaID { get; set; }
        public int TimID { get; set; }
        public byte BrojMinuta { get; set; }
        public byte UkupnoSlobodnihBacanja { get; set; }
        public byte PogodjenihSlobodnihBacanja { get; set; }
        public byte UkupnoDvojki { get; set; }
        public byte PogodjenihDvojki { get; set; }
        public byte UkupnoTrojki { get; set; }
        public byte PogodjenihTrojki { get; set; }
        public byte Faulova { get; set; }
        public byte Skokovi { get; set; }
        public byte Asistencije { get; set; }
        public byte Blokade { get; set; }
        public byte IzgubljeneLopte { get; set; }
        public byte UkradeneLopte { get; set; }
    
        public virtual Igrac Igrac { get; set; }
        public virtual Tim Tim { get; set; }
        public virtual Utakmica Utakmica { get; set; }
    }
}
