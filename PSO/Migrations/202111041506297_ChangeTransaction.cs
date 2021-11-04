namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTransaction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Transactions", "ShoppingCartId", "dbo.ShoppingCarts");
            DropIndex("dbo.Transactions", new[] { "ClientId" });
            DropIndex("dbo.Transactions", new[] { "ShoppingCartId" });
            AddColumn("dbo.Transactions", "TransactionTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Transactions", "TransactionStart");
            DropColumn("dbo.Transactions", "TransactionEnd");
            DropColumn("dbo.Transactions", "ShoppingCartId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "ShoppingCartId", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "TransactionEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Transactions", "TransactionStart", c => c.DateTime(nullable: false));
            DropColumn("dbo.Transactions", "TransactionTime");
            CreateIndex("dbo.Transactions", "ShoppingCartId");
            CreateIndex("dbo.Transactions", "ClientId");
            AddForeignKey("dbo.Transactions", "ShoppingCartId", "dbo.ShoppingCarts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Transactions", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
        }
    }
}
