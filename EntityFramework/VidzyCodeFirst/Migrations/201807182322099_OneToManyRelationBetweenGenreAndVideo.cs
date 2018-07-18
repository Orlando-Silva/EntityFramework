namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneToManyRelationBetweenGenreAndVideo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo._VideoGenres",
                c => new
                {
                    Video_ID = c.Int(nullable: false),
                    Genre_ID = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Video_ID, t.Genre_ID });
            Sql("INSERT INTO _VideoGenres SELECT * FROM VideoGenres");

            DropForeignKey("dbo.VideoGenres", "Video_ID", "dbo.Videos");
            DropForeignKey("dbo.VideoGenres", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.VideoGenres", new[] { "Video_ID" });
            DropIndex("dbo.VideoGenres", new[] { "Genre_ID" });
            AddColumn("dbo.Videos", "Genre_ID", c => c.Int());
            CreateIndex("dbo.Videos", "Genre_ID");
            AddForeignKey("dbo.Videos", "Genre_ID", "dbo.Genres", "ID");
            DropTable("dbo.VideoGenres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VideoGenres",
                c => new
                    {
                        Video_ID = c.Int(nullable: false),
                        Genre_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_ID, t.Genre_ID });

            Sql("INSERT INTO VideoGenres SELECT * FROM _VideoGenres");

            DropForeignKey("dbo.Videos", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_ID" });
            DropColumn("dbo.Videos", "Genre_ID");
            CreateIndex("dbo.VideoGenres", "Genre_ID");
            CreateIndex("dbo.VideoGenres", "Video_ID");
            AddForeignKey("dbo.VideoGenres", "Genre_ID", "dbo.Genres", "ID", cascadeDelete: true);
            AddForeignKey("dbo.VideoGenres", "Video_ID", "dbo.Videos", "ID", cascadeDelete: true);
            DropTable("dbo._VideoGenres");

        }
    }
}
