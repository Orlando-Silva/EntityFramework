namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentApiConfigurations : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.Videos DROP CONSTRAINT DF__Videos__Classifi__5EBF139D");
            DropForeignKey("dbo.Videos", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_ID" });
            RenameColumn(table: "dbo.Videos", name: "Genre_ID", newName: "GenreId");
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Classiﬁcation", c => c.Byte(nullable: false));
            AlterColumn("dbo.Videos", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Videos", "GenreId");
            AddForeignKey("dbo.Videos", "GenreId", "dbo.Genres", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "GenreId", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "GenreId" });
            AlterColumn("dbo.Videos", "GenreId", c => c.Int());
            AlterColumn("dbo.Videos", "Classiﬁcation", c => c.Int(nullable: false));
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            RenameColumn(table: "dbo.Videos", name: "GenreId", newName: "Genre_ID");
            CreateIndex("dbo.Videos", "Genre_ID");
            AddForeignKey("dbo.Videos", "Genre_ID", "dbo.Genres", "ID");
            Sql("ALTER TABLE dbo.Videos ADD CONSTRAINT DF__Videos__Classifi__5EBF139D");

        }
    }
}
