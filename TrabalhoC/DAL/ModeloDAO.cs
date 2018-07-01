using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoC.Model;

namespace TrabalhoC.DAL
{
    class ModeloDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarModelo(ModeloSapato modelo)
        {
            try
            {
                ctx.Modelos.Add(modelo);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }


        public static ModeloSapato BuscarModeloPorNome(ModeloSapato modelo)
        {
            return ctx.Modelos.FirstOrDefault(x => x.Nome.Equals(modelo.Nome));
        }

        public static List<ModeloSapato> RetornarLista()
        {
            return ctx.Modelos.ToList();
        }
    }
}
