namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProductSpecificationsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductSpecifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        SpecData = c.Binary(),
                        SpecDataExtension = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductSpecifications");
        }
    }
}
