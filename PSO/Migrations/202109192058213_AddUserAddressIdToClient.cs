namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserAddressIdToClient : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "UserAddress_Id", "dbo.UserAddresses");
            DropIndex("dbo.Clients", new[] { "UserAddress_Id" });
            RenameColumn(table: "dbo.Clients", name: "UserAddress_Id", newName: "UserAddressId");
            AlterColumn("dbo.Clients", "UserAddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "UserAddressId");
            AddForeignKey("dbo.Clients", "UserAddressId", "dbo.UserAddresses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "UserAddressId", "dbo.UserAddresses");
            DropIndex("dbo.Clients", new[] { "UserAddressId" });
            AlterColumn("dbo.Clients", "UserAddressId", c => c.Int());
            RenameColumn(table: "dbo.Clients", name: "UserAddressId", newName: "UserAddress_Id");
            CreateIndex("dbo.Clients", "UserAddress_Id");
            AddForeignKey("dbo.Clients", "UserAddress_Id", "dbo.UserAddresses", "Id");
        }
    }
}
