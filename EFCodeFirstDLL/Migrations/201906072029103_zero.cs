namespace EFCodeFirstDLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zero : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticleFirstTypeTable",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ArticleFirstTypeProperty = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ArticleCommonTable", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.ArticleCommonTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ArticleTitle = c.String(nullable: false, maxLength: 255),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ArticleSecondTypeTable",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ArticleSecondTypeProperty = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ArticleCommonTable", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticleFirstTypeTable", "ID", "dbo.ArticleCommonTable");
            DropForeignKey("dbo.ArticleSecondTypeTable", "ID", "dbo.ArticleCommonTable");
            DropIndex("dbo.ArticleSecondTypeTable", new[] { "ID" });
            DropIndex("dbo.ArticleFirstTypeTable", new[] { "ID" });
            DropTable("dbo.ArticleSecondTypeTable");
            DropTable("dbo.ArticleCommonTable");
            DropTable("dbo.ArticleFirstTypeTable");
        }
    }
}
