namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset : DbMigration
    {
        public override void Up()
        {

            /*
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        UserPersonalDataId = c.Int(nullable: false),
                        UserAddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAddresses", t => t.UserAddressId, cascadeDelete: true)
                .ForeignKey("dbo.UserPersonalDatas", t => t.UserPersonalDataId, cascadeDelete: true)
                .Index(t => t.UserPersonalDataId)
                .Index(t => t.UserAddressId);
            
            CreateTable(
                "dbo.UserAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        StreetNr = c.Int(nullable: false),
                        City = c.String(),
                        Region = c.String(),
                        Country = c.String(),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserPersonalDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        UserPersonalDataId = c.Int(nullable: false),
                        UserAddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAddresses", t => t.UserAddressId, cascadeDelete: true)
                .ForeignKey("dbo.UserPersonalDatas", t => t.UserPersonalDataId, cascadeDelete: true)
                .Index(t => t.UserPersonalDataId)
                .Index(t => t.UserAddressId);
            
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
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductSubCategoryId = c.Int(nullable: false),
                        ManufacturerId = c.Int(nullable: false),
                        Model = c.String(),
                        Stock = c.Int(nullable: false),
                        crtClientPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .ForeignKey("dbo.ProductSubCategories", t => t.ProductSubCategoryId, cascadeDelete: true)
                .Index(t => t.ProductSubCategoryId)
                .Index(t => t.ManufacturerId);
            
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
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReviewMark = c.Int(nullable: false),
                        ReviewText = c.String(),
                        ClientId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionStart = c.DateTime(nullable: false),
                        TransactionEnd = c.DateTime(nullable: false),
                        TransactionStatus_CrtStatus = c.String(),
                        TotalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientId = c.Int(nullable: false),
                        ShoppingCartId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductSubCategoryId", "dbo.ProductSubCategories");
            DropForeignKey("dbo.ProductSubCategories", "ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.Products", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Clients", "UserPersonalDataId", "dbo.UserPersonalDatas");
            DropForeignKey("dbo.Clients", "UserAddressId", "dbo.UserAddresses");
            DropForeignKey("dbo.Admins", "UserPersonalDataId", "dbo.UserPersonalDatas");
            DropForeignKey("dbo.Admins", "UserAddressId", "dbo.UserAddresses");
            DropIndex("dbo.ProductSubCategories", new[] { "ProductCategoryId" });
            DropIndex("dbo.Products", new[] { "ManufacturerId" });
            DropIndex("dbo.Products", new[] { "ProductSubCategoryId" });
            DropIndex("dbo.Clients", new[] { "UserAddressId" });
            DropIndex("dbo.Clients", new[] { "UserPersonalDataId" });
            DropIndex("dbo.Admins", new[] { "UserAddressId" });
            DropIndex("dbo.Admins", new[] { "UserPersonalDataId" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Suppliers");
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.Reviews");
            DropTable("dbo.ProductSubCategories");
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Clients");
            DropTable("dbo.UserPersonalDatas");
            DropTable("dbo.UserAddresses");
            DropTable("dbo.Admins");
            */
        }
    }
}
