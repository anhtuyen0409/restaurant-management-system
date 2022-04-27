namespace THD_DoAnCuoiKi.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        [Key]
        public int MaCTHD { get; set; }

        public int MaHoaDon { get; set; }

        public int MaMon { get; set; }

        public int SoLuong { get; set; }

        public int ThanhTien { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual MonAn MonAn { get; set; }
    }
}
