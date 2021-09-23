namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiesToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "crtSellPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "crtManufacturerPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Products", "crtClientPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "crtClientPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Products", "crtManufacturerPrice");
            DropColumn("dbo.Products", "crtSellPrice");
        }
    }
}
