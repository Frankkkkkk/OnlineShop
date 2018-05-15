namespace NewAssign2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Year", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Year", c => c.String());
        }
    }
}
