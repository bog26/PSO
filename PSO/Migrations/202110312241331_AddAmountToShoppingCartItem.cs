namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAmountToShoppingCartItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingCartItems", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoppingCartItems", "Amount");
        }
    }
}
