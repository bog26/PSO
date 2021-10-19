namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMessageSenderAndReceiverStatuses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "MessageSenderStatus", c => c.String());
            AddColumn("dbo.Messages", "MessageReceiverStatus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "MessageReceiverStatus");
            DropColumn("dbo.Messages", "MessageSenderStatus");
        }
    }
}
