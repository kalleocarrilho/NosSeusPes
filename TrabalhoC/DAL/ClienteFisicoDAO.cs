using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoC.Model;

namespace TrabalhoC.DAL
{
    class ClienteFisicoDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarClienteFisico(ClienteFisico clienteFisico)
        {
            if (BuscarClientePorCpf(clienteFisico) == null) {
                try {
                    ctx.ClientesFisicos.Add(clienteFisico);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }return false;
        }

        public static ClienteFisico BuscarClientePorCpf(ClienteFisico clienteFisico)
        {
            return ctx.ClientesFisicos.FirstOrDefault(x => x.Cpf.Equals(clienteFisico.Cpf));
        }

        public static List<ClienteFisico> RetornarLista()
        {
           return ctx.ClientesFisicos.ToList();
        }

    }
}
