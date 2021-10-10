namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMessages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Sender", c => c.String());
            AddColumn("dbo.Messages", "Receiver", c => c.String());
            DropColumn("dbo.Messages", "SenderID");
            DropColumn("dbo.Messages", "ReceiverID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "ReceiverID", c => c.Int(nullable: false));
            AddColumn("dbo.Messages", "SenderID", c => c.Int(nullable: false));
            DropColumn("dbo.Messages", "Receiver");
            DropColumn("dbo.Messages", "Sender");
        }
    }
}
