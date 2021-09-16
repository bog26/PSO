namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewKeys1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Admins", "UserInfo_Id", "dbo.UserPersonalDatas");
            DropForeignKey("dbo.Clients", "UserInfo_Id", "dbo.UserPersonalDatas");
            DropIndex("dbo.Admins", new[] { "UserInfo_Id" });
            DropIndex("dbo.Clients", new[] { "UserInfo_Id" });
            RenameColumn(table: "dbo.Admins", name: "UserInfo_Id", newName: "UserPersonalDataId");
            RenameColumn(table: "dbo.Clients", name: "UserInfo_Id", newName: "UserPersonalDataId");
            AlterColumn("dbo.Admins", "UserPersonalDataId", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "UserPersonalDataId", c => c.Int(nullable: false));
            CreateIndex("dbo.Admins", "UserPersonalDataId");
            CreateIndex("dbo.Clients", "UserPersonalDataId");
            AddForeignKey("dbo.Admins", "UserPersonalDataId", "dbo.UserPersonalDatas", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "UserPersonalDataId", "dbo.UserPersonalDatas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "UserPersonalDataId", "dbo.UserPersonalDatas");
            DropForeignKey("dbo.Admins", "UserPersonalDataId", "dbo.UserPersonalDatas");
            DropIndex("dbo.Clients", new[] { "UserPersonalDataId" });
            DropIndex("dbo.Admins", new[] { "UserPersonalDataId" });
            AlterColumn("dbo.Clients", "UserPersonalDataId", c => c.Int());
            AlterColumn("dbo.Admins", "UserPersonalDataId", c => c.Int());
            RenameColumn(table: "dbo.Clients", name: "UserPersonalDataId", newName: "UserInfo_Id");
            RenameColumn(table: "dbo.Admins", name: "UserPersonalDataId", newName: "UserInfo_Id");
            CreateIndex("dbo.Clients", "UserInfo_Id");
            CreateIndex("dbo.Admins", "UserInfo_Id");
            AddForeignKey("dbo.Clients", "UserInfo_Id", "dbo.UserPersonalDatas", "Id");
            AddForeignKey("dbo.Admins", "UserInfo_Id", "dbo.UserPersonalDatas", "Id");
        }
    }
}
