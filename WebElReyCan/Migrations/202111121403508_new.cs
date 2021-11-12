namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Turno", "Fecha", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Turno", "Hora", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Turno", "Hora", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Turno", "Fecha", c => c.DateTime(nullable: false));
        }
    }
}
