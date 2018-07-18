namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VideoGenres",
                c => new
                    {
                        Video_ID = c.Int(nullable: false),
                        Genre_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_ID, t.Genre_ID })
                .ForeignKey("dbo.Videos", t => t.Video_ID, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_ID, cascadeDelete: true)
                .Index(t => t.Video_ID)
                .Index(t => t.Genre_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideoGenres", "Genre_ID", "dbo.Genres");
            DropForeignKey("dbo.VideoGenres", "Video_ID", "dbo.Videos");
            DropIndex("dbo.VideoGenres", new[] { "Genre_ID" });
            DropIndex("dbo.VideoGenres", new[] { "Video_ID" });
            DropTable("dbo.VideoGenres");
            DropTable("dbo.Videos");
            DropTable("dbo.Genres");
        }
    }
}
