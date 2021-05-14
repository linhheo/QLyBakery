namespace QLyBakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanViens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        NhanvienID = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenNhanvien = c.String(),
                        SoDienThoai = c.String(),
                        SoTaiKhoan = c.String(),
                    })
                .PrimaryKey(t => t.NhanvienID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
