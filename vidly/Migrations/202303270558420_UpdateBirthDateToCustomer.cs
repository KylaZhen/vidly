namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthDateToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1990/03/27' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
