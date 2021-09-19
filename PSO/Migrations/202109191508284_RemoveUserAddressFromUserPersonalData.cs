namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUserAddressFromUserPersonalData : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserPersonalDatas", "Address_Id", "dbo.UserAddresses");
            DropIndex("dbo.UserPersonalDatas", new[] { "Address_Id" });
            DropColumn("dbo.UserPersonalDatas", "Address_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserPersonalDatas", "Address_Id", c => c.Int());
            CreateIndex("dbo.UserPersonalDatas", "Address_Id");
            AddForeignKey("dbo.UserPersonalDatas", "Address_Id", "dbo.UserAddresses", "Id");
        }
    }
}
