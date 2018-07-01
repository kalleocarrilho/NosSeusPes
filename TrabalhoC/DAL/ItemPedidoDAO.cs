using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoC.Model;

namespace TrabalhoC.DAL
{
    class ItemPedidoDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarItem(ItemPedido item)
        {
            try
            {
                ctx.ItensPedido.Add(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
