namespace SushiRestoran.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStavkaNarudzbina : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StavkaNarudzbines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kolicina = c.Int(nullable: false),
                        JedinicnaCena = c.Double(nullable: false),
                        Vrednost = c.Double(nullable: false),
                        JeloId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jeloes", t => t.JeloId, cascadeDelete: true)
                .Index(t => t.JeloId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StavkaNarudzbines", "JeloId", "dbo.Jeloes");
            DropIndex("dbo.StavkaNarudzbines", new[] { "JeloId" });
            DropTable("dbo.StavkaNarudzbines");
        }
    }
}
