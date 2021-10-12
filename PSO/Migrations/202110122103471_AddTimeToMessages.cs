namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimeToMessages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "MessageTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "MessageTime");
        }
    }
}
