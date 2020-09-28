namespace SushiRestoran.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingValidationToJelo1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jeloes", "Naziv", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jeloes", "Naziv", c => c.String(nullable: false));
        }
    }
}
