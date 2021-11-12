namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.Time(nullable: false, precision: 7),
                        NombreMascota = c.String(nullable: false, maxLength: 50, unicode: false),
                        Raza = c.String(maxLength: 50, unicode: false),
                        Edad = c.Int(nullable: false),
                        NombreDueno = c.String(nullable: false, maxLength: 50, unicode: false),
                        Celular = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Turno");
        }
    }
}
