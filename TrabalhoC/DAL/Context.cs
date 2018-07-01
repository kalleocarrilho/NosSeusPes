using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoC.Model;

namespace TrabalhoC.DAL
{
    class Context : DbContext
    {
        public DbSet<ClienteFisico> ClientesFisicos { get; set; }
        public DbSet<ClienteJuridico> ClientesJuridicos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<ModeloSapato> Modelos { get; set; }
        public DbSet<Sapato> Sapatos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
