namespace Repositorio.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BDRepositorioUPT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Articulo",
                c => new
                    {
                        Id_Articulo = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Resumen = c.String(),
                        Contenido = c.String(),
                        FechaPublicacion = c.DateTime(nullable: false),
                        Id_DetalleArticuloAutor = c.Int(nullable: false),
                        Id_DetalleArticuloPalabra = c.Int(nullable: false),
                        Id_Coleccion = c.Int(nullable: false),
                        Id_Editorial = c.Int(nullable: false),
                        Id_Fichero = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        DetalleArticuloAutor_IdDetalleArticuloAutor = c.Int(),
                        DetalleArticuloPalabra_IdDetalleArticuloPalabra = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Articulo)
                .ForeignKey("dbo.tbl_Colecciones", t => t.Id_Coleccion, cascadeDelete: true)
                .ForeignKey("dbo.tbl_DetalleArticuloAutor", t => t.DetalleArticuloAutor_IdDetalleArticuloAutor)
                .ForeignKey("dbo.tbl_DetalleArticuloPalabra", t => t.DetalleArticuloPalabra_IdDetalleArticuloPalabra)
                .ForeignKey("dbo.tbl_Editorial", t => t.Id_Editorial, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Fichero", t => t.Id_Fichero, cascadeDelete: true)
                .Index(t => t.Id_Coleccion)
                .Index(t => t.Id_Editorial)
                .Index(t => t.Id_Fichero)
                .Index(t => t.DetalleArticuloAutor_IdDetalleArticuloAutor)
                .Index(t => t.DetalleArticuloPalabra_IdDetalleArticuloPalabra);
            
            CreateTable(
                "dbo.tbl_Colecciones",
                c => new
                    {
                        Id_Coleccion = c.Int(nullable: false, identity: true),
                        Id_Subcomunidad = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 200),
                        Descripcion = c.String(maxLength: 200),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Coleccion)
                .ForeignKey("dbo.tbl_Subcomunidades", t => t.Id_Subcomunidad, cascadeDelete: true)
                .Index(t => t.Id_Subcomunidad);
            
            CreateTable(
                "dbo.tbl_Subcomunidades",
                c => new
                    {
                        Id_Subcomunidad = c.Int(nullable: false, identity: true),
                        Id_Comunidad = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 200),
                        Descripcion = c.String(maxLength: 200),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Subcomunidad)
                .ForeignKey("dbo.tbl_Comunidades", t => t.Id_Comunidad, cascadeDelete: true)
                .Index(t => t.Id_Comunidad);
            
            CreateTable(
                "dbo.tbl_Comunidades",
                c => new
                    {
                        Id_Comunidad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 200),
                        Descripcion = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Comunidad);
            
            CreateTable(
                "dbo.tbl_DetalleArticuloAutor",
                c => new
                    {
                        Id_DetalleArticuloAutor = c.Int(nullable: false, identity: true),
                        Id_Articulo = c.Int(nullable: false),
                        Id_Autor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_DetalleArticuloAutor)
                .ForeignKey("dbo.tbl_Articulo", t => t.Id_Articulo, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Autor", t => t.Id_Autor, cascadeDelete: true)
                .Index(t => t.Id_Articulo)
                .Index(t => t.Id_Autor);
            
            CreateTable(
                "dbo.tbl_Autor",
                c => new
                    {
                        Id_Autor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 200),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Autor);
            
            CreateTable(
                "dbo.tbl_DetalleArticuloPalabra",
                c => new
                    {
                        Id_DetalleArticuloPalabra = c.Int(nullable: false, identity: true),
                        Id_Palabra = c.Int(nullable: false),
                        Id_Articulo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_DetalleArticuloPalabra)
                .ForeignKey("dbo.tbl_Articulo", t => t.Id_Articulo, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Palabra", t => t.Id_Palabra, cascadeDelete: true)
                .Index(t => t.Id_Palabra)
                .Index(t => t.Id_Articulo);
            
            CreateTable(
                "dbo.tbl_Palabra",
                c => new
                    {
                        Id_Palabra = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 200),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Palabra);
            
            CreateTable(
                "dbo.tbl_Editorial",
                c => new
                    {
                        Id_Editorial = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 200),
                        Direccion = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Editorial);
            
            CreateTable(
                "dbo.tbl_Fichero",
                c => new
                    {
                        Id_Fichero = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 200),
                        Descripcion = c.String(),
                        Enlace = c.String(),
                        Tamanio = c.Int(nullable: false),
                        Formato = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Fichero);
            
            CreateTable(
                "dbo.tbl_ConsultaTrabajo",
                c => new
                    {
                        Id_ConsultaTrabajo = c.Int(nullable: false, identity: true),
                        Id_Usuario = c.Int(nullable: false),
                        Id_Articulo = c.Int(nullable: false),
                        Hora = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id_ConsultaTrabajo)
                .ForeignKey("dbo.tbl_Articulo", t => t.Id_Articulo, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Usuario", t => t.Id_Usuario, cascadeDelete: true)
                .Index(t => t.Id_Usuario)
                .Index(t => t.Id_Articulo);
            
            CreateTable(
                "dbo.tbl_Usuario",
                c => new
                    {
                        Id_Usuario = c.Int(nullable: false, identity: true),
                        Id_DireccionIp = c.String(),
                        Id_Pais = c.String(),
                    })
                .PrimaryKey(t => t.Id_Usuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_ConsultaTrabajo", "Id_Usuario", "dbo.tbl_Usuario");
            DropForeignKey("dbo.tbl_ConsultaTrabajo", "Id_Articulo", "dbo.tbl_Articulo");
            DropForeignKey("dbo.tbl_Articulo", "Id_Fichero", "dbo.tbl_Fichero");
            DropForeignKey("dbo.tbl_Articulo", "Id_Editorial", "dbo.tbl_Editorial");
            DropForeignKey("dbo.tbl_Articulo", "DetalleArticuloPalabra_IdDetalleArticuloPalabra", "dbo.tbl_DetalleArticuloPalabra");
            DropForeignKey("dbo.tbl_DetalleArticuloPalabra", "Id_Palabra", "dbo.tbl_Palabra");
            DropForeignKey("dbo.tbl_DetalleArticuloPalabra", "Id_Articulo", "dbo.tbl_Articulo");
            DropForeignKey("dbo.tbl_Articulo", "DetalleArticuloAutor_IdDetalleArticuloAutor", "dbo.tbl_DetalleArticuloAutor");
            DropForeignKey("dbo.tbl_DetalleArticuloAutor", "Id_Autor", "dbo.tbl_Autor");
            DropForeignKey("dbo.tbl_DetalleArticuloAutor", "Id_Articulo", "dbo.tbl_Articulo");
            DropForeignKey("dbo.tbl_Articulo", "Id_Coleccion", "dbo.tbl_Colecciones");
            DropForeignKey("dbo.tbl_Colecciones", "Id_Subcomunidad", "dbo.tbl_Subcomunidades");
            DropForeignKey("dbo.tbl_Subcomunidades", "Id_Comunidad", "dbo.tbl_Comunidades");
            DropIndex("dbo.tbl_ConsultaTrabajo", new[] { "Id_Articulo" });
            DropIndex("dbo.tbl_ConsultaTrabajo", new[] { "Id_Usuario" });
            DropIndex("dbo.tbl_DetalleArticuloPalabra", new[] { "Id_Articulo" });
            DropIndex("dbo.tbl_DetalleArticuloPalabra", new[] { "Id_Palabra" });
            DropIndex("dbo.tbl_DetalleArticuloAutor", new[] { "Id_Autor" });
            DropIndex("dbo.tbl_DetalleArticuloAutor", new[] { "Id_Articulo" });
            DropIndex("dbo.tbl_Subcomunidades", new[] { "Id_Comunidad" });
            DropIndex("dbo.tbl_Colecciones", new[] { "Id_Subcomunidad" });
            DropIndex("dbo.tbl_Articulo", new[] { "DetalleArticuloPalabra_IdDetalleArticuloPalabra" });
            DropIndex("dbo.tbl_Articulo", new[] { "DetalleArticuloAutor_IdDetalleArticuloAutor" });
            DropIndex("dbo.tbl_Articulo", new[] { "Id_Fichero" });
            DropIndex("dbo.tbl_Articulo", new[] { "Id_Editorial" });
            DropIndex("dbo.tbl_Articulo", new[] { "Id_Coleccion" });
            DropTable("dbo.tbl_Usuario");
            DropTable("dbo.tbl_ConsultaTrabajo");
            DropTable("dbo.tbl_Fichero");
            DropTable("dbo.tbl_Editorial");
            DropTable("dbo.tbl_Palabra");
            DropTable("dbo.tbl_DetalleArticuloPalabra");
            DropTable("dbo.tbl_Autor");
            DropTable("dbo.tbl_DetalleArticuloAutor");
            DropTable("dbo.tbl_Comunidades");
            DropTable("dbo.tbl_Subcomunidades");
            DropTable("dbo.tbl_Colecciones");
            DropTable("dbo.tbl_Articulo");
        }
    }
}
