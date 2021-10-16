namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsEncryptedToMessage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "IsEncrypted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "IsEncrypted");
        }
    }
}
