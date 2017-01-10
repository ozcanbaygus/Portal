//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class isler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public isler()
        {
            this.IsiYapacakKisis = new HashSet<IsiYapacakKisi>();
            this.isYorums = new HashSet<isYorum>();
            this.YorumDurums = new HashSet<YorumDurum>();
        }
    
        public int islerID { get; set; }
        public string islerAdi { get; set; }
        public string islerAciklama { get; set; }
        public Nullable<int> islerRefKategoriID { get; set; }
        public Nullable<int> islerRefDomainID { get; set; }
        public Nullable<int> islerRefFirmaID { get; set; }
        public string islerisiYapacakKisi { get; set; }
        public string islerisiVerenKisi { get; set; }
        public Nullable<System.DateTime> islerTarih { get; set; }
        public Nullable<System.DateTime> islerTamamlanmaTarihi { get; set; }
        public Nullable<int> islerOncelikSiraID { get; set; }
        public Nullable<bool> islerisinTamamlanmaDurumu { get; set; }
        public Nullable<bool> islerinisinOnayDurumu { get; set; }
        public Nullable<int> islerisYorumID { get; set; }
        public Nullable<int> islerRefArayanID { get; set; }
        public Nullable<int> islerRefIstekTipiID { get; set; }
        public string islerCalisanTipi { get; set; }
        public string islerDosyaAdi { get; set; }
        public Nullable<int> islerSira { get; set; }
        public int islerIsinDurumu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsiYapacakKisi> IsiYapacakKisis { get; set; }
        public virtual Arayanlar Arayanlar { get; set; }
        public virtual Domain Domain { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual IstekTipi IstekTipi { get; set; }
        public virtual isKategori isKategori { get; set; }
        public virtual isOncelikSira isOncelikSira { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<isYorum> isYorums { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YorumDurum> YorumDurums { get; set; }
    }
}
