namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Category : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (4, 'Romace')");



            Sql("INSERT INTO Videos (Name, CategoryId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover',1,'2021/02/15','2022/01/01',5)");
            Sql("INSERT INTO Videos (Name, CategoryId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard',2,'2021/02/15','2022/01/01',5)");
            Sql("INSERT INTO Videos (Name, CategoryId, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator',2,'2021/02/15','2022/01/01',5)");
            Sql("INSERT INTO Videos (Name, CategoryId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story',3,'2021/02/15','2022/01/01',5)");
            Sql("INSERT INTO Videos (Name, CategoryId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic',4,'2021/02/15','2022/01/01',5)");
        }
        
        public override void Down()
        {
        }
    }
}
