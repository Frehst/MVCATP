namespace MVCATP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDataToCoaches : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Coaches(CoachName,CoachSurname) Values('Marian','Vajda')");
            Sql("Insert INTO Coaches(CoachName,CoachSurname) Values('Gilles','Cervera')");
            Sql("Insert INTO Coaches(CoachName,CoachSurname) Values('Carlos','Moya')");
            Sql("Insert INTO Coaches(CoachName,CoachSurname) Values('Nicolass','Massu')");
            Sql("Insert INTO Coaches(CoachName,CoachSurname) Values('Apostolos','Tsitsipas')");
            Sql("Insert INTO Coaches(CoachName,CoachSurname) Values('Alexander','Zverev Sr')");
            Sql("Insert INTO Coaches(CoachName,CoachSurname) Values('Ivan','Ljubicic')");
            Sql("Insert INTO Coaches(CoachName,CoachSurname) Values('Fernando','Vincente')");
            Sql("Insert INTO Coaches(CoachName,CoachSurname) Values('Leonardo','Olguin')");
            Sql("Insert INTO Coaches(CoachName,CoachSurname) Values('Vincenzo','Santopadre')");
        }
        
        public override void Down()
        {
        }
    }
}
