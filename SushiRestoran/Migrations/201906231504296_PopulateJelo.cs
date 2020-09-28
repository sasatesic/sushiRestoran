namespace SushiRestoran.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateJelo : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Jeloes (Naziv, Sastojci, BrojKomada, JedinicnaCena, NaMeniju, TipSushijaId) VALUES ('Chesse Hug', 'Losos, krem sir', 8, 650.00, 1, 1)");
            Sql("INSERT INTO Jeloes (Naziv, Sastojci, BrojKomada, JedinicnaCena, NaMeniju, TipSushijaId) VALUES ('Temaki Classic', 'Losos, avokado', 4, 850.00, 0, 3)");
            Sql("INSERT INTO Jeloes (Naziv, Sastojci, BrojKomada, JedinicnaCena, NaMeniju, TipSushijaId) VALUES ('Tatami', 'Tuna, avokado, krem sir, susam', 8, 550.00, 1, 2)");
            Sql("INSERT INTO Jeloes (Naziv, Sastojci, BrojKomada, JedinicnaCena, NaMeniju, TipSushijaId) VALUES ('Avoka Nigiri', 'Losos, avokado', 1, 130.00, 0, 4)");
            Sql("INSERT INTO Jeloes (Naziv, Sastojci, BrojKomada, JedinicnaCena, NaMeniju, TipSushijaId) VALUES ('Salmon Tataki', 'Srednje peceni losos', 6, 950.00, 1, 5)");
                                                
        }
        
        public override void Down()
        {
        }
    }
}
