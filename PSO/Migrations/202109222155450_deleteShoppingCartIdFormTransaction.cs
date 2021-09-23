namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteShoppingCartIdFormTransaction : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Transactions", "ShoppingCartId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "ShoppingCartId", c => c.Int(nullable: false));
        }
    }
}
