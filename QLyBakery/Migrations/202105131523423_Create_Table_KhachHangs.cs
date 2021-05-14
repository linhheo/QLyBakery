namespace QLyBakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHangs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        KhachhangID = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenKhachhang = c.String(),
                        SoDienThoai = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.KhachhangID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
