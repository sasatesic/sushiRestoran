namespace SushiRestoran.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNarudzbinaIdToStavka : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StavkaNarudzbines", "NarudzbinaId", c => c.Int(nullable: false));
            CreateIndex("dbo.StavkaNarudzbines", "NarudzbinaId");
            AddForeignKey("dbo.StavkaNarudzbines", "NarudzbinaId", "dbo.Narudzbinas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StavkaNarudzbines", "NarudzbinaId", "dbo.Narudzbinas");
            DropIndex("dbo.StavkaNarudzbines", new[] { "NarudzbinaId" });
            DropColumn("dbo.StavkaNarudzbines", "NarudzbinaId");
        }
    }
}
