namespace QLyBakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Khos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khos",
                c => new
                    {
                        NguyenlieuID = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenNguyenlieu = c.String(),
                        Soluong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NguyenlieuID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khos");
        }
    }
}
