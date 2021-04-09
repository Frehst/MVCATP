namespace MVCATP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChaneCoachIDTONull : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Players ALTER COLUMN CoachID INT NULL");

        }

        public override void Down()
        {
        }
    }
}
