namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientAndProductToReview : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Reviews", "ClientId");
            CreateIndex("dbo.Reviews", "ProductId");
            AddForeignKey("dbo.Reviews", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Reviews", "ClientId", "dbo.Clients");
            DropIndex("dbo.Reviews", new[] { "ProductId" });
            DropIndex("dbo.Reviews", new[] { "ClientId" });
        }
    }
}
