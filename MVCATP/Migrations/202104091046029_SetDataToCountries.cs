namespace MVCATP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDataToCountries : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Countries(CountryName) Values('Serbia')");
            Sql("Insert INTO Countries(CountryName) Values('Russia')");
            Sql("Insert INTO Countries(CountryName) Values('Spain')");
            Sql("Insert INTO Countries(CountryName) Values('Austria')");
            Sql("Insert INTO Countries(CountryName) Values('Greece')");
            Sql("Insert INTO Countries(CountryName) Values('Germany')");
            Sql("Insert INTO Countries(CountryName) Values('Switzerland')");
            Sql("Insert INTO Countries(CountryName) Values('Argentina')");
            Sql("Insert INTO Countries(CountryName) Values('Italy')");

        }
        
        public override void Down()
        {
        }
    }
}
