namespace SushiRestoran.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Checking : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jeloes", "Naziv", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jeloes", "Naziv", c => c.String());
        }
    }
}
