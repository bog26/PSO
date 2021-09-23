namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteClientIdFromShoppingCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingCarts", "Client_Id", c => c.Int());
            CreateIndex("dbo.ShoppingCarts", "Client_Id");
            AddForeignKey("dbo.ShoppingCarts", "Client_Id", "dbo.Clients", "Id");
            DropColumn("dbo.ShoppingCarts", "ClientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ShoppingCarts", "ClientId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ShoppingCarts", "Client_Id", "dbo.Clients");
            DropIndex("dbo.ShoppingCarts", new[] { "Client_Id" });
            DropColumn("dbo.ShoppingCarts", "Client_Id");
        }
    }
}
