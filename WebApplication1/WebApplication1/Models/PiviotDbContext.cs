using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PiviotDbContext:DbContext
    {
        public PiviotDbContext() : base("piviosql")
        {

        }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<KetQua> KetQuas { get; set; }
        public DbSet<HocKy> HocKys { get; set; }


    }
}