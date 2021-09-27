namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteManufacturerFromProducts : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Manufacturer");
        }
        
        public override void Down()
        {
        }
    }
}
