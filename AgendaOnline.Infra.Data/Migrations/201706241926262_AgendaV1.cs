namespace AgendaOnline.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgendaV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 70, unicode: false),
                        WebSite = c.String(maxLength: 100, unicode: false),
                        Contato = c.String(maxLength: 40, unicode: false),
                        Telefone = c.String(nullable: false, maxLength: 20, unicode: false),
                        Celular = c.String(maxLength: 20, unicode: false),
                        ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        IdEndereco = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        Endereco = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 60, unicode: false),
                        Clientes_IdCliente = c.Int(),
                    })
                .PrimaryKey(t => t.IdEndereco)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .ForeignKey("dbo.Clientes", t => t.Clientes_IdCliente)
                .Index(t => t.ClienteId)
                .Index(t => t.Clientes_IdCliente);
            
            CreateTable(
                "dbo.Historico",
                c => new
                    {
                        IdHistorico = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        HistoricoDescricao = c.String(maxLength: 500, unicode: false),
                        DataContato = c.DateTime(nullable: false),
                        Obs = c.String(maxLength: 500, unicode: false),
                        Clientes_IdCliente = c.Int(),
                    })
                .PrimaryKey(t => t.IdHistorico)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .ForeignKey("dbo.Clientes", t => t.Clientes_IdCliente)
                .Index(t => t.ClienteId)
                .Index(t => t.Clientes_IdCliente);
            
            CreateTable(
                "dbo.Lembretes",
                c => new
                    {
                        IdLembrete = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        Lembrete = c.String(maxLength: 200, unicode: false),
                        Alerta = c.String(maxLength: 100, unicode: false),
                        DesabilitarLembretes = c.Boolean(nullable: false),
                        Clientes_IdCliente = c.Int(),
                    })
                .PrimaryKey(t => t.IdLembrete)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .ForeignKey("dbo.Clientes", t => t.Clientes_IdCliente)
                .Index(t => t.ClienteId)
                .Index(t => t.Clientes_IdCliente);
            
            CreateTable(
                "dbo.LogUsuario",
                c => new
                    {
                        IdLog = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 20, unicode: false),
                        Data = c.DateTime(nullable: false),
                        Operacao = c.String(maxLength: 30, unicode: false),
                        Valor = c.String(maxLength: 500, unicode: false),
                        Host = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.IdLog);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Login = c.String(nullable: false, maxLength: 50, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 30, unicode: false),
                        Email = c.String(nullable: false, maxLength: 70, unicode: false),
                        FlagSenha = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lembretes", "Clientes_IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Lembretes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Historico", "Clientes_IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Historico", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Enderecos", "Clientes_IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Enderecos", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Lembretes", new[] { "Clientes_IdCliente" });
            DropIndex("dbo.Lembretes", new[] { "ClienteId" });
            DropIndex("dbo.Historico", new[] { "Clientes_IdCliente" });
            DropIndex("dbo.Historico", new[] { "ClienteId" });
            DropIndex("dbo.Enderecos", new[] { "Clientes_IdCliente" });
            DropIndex("dbo.Enderecos", new[] { "ClienteId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.LogUsuario");
            DropTable("dbo.Lembretes");
            DropTable("dbo.Historico");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Clientes");
        }
    }
}
