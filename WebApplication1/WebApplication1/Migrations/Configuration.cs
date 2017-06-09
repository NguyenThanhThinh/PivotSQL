namespace WebApplication1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.PiviotDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.PiviotDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            ////
            CreateHocKy(context);
            CreateSinhVien(context);
            CreateKetQua(context);
        }
        private void CreateHocKy(WebApplication1.Models.PiviotDbContext context)
        {
            if (context.HocKys.Count() == 0)
            {
                List<HocKy> list = new List<HocKy>()
                {
                    new HocKy{MaHocKy="HK1",TenHocKy="Học kỳ 1"},
                      new HocKy{MaHocKy="HK2",TenHocKy="Học kỳ 2"},
              new HocKy{MaHocKy="HK3",TenHocKy="Học kỳ 3"},
                     new HocKy{MaHocKy="HK4",TenHocKy="Học kỳ 4"},
                };
                context.HocKys.AddRange(list);
                context.SaveChanges();
            }
        }

        private void CreateSinhVien(WebApplication1.Models.PiviotDbContext context)
        {
            if (context.SinhViens.Count() == 0)
            {
                List<SinhVien> list = new List<SinhVien>()
                {
                  new SinhVien{MaSV="SV01",TenSV="Nguyen Van A",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},
                      new SinhVien{MaSV="SV02",TenSV="Nguyen Van B",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},

                          new SinhVien{MaSV="SV03",TenSV="Nguyen Van C",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},
                          new SinhVien{MaSV="SV04",TenSV="Nguyen Van D",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},
                          new SinhVien{MaSV="SV05",TenSV="Nguyen Van T",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},
                          new SinhVien{MaSV="SV06",TenSV="Nguyen Van G",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},
                              new SinhVien{MaSV="SV07",TenSV="Nguyen Van K",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},

                                  new SinhVien{MaSV="SV08",TenSV="Nguyen Van U",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},

                                      new SinhVien{MaSV="SV09",TenSV="Nguyen Van H",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},
                                  new SinhVien{MaSV="SV10",TenSV="Nguyen Van N",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},
                                  new SinhVien{MaSV="SV11",TenSV="Nguyen Van W",DiaChi="ST",DienThoai="0965899230",NgaySinh= new DateTime(1995,2,1)},
                };
                context.SinhViens.AddRange(list);
                context.SaveChanges();
            }
        }

        private void CreateKetQua(WebApplication1.Models.PiviotDbContext context)
        {
            if (context.KetQuas.Count() == 0)
            {
                List<KetQua> list = new List<KetQua>()
                {
                  new KetQua{MaSV="SV01",MaHocKy="HK1",DiemTB=8.0,XepLoai="Gioi"},
                   new KetQua{MaSV="SV01",MaHocKy="HK2",DiemTB=7.1,XepLoai="Kha"},

                    new KetQua{MaSV="SV01",MaHocKy="HK3",DiemTB=8.3,XepLoai="Gioi"},
                     new KetQua{MaSV="SV01",MaHocKy="HK4",DiemTB=8.0,XepLoai="Gioi"},

                      new KetQua{MaSV="SV02",MaHocKy="HK1",DiemTB=8.0,XepLoai="Gioi"},
                       new KetQua{MaSV="SV02",MaHocKy="HK2",DiemTB=7.0,XepLoai="Kha"},
                        new KetQua{MaSV="SV02",MaHocKy="HK3",DiemTB=6.0,XepLoai="Trung Binh"},
                         new KetQua{MaSV="SV02",MaHocKy="HK4",DiemTB=8.0,XepLoai="Gioi"},


                          new KetQua{MaSV="SV03",MaHocKy="HK1",DiemTB=8.0,XepLoai="Gioi"},
                       new KetQua{MaSV="SV03",MaHocKy="HK2",DiemTB=8.0,XepLoai="Gioi"},
                        new KetQua{MaSV="SV03",MaHocKy="HK3",DiemTB=6.0,XepLoai="Trung Binh"},
                         new KetQua{MaSV="SV03",MaHocKy="HK4",DiemTB=8.0,XepLoai="Gioi"},

                             new KetQua{MaSV="SV04",MaHocKy="HK1",DiemTB=8.0,XepLoai="Gioi"},
                       new KetQua{MaSV="SV04",MaHocKy="HK2",DiemTB=8.0,XepLoai="Gioi"},
                        new KetQua{MaSV="SV04",MaHocKy="HK3",DiemTB=6.0,XepLoai="Trung Binh"},
                         new KetQua{MaSV="SV04",MaHocKy="HK4",DiemTB=8.0,XepLoai="Gioi"},



                              new KetQua{MaSV="SV05",MaHocKy="HK1",DiemTB=8.0,XepLoai="Gioi"},
                       new KetQua{MaSV="SV05",MaHocKy="HK2",DiemTB=8.0,XepLoai="Gioi"},
                        new KetQua{MaSV="SV05",MaHocKy="HK3",DiemTB=6.0,XepLoai="Trung Binh"},
                         new KetQua{MaSV="SV05",MaHocKy="HK4",DiemTB=8.0,XepLoai="Gioi"},



                              new KetQua{MaSV="SV06",MaHocKy="HK1",DiemTB=8.0,XepLoai="Gioi"},
                       new KetQua{MaSV="SV06",MaHocKy="HK2",DiemTB=7.0,XepLoai="Kha"},
                        new KetQua{MaSV="SV06",MaHocKy="HK3",DiemTB=6.0,XepLoai="Trung Binh"},
                         new KetQua{MaSV="SV06",MaHocKy="HK4",DiemTB=8.0,XepLoai="Gioi"},




                };
                context.KetQuas.AddRange(list);
                context.SaveChanges();
            }
        }
    }
}
