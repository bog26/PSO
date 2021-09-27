namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubCategoryToProduct1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SubCategory", c => c.String());
        }
        
        public override void Down()
        {
        }
    }
}
