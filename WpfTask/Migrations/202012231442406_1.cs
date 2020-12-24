namespace WpfTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookTakings", "BookId", "dbo.Books");
            DropForeignKey("dbo.BookTakings", "ClientId", "dbo.Clients");
            DropIndex("dbo.BookTakings", new[] { "ClientId" });
            DropIndex("dbo.BookTakings", new[] { "BookId" });
            DropTable("dbo.BookTakings");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BookTakings",
                c => new
                    {
                        TakingsAmount = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TakingsAmount);
            
            CreateIndex("dbo.BookTakings", "BookId");
            CreateIndex("dbo.BookTakings", "ClientId");
            AddForeignKey("dbo.BookTakings", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BookTakings", "BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
