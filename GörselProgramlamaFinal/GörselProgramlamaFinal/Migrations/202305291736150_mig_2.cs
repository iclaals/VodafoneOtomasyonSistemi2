namespace GörselProgramlamaFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Loginsses", newName: "Logins");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Logins", newName: "Loginsses");
        }
    }
}
