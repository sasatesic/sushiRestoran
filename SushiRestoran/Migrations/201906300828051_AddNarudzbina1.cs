namespace SushiRestoran.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNarudzbina1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Narudzbinas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumVreme = c.DateTime(nullable: false),
                        UkupnaVrednost = c.Double(nullable: false),
                        Kompletirana = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Narudzbinas");
        }
    }
}
