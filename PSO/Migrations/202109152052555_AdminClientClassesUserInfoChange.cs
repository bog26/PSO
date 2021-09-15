namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminClientClassesUserInfoChange : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Admins", name: "AdminPersonalData_Id", newName: "UserInfo_Id");
            RenameColumn(table: "dbo.Clients", name: "ClientPersonalData_Id", newName: "UserInfo_Id");
            RenameIndex(table: "dbo.Admins", name: "IX_AdminPersonalData_Id", newName: "IX_UserInfo_Id");
            RenameIndex(table: "dbo.Clients", name: "IX_ClientPersonalData_Id", newName: "IX_UserInfo_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Clients", name: "IX_UserInfo_Id", newName: "IX_ClientPersonalData_Id");
            RenameIndex(table: "dbo.Admins", name: "IX_UserInfo_Id", newName: "IX_AdminPersonalData_Id");
            RenameColumn(table: "dbo.Clients", name: "UserInfo_Id", newName: "ClientPersonalData_Id");
            RenameColumn(table: "dbo.Admins", name: "UserInfo_Id", newName: "AdminPersonalData_Id");
        }
    }
}
