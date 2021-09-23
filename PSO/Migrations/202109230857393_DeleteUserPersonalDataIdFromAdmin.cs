namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteUserPersonalDataIdFromAdmin : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Admins", "UserPersonalDataId", "dbo.UserPersonalDatas");
            DropIndex("dbo.Admins", new[] { "UserPersonalDataId" });
            RenameColumn(table: "dbo.Admins", name: "UserPersonalDataId", newName: "UserInfo_Id");
            AlterColumn("dbo.Admins", "UserInfo_Id", c => c.Int());
            CreateIndex("dbo.Admins", "UserInfo_Id");
            AddForeignKey("dbo.Admins", "UserInfo_Id", "dbo.UserPersonalDatas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "UserInfo_Id", "dbo.UserPersonalDatas");
            DropIndex("dbo.Admins", new[] { "UserInfo_Id" });
            AlterColumn("dbo.Admins", "UserInfo_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Admins", name: "UserInfo_Id", newName: "UserPersonalDataId");
            CreateIndex("dbo.Admins", "UserPersonalDataId");
            AddForeignKey("dbo.Admins", "UserPersonalDataId", "dbo.UserPersonalDatas", "Id", cascadeDelete: true);
        }
    }
}
