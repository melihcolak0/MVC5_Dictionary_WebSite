namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig15 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbilityCards",
                c => new
                    {
                        CardId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(maxLength: 50),
                        Information = c.String(maxLength: 150),
                        Ability1 = c.String(maxLength: 50),
                        Ability1Rate = c.Int(nullable: false),
                        Ability2 = c.String(maxLength: 50),
                        Ability2Rate = c.Int(nullable: false),
                        Ability3 = c.String(maxLength: 50),
                        Ability3Rate = c.Int(nullable: false),
                        Ability4 = c.String(maxLength: 50),
                        Ability4Rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CardId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AbilityCards");
        }
    }
}
