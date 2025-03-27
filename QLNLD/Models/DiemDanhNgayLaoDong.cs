namespace QLNLD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemDanhNgayLaoDong")]
    public partial class DiemDanhNgayLaoDong
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? MSSV { get; set; }

        public int? NguoiTao { get; set; }

        [Required]
        [StringLength(255)]
        public string AnhTaoQR { get; set; }

        public virtual QuanLy QuanLy { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
