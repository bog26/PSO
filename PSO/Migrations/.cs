namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resetRelationships : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.ProductSubCategories", "ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.Products", "ProductSubCategoryId", "dbo.ProductSubCategories");
            DropIndex("dbo.Products", new[] { "ProductSubCategoryId" });
            DropIndex("dbo.Products", new[] { "ManufacturerId" });
            DropIndex("dbo.ProductSubCategories", new[] { "ProductCategoryId" });
            DropColumn("dbo.ShoppingCarts", "ClientId");
            //DropTable("dbo.Manufacturers");
            //DropTable("dbo.ProductCategories");
            //DropTable("dbo.ProductSubCategories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductSubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductCategoryId = c.Int(nullable: false),
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
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ShoppingCarts", "ClientId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductSubCategories", "ProductCategoryId");
            CreateIndex("dbo.Products", "ManufacturerId");
            CreateIndex("dbo.Products", "ProductSubCategoryId");
            AddForeignKey("dbo.Products", "ProductSubCategoryId", "dbo.ProductSubCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductSubCategories", "ProductCategoryId", "dbo.ProductCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "ManufacturerId", "dbo.Manufacturers", "Id", cascadeDelete: true);
        }
    }
}
