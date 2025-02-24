namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbilityCards", "SocialMediaLink1", c => c.String(maxLength: 300));
            AddColumn("dbo.AbilityCards", "SocialMediaLink2", c => c.String(maxLength: 300));
            AddColumn("dbo.AbilityCards", "SocialMediaLink3", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AbilityCards", "SocialMediaLink3");
            DropColumn("dbo.AbilityCards", "SocialMediaLink2");
            DropColumn("dbo.AbilityCards", "SocialMediaLink1");
        }
    }
}
