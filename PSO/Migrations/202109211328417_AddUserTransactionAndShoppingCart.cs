namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTransactionAndShoppingCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category", c => c.String());
            AddColumn("dbo.Products", "SubCategory", c => c.String());
            AddColumn("dbo.Products", "Manufacturer", c => c.String());
            AddColumn("dbo.Products", "Model", c => c.String());
            AddColumn("dbo.Products", "Stock", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "crtClientPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Transactions", "TransactionStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Transactions", "TransactionEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Transactions", "TransactionStatus_CrtStatus", c => c.String());
            AddColumn("dbo.Transactions", "TotalCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Transactions", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "ShoppingCartId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "ShoppingCartId");
            DropColumn("dbo.Transactions", "ClientId");
            DropColumn("dbo.Transactions", "TotalCost");
            DropColumn("dbo.Transactions", "TransactionStatus_CrtStatus");
            DropColumn("dbo.Transactions", "TransactionEnd");
            DropColumn("dbo.Transactions", "TransactionStart");
            DropColumn("dbo.Products", "crtClientPrice");
            DropColumn("dbo.Products", "Stock");
            DropColumn("dbo.Products", "Model");
            DropColumn("dbo.Products", "Manufacturer");
            DropColumn("dbo.Products", "SubCategory");
            DropColumn("dbo.Products", "Category");
        }
    }
}
