namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSubcategoryFromProducts : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "SubCategory");
        }
        
        public override void Down()
        {
        }
    }
}
