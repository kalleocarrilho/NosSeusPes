namespace TrabalhoC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteFisico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClienteJuridico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Razao = c.String(),
                        Cnpj = c.String(),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemPedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preco = c.Single(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Sapato_Id = c.Int(),
                        Pedido_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sapato", t => t.Sapato_Id)
                .ForeignKey("dbo.Pedido", t => t.Pedido_Id)
                .Index(t => t.Sapato_Id)
                .Index(t => t.Pedido_Id);
            
            CreateTable(
                "dbo.Sapato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tamanho = c.Int(nullable: false),
                        Estoque = c.Int(nullable: false),
                        Modelo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ModeloSapato", t => t.Modelo_Id)
                .Index(t => t.Modelo_Id);
            
            CreateTable(
                "dbo.ModeloSapato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Material = c.String(),
                        cor = c.String(),
                        Preco = c.Single(nullable: false),
                        Cadarco = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteFisico_Id = c.Int(),
                        CLienteJuridico_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClienteFisico", t => t.ClienteFisico_Id)
                .ForeignKey("dbo.ClienteJuridico", t => t.CLienteJuridico_Id)
                .Index(t => t.ClienteFisico_Id)
                .Index(t => t.CLienteJuridico_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemPedido", "Pedido_Id", "dbo.Pedido");
            DropForeignKey("dbo.Pedido", "CLienteJuridico_Id", "dbo.ClienteJuridico");
            DropForeignKey("dbo.Pedido", "ClienteFisico_Id", "dbo.ClienteFisico");
            DropForeignKey("dbo.ItemPedido", "Sapato_Id", "dbo.Sapato");
            DropForeignKey("dbo.Sapato", "Modelo_Id", "dbo.ModeloSapato");
            DropIndex("dbo.Pedido", new[] { "CLienteJuridico_Id" });
            DropIndex("dbo.Pedido", new[] { "ClienteFisico_Id" });
            DropIndex("dbo.Sapato", new[] { "Modelo_Id" });
            DropIndex("dbo.ItemPedido", new[] { "Pedido_Id" });
            DropIndex("dbo.ItemPedido", new[] { "Sapato_Id" });
            DropTable("dbo.Pedido");
            DropTable("dbo.ModeloSapato");
            DropTable("dbo.Sapato");
            DropTable("dbo.ItemPedido");
            DropTable("dbo.ClienteJuridico");
            DropTable("dbo.ClienteFisico");
        }
    }
}
