namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedWishProductsFromWishList : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "WishList_Id", "dbo.WishLists");
            DropIndex("dbo.Products", new[] { "WishList_Id" });
            DropColumn("dbo.Products", "WishList_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "WishList_Id", c => c.Int());
            CreateIndex("dbo.Products", "WishList_Id");
            AddForeignKey("dbo.Products", "WishList_Id", "dbo.WishLists", "Id");
        }
    }
}
