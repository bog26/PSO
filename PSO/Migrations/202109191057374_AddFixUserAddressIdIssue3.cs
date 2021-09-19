namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFixUserAddressIdIssue3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "UserAddress_Id", c => c.Int());
            AddColumn("dbo.Clients", "UserAddress_Id", c => c.Int());
            CreateIndex("dbo.Admins", "UserAddress_Id");
            CreateIndex("dbo.Clients", "UserAddress_Id");
            AddForeignKey("dbo.Admins", "UserAddress_Id", "dbo.UserAddresses", "Id");
            AddForeignKey("dbo.Clients", "UserAddress_Id", "dbo.UserAddresses", "Id");
            DropColumn("dbo.Admins", "UserAddressId");
            DropColumn("dbo.Clients", "UserAddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "UserAddressId", c => c.Int(nullable: false));
            AddColumn("dbo.Admins", "UserAddressId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Clients", "UserAddress_Id", "dbo.UserAddresses");
            DropForeignKey("dbo.Admins", "UserAddress_Id", "dbo.UserAddresses");
            DropIndex("dbo.Clients", new[] { "UserAddress_Id" });
            DropIndex("dbo.Admins", new[] { "UserAddress_Id" });
            DropColumn("dbo.Clients", "UserAddress_Id");
            DropColumn("dbo.Admins", "UserAddress_Id");
        }
    }
}
