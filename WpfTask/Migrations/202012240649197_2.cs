namespace WpfTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookTakings", "TakeDate", c => c.DateTime());
            AddColumn("dbo.BookTakings", "GiveDate", c => c.DateTime());
            AddColumn("dbo.Clients", "FirstName", c => c.String());
            AddColumn("dbo.Clients", "MiddleName", c => c.String());
            AddColumn("dbo.Clients", "LastName", c => c.String());
            DropColumn("dbo.BookTakings", "TakingsAmount");
            DropColumn("dbo.Clients", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Name", c => c.String());
            AddColumn("dbo.BookTakings", "TakingsAmount", c => c.Int(nullable: false));
            DropColumn("dbo.Clients", "LastName");
            DropColumn("dbo.Clients", "MiddleName");
            DropColumn("dbo.Clients", "FirstName");
            DropColumn("dbo.BookTakings", "GiveDate");
            DropColumn("dbo.BookTakings", "TakeDate");
        }
    }
}
