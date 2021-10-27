namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStringPIDsToWishList : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WishLists", "StringPIDs", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WishLists", "StringPIDs");
        }
    }
}
