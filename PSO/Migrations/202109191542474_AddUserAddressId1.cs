namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserAddressId1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Admins", "UserAddress_Id", "dbo.UserAddresses");
            DropIndex("dbo.Admins", new[] { "UserAddress_Id" });
            RenameColumn(table: "dbo.Admins", name: "UserAddress_Id", newName: "UserAddressId");
            AlterColumn("dbo.Admins", "UserAddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.Admins", "UserAddressId");
            AddForeignKey("dbo.Admins", "UserAddressId", "dbo.UserAddresses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "UserAddressId", "dbo.UserAddresses");
            DropIndex("dbo.Admins", new[] { "UserAddressId" });
            AlterColumn("dbo.Admins", "UserAddressId", c => c.Int());
            RenameColumn(table: "dbo.Admins", name: "UserAddressId", newName: "UserAddress_Id");
            CreateIndex("dbo.Admins", "UserAddress_Id");
            AddForeignKey("dbo.Admins", "UserAddress_Id", "dbo.UserAddresses", "Id");
        }
    }
}
