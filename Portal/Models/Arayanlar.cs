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
    
    public partial class Arayanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arayanlar()
        {
            this.Firmas = new HashSet<Firma>();
            this.islers = new HashSet<isler>();
            this.Randevus = new HashSet<Randevu>();
            this.Teklifs = new HashSet<Teklif>();
            this.TeklifDetays = new HashSet<TeklifDetay>();
        }
    
        public int arayanID { get; set; }
        public string arayanAdi { get; set; }
        public string arayanSoyadi { get; set; }
        public string arayanFirmaAdi { get; set; }
        public string arayanFirmaSahibiOzelligi { get; set; }
        public string arayanTelefonNo { get; set; }
        public string arayanCepTelNo { get; set; }
        public string arayanMailAdresi { get; set; }
        public string arayanWebAdresi { get; set; }
        public string arayanSehir { get; set; }
        public string arayanilce { get; set; }
        public string arayanAdres { get; set; }
        public Nullable<int> arayanRefKonumID { get; set; }
        public string arayanKonu { get; set; }
        public string arayanNot { get; set; }
        public string arayanBegendigiWebSiteleri { get; set; }
        public Nullable<System.DateTime> arayanKayitTarih { get; set; }
        public Nullable<int> arayanDomainKategoriID { get; set; }
        public string arayanTelefonaBakanKisiID { get; set; }
        public Nullable<int> arayanSektorID { get; set; }
        public Nullable<int> arayanGrupID { get; set; }
        public Nullable<bool> arayanilkArama { get; set; }
        public Nullable<bool> arayanFirmaKayitDurum { get; set; }
        public Nullable<bool> arayanKayitliMusterimi { get; set; }
        public Nullable<int> arayanKayitliRefFirmaID { get; set; }
    
        public virtual ArayanGrup ArayanGrup { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual DomainKategori DomainKategori { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual Konum Konum { get; set; }
        public virtual Sektorler Sektorler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Firma> Firmas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<isler> islers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevu> Randevus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teklif> Teklifs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeklifDetay> TeklifDetays { get; set; }
    }
}
