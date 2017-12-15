namespace NewbridgeLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Genre = c.String(),
                        AuthorId = c.Int(),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Author", t => t.AuthorId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Collection",
                c => new
                    {
                        CollectionId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(),
                        AuthorId = c.Int(),
                    })
                .PrimaryKey(t => t.CollectionId)
                .ForeignKey("dbo.Author", t => t.AuthorId)
                .ForeignKey("dbo.Book", t => t.BookId)
                .Index(t => t.BookId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Feedback",
                c => new
                    {
                        FeedbackId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(),
                        Summary = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FeedbackId)
                .ForeignKey("dbo.Book", t => t.BookId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedback", "BookId", "dbo.Book");
            DropForeignKey("dbo.Collection", "BookId", "dbo.Book");
            DropForeignKey("dbo.Collection", "AuthorId", "dbo.Author");
            DropForeignKey("dbo.Book", "AuthorId", "dbo.Author");
            DropIndex("dbo.Feedback", new[] { "BookId" });
            DropIndex("dbo.Collection", new[] { "AuthorId" });
            DropIndex("dbo.Collection", new[] { "BookId" });
            DropIndex("dbo.Book", new[] { "AuthorId" });
            DropTable("dbo.Feedback");
            DropTable("dbo.Collection");
            DropTable("dbo.Book");
            DropTable("dbo.Author");
        }
    }
}
