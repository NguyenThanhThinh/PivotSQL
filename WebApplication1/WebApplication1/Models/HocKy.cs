using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("HocKy")]
    public class HocKy
    {
        [Key]
        public string MaHocKy { get; set; }
        [StringLength(100)]
        public string TenHocKy { get; set; }
        public ICollection<KetQua> KetQua { get; set; }
    }
}