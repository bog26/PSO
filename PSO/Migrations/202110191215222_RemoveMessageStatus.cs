namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMessageStatus : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Messages", "MessageStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "MessageStatus", c => c.String());
        }
    }
}
