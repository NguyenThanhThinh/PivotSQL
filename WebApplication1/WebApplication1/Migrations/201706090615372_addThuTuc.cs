namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addThuTuc : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("Thongke", @"select a.MASV,a.tensv,a.hk1 'DiemHK1',b.hk1 'XepLoaiHK1',a.hk2 'DiemHK2',b.hk2 'XepLoaiHK2',a.HK3 'DiemHK3',b.HK3 'XepLoaiHK3',a.HK4 'DiemHK4',b.HK4 'XepLoaiHK4' from
(
select * 
from 
(select kq.MaSV,sv.TenSV ,kq.MaHocKy,kq.DiemTB
 from  Ketqua kq
 inner join SinhVien sv on sv.MaSV=kq.MaSV)
  as temp
 PIVOT(MIN(diemtb) FOR mahocky in ([HK1],[HK2],[HK3],[HK4])) as demo) a
 inner join
 (select * 
from 
(select kq.MaSV ,kq.MaHocKy,Kq.xeploai
 from  Ketqua kq
 ) as temp
 PIVOT(MIN(xeploai) FOR mahocky in ([HK1],[HK2],[HK3],[HK4])) as demo) b
on a.MaSV=b.MaSV
");
        }

        public override void Down()
        {
            DropStoredProcedure("db.Thongke");
        }
    }
}
