namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShoppingCarts", "Client_Id", "dbo.Clients");
            DropIndex("dbo.ShoppingCarts", new[] { "Client_Id" });
            AddColumn("dbo.ShoppingCarts", "ClientId", c => c.Int(nullable: false));
            DropColumn("dbo.ShoppingCarts", "Client_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ShoppingCarts", "Client_Id", c => c.Int());
            DropColumn("dbo.ShoppingCarts", "ClientId");
            CreateIndex("dbo.ShoppingCarts", "Client_Id");
            AddForeignKey("dbo.ShoppingCarts", "Client_Id", "dbo.Clients", "Id");
        }
    }
}
