namespace MFCoach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Amarillo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Name", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Companies", "Adress", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Companies", "postalCode", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Companies", "phoneNumber", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Companies", "webSite", c => c.String(maxLength: 100));
            AddColumn("dbo.Companies", "Email", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.Companies", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Coordinators", "CellPhoneNumber", c => c.String(maxLength: 250));
            AlterColumn("dbo.Coordinators", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coordinators", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Coordinators", "CellPhoneNumber", c => c.String());
            DropColumn("dbo.Companies", "Photo");
            DropColumn("dbo.Companies", "Email");
            DropColumn("dbo.Companies", "webSite");
            DropColumn("dbo.Companies", "phoneNumber");
            DropColumn("dbo.Companies", "postalCode");
            DropColumn("dbo.Companies", "Adress");
            DropColumn("dbo.Companies", "Name");
        }
    }
}
