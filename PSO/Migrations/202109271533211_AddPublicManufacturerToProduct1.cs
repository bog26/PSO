﻿namespace PSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPublicManufacturerToProduct1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Manufacturer", c => c.String());
        }
        
        public override void Down()
        {
        }
    }
}
