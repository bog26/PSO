namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPAsswords : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Password", c => c.String());
            AddColumn("dbo.Clients", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Password");
            DropColumn("dbo.Admins", "Password");
        }
    }
}
