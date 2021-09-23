namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShoppingCartAndClientToTransaction : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Transactions", "ClientId");
            CreateIndex("dbo.Transactions", "ShoppingCartId");
            AddForeignKey("dbo.Transactions", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Transactions", "ShoppingCartId", "dbo.ShoppingCarts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "ShoppingCartId", "dbo.ShoppingCarts");
            DropForeignKey("dbo.Transactions", "ClientId", "dbo.Clients");
            DropIndex("dbo.Transactions", new[] { "ShoppingCartId" });
            DropIndex("dbo.Transactions", new[] { "ClientId" });
        }
    }
}
