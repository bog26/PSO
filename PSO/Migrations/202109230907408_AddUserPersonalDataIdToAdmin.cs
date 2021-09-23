namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserPersonalDataIdToAdmin : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Admins", "UserInfo_Id", "dbo.UserPersonalDatas");
            DropIndex("dbo.Admins", new[] { "UserInfo_Id" });
            RenameColumn(table: "dbo.Admins", name: "UserInfo_Id", newName: "UserPersonalDataId");
            AlterColumn("dbo.Admins", "UserPersonalDataId", c => c.Int(nullable: false));
            CreateIndex("dbo.Admins", "UserPersonalDataId");
            AddForeignKey("dbo.Admins", "UserPersonalDataId", "dbo.UserPersonalDatas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "UserPersonalDataId", "dbo.UserPersonalDatas");
            DropIndex("dbo.Admins", new[] { "UserPersonalDataId" });
            AlterColumn("dbo.Admins", "UserPersonalDataId", c => c.Int());
            RenameColumn(table: "dbo.Admins", name: "UserPersonalDataId", newName: "UserInfo_Id");
            CreateIndex("dbo.Admins", "UserInfo_Id");
            AddForeignKey("dbo.Admins", "UserInfo_Id", "dbo.UserPersonalDatas", "Id");
        }
    }
}
