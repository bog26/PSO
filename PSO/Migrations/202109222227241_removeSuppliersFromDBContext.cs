namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeSuppliersFromDBContext : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Suppliers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
