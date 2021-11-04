namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTransaction1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "TransactionStatus", c => c.String());
            DropColumn("dbo.Transactions", "TransactionStatus_CrtStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "TransactionStatus_CrtStatus", c => c.String());
            DropColumn("dbo.Transactions", "TransactionStatus");
        }
    }
}
