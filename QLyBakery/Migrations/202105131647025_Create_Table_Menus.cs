namespace QLyBakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Menus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        IDMon = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenMon = c.String(),
                        Dongia = c.String(),
                    })
                .PrimaryKey(t => t.IDMon);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Menus");
        }
    }
}
