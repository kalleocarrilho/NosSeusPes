using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoC.Model;

namespace TrabalhoC.DAL
{
    class SapatoDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarSapato(Sapato sapato)
        {
            try
            {
                ctx.Sapatos.Add(sapato);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Sapato BuscarSapato(Sapato sapato)
        {
            return ctx.Sapatos.FirstOrDefault(x => x.Id.Equals(sapato.Id));
        }

        public static List<Sapato> RetornarLista()
        {
            return ctx.Sapatos.ToList();
        }

    }
}
