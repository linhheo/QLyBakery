namespace QLyBakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhaCungCaps : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCaps",
                c => new
                    {
                        NhacungcapID = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenNhacungcap = c.String(),
                        SoDienThoai = c.String(),
                        DiaChi = c.String(),
                        SoTaiKhoan = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.NhacungcapID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCungCaps");
        }
    }
}
