namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql($@" INSERT INTO Genres(Name) VALUES('Horror')
                    INSERT INTO Genres(Name) VALUES('Comedy')
                    INSERT INTO Genres(Name) VALUES('Documentary')
                    INSERT INTO Genres(Name) VALUES('Romance')
                    INSERT INTO Genres(Name) VALUES('Musical')
                    INSERT INTO Genres(Name) VALUES('Kids')
                    INSERT INTO Genres(Name) VALUES('Vintage')
                    INSERT INTO Genres(Name) VALUES('Action')");

        }
        
        public override void Down()
        {

            Sql($@"DELETE FROM Genres WHERE Name IN
                (
                'Horror',
                'Comedy',
                'Documentary',
                'Romance',
                'Musical',
                'Kids',
                'Vintage',
                'Action'
                )");
        }
    }
}
