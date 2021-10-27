namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWishClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WishLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clients", "WishList_Id", c => c.Int());
            AddColumn("dbo.Products", "WishList_Id", c => c.Int());
            CreateIndex("dbo.Clients", "WishList_Id");
            CreateIndex("dbo.Products", "WishList_Id");
            AddForeignKey("dbo.Products", "WishList_Id", "dbo.WishLists", "Id");
            AddForeignKey("dbo.Clients", "WishList_Id", "dbo.WishLists", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "WishList_Id", "dbo.WishLists");
            DropForeignKey("dbo.Products", "WishList_Id", "dbo.WishLists");
            DropIndex("dbo.Products", new[] { "WishList_Id" });
            DropIndex("dbo.Clients", new[] { "WishList_Id" });
            DropColumn("dbo.Products", "WishList_Id");
            DropColumn("dbo.Clients", "WishList_Id");
            DropTable("dbo.WishLists");
        }
    }
}
