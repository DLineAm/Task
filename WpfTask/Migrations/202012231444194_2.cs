namespace WpfTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookTakings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TakingsAmount = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookTakings", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.BookTakings", "BookId", "dbo.Books");
            DropIndex("dbo.BookTakings", new[] { "BookId" });
            DropIndex("dbo.BookTakings", new[] { "ClientId" });
            DropTable("dbo.BookTakings");
        }
    }
}
