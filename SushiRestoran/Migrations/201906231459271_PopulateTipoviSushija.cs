namespace SushiRestoran.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTipoviSushija : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipSushijas (Naziv) VALUES ('Maki')");
            Sql("INSERT INTO TipSushijas (Naziv) VALUES ('Uramaki')");
            Sql("INSERT INTO TipSushijas (Naziv) VALUES ('Temaki')");
            Sql("INSERT INTO TipSushijas (Naziv) VALUES ('Nigiri')");
            Sql("INSERT INTO TipSushijas (Naziv) VALUES ('Sashimi')");
        }
        
        public override void Down()
        {
        }
    }
}
