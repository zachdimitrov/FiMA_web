namespace Fima.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdminUser : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.AspNetUsers", "IsDeleted");
        }
        
        public override void Down()
        {
            DropIndex("dbo.AspNetUsers", new[] { "IsDeleted" });
        }
    }
}
