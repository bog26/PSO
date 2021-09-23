namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShoppingCartIdAndClientIdToTransaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "ShoppingCartId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "ShoppingCartId");
            DropColumn("dbo.Transactions", "ClientId");
        }
    }
}
