namespace MVCATP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MorePlayers : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Players(PlayerName,PlayerSurname,CoachID,SurfaceID,CountryID,Birthday,Points) Values('Danill','Miedviediev',2,2,2,'1997-02-11',10030)");
            Sql("Insert INTO Players(PlayerName,PlayerSurname,CoachID,SurfaceID,CountryID,Birthday,Points) Values('Rafael','Nadal',3,1,3,'1986-06-03',9670)");
            Sql("Insert INTO Players(PlayerName,PlayerSurname,CoachID,SurfaceID,CountryID,Birthday,Points) Values('Dominic','Thiem',4,1,4,'1993-09-03',8660)");
            Sql("Insert INTO Players(PlayerName,PlayerSurname,CoachID,SurfaceID,CountryID,Birthday,Points) Values('Stefanos','Tsitsipas',5,2,5,'1998-08-12',7040)");
            Sql("Insert INTO Players(PlayerName,PlayerSurname,CoachID,SurfaceID,CountryID,Birthday,Points) Values('Alexander','Zverev',6,2,6,'1997-04-20',6125)");
            Sql("Insert INTO Players(PlayerName,PlayerSurname,CoachID,SurfaceID,CountryID,Birthday,Points) Values('Roger','Federer',7,3,7,'1981-08-08',5875)");
            Sql("Insert INTO Players(PlayerName,PlayerSurname,CoachID,SurfaceID,CountryID,Birthday,Points) Values('Andrey','Rublev',8,2,2,'1997-10-20',5400)");
            Sql("Insert INTO Players(PlayerName,PlayerSurname,CoachID,SurfaceID,CountryID,Birthday,Points) Values('Diego','Schwarzman',9,1,8,'1992-08-16',3720)");
            Sql("Insert INTO Players(PlayerName,PlayerSurname,CoachID,SurfaceID,CountryID,Birthday,Points) Values('Matteo','Berettini',10,1,9,'1996-04-12',3453)");





        }

        public override void Down()
        {
        }
    }
}
