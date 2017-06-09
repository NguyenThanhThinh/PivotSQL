using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("KetQua")]
    public partial class KetQua
    {
        [Key]
        [Column(Order =1)]
        public string MaSV { get; set; }
        [Column(Order = 2)]
        [Key]
        public string MaHocKy { get; set; }

        public double? DiemTB { get; set; }
        [StringLength(50)]
        public string XepLoai { get; set; }
        public virtual HocKy HocKy { get; set; }
        public virtual SinhVien SinhVien { get; set; }

    }
}