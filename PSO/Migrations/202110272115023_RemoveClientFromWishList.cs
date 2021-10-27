namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveClientFromWishList : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "WishList_Id", c => c.Int());
            CreateIndex("dbo.Products", "WishList_Id");
            AddForeignKey("dbo.Products", "WishList_Id", "dbo.WishLists", "Id");
            DropColumn("dbo.WishLists", "ClientName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WishLists", "ClientName", c => c.String());
            DropForeignKey("dbo.Products", "WishList_Id", "dbo.WishLists");
            DropIndex("dbo.Products", new[] { "WishList_Id" });
            DropColumn("dbo.Products", "WishList_Id");
        }
    }
}
