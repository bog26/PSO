namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMessages : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SenderID = c.Int(nullable: false),
                        ReceiverID = c.Int(nullable: false),
                        MessageTitle = c.String(),
                        MessageBody = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
