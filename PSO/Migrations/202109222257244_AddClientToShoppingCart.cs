namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientToShoppingCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingCarts", "ClientId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoppingCarts", "ClientId");
        }
    }
}
