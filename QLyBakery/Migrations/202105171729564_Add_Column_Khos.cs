namespace QLyBakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_Khos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Khos", "NhaCungCapID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Khos", "NhaCungCapID");
        }
    }
}
