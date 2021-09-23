namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteClientIdFormTransaction : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Transactions", "ClientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "ClientId", c => c.Int(nullable: false));
        }
    }
}
