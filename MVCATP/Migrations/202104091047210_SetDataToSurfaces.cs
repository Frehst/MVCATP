namespace MVCATP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDataToSurfaces : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Surfaces(SurfaceName) Values('clay')");
            Sql("Insert INTO Surfaces(SurfaceName) Values('hard')");
            Sql("Insert INTO Surfaces(SurfaceName) Values('grass')");
        }
        
        public override void Down()
        {
        }
    }
}
