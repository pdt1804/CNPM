//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class DOCGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCGIA()
        {
            this.PHIEUMUONTRAs = new HashSet<PHIEUMUONTRA>();
            this.PHIEUTHUs = new HashSet<PHIEUTHU>();
        }
    
        public int ID { get; set; }
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public System.DateTime NgayLapThe { get; set; }
        public System.DateTime NgayHetHan { get; set; }
        public int idLoaiDocGia { get; set; }
        public int TongNoHienTai { get; set; }
        public int idNguoiDung { get; set; }
    
        public virtual LOAIDOCGIA LOAIDOCGIA { get; set; }
        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUONTRA> PHIEUMUONTRAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHU> PHIEUTHUs { get; set; }
    }
}
