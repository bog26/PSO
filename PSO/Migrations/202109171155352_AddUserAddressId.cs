namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserAddressId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "UserAddressId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "UserAddressId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "UserAddressId");
            DropColumn("dbo.Admins", "UserAddressId");
        }
    }
}
