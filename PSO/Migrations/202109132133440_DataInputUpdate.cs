namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataInputUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ClientPersonalData_Id", c => c.Int());
            CreateIndex("dbo.Clients", "ClientPersonalData_Id");
            AddForeignKey("dbo.Clients", "ClientPersonalData_Id", "dbo.UserPersonalDatas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "ClientPersonalData_Id", "dbo.UserPersonalDatas");
            DropIndex("dbo.Clients", new[] { "ClientPersonalData_Id" });
            DropColumn("dbo.Clients", "ClientPersonalData_Id");
        }
    }
}
