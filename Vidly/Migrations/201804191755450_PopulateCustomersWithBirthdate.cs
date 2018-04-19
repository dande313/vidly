namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomersWithBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '10/20/1984' WHERE Name= 'John Smith'");
            Sql("UPDATE Customers SET Birthdate = '04/21/1992' WHERE Name= 'Mary Williams'");
        }

        public override void Down()
        {
        }
    }
}
