namespace MVCATP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDataToPlayers : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Players(PlayerName,PlayerSurname,CoachID,SurfaceID,CountryID,Birthday,Points) Values('Novak','Djokovic',1,2,1,'1987-05-22',11963)");

        }
        
        public override void Down()
        {
        }
    }
}
