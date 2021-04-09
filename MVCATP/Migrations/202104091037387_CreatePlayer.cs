namespace MVCATP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePlayer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerID = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        PlayerSurname = c.String(),
                        CoachID = c.Int(nullable: false),
                        SurfaceID = c.Int(nullable: false),
                        CountryID = c.Int(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerID)
                .ForeignKey("dbo.Coaches", t => t.CoachID, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .ForeignKey("dbo.Surfaces", t => t.SurfaceID, cascadeDelete: true)
                .Index(t => t.CoachID)
                .Index(t => t.SurfaceID)
                .Index(t => t.CountryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "SurfaceID", "dbo.Surfaces");
            DropForeignKey("dbo.Players", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Players", "CoachID", "dbo.Coaches");
            DropIndex("dbo.Players", new[] { "CountryID" });
            DropIndex("dbo.Players", new[] { "SurfaceID" });
            DropIndex("dbo.Players", new[] { "CoachID" });
            DropTable("dbo.Players");
        }
    }
}
