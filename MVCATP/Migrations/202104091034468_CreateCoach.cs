namespace MVCATP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCoach : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        CoachID = c.Int(nullable: false, identity: true),
                        CoachName = c.String(),
                        CoachSurname = c.String(),
                    })
                .PrimaryKey(t => t.CoachID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Coaches");
        }
    }
}
