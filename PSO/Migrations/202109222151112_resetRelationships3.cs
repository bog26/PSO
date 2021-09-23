namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resetRelationships3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductSubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryId, cascadeDelete: true)
                .Index(t => t.ProductCategoryId);
            
            CreateIndex("dbo.Products", "ProductSubCategoryId");
            CreateIndex("dbo.Products", "ManufacturerId");
            AddForeignKey("dbo.Products", "ManufacturerId", "dbo.Manufacturers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "ProductSubCategoryId", "dbo.ProductSubCategories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductSubCategoryId", "dbo.ProductSubCategories");
            DropForeignKey("dbo.ProductSubCategories", "ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.Products", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.ProductSubCategories", new[] { "ProductCategoryId" });
            DropIndex("dbo.Products", new[] { "ManufacturerId" });
            DropIndex("dbo.Products", new[] { "ProductSubCategoryId" });
            DropTable("dbo.ProductSubCategories");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Manufacturers");
        }
    }
}
