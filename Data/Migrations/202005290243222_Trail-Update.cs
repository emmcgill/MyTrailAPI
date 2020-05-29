namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrailUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Park", "YearEstablished", c => c.Int(nullable: false));
            AddColumn("dbo.Park", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Trail", "TrailName", c => c.String(nullable: false));
            AddColumn("dbo.Trail", "TrailLength", c => c.Double(nullable: false));
            AddColumn("dbo.Trail", "TrailDescription", c => c.String(nullable: false));
            AddColumn("dbo.Trail", "IsDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Trail", "Name");
            DropColumn("dbo.Trail", "Length");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trail", "Length", c => c.Double(nullable: false));
            AddColumn("dbo.Trail", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Trail", "IsDeleted");
            DropColumn("dbo.Trail", "TrailDescription");
            DropColumn("dbo.Trail", "TrailLength");
            DropColumn("dbo.Trail", "TrailName");
            DropColumn("dbo.Park", "IsDeleted");
            DropColumn("dbo.Park", "YearEstablished");
        }
    }
}
