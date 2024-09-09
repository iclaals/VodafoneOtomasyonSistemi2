namespace GörselProgramlamaFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alisveris",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        Marka = c.String(),
                        Model = c.String(),
                        Renk = c.String(),
                        Fiyat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunId);
            
            CreateTable(
                "dbo.Hats",
                c => new
                    {
                        HatId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Kimlik = c.Int(nullable: false),
                        Sehir = c.String(),
                    })
                .PrimaryKey(t => t.HatId);
            
            CreateTable(
                "dbo.Loginsses",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.userId);
            
            CreateTable(
                "dbo.Modems",
                c => new
                    {
                        ModemId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Kimlik = c.Int(nullable: false),
                        Sehir = c.String(),
                    })
                .PrimaryKey(t => t.ModemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Modems");
            DropTable("dbo.Loginsses");
            DropTable("dbo.Hats");
            DropTable("dbo.Alisveris");
        }
    }
}
