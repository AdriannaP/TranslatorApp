namespace TranslatorApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Translates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PolishLanguage = c.String(),
                        GermanLanguage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Translates");
        }
    }
}
