namespace DivulgaTudo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anuncios",
                c => new
                    {
                        anuncioId = c.Int(nullable: false, identity: true),
                        nomeAnuncio = c.String(),
                        nomeCliente = c.String(),
                        dataInicial = c.String(),
                        dataFinal = c.String(),
                        investimento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.anuncioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Anuncios");
        }
    }
}
