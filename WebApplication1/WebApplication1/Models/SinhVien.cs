using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public string MaSV { get; set; }
        [StringLength(150)]
        public string TenSV { get; set; }
        public DateTime? NgaySinh { get; set; }
        [StringLength(12)]
        public string DienThoai { get; set; }
        [StringLength(150)]
        public string DiaChi{ get; set;}
        public ICollection<KetQua> KetQua { get; set; }

    }
}