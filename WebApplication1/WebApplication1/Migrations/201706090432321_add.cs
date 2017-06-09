namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HocKy",
                c => new
                    {
                        MaHocKy = c.String(nullable: false, maxLength: 128),
                        TenHocKy = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.MaHocKy);
            
            CreateTable(
                "dbo.KetQua",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 128),
                        MaHocKy = c.String(nullable: false, maxLength: 128),
                        DiemTB = c.Double(),
                        XepLoai = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.MaSV, t.MaHocKy })
                .ForeignKey("dbo.HocKy", t => t.MaHocKy, cascadeDelete: true)
                .ForeignKey("dbo.SinhVien", t => t.MaSV, cascadeDelete: true)
                .Index(t => t.MaSV)
                .Index(t => t.MaHocKy);
            
            CreateTable(
                "dbo.SinhVien",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 128),
                        TenSV = c.String(maxLength: 150),
                        NgaySinh = c.DateTime(),
                        DienThoai = c.String(maxLength: 12),
                        DiaChi = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.MaSV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KetQua", "MaSV", "dbo.SinhVien");
            DropForeignKey("dbo.KetQua", "MaHocKy", "dbo.HocKy");
            DropIndex("dbo.KetQua", new[] { "MaHocKy" });
            DropIndex("dbo.KetQua", new[] { "MaSV" });
            DropTable("dbo.SinhVien");
            DropTable("dbo.KetQua");
            DropTable("dbo.HocKy");
        }
    }
}
