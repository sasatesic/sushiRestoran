namespace SushiRestoran.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingValidationToJelo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jeloes", "Sastojci", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jeloes", "Sastojci", c => c.String());
        }
    }
}
