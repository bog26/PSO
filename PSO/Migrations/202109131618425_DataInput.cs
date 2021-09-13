namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataInput : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserPersonalDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        Telephone = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAddresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.UserAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        StreetNr = c.Int(nullable: false),
                        City = c.String(),
                        Region = c.String(),
                        Country = c.String(),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Admins", "AdminPersonalData_Id", c => c.Int());
            CreateIndex("dbo.Admins", "AdminPersonalData_Id");
            AddForeignKey("dbo.Admins", "AdminPersonalData_Id", "dbo.UserPersonalDatas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "AdminPersonalData_Id", "dbo.UserPersonalDatas");
            DropForeignKey("dbo.UserPersonalDatas", "Address_Id", "dbo.UserAddresses");
            DropIndex("dbo.UserPersonalDatas", new[] { "Address_Id" });
            DropIndex("dbo.Admins", new[] { "AdminPersonalData_Id" });
            DropColumn("dbo.Admins", "AdminPersonalData_Id");
            DropTable("dbo.UserAddresses");
            DropTable("dbo.UserPersonalDatas");
        }
    }
}
