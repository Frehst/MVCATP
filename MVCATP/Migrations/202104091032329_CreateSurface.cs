namespace MVCATP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSurface : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surfaces",
                c => new
                    {
                        SurfaceID = c.Int(nullable: false, identity: true),
                        SurfaceName = c.String(),
                    })
                .PrimaryKey(t => t.SurfaceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Surfaces");
        }
    }
}
