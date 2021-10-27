namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientNameToWishList : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WishLists", "ClientName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WishLists", "ClientName");
        }
    }
}
