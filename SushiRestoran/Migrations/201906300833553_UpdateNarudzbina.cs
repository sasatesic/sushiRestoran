namespace SushiRestoran.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNarudzbina : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Narudzbinas", "DatumVreme", c => c.DateTime());
            AlterColumn("dbo.Narudzbinas", "UkupnaVrednost", c => c.Double());
            AlterColumn("dbo.Narudzbinas", "Kompletirana", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Narudzbinas", "Kompletirana", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Narudzbinas", "UkupnaVrednost", c => c.Double(nullable: false));
            AlterColumn("dbo.Narudzbinas", "DatumVreme", c => c.DateTime(nullable: false));
        }
    }
}
