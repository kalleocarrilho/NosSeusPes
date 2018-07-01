using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoC.Model;

namespace TrabalhoC.DAL
{
    class ClienteJuridicoDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarClienteJuridico(ClienteJuridico clienteJuridico)
        {
            if (BuscarClientePorCnpj(clienteJuridico)==null)
            {
                try
                {
                    ctx.ClientesJuridicos.Add(clienteJuridico);
                    ctx.SaveChanges();
                    return true;
                }catch(Exception)
                {
                    return false;
                }


            }return false;
        }

        public static ClienteJuridico BuscarClientePorCnpj(ClienteJuridico clienteJuridico)
        {
            return ctx.ClientesJuridicos.FirstOrDefault(x => x.Cnpj.Equals(clienteJuridico.Cnpj));
        }

        public static List<ClienteJuridico> RetornarLista()
        {
            return ctx.ClientesJuridicos.ToList();
        }


    }
}
